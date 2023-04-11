namespace SearchOnSharesFromHost
{
    partial class FMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttSearch = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.txtBasePath = new System.Windows.Forms.TextBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkHiddenShares = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bttSearch
            // 
            this.bttSearch.Location = new System.Drawing.Point(12, 95);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(75, 23);
            this.bttSearch.TabIndex = 0;
            this.bttSearch.Text = "Search";
            this.bttSearch.UseVisualStyleBackColor = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // txtOut
            // 
            this.txtOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOut.Location = new System.Drawing.Point(12, 124);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(429, 282);
            this.txtOut.TabIndex = 1;
            // 
            // txtBasePath
            // 
            this.txtBasePath.Location = new System.Drawing.Point(79, 12);
            this.txtBasePath.Name = "txtBasePath";
            this.txtBasePath.Size = new System.Drawing.Size(209, 23);
            this.txtBasePath.TabIndex = 2;
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(79, 41);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(100, 23);
            this.txtFilename.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filename:";
            // 
            // chkHiddenShares
            // 
            this.chkHiddenShares.AutoSize = true;
            this.chkHiddenShares.Location = new System.Drawing.Point(12, 70);
            this.chkHiddenShares.Name = "chkHiddenShares";
            this.chkHiddenShares.Size = new System.Drawing.Size(101, 19);
            this.chkHiddenShares.TabIndex = 6;
            this.chkHiddenShares.Text = "Hidden shares";
            this.chkHiddenShares.UseVisualStyleBackColor = true;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 418);
            this.Controls.Add(this.chkHiddenShares);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.txtBasePath);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.bttSearch);
            this.Name = "FMain";
            this.Text = "Search files on shares from host";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttSearch;
        private TextBox txtOut;
        private TextBox txtBasePath;
        private TextBox txtFilename;
        private Label label1;
        private Label label2;
        private CheckBox chkHiddenShares;
    }
}