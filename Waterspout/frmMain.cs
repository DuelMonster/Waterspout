using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using IdSharp.Tagging.ID3v1;
using IdSharp.Tagging.ID3v2;
using WaterButt;

namespace Waterspout
{
    public partial class frmMain : Form
    {
        private string sAppDataPath = "";
        private bool bCopyCompletedOnce = false;
        private bool bIsFolderScanning = false;
        private bool bIsRainwaveScanning = false;
        private bool bCancelScanning = false;
        private List<Track> rwTrackList = new List<Track>();
        private List<Track> fileTrackList = new List<Track>();
        private List<Track> finalTrackList = new List<Track>();
        private List<Track> orderedTrackList = null;
        private int[] iaRandOrder;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\-= MP3s =-"))
            {
                txtUserID.Text = "23994";
                txtAPIKey.Text = "1382eab9d0";
                txtSourceFolder.Text = @"C:\-= MP3s =-\[OCRemix]";
                txtDestFolder.Text = @"C:\-= MP3s =-\[~Discs for the Car~]\[OCRemix]";
            }

            // Ensure our AppDataPath exists.
            sAppDataPath = Application.UserAppDataPath;
            if (!Directory.Exists(sAppDataPath)) Directory.CreateDirectory(sAppDataPath);

            // Ensure the DataViews won't include any unwanted columns.
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView3.AutoGenerateColumns = false;
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtSourceFolder.Text))
                fldBrowser.SelectedPath = txtSourceFolder.Text;

            if (fldBrowser.ShowDialog() == DialogResult.OK)
                txtSourceFolder.Text = fldBrowser.SelectedPath;
        }

        private void btnDestFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtDestFolder.Text))
                fldBrowser.SelectedPath = txtDestFolder.Text;

            if (fldBrowser.ShowDialog() == DialogResult.OK)
                txtDestFolder.Text = fldBrowser.SelectedPath;
        }

        private void btnFullScan_Click(object sender, EventArgs e)
        {
            if (bIsFolderScanning || bIsRainwaveScanning)
            {
                bCancelScanning = true;
                return;
            }

            if (Directory.Exists(txtSourceFolder.Text))
                StartRecursiveScan(txtSourceFolder.Text);
            else
                MessageBox.Show("Directory does not exist");
        }

        private void btnCopyMP3s_Click(object sender, EventArgs e)
        {
            StartCopyAndSplit();
        }

        private void btnReCopyMP3s_Click(object sender, EventArgs e)
        {
            // Request the Track listing from disc.
            fileBrowser.InitialDirectory = sAppDataPath;
            if (fileBrowser.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader srFile = new StreamReader(fileBrowser.OpenFile()))
                {
                    orderedTrackList = fastJSON.JSON.Instance.ToObject<List<Track>>(srFile.ReadToEnd());
                }

                // ReCopy and Split the MP3s.
                StartCopyAndSplit(true);
            }
        }

        private void StartCopyAndSplit(bool p_bIsReSpliting = false)
        {
            btnFullScan.Enabled = false;
            btnCopyMP3s.Enabled = false;
            btnReCopyMP3s.Enabled = false;

            lblProgress_1.Text = "";
            lblProgress_2.Text = "Copying:";
            prgRaiwaveScan.Visible = false;
            prgFolderScan.Value = 0;

            pnlRainwave.Visible = false;
            pnlFolder.Visible = false;
            pnlProgressBars.Visible = true;

            Application.DoEvents();

            CopyAndSplitMP3s(p_bIsReSpliting);

            prgRaiwaveScan.Visible = true;
            pnlRainwave.Visible = true;
            pnlFolder.Visible = true;
            pnlProgressBars.Visible = false;

            btnFullScan.Enabled = true;
            btnCopyMP3s.Enabled = true;
            btnReCopyMP3s.Enabled = true;
        }

        private void StartRecursiveScan(string p_sBasePath)
        {
            bIsFolderScanning = true;
            bIsRainwaveScanning = true;
            bCancelScanning = false;

            btnFullScan.Text = "&Cancel";
            btnFullScan.Enabled = false;
            btnCopyMP3s.Enabled = false;
            btnReCopyMP3s.Enabled = false;

            lblProgress_1.Text = "Rainwave:";
            lblProgress_2.Text = "Folders:";
            prgRaiwaveScan.Value = 0;
            prgFolderScan.Value = 0;

            pnlRainwave.Visible = false;
            pnlFolder.Visible = false;
            pnlProgressBars.Visible = true;

            rwTrackList = new List<Track>();
            fileTrackList = new List<Track>();
            finalTrackList = new List<Track>();

            ThreadPool.QueueUserWorkItem(GetFavsAndHighlyRated);
            ThreadPool.QueueUserWorkItem(ScanDirectory, p_sBasePath);
            ThreadPool.QueueUserWorkItem(EndAllScanning);
        }

        private void ScanDirectory(object p_oBasePath)
        {
            try
            {
                string sBasePath = (string)p_oBasePath;
                int iDirCount = 0;
                int iTotalDirs = 0;

                DirectoryInfo dirBase = new DirectoryInfo(sBasePath);

                DirectoryInfo[] subDirList = dirBase.GetDirectories("*", SearchOption.AllDirectories);
                iTotalDirs = subDirList.Length + 1;
                DirectoryInfo[] dirList = new DirectoryInfo[iTotalDirs];
                dirList[0] = dirBase;

                subDirList.CopyTo(dirList, 1);

                EnableCancelButton();

                foreach (DirectoryInfo dir in dirList)
                {
                    if (bCancelScanning)
                        return;

                    iDirCount++;

                    FileInfo[] fileList = dir.GetFiles("*.mp3");

                    foreach (FileInfo file in fileList)
                    {
                        if (bCancelScanning)
                            return;

                        if (ID3v2Tag.DoesTagExist(file.FullName))
                        {
                            IID3v2Tag id3 = new ID3v2Tag(file.FullName);

                            fileTrackList.Add(new Track
                            {
                                Artist = id3.Artist,
                                Title = id3.Title,
                                SubTitle = id3.Subtitle,
                                Album = id3.Album,
                                TrackNumber = id3.TrackNumber,
                                ContentGroup = id3.ContentGroup,
                                FileName = file.FullName,
                                FileSize = file.Length
                            });
                        }
                        else if (ID3v1Tag.DoesTagExist(file.FullName))
                        {
                            ID3v1Tag id3 = new ID3v1Tag(file.FullName);

                            fileTrackList.Add(new Track
                            {
                                Artist = id3.Artist,
                                Title = id3.Title,
                                Album = id3.Album,
                                FileName = file.FullName
                            });
                        }
                    }

                    UpdateFolderProgress(iDirCount, iTotalDirs);

                    //DisableCancelButton();
                }
            }
            finally
            {
                EndFolderScanning(new BindingList<Track>(fileTrackList));
            }
        }

        private void DisableCancelButton()
        {
            if (!InvokeRequired)
                btnFullScan.Enabled = false;
            else
                Invoke(new MethodInvoker(DisableCancelButton));
        }

        private void EnableCancelButton()
        {
            if (!InvokeRequired)
                btnFullScan.Enabled = true;
            else
                Invoke(new MethodInvoker(EnableCancelButton));
        }

        private delegate void UpdateProgressDelegate(int p_iValue, int p_iTotal);
        private void UpdateFolderProgress(int p_iValue, int p_iTotal)
        {
            if (!InvokeRequired)
            {
                prgFolderScan.Maximum = p_iTotal;
                prgFolderScan.Value = p_iValue;
                Application.DoEvents();
            }
            else
                Invoke(new UpdateProgressDelegate(UpdateFolderProgress), p_iValue, p_iTotal);
        }
        private void UpdateRainwaveProgress(int p_iValue, int p_iTotal)
        {
            if (!InvokeRequired)
            {
                prgRaiwaveScan.Maximum = p_iTotal;
                prgRaiwaveScan.Value = p_iValue;
            }
            else
                Invoke(new UpdateProgressDelegate(UpdateRainwaveProgress), p_iValue, p_iTotal);
        }

        private delegate void EndFolderScanningDelegate(BindingList<Track> p_TrackList);
        private void EndFolderScanning(BindingList<Track> p_TrackList)
        {
            if (!InvokeRequired)
            {
                bIsFolderScanning = false;
                dataGridView2.DataSource = new BindingList<Track>(fileTrackList);
            }
            else
                Invoke(new EndFolderScanningDelegate(EndFolderScanning), p_TrackList);
        }

        private delegate void EndRainwaveScanningDelegate();
        private void EndRainwaveScanning()
        {
            if (!InvokeRequired)
            {
                bIsRainwaveScanning = false;

                dataGridView1.DataSource = new BindingList<Track>(rwTrackList);
            }
            else
                Invoke(new EndRainwaveScanningDelegate(EndRainwaveScanning));
        }

        private delegate void EndAllScanningDelegate(object p_oStateInfo);
        private void EndAllScanning(object p_oStateInfo)
        {
            if (!InvokeRequired)
            {
                while (bIsFolderScanning || bIsRainwaveScanning) Application.DoEvents();

                if (!bCancelScanning) CompareTrackLists();
                if (!bCancelScanning) CopyAndSplitMP3s();

                // Export Final Track order to JSON formatted file.
                StreamWriter swJSON = new StreamWriter(Path.Combine(sAppDataPath, "FinalTrackOrder - " + DateTime.Now.ToString("yyyy-MM-dd") + ".json"), false, System.Text.Encoding.UTF8);
                fastJSON.JSON.Instance.Parameters.UseExtensions = false;
                swJSON.Write(fastJSON.JSON.Instance.ToJSON(orderedTrackList));
                swJSON.Close();

                pnlProgressBars.Visible = false;
                pnlRainwave.Visible = true;
                pnlFolder.Visible = true;

                btnFullScan.Text = "&Scan";
                btnFullScan.Enabled = true;
                btnCopyMP3s.Enabled = true;
                btnReCopyMP3s.Enabled = true;
            }
            else
                Invoke(new EndAllScanningDelegate(EndAllScanning), p_oStateInfo);
        }

        private void GetFavsAndHighlyRated(object p_oStateInfo)
        {
            try
            {
                prgFolderScan.Value = 0;

                RainwaveClient rw = new RainwaveClient(Convert.ToInt32(txtUserID.Text), txtAPIKey.Text);
                RainwaveChannel rwChan = rw.Channels[1]; // OCRemix

                int iTotalAlbums = rwChan.Albums.Count;
                int iAlbumCount = 0;
                foreach (RainwaveAlbum rwAlbum in rwChan.Albums)
                {
                    if (bCancelScanning)
                        return;

                    iAlbumCount++;

                    foreach (RainwaveSong rwSong in rwAlbum.Songs)
                    {
                        if (bCancelScanning)
                            return;

                        if ((chkIncludeFavourites.Checked && rwSong.bFavourite) ||
                            (chkIncludeRated.Checked && rwSong.fRating >= (float)numRatedFrom.Value))
                            rwTrackList.Add(new Track
                            {
                                Artist = rwSong.sArtistString,
                                Title = rwSong.sTitle,
                                Album = rwAlbum.sName,
                                FileName = "NA"
                            });
                    }

                    UpdateRainwaveProgress(iAlbumCount, iTotalAlbums);
                }
            }
            finally
            {
                EndRainwaveScanning();
            }
        }

        private void CompareTrackLists()
        {
            // Re-label the Progress labels
            lblProgress_1.Text = "MP3 Files:";
            lblProgress_2.Text = "Rainwave:";

            int iFileCount = 0, iTotalFiles = fileTrackList.Count;
            int iTrackCount = 0, iTotalTracks = rwTrackList.Count;
            finalTrackList = new List<Track>();

            foreach (Track fileTrack in fileTrackList)
            {
                if (bCancelScanning)
                    return;

                foreach (Track rwTrack in rwTrackList)
                {
                    if (bCancelScanning)
                        return;

                    if (rwTrack.Matches(fileTrack))
                    {
                        rwTrack.FileName = fileTrack.FileName;
                        rwTrack.FileSize = fileTrack.FileSize;
                        finalTrackList.Add(rwTrack);
                    }
                    iTrackCount++;
                    UpdateFolderProgress(iTrackCount, iTotalTracks);
                }

                iFileCount++;
                iTrackCount = 0;
                UpdateRainwaveProgress(iFileCount, iTotalFiles);
            }

            dataGridView3.DataSource = new BindingList<Track>(finalTrackList);
            tabControl1.SelectedTab = tabPage3;
        }

        private void CopyAndSplitMP3s(bool p_bIsReSpliting = false)
        {
            // Get the Split size in bytes (from megabytes)
            Int64 iSplitSize = ((Convert.ToInt64(numSplitSize.Value /* Megabytes */ ) * 1024 /* Kilobytes */) * 1024 /* Bytes */);

            if (!p_bIsReSpliting)
            {
                if (chkSplitRandomly.Checked)
                {
                    if (!bCopyCompletedOnce)
                    {
                        iaRandOrder = new int[finalTrackList.Count];
                        for (int i = 0; i < iaRandOrder.Length; i++) iaRandOrder[i] = i;
                        Shuffle(iaRandOrder);
                    }

                    orderedTrackList = new List<Track>();
                    foreach (int iIndx in iaRandOrder)
                        orderedTrackList.Add(finalTrackList[iIndx]);

                    iaRandOrder = null;
                }
                else
                    orderedTrackList = finalTrackList;
            }

            // Split the MP3s into Size folders
            Int64 iCurrentTotalSize = 0;
            int iSplitCount = 1;
            int iTrackCount = 0;
            foreach (Track rwTrack in orderedTrackList)
            {
                if (chkSplitSize.Checked && (iCurrentTotalSize + rwTrack.FileSize) > iSplitSize)
                {
                    iCurrentTotalSize = 0;
                    iSplitCount++;
                }

                // Copy MP3s into Folder
                FileInfo oFile = new FileInfo(rwTrack.FileName);
                string sDestFolder = Path.Combine(txtDestFolder.Text, (chkSplitSize.Checked ? "Disc_" + iSplitCount.ToString("D2") : ""));
                if (!Directory.Exists(sDestFolder)) Directory.CreateDirectory(sDestFolder);
                string sDestPath = Path.Combine(sDestFolder, rwTrack.DestFileName);
                if (!File.Exists(sDestPath))
                {
                    oFile.CopyTo(sDestPath);

                    // Now that we have a copy of the MP3 file we should re-tag it to match the tags retrieved from Rainwave.
                    // The Rainwave tags are much better than the OCRemix tags!!
                    IID3v1Tag id3v1 = new ID3v1Tag(sDestPath);
                    id3v1.Album = rwTrack.Album;
                    id3v1.Artist = rwTrack.Artist;
                    id3v1.Title = rwTrack.Title;
                    id3v1.Save(sDestPath);

                    IID3v2Tag id3v2 = new ID3v2Tag(sDestPath);
                    id3v2.Album = rwTrack.Album;
                    id3v2.Artist = rwTrack.Artist;
                    id3v2.Title = rwTrack.Title;
                    id3v2.Save(sDestPath);

                    if (chkSplitSize.Checked) iCurrentTotalSize += rwTrack.FileSize;

                    iTrackCount++;
                    UpdateFolderProgress(iTrackCount, orderedTrackList.Count);
                }
            }

            bCopyCompletedOnce = true;
        }

        /// <summary>
        /// Used in Shuffle(T).
        /// </summary>
        static Random _random = new Random();

        /// <summary>
        /// Shuffle an array using the "Fisher–Yates shuffle" algorithm.
        /// </summary>
        /// <typeparam name="T">Array element type.</typeparam>
        /// <param name="array">Array to shuffle.</param>
        public static void Shuffle<T>(T[] array)
        {
            var random = _random;
            for (int i = array.Length; i > 1; i--)
            {
                // Pick random element to swap.
                int j = random.Next(i); // 0 <= j <= i-1
                // Swap.
                T tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
        }
    }
}
