using System;
using System.Collections.Generic;
using System.IO;

namespace Waterspout
{
    public class Track
    {
        public Track() { }

        public string Album { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Artist { get; set; }

        public string TrackNumber { get; set; }

        public string ContentGroup { get; set; }

        public string FileName { get; set; }

        public Int64 FileSize { get; set; }

        public string DestFileName
        {
            get
            {
                // Generate the new Filename
                string sReturn = Album + " - " + Title + " {" + Artist + "}.mp3";
                // Remove any Invalid Filename Chars
                sReturn = String.Join("", sReturn.Split(Path.GetInvalidFileNameChars()));

                return sReturn;
            }
        }

        public string AllCombined() { return ConvertRomanNumerals(Album) + " ~ " + ConvertRomanNumerals(Title) + " ~ " + ConvertRomanNumerals(SubTitle) + " ~ " + ConvertRomanNumerals(Artist) + " ~ " + ConvertRomanNumerals(TrackNumber) + " ~ " + ConvertRomanNumerals(ContentGroup) + " ~ " + ConvertRomanNumerals(FileName); }

        public bool Matches(Track p_tMatch)
        {
            string sMyTags = RemoveSymbols(ConvertRomanNumerals(this.AllCombined())).ToLower();
            string sMatchTags = RemoveSymbols(ConvertRomanNumerals(p_tMatch.AllCombined())).ToLower();

            // Compare this with p_tMatch
            int iThisMatchCount = 0;
            if (!IsNullEmptyOrWhiteSpace(p_tMatch.Album) && sMyTags.Contains(RemoveSymbols(ConvertRomanNumerals(p_tMatch.Album)).ToLower())) iThisMatchCount++;
            if (!IsNullEmptyOrWhiteSpace(p_tMatch.Title) && sMyTags.Contains(RemoveSymbols(ConvertRomanNumerals(p_tMatch.Title)).ToLower())) iThisMatchCount++;
            if (!IsNullEmptyOrWhiteSpace(p_tMatch.SubTitle) && sMyTags.Contains(RemoveSymbols(ConvertRomanNumerals(p_tMatch.SubTitle)).ToLower())) iThisMatchCount++;
            if (!IsNullEmptyOrWhiteSpace(p_tMatch.Artist) && sMyTags.Contains(RemoveSymbols(ConvertRomanNumerals(p_tMatch.Artist)).ToLower())) iThisMatchCount++;
            if (!IsNullEmptyOrWhiteSpace(p_tMatch.ContentGroup) && sMyTags.Contains(RemoveSymbols(ConvertRomanNumerals(p_tMatch.ContentGroup)).ToLower())) iThisMatchCount++;

            // Compare p_tMatch with this
            int iMatchCount = 0;
            if (!IsNullEmptyOrWhiteSpace(this.Album) && sMatchTags.Contains(RemoveSymbols(ConvertRomanNumerals(this.Album)).ToLower())) iMatchCount++;
            if (!IsNullEmptyOrWhiteSpace(this.Title) && sMatchTags.Contains(RemoveSymbols(ConvertRomanNumerals(this.Title)).ToLower())) iMatchCount++;
            if (!IsNullEmptyOrWhiteSpace(this.SubTitle) && sMatchTags.Contains(RemoveSymbols(ConvertRomanNumerals(this.SubTitle)).ToLower())) iMatchCount++;
            if (!IsNullEmptyOrWhiteSpace(this.Artist) && sMatchTags.Contains(RemoveSymbols(ConvertRomanNumerals(this.Artist)).ToLower())) iMatchCount++;
            if (!IsNullEmptyOrWhiteSpace(this.ContentGroup) && sMatchTags.Contains(RemoveSymbols(ConvertRomanNumerals(this.ContentGroup)).ToLower())) iMatchCount++;

            return iThisMatchCount > 2 || iMatchCount > 2;
        }

        private bool IsNullEmptyOrWhiteSpace(string p_sValue)
        {
            return string.IsNullOrEmpty(p_sValue) || string.IsNullOrWhiteSpace(p_sValue);
        }

        private string RemoveSymbols(string p_sSource)
        {
            string sReturn = p_sSource;
            char[] cValues = { ' ', '`', '¬', '¦', '!', '"', '£', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', '{', ']', '}', ';', ':', '\'', '@', '#', '~', ',', '<', '.', '>', '/', '?', '\\', '|' };

            foreach (char cValue in cValues)
            {
                sReturn = sReturn.Replace(cValue.ToString(), "");
            }
            return sReturn;
        }

        private string ConvertRomanNumerals(string p_sSource)
        {
            if (!IsNullEmptyOrWhiteSpace(p_sSource))
            {
                Dictionary<string, int> RomanNumerals = new Dictionary<string, int>
            {
                //{"M", 1000},
                //{"CM", 900},
                //{"D", 500},
                //{"CD", 400},
                //{"C", 100},
                //{"XC", 90},
                //{"L", 50},
                //{"XL", 40},
                {"X", 10},
                {"IX", 9},
                {"V", 5},
                {"IV", 4},
                {"I", 1}
            };

                int iValue = 0;
                int iStartIndx = 0;
                int iEndIndx = 0;
                string sSource = p_sSource;
                string sRomanNumerals = "";
                foreach (KeyValuePair<string, int> pair in RomanNumerals)
                    while (p_sSource.IndexOf(pair.Key) == 0 &&
                          (iStartIndx == 0 && p_sSource.IndexOf(pair.Key) > 0 && p_sSource[p_sSource.IndexOf(pair.Key) - 1] == ' '))
                    {
                        if (iStartIndx == 0) iStartIndx = p_sSource.IndexOf(pair.Key);
                        iEndIndx += pair.Key.Length;

                        iValue += int.Parse(pair.Value.ToString());

                        sSource = sSource.Substring(pair.Key.Length);
                    }

                if (iValue > 0)
                {
                    sRomanNumerals = p_sSource.Substring(iStartIndx, iEndIndx);
                    return p_sSource.Replace(sRomanNumerals, iValue.ToString());
                }
                else
                    return p_sSource;
            }
            else
                return p_sSource;
        }
    }
}
