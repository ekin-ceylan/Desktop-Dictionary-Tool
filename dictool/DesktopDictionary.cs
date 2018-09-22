using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using dictool.Properties;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace dictool
{
    public partial class DesktopDictionary : Form
    {
        public DesktopDictionary()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Region = Region.FromHrgn(Methods.CreateRoundRectRgn(0, 0, Width = _width[1], Height = _height[1], 10, 10));

            _clm = (ToolStripMenuItem)ctxItemColor.DropDownItems[Settings.Default.Color] ?? ctxItemColorLime;
            _tsm = (ToolStripMenuItem)ctxItemTransparent.DropDownItems[Settings.Default.Transparency] ?? ctxItemTransparent0;
            _dcb = btnEn;
            txtWord.Text = Settings.Default.Welcome ?? "welcome";

            _clm.Checked = true;
            BackgroundImage = _clm.BackgroundImage;

            _tsm.Checked = true;
            Opacity = Convert.ToDouble(_tsm.Tag, new NumberFormatInfo { NumberDecimalSeparator = "." });

            Methods.Appname = Assembly.GetExecutingAssembly().FullName.Remove(Assembly.GetExecutingAssembly().FullName.IndexOf(","));
            _startupPathName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Methods.Appname + ".lnk");

            ctxItemStartup.Checked = Methods.CreateShortcut(_startupPathName, Settings.Default.RunAtStartup);
            ctxItemAlwaysTop.Checked = (TopMost = Settings.Default.AlwaysOnTop);
        }

        private ToolStripMenuItem _tsm;
        private ToolStripMenuItem _clm;
        private Button _dcb;
        private bool _isTr;
        private readonly int[] _height = { 291, 55 };
        private readonly int[] _width = { 180, 148 };
        private readonly string _version = "1.2";
        private bool _setFired;
        private readonly string _startupPathName;
        private bool _isProsessing;

        private const int CsDropshadow = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CsDropshadow;
                return cp;
            }
        }

        private void ShowTextArea(string text)
        {
            txtTranslation.Rtf = text;

            if (Height == _height[1])
            {
                Region = Region.FromHrgn(Methods.CreateRoundRectRgn(0, 0, Width = _width[0], Height = _height[0], 10, 10));
                Location = new Point(Location.X - (Width - _width[1]), Location.Y);
            }

            Activate();
            txtWord.Focus();
            txtWord.SelectAll();
            txtTranslation.Focus();
            Opacity = 1;
            UpdateStyles();
        }

        private void Search()
        {
            if (!Methods.IsConnectedToInternet())
            {
                RichTextBox rtb = new RichTextBox { SelectionAlignment = HorizontalAlignment.Center };
                rtb.AppendText("\nPlease check your internet connection");
                ShowTextArea(rtb.Rtf);
                _isProsessing = false;

                return;
            }

            HtmlDocument document;

            try
            {
                document = new HtmlWeb().Load(_isTr ? Methods.Tdk(txtWord.Text.Trim()) : Methods.Tureng(txtWord.Text.Trim()));
            }
            catch (WebException)
            {
                RichTextBox rtb = new RichTextBox { SelectionAlignment = HorizontalAlignment.Center };
                rtb.AppendText("\nUnable to reach the website");
                ShowTextArea(rtb.Rtf);
                _isProsessing = false;

                return;
            }
            catch (Exception ex)
            {
                RichTextBox rtb = new RichTextBox { SelectionAlignment = HorizontalAlignment.Center };
                rtb.AppendText("\n" + ex.Message);
                ShowTextArea(rtb.Rtf);
                _isProsessing = false;

                return;
            }

            HtmlNode node = document.DocumentNode.SelectSingleNode("//*[@id='turengVoiceENTRENus']");

            if (node == null)
            {
                btnSound.BackgroundImage = Resources._1446619580_volume_off_70px;
                btnSound.Tag = null;
            }
            else
            {
                btnSound.Tag = Methods.GetSound(node);
                btnSound.BackgroundImage = Resources._1446617989_volume_70px;
            }

            HtmlNodeCollection name = _isTr ? document.DocumentNode.SelectNodes("//*[@id='hor-minimalist-a']") : document.DocumentNode.SelectNodes("//*[@id='englishResultsTable']");
            ShowTextArea(_isTr ? Methods.TdkHtmlNodeToRichText(name) : Methods.HtmlNodeToRichText(name));
            _isProsessing = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!_isProsessing && txtWord.Text != "")
            {
                _isProsessing = true;
                Thread thread = new Thread(Search) { IsBackground = true };
                thread.Start();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Methods.ReleaseCapture();
                Methods.SendMessage(Handle, Methods.WmNclbuttondown, Methods.HtCaption, 0);
            }
            else if (e.Button == MouseButtons.Right)
            {
                ctxMenu.Visible = true;
                ctxMenu.Location = MousePosition;
            }
        }

        private void txtWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnSearch_Click(this, new EventArgs());
                e.Handled = true;
            }
        }

        private void ctxItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ctxItemAlwaysTop_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;
            tsm.Checked = !tsm.Checked;
            TopMost = !TopMost;
        }

        private void ctxMenu_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
            {
                e.Cancel = true;
            }
        }

        private void ctxItemTransparent_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            _tsm.Checked = false;
            _tsm = (ToolStripMenuItem)e.ClickedItem;
            _tsm.Checked = true;
            Opacity = Convert.ToDouble(_tsm.Tag, new NumberFormatInfo { NumberDecimalSeparator = "." });
        }

        private void ctxItemAbout_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = new RichTextBox { SelectionAlignment = HorizontalAlignment.Center };

            rtb.AppendText("\n\nSimple desktop dictionary tool for Windows");
            rtb.AppendText("\nVersion: " + _version + " (2015)");
            rtb.AppendText("\n\nDeveloped by Ekin Ceylan");
            rtb.AppendText("\nekinceylan@gmail.com");
            ShowTextArea(rtb.Rtf);
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            int x = MousePosition.X - Location.X;
            int y = MousePosition.Y - Location.Y;

            if (Height == _height[1] && (x < 0 || x + 1 >= Width || y < 0 || y + 1 >= Height))
            {
                Opacity = Convert.ToDouble(_tsm.Tag, new NumberFormatInfo { NumberDecimalSeparator = "." });
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Location = new Point(Location.X + (Width - _width[1]), Location.Y);
            Region = Region.FromHrgn(Methods.CreateRoundRectRgn(0, 0, Width = _width[1], Height = _height[1], 10, 10));
            Opacity = Convert.ToDouble(_tsm.Tag, new NumberFormatInfo { NumberDecimalSeparator = "." });

            txtTranslation.Clear();
        }

        private void txtTranslation_MouseHover(object sender, EventArgs e)
        {
            txtTranslation.Focus();
        }

        private void txtTranslation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            txtWord.Focus();
            txtWord.Text = e.KeyChar.ToString();
            txtWord.SelectionStart = txtWord.Text.Length;
        }

        private void txtTranslation_ClientSizeChanged(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            panel2.Visible = !panel2.Visible;
        }

        private void txtTranslation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _setFired = true;

            if (txtTranslation.SelectedText.Trim() != "")
            {
                txtWord.Text = txtTranslation.SelectedText.Trim();
                btnSearch_Click(null, new EventArgs());
            }
        }

        private void txtTranslation_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtTranslation.SelectedText.Length > 0 && !_setFired)
            {
                ctxSearch.Visible = true;
                ctxSearch.Location = MousePosition;
            }

            _setFired = false;
        }

        private void ctxItemSearch_Click(object sender, EventArgs e)
        {
            txtWord.Text = txtTranslation.SelectedText.Trim();
            btnSearch_Click(null, new EventArgs());
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtTranslation.SelectedText.Trim());
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            MediaPlayer.MediaPlayer player = new MediaPlayer.MediaPlayer { FileName = (string)btnSound.Tag };
            player.Play();
            txtTranslation.Focus();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtWord.Focus();
        }

        private void ctxItemColor_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            _clm.Checked = false;
            _clm = (ToolStripMenuItem)e.ClickedItem;
            _clm.Checked = true;
            BackgroundImage = _clm.BackgroundImage;
        }

        private void ctxItemColor_MouseHover(object sender, EventArgs e)
        {
            BackgroundImage = ((ToolStripMenuItem)sender).BackgroundImage;
        }

        private void colorToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            BackgroundImage = _clm.BackgroundImage;
        }

        private void ctxItemTransparent0_MouseHover(object sender, EventArgs e)
        {
            Opacity = Convert.ToDouble(((ToolStripMenuItem)sender).Tag, new NumberFormatInfo { NumberDecimalSeparator = "." });
        }

        private void ctxItemTransparent_DropDownClosed(object sender, EventArgs e)
        {
            Opacity = Convert.ToDouble(_tsm.Tag, new NumberFormatInfo { NumberDecimalSeparator = "." });
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Transparency = _tsm.Name;
            Settings.Default.Color = _clm.Name;
            Settings.Default.LocationX = Location.X + Width - _width[1];
            Settings.Default.LocationY = Location.Y;
            Settings.Default.Welcome = "";
            Settings.Default.RunAtStartup = ctxItemStartup.Checked;
            Settings.Default.AlwaysOnTop = ctxItemAlwaysTop.Checked;
            Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = new Point(Settings.Default.LocationX, Settings.Default.LocationY);
        }

        private void ctxItemStartup_Click(object sender, EventArgs e)
        {
            ctxItemStartup.Checked = Methods.CreateShortcut(_startupPathName, !ctxItemStartup.Checked);
        }

        private void txtWord_DragDrop(object sender, DragEventArgs e)
        {
            txtWord.Text = e.Data.GetData(DataFormats.Text).ToString();
            btnSearch_Click(null, new EventArgs());
        }

        private void txtWord_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.Text) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void btnTr_Click(object sender, EventArgs e)
        {
            _dcb.FlatAppearance.BorderSize = 0;
            _dcb = ((Button)sender);
            _dcb.FlatAppearance.BorderSize = 1;
            _isTr = Convert.ToBoolean(_dcb.Tag);
        }
    }
}
