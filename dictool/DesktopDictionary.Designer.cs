namespace dictool
{
    partial class DesktopDictionary
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopDictionary));
            this.txtWord = new System.Windows.Forms.TextBox();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxItemAlwaysTop = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItemStartup = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItemTransparent = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItemTransparent0 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItemTransparent20 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItemTransparent40 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItemTransparent60 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItemTransparent80 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItemColorLime = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItemColorTurquoise = new System.Windows.Forms.ToolStripMenuItem();
            this.khakiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.violetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctxSearch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnSearch = new CustomFormTools.RoundButton();
            this.txtTranslation = new CustomFormTools.TransparentRichTextBox();
            this.btnTr = new System.Windows.Forms.Button();
            this.btnEn = new System.Windows.Forms.Button();
            this.ctxMenu.SuspendLayout();
            this.ctxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.AllowDrop = true;
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWord.Location = new System.Drawing.Point(7, 9);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(92, 20);
            this.txtWord.TabIndex = 0;
            this.txtWord.Text = "welcome";
            this.txtWord.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtWord_DragDrop);
            this.txtWord.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtWord_DragEnter);
            this.txtWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWord_KeyPress);
            this.txtWord.MouseEnter += new System.EventHandler(this.Form1_MouseHover);
            this.txtWord.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxItemAlwaysTop,
            this.ctxItemStartup,
            this.ctxItemTransparent,
            this.ctxItemColor,
            this.toolStripSeparator1,
            this.ctxItemAbout,
            this.ctxItemExit});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(150, 142);
            // 
            // ctxItemAlwaysTop
            // 
            this.ctxItemAlwaysTop.Checked = true;
            this.ctxItemAlwaysTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctxItemAlwaysTop.Name = "ctxItemAlwaysTop";
            this.ctxItemAlwaysTop.Size = new System.Drawing.Size(149, 22);
            this.ctxItemAlwaysTop.Text = "Always on top";
            this.ctxItemAlwaysTop.Click += new System.EventHandler(this.ctxItemAlwaysTop_Click);
            // 
            // ctxItemStartup
            // 
            this.ctxItemStartup.Name = "ctxItemStartup";
            this.ctxItemStartup.Size = new System.Drawing.Size(149, 22);
            this.ctxItemStartup.Text = "Run at startup";
            this.ctxItemStartup.Click += new System.EventHandler(this.ctxItemStartup_Click);
            // 
            // ctxItemTransparent
            // 
            this.ctxItemTransparent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxItemTransparent0,
            this.ctxItemTransparent20,
            this.ctxItemTransparent40,
            this.ctxItemTransparent60,
            this.ctxItemTransparent80});
            this.ctxItemTransparent.Image = global::dictool.Properties.Resources.Cube_Design_Box_Transparent_Creative_32;
            this.ctxItemTransparent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctxItemTransparent.Name = "ctxItemTransparent";
            this.ctxItemTransparent.Size = new System.Drawing.Size(149, 22);
            this.ctxItemTransparent.Text = "Transparency";
            this.ctxItemTransparent.DropDownClosed += new System.EventHandler(this.ctxItemTransparent_DropDownClosed);
            this.ctxItemTransparent.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxItemTransparent_DropDownItemClicked);
            // 
            // ctxItemTransparent0
            // 
            this.ctxItemTransparent0.Name = "ctxItemTransparent0";
            this.ctxItemTransparent0.Size = new System.Drawing.Size(96, 22);
            this.ctxItemTransparent0.Tag = "1";
            this.ctxItemTransparent0.Text = "0%";
            this.ctxItemTransparent0.MouseHover += new System.EventHandler(this.ctxItemTransparent0_MouseHover);
            // 
            // ctxItemTransparent20
            // 
            this.ctxItemTransparent20.Name = "ctxItemTransparent20";
            this.ctxItemTransparent20.Size = new System.Drawing.Size(96, 22);
            this.ctxItemTransparent20.Tag = ".8";
            this.ctxItemTransparent20.Text = "20%";
            this.ctxItemTransparent20.MouseHover += new System.EventHandler(this.ctxItemTransparent0_MouseHover);
            // 
            // ctxItemTransparent40
            // 
            this.ctxItemTransparent40.Name = "ctxItemTransparent40";
            this.ctxItemTransparent40.Size = new System.Drawing.Size(96, 22);
            this.ctxItemTransparent40.Tag = ".6";
            this.ctxItemTransparent40.Text = "40%";
            this.ctxItemTransparent40.MouseHover += new System.EventHandler(this.ctxItemTransparent0_MouseHover);
            // 
            // ctxItemTransparent60
            // 
            this.ctxItemTransparent60.Name = "ctxItemTransparent60";
            this.ctxItemTransparent60.Size = new System.Drawing.Size(96, 22);
            this.ctxItemTransparent60.Tag = ".4";
            this.ctxItemTransparent60.Text = "60%";
            this.ctxItemTransparent60.MouseHover += new System.EventHandler(this.ctxItemTransparent0_MouseHover);
            // 
            // ctxItemTransparent80
            // 
            this.ctxItemTransparent80.Name = "ctxItemTransparent80";
            this.ctxItemTransparent80.Size = new System.Drawing.Size(96, 22);
            this.ctxItemTransparent80.Tag = ".2";
            this.ctxItemTransparent80.Text = "80%";
            this.ctxItemTransparent80.MouseHover += new System.EventHandler(this.ctxItemTransparent0_MouseHover);
            // 
            // ctxItemColor
            // 
            this.ctxItemColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxItemColorLime,
            this.ctxItemColorTurquoise,
            this.khakiToolStripMenuItem,
            this.violetToolStripMenuItem,
            this.silverToolStripMenuItem});
            this.ctxItemColor.Image = global::dictool.Properties.Resources._1446665823_paint_bucket;
            this.ctxItemColor.Name = "ctxItemColor";
            this.ctxItemColor.Size = new System.Drawing.Size(149, 22);
            this.ctxItemColor.Text = "Theme";
            this.ctxItemColor.DropDownClosed += new System.EventHandler(this.colorToolStripMenuItem_DropDownClosed);
            this.ctxItemColor.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxItemColor_DropDownItemClicked);
            // 
            // ctxItemColorLime
            // 
            this.ctxItemColorLime.BackColor = System.Drawing.Color.Lime;
            this.ctxItemColorLime.BackgroundImage = global::dictool.Properties.Resources.Green;
            this.ctxItemColorLime.Name = "ctxItemColorLime";
            this.ctxItemColorLime.Size = new System.Drawing.Size(105, 22);
            this.ctxItemColorLime.Text = "Green";
            this.ctxItemColorLime.MouseHover += new System.EventHandler(this.ctxItemColor_MouseHover);
            // 
            // ctxItemColorTurquoise
            // 
            this.ctxItemColorTurquoise.BackColor = System.Drawing.Color.Turquoise;
            this.ctxItemColorTurquoise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctxItemColorTurquoise.BackgroundImage")));
            this.ctxItemColorTurquoise.Name = "ctxItemColorTurquoise";
            this.ctxItemColorTurquoise.Size = new System.Drawing.Size(105, 22);
            this.ctxItemColorTurquoise.Tag = "";
            this.ctxItemColorTurquoise.Text = "Blue";
            this.ctxItemColorTurquoise.MouseHover += new System.EventHandler(this.ctxItemColor_MouseHover);
            // 
            // khakiToolStripMenuItem
            // 
            this.khakiToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.khakiToolStripMenuItem.BackgroundImage = global::dictool.Properties.Resources.Paper;
            this.khakiToolStripMenuItem.Name = "khakiToolStripMenuItem";
            this.khakiToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.khakiToolStripMenuItem.Text = "Paper";
            this.khakiToolStripMenuItem.MouseHover += new System.EventHandler(this.ctxItemColor_MouseHover);
            // 
            // violetToolStripMenuItem
            // 
            this.violetToolStripMenuItem.BackColor = System.Drawing.Color.Violet;
            this.violetToolStripMenuItem.BackgroundImage = global::dictool.Properties.Resources.Violet;
            this.violetToolStripMenuItem.Name = "violetToolStripMenuItem";
            this.violetToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.violetToolStripMenuItem.Tag = "";
            this.violetToolStripMenuItem.Text = "Violet";
            this.violetToolStripMenuItem.MouseHover += new System.EventHandler(this.ctxItemColor_MouseHover);
            // 
            // silverToolStripMenuItem
            // 
            this.silverToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.silverToolStripMenuItem.BackgroundImage = global::dictool.Properties.Resources.Silver;
            this.silverToolStripMenuItem.Name = "silverToolStripMenuItem";
            this.silverToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.silverToolStripMenuItem.Text = "Silver";
            this.silverToolStripMenuItem.MouseHover += new System.EventHandler(this.ctxItemColor_MouseHover);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // ctxItemAbout
            // 
            this.ctxItemAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctxItemAbout.Image = global::dictool.Properties.Resources._1446446524_about;
            this.ctxItemAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctxItemAbout.Name = "ctxItemAbout";
            this.ctxItemAbout.Size = new System.Drawing.Size(149, 22);
            this.ctxItemAbout.Text = "About";
            this.ctxItemAbout.Click += new System.EventHandler(this.ctxItemAbout_Click);
            // 
            // ctxItemExit
            // 
            this.ctxItemExit.Image = global::dictool.Properties.Resources._1446446847_close;
            this.ctxItemExit.Name = "ctxItemExit";
            this.ctxItemExit.Size = new System.Drawing.Size(149, 22);
            this.ctxItemExit.Text = "Close";
            this.ctxItemExit.Click += new System.EventHandler(this.ctxItemExit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(7, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 1);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(7, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 1);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // ctxSearch
            // 
            this.ctxSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxItemSearch,
            this.copyToolStripMenuItem});
            this.ctxSearch.Name = "ctxSearch";
            this.ctxSearch.Size = new System.Drawing.Size(110, 48);
            // 
            // ctxItemSearch
            // 
            this.ctxItemSearch.Name = "ctxItemSearch";
            this.ctxItemSearch.Size = new System.Drawing.Size(109, 22);
            this.ctxItemSearch.Text = "Search";
            this.ctxItemSearch.Click += new System.EventHandler(this.ctxItemSearch_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.Transparent;
            this.btnSound.BackgroundImage = global::dictool.Properties.Resources._1446619580_volume_off_70px;
            this.btnSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSound.FlatAppearance.BorderSize = 0;
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Location = new System.Drawing.Point(12, 31);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(21, 21);
            this.btnSound.TabIndex = 7;
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            this.btnSound.MouseEnter += new System.EventHandler(this.Form1_MouseHover);
            this.btnSound.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::dictool.Properties.Resources._1446933047_search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderWidth = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.Location = new System.Drawing.Point(105, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 25);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.Form1_MouseHover);
            this.btnSearch.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            // 
            // txtTranslation
            // 
            this.txtTranslation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTranslation.BackColor = System.Drawing.Color.Lime;
            this.txtTranslation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTranslation.EnableAutoDragDrop = true;
            this.txtTranslation.Location = new System.Drawing.Point(7, 55);
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.ReadOnly = true;
            this.txtTranslation.RightMargin = 165;
            this.txtTranslation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtTranslation.Size = new System.Drawing.Size(160, 224);
            this.txtTranslation.TabIndex = 1;
            this.txtTranslation.Text = "";
            this.txtTranslation.ClientSizeChanged += new System.EventHandler(this.txtTranslation_ClientSizeChanged);
            this.txtTranslation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTranslation_KeyPress);
            this.txtTranslation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtTranslation_MouseDoubleClick);
            this.txtTranslation.MouseHover += new System.EventHandler(this.txtTranslation_MouseHover);
            this.txtTranslation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtTranslation_MouseUp);
            // 
            // btnTr
            // 
            this.btnTr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTr.BackColor = System.Drawing.Color.Transparent;
            this.btnTr.BackgroundImage = global::dictool.Properties.Resources.Turkey_48;
            this.btnTr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTr.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnTr.FlatAppearance.BorderSize = 0;
            this.btnTr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTr.Location = new System.Drawing.Point(95, 31);
            this.btnTr.Name = "btnTr";
            this.btnTr.Size = new System.Drawing.Size(21, 21);
            this.btnTr.TabIndex = 8;
            this.btnTr.Tag = "True";
            this.btnTr.UseVisualStyleBackColor = false;
            this.btnTr.Click += new System.EventHandler(this.btnTr_Click);
            // 
            // btnEn
            // 
            this.btnEn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEn.BackColor = System.Drawing.Color.Transparent;
            this.btnEn.BackgroundImage = global::dictool.Properties.Resources.england_circle_48;
            this.btnEn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEn.Location = new System.Drawing.Point(121, 31);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(21, 21);
            this.btnEn.TabIndex = 9;
            this.btnEn.Tag = "False";
            this.btnEn.UseVisualStyleBackColor = false;
            this.btnEn.Click += new System.EventHandler(this.btnTr_Click);
            // 
            // DesktopDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::dictool.Properties.Resources.Green;
            this.ClientSize = new System.Drawing.Size(148, 291);
            this.Controls.Add(this.btnEn);
            this.Controls.Add(this.btnTr);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTranslation);
            this.Controls.Add(this.txtWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DesktopDictionary";
            this.ShowInTaskbar = false;
            this.Text = "Desktop Dictionary";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.ctxMenu.ResumeLayout(false);
            this.ctxSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWord;
        //private System.Windows.Forms.RichTextBox txtTranslation;
        private CustomFormTools.TransparentRichTextBox txtTranslation;
        private CustomFormTools.RoundButton btnSearch;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxItemAlwaysTop;
        private System.Windows.Forms.ToolStripMenuItem ctxItemTransparent;
        private System.Windows.Forms.ToolStripMenuItem ctxItemTransparent0;
        private System.Windows.Forms.ToolStripMenuItem ctxItemTransparent20;
        private System.Windows.Forms.ToolStripMenuItem ctxItemTransparent40;
        private System.Windows.Forms.ToolStripMenuItem ctxItemTransparent60;
        private System.Windows.Forms.ToolStripMenuItem ctxItemTransparent80;
        private System.Windows.Forms.ToolStripMenuItem ctxItemAbout;
        private System.Windows.Forms.ToolStripMenuItem ctxItemExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip ctxSearch;
        private System.Windows.Forms.ToolStripMenuItem ctxItemSearch;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.ToolStripMenuItem ctxItemColor;
        private System.Windows.Forms.ToolStripMenuItem ctxItemColorLime;
        private System.Windows.Forms.ToolStripMenuItem ctxItemColorTurquoise;
        private System.Windows.Forms.ToolStripMenuItem silverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khakiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem violetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctxItemStartup;
        private System.Windows.Forms.Button btnTr;
        private System.Windows.Forms.Button btnEn;
    }
}