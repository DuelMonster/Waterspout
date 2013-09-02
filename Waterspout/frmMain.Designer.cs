namespace Waterspout
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnFullScan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSourceFolder = new System.Windows.Forms.Button();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.fldBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.prgFolderScan = new System.Windows.Forms.ProgressBar();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prgRaiwaveScan = new System.Windows.Forms.ProgressBar();
            this.pnlRainwave = new System.Windows.Forms.Panel();
            this.chkIncludeRated = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numRatedFrom = new System.Windows.Forms.NumericUpDown();
            this.chkIncludeFavourites = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFolder = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.chkSplitRandomly = new System.Windows.Forms.CheckBox();
            this.chkSplitSize = new System.Windows.Forms.CheckBox();
            this.numSplitSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestFolder = new System.Windows.Forms.TextBox();
            this.btnDestFolder = new System.Windows.Forms.Button();
            this.lblProgress_2 = new System.Windows.Forms.Label();
            this.lblProgress_1 = new System.Windows.Forms.Label();
            this.pnlProgressBars = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TrackNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCopyMP3s = new System.Windows.Forms.Button();
            this.btnReCopyMP3s = new System.Windows.Forms.Button();
            this.fileBrowser = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlRainwave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatedFrom)).BeginInit();
            this.pnlFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSplitSize)).BeginInit();
            this.pnlProgressBars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFullScan
            // 
            this.btnFullScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScan.Location = new System.Drawing.Point(820, 11);
            this.btnFullScan.Name = "btnFullScan";
            this.btnFullScan.Size = new System.Drawing.Size(100, 21);
            this.btnFullScan.TabIndex = 32;
            this.btnFullScan.Text = "Full &Scan";
            this.btnFullScan.UseVisualStyleBackColor = true;
            this.btnFullScan.Click += new System.EventHandler(this.btnFullScan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAlbum,
            this.colTitle,
            this.colArtist});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(895, 361);
            this.dataGridView1.TabIndex = 31;
            // 
            // colAlbum
            // 
            this.colAlbum.DataPropertyName = "Album";
            this.colAlbum.HeaderText = "Album";
            this.colAlbum.Name = "colAlbum";
            this.colAlbum.ReadOnly = true;
            this.colAlbum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAlbum.Width = 42;
            // 
            // colTitle
            // 
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTitle.Width = 33;
            // 
            // colArtist
            // 
            this.colArtist.DataPropertyName = "Artist";
            this.colArtist.HeaderText = "Artist";
            this.colArtist.Name = "colArtist";
            this.colArtist.ReadOnly = true;
            this.colArtist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colArtist.Width = 36;
            // 
            // btnSourceFolder
            // 
            this.btnSourceFolder.Location = new System.Drawing.Point(477, 0);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(24, 20);
            this.btnSourceFolder.TabIndex = 30;
            this.btnSourceFolder.Text = "...";
            this.btnSourceFolder.UseVisualStyleBackColor = true;
            this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(164, 0);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(307, 20);
            this.txtSourceFolder.TabIndex = 28;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(114, 4);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(44, 13);
            this.lblFolder.TabIndex = 29;
            this.lblFolder.Text = "Source:";
            // 
            // fldBrowser
            // 
            this.fldBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.fldBrowser.ShowNewFolderButton = false;
            // 
            // prgFolderScan
            // 
            this.prgFolderScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgFolderScan.Location = new System.Drawing.Point(67, 26);
            this.prgFolderScan.Name = "prgFolderScan";
            this.prgFolderScan.Size = new System.Drawing.Size(736, 20);
            this.prgFolderScan.Step = 1;
            this.prgFolderScan.TabIndex = 34;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(137, 3);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(46, 13);
            this.lblUserID.TabIndex = 35;
            this.lblUserID.Text = "User ID:";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(189, 0);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(50, 20);
            this.txtUserID.TabIndex = 36;
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(299, 0);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(80, 20);
            this.txtAPIKey.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "API Key:";
            // 
            // prgRaiwaveScan
            // 
            this.prgRaiwaveScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgRaiwaveScan.Location = new System.Drawing.Point(67, 0);
            this.prgRaiwaveScan.Name = "prgRaiwaveScan";
            this.prgRaiwaveScan.Size = new System.Drawing.Size(736, 20);
            this.prgRaiwaveScan.Step = 1;
            this.prgRaiwaveScan.TabIndex = 39;
            // 
            // pnlRainwave
            // 
            this.pnlRainwave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRainwave.Controls.Add(this.chkIncludeRated);
            this.pnlRainwave.Controls.Add(this.label4);
            this.pnlRainwave.Controls.Add(this.numRatedFrom);
            this.pnlRainwave.Controls.Add(this.chkIncludeFavourites);
            this.pnlRainwave.Controls.Add(this.label2);
            this.pnlRainwave.Controls.Add(this.txtAPIKey);
            this.pnlRainwave.Controls.Add(this.lblUserID);
            this.pnlRainwave.Controls.Add(this.txtUserID);
            this.pnlRainwave.Controls.Add(this.label1);
            this.pnlRainwave.Location = new System.Drawing.Point(12, 12);
            this.pnlRainwave.Name = "pnlRainwave";
            this.pnlRainwave.Size = new System.Drawing.Size(802, 20);
            this.pnlRainwave.TabIndex = 40;
            // 
            // chkIncludeRated
            // 
            this.chkIncludeRated.AutoSize = true;
            this.chkIncludeRated.Location = new System.Drawing.Point(518, 2);
            this.chkIncludeRated.Name = "chkIncludeRated";
            this.chkIncludeRated.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkIncludeRated.Size = new System.Drawing.Size(96, 17);
            this.chkIncludeRated.TabIndex = 45;
            this.chkIncludeRated.Text = ":Include Rated";
            this.chkIncludeRated.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Rainwave Settings:";
            // 
            // numRatedFrom
            // 
            this.numRatedFrom.Cursor = System.Windows.Forms.Cursors.Default;
            this.numRatedFrom.DecimalPlaces = 1;
            this.numRatedFrom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numRatedFrom.Location = new System.Drawing.Point(691, 0);
            this.numRatedFrom.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRatedFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRatedFrom.Name = "numRatedFrom";
            this.numRatedFrom.Size = new System.Drawing.Size(38, 20);
            this.numRatedFrom.TabIndex = 43;
            this.numRatedFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRatedFrom.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // chkIncludeFavourites
            // 
            this.chkIncludeFavourites.AutoSize = true;
            this.chkIncludeFavourites.Checked = true;
            this.chkIncludeFavourites.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeFavourites.Location = new System.Drawing.Point(385, 2);
            this.chkIncludeFavourites.Name = "chkIncludeFavourites";
            this.chkIncludeFavourites.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkIncludeFavourites.Size = new System.Drawing.Size(116, 17);
            this.chkIncludeFavourites.TabIndex = 42;
            this.chkIncludeFavourites.Text = ":Include Favourites";
            this.chkIncludeFavourites.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Rated From:";
            // 
            // pnlFolder
            // 
            this.pnlFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFolder.Controls.Add(this.label6);
            this.pnlFolder.Controls.Add(this.chkSplitRandomly);
            this.pnlFolder.Controls.Add(this.chkSplitSize);
            this.pnlFolder.Controls.Add(this.numSplitSize);
            this.pnlFolder.Controls.Add(this.label5);
            this.pnlFolder.Controls.Add(this.label3);
            this.pnlFolder.Controls.Add(this.txtDestFolder);
            this.pnlFolder.Controls.Add(this.btnDestFolder);
            this.pnlFolder.Controls.Add(this.lblFolder);
            this.pnlFolder.Controls.Add(this.txtSourceFolder);
            this.pnlFolder.Controls.Add(this.btnSourceFolder);
            this.pnlFolder.Location = new System.Drawing.Point(12, 38);
            this.pnlFolder.Name = "pnlFolder";
            this.pnlFolder.Size = new System.Drawing.Size(802, 40);
            this.pnlFolder.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Split Size:";
            // 
            // chkSplitRandomly
            // 
            this.chkSplitRandomly.AutoSize = true;
            this.chkSplitRandomly.Checked = true;
            this.chkSplitRandomly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSplitRandomly.Location = new System.Drawing.Point(534, 22);
            this.chkSplitRandomly.Name = "chkSplitRandomly";
            this.chkSplitRandomly.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSplitRandomly.Size = new System.Drawing.Size(132, 17);
            this.chkSplitRandomly.TabIndex = 48;
            this.chkSplitRandomly.Text = ":Split in Random Order";
            this.chkSplitRandomly.UseVisualStyleBackColor = true;
            // 
            // chkSplitSize
            // 
            this.chkSplitSize.AutoSize = true;
            this.chkSplitSize.Checked = true;
            this.chkSplitSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSplitSize.Location = new System.Drawing.Point(513, 3);
            this.chkSplitSize.Name = "chkSplitSize";
            this.chkSplitSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSplitSize.Size = new System.Drawing.Size(153, 17);
            this.chkSplitSize.TabIndex = 47;
            this.chkSplitSize.Text = ":Split Into Seperate Folders";
            this.chkSplitSize.UseVisualStyleBackColor = true;
            // 
            // numSplitSize
            // 
            this.numSplitSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.numSplitSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numSplitSize.Location = new System.Drawing.Point(726, 1);
            this.numSplitSize.Maximum = new decimal(new int[] {
            102400,
            0,
            0,
            0});
            this.numSplitSize.Minimum = new decimal(new int[] {
            650,
            0,
            0,
            0});
            this.numSplitSize.Name = "numSplitSize";
            this.numSplitSize.Size = new System.Drawing.Size(58, 20);
            this.numSplitSize.TabIndex = 47;
            this.numSplitSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSplitSize.ThousandsSeparator = true;
            this.numSplitSize.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "MP3 Settings:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Destination:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDestFolder
            // 
            this.txtDestFolder.Location = new System.Drawing.Point(164, 20);
            this.txtDestFolder.Name = "txtDestFolder";
            this.txtDestFolder.Size = new System.Drawing.Size(307, 20);
            this.txtDestFolder.TabIndex = 31;
            // 
            // btnDestFolder
            // 
            this.btnDestFolder.Location = new System.Drawing.Point(477, 20);
            this.btnDestFolder.Name = "btnDestFolder";
            this.btnDestFolder.Size = new System.Drawing.Size(24, 20);
            this.btnDestFolder.TabIndex = 33;
            this.btnDestFolder.Text = "...";
            this.btnDestFolder.UseVisualStyleBackColor = true;
            this.btnDestFolder.Click += new System.EventHandler(this.btnDestFolder_Click);
            // 
            // lblProgress_2
            // 
            this.lblProgress_2.Location = new System.Drawing.Point(3, 29);
            this.lblProgress_2.Name = "lblProgress_2";
            this.lblProgress_2.Size = new System.Drawing.Size(58, 13);
            this.lblProgress_2.TabIndex = 42;
            this.lblProgress_2.Text = "Folders:";
            this.lblProgress_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblProgress_1
            // 
            this.lblProgress_1.Location = new System.Drawing.Point(3, 3);
            this.lblProgress_1.Name = "lblProgress_1";
            this.lblProgress_1.Size = new System.Drawing.Size(58, 13);
            this.lblProgress_1.TabIndex = 43;
            this.lblProgress_1.Text = "Rainwave:";
            this.lblProgress_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlProgressBars
            // 
            this.pnlProgressBars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProgressBars.Controls.Add(this.prgRaiwaveScan);
            this.pnlProgressBars.Controls.Add(this.lblProgress_2);
            this.pnlProgressBars.Controls.Add(this.prgFolderScan);
            this.pnlProgressBars.Controls.Add(this.lblProgress_1);
            this.pnlProgressBars.Location = new System.Drawing.Point(11, 12);
            this.pnlProgressBars.Name = "pnlProgressBars";
            this.pnlProgressBars.Size = new System.Drawing.Size(803, 66);
            this.pnlProgressBars.TabIndex = 44;
            this.pnlProgressBars.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrackNumber,
            this.dataGridViewTextBoxColumn3,
            this.ContentGroup,
            this.dataGridViewTextBoxColumn2,
            this.SubTitle,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(895, 368);
            this.dataGridView2.TabIndex = 45;
            // 
            // TrackNumber
            // 
            this.TrackNumber.DataPropertyName = "TrackNumber";
            this.TrackNumber.HeaderText = "Track Number";
            this.TrackNumber.Name = "TrackNumber";
            this.TrackNumber.ReadOnly = true;
            this.TrackNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TrackNumber.Width = 81;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Album";
            this.dataGridViewTextBoxColumn3.HeaderText = "Album";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 42;
            // 
            // ContentGroup
            // 
            this.ContentGroup.DataPropertyName = "ContentGroup";
            this.ContentGroup.HeaderText = "Content Group";
            this.ContentGroup.Name = "ContentGroup";
            this.ContentGroup.ReadOnly = true;
            this.ContentGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ContentGroup.Width = 82;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 33;
            // 
            // SubTitle
            // 
            this.SubTitle.DataPropertyName = "SubTitle";
            this.SubTitle.HeaderText = "Sub Title";
            this.SubTitle.Name = "SubTitle";
            this.SubTitle.ReadOnly = true;
            this.SubTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SubTitle.Width = 55;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Artist";
            this.dataGridViewTextBoxColumn1.HeaderText = "Artist";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 36;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Filename";
            this.dataGridViewTextBoxColumn4.HeaderText = "Filename";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 20;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(895, 368);
            this.dataGridView3.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Artist";
            this.dataGridViewTextBoxColumn5.HeaderText = "Artist";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 36;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn6.HeaderText = "Title";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 33;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Album";
            this.dataGridViewTextBoxColumn7.HeaderText = "Album";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 42;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Filename";
            this.dataGridViewTextBoxColumn8.HeaderText = "Filename";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 55;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 393);
            this.tabControl1.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rainwave Scan Results";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MP3 Folder Scan Results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(901, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Comparison Results";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCopyMP3s
            // 
            this.btnCopyMP3s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyMP3s.Enabled = false;
            this.btnCopyMP3s.Location = new System.Drawing.Point(820, 34);
            this.btnCopyMP3s.Name = "btnCopyMP3s";
            this.btnCopyMP3s.Size = new System.Drawing.Size(100, 21);
            this.btnCopyMP3s.TabIndex = 48;
            this.btnCopyMP3s.Text = "&Copy MP3s";
            this.btnCopyMP3s.UseVisualStyleBackColor = true;
            this.btnCopyMP3s.Click += new System.EventHandler(this.btnCopyMP3s_Click);
            // 
            // btnReCopyMP3s
            // 
            this.btnReCopyMP3s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReCopyMP3s.Location = new System.Drawing.Point(820, 57);
            this.btnReCopyMP3s.Name = "btnReCopyMP3s";
            this.btnReCopyMP3s.Size = new System.Drawing.Size(100, 21);
            this.btnReCopyMP3s.TabIndex = 49;
            this.btnReCopyMP3s.Text = "&ReCopy MP3s";
            this.btnReCopyMP3s.UseVisualStyleBackColor = true;
            this.btnReCopyMP3s.Click += new System.EventHandler(this.btnReCopyMP3s_Click);
            // 
            // fileBrowser
            // 
            this.fileBrowser.Filter = "JSON Files|*.json";
            this.fileBrowser.Title = "Select the Track listing required";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 489);
            this.Controls.Add(this.btnReCopyMP3s);
            this.Controls.Add(this.btnCopyMP3s);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlFolder);
            this.Controls.Add(this.pnlRainwave);
            this.Controls.Add(this.btnFullScan);
            this.Controls.Add(this.pnlProgressBars);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "MP3 Folder Scanner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlRainwave.ResumeLayout(false);
            this.pnlRainwave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRatedFrom)).EndInit();
            this.pnlFolder.ResumeLayout(false);
            this.pnlFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSplitSize)).EndInit();
            this.pnlProgressBars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnFullScan;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnSourceFolder;
		private System.Windows.Forms.TextBox txtSourceFolder;
		private System.Windows.Forms.Label lblFolder;
		private System.Windows.Forms.FolderBrowserDialog fldBrowser;
        private System.Windows.Forms.ProgressBar prgFolderScan;
		private System.Windows.Forms.Label lblUserID;
		private System.Windows.Forms.TextBox txtUserID;
		private System.Windows.Forms.TextBox txtAPIKey;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar prgRaiwaveScan;
		private System.Windows.Forms.Panel pnlRainwave;
		private System.Windows.Forms.Panel pnlFolder;
		private System.Windows.Forms.Label lblProgress_2;
		private System.Windows.Forms.Label lblProgress_1;
		private System.Windows.Forms.Panel pnlProgressBars;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.NumericUpDown numRatedFrom;
        private System.Windows.Forms.CheckBox chkIncludeFavourites;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestFolder;
        private System.Windows.Forms.Button btnDestFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtist;
        private System.Windows.Forms.NumericUpDown numSplitSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.CheckBox chkIncludeRated;
        private System.Windows.Forms.CheckBox chkSplitSize;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkSplitRandomly;
        private System.Windows.Forms.Button btnCopyMP3s;
        private System.Windows.Forms.Button btnReCopyMP3s;
        private System.Windows.Forms.OpenFileDialog fileBrowser;
	}
}

