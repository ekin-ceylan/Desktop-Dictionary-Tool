using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HtmlAgilityPack;
using IWshRuntimeLibrary;
using File = System.IO.File;

namespace dictool
{
    public static class Methods
    {
        private static readonly Dictionary<string, string> DictionaryLang = new Dictionary<string, string>
        {
            {"English", "en"},
            {"İngilizce", "en"},
            {"Türkçe", "tr"},
            {"Turkish", "tr"}
        };

        internal static string Appname;

        public static string Tureng(string word)
        {
            return @"http://www.tureng.com/search/" + word;
        }

        public static string Tdk(string word)
        {
            return @"http://tdk.gov.tr/index.php?option=com_gts&arama=gts&kelime=" + word + @"&uid=26607&guid=TDK.GTS.56c47c055e0e83.89258879";
        }

        public static string Temizle(string kirli)
        {
            return kirli.Replace("&Ouml;", "Ö").Replace("&ouml;", "ö")
                        .Replace("&#214;", "Ö").Replace("&#246;", "ö")
                        .Replace("&Uuml;", "Ü").Replace("&uuml;", "ü")
                        .Replace("&#220;", "Ü").Replace("&#252;", "ü")
                        .Replace("&nbsp;", " ").Replace("&#160;", " ")
                        .Replace("&rsquo;","'")
                        .Replace("&Ccedil;","Ç").Replace("&ccedil;", "ç")
                        .Replace("&#199;", "Ç").Replace("&#231;", "ç")
                        .Replace("&#350;", "Ş").Replace("&#351;", "ş")
                        .Replace("&#39;", "'").Trim();
        }

        public static string HtmlNodeToRichText(HtmlNodeCollection nodeCollection)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            RichTextBox rtb = new RichTextBox();

            if (nodeCollection == null)
            {
                rtb.SelectionAlignment = HorizontalAlignment.Center;
                rtb.AppendText("\nSonuç bulunamadı.");
                return rtb.Rtf;
            }

            string lang1 = "";

            for (int i = 0; i < nodeCollection.Count; i++)
            {
                dictionary.Clear();
                HtmlNodeCollection trCollection = nodeCollection[i].SelectNodes("tr");
                HtmlNodeCollection nd = trCollection[0].SelectNodes("th");

                if (lang1 == Temizle(nd[2].InnerText) || i == 2)
                {
                    continue;
                }

                lang1 = Temizle(nd[2].InnerText);
                string lang2 = Temizle(nd[3].InnerText);

                if (i > 0)
                {
                    rtb.AppendText("\n\n");
                }

                rtb.SelectionFont = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Italic);
                rtb.AppendText("              " + lang1 + " - " + lang2);

                foreach (HtmlNode tableRow in trCollection)
                {
                    HtmlNode temptd = tableRow.SelectSingleNode("*[@lang='" + DictionaryLang[lang2] + "']");

                    if (temptd == null)
                    {
                        continue;
                    }

                    string str = temptd.ChildNodes[0].InnerText;
                    string key = tableRow.SelectSingleNode("*[@class='hidden-xs']").InnerText;

                    if (dictionary.ContainsKey(key))
                    {
                        dictionary[key] += (", " + str);
                        rtb.AppendText(", " + str);
                    }
                    else
                    {
                        dictionary.Add(key, str);
                        rtb.SelectionFont = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Bold);
                        rtb.AppendText("\n" + key.Replace('İ','I') + ": ");
                        rtb.SelectionFont = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular);
                        rtb.AppendText(str);
                    }
                }
            }

            return Temizle(rtb.Rtf);
        }

        public static string TdkHtmlNodeToRichText(HtmlNodeCollection nodeCollection)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            RichTextBox rtb = new RichTextBox();

            if (nodeCollection == null)
            {
                rtb.SelectionAlignment = HorizontalAlignment.Center;
                rtb.AppendText("\nSonuç bulunamadı.");
                return rtb.Rtf;
            }

            for (int i = 0; i < nodeCollection.Count; i++)
            {
                dictionary.Clear();
                HtmlNodeCollection trCollection = nodeCollection[i].SelectNodes("tr");
                HtmlNode nd = nodeCollection[i].SelectSingleNode("thead").SelectSingleNode("tr").SelectSingleNode("th");
                string word = nd.SelectSingleNode("b").InnerText.Trim();
                string wordType = nd.SelectSingleNode("i").SelectSingleNode("b").InnerText.Trim();

                if (i > 0)
                { 
                    rtb.AppendText("\n\n");
                }

                rtb.SelectionFont = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Bold);
                rtb.AppendText(word);

                foreach (HtmlNode tableRow in trCollection)
                {
                    string str = tableRow.SelectSingleNode("td").InnerText.Trim();
                    string strh = tableRow.SelectSingleNode("td").InnerHtml;
                    
                    if (str == null)
                        continue;

                    rtb.SelectionFont = new Font("Microsoft Sans Serif", 7.25f, FontStyle.Regular);
                    rtb.AppendText(" " + str);
                }
            }

            return Temizle(rtb.Rtf);
        }

        public static string GetSound(HtmlNode node)
        {
            return node.SelectSingleNode("source").GetAttributeValue("src", null);
        }

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool IsConnectedToInternet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }

        #region formShape
        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        #endregion
                
        internal static bool CreateShortcut(string shortcutPathName, bool create)
        {
            if (create)
            {
                try
                {
                    string shortcutTarget = Path.Combine(Application.StartupPath, Appname + ".exe");
                    WshShell myShell = new WshShell();
                    WshShortcut myShortcut = (WshShortcut)myShell.CreateShortcut(shortcutPathName);
                    myShortcut.TargetPath = shortcutTarget; //The exe file this shortcut executes when double clicked 
                    myShortcut.IconLocation = shortcutTarget + ",0"; //Sets the icon of the shortcut to the exe`s icon 
                    myShortcut.WorkingDirectory = Application.StartupPath; //The working directory for the exe 
                    myShortcut.Arguments = ""; //The arguments used when executing the exe 
                    myShortcut.Save(); //Creates the shortcut 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    if (File.Exists(shortcutPathName))
                    {
                        File.Delete(shortcutPathName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return File.Exists(shortcutPathName);
        }        
    }
}
