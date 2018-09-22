namespace dictool
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.transparentRichTextBox1 = new CustomFormTools.TransparentRichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // transparentRichTextBox1
            // 
            this.transparentRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transparentRichTextBox1.Location = new System.Drawing.Point(58, 49);
            this.transparentRichTextBox1.Name = "transparentRichTextBox1";
            this.transparentRichTextBox1.Size = new System.Drawing.Size(150, 168);
            this.transparentRichTextBox1.TabIndex = 0;
            this.transparentRichTextBox1.Text = "sdfsefsd\nsefsefs\nsfdsesfsef\nsfsefse\nsefsefs\nsefsefsef\nsefsefsefsef\nsefsefsefsef\ns" +
    "efsefseffse\nsfsefse\nsefsefs\nsefsefsef\nsefsefsefsef\nsefsefsefsef\nsefsefseffse";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::dictool.Properties.Resources.green_background_hd_background_wallpaper_35;
            this.ClientSize = new System.Drawing.Size(180, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transparentRichTextBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomFormTools.TransparentRichTextBox transparentRichTextBox1;
        private System.Windows.Forms.Button button1;
    }
}