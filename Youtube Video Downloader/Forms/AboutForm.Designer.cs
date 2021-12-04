
namespace Youtube_Video_Downloader.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AppLogoLabel = new System.Windows.Forms.Label();
            this.AppLogoPB = new System.Windows.Forms.PictureBox();
            this.AppVersionLabel = new System.Windows.Forms.Label();
            this.MadeByLabel = new System.Windows.Forms.Label();
            this.ClosteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // AppLogoLabel
            // 
            this.AppLogoLabel.AutoSize = true;
            this.AppLogoLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppLogoLabel.Location = new System.Drawing.Point(18, 41);
            this.AppLogoLabel.Name = "AppLogoLabel";
            this.AppLogoLabel.Size = new System.Drawing.Size(270, 28);
            this.AppLogoLabel.TabIndex = 0;
            this.AppLogoLabel.Text = "Youtube Video Downloader";
            // 
            // AppLogoPB
            // 
            this.AppLogoPB.Image = global::Youtube_Video_Downloader.Properties.Resources.logo;
            this.AppLogoPB.Location = new System.Drawing.Point(127, 12);
            this.AppLogoPB.Name = "AppLogoPB";
            this.AppLogoPB.Size = new System.Drawing.Size(30, 30);
            this.AppLogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppLogoPB.TabIndex = 1;
            this.AppLogoPB.TabStop = false;
            // 
            // AppVersionLabel
            // 
            this.AppVersionLabel.AutoSize = true;
            this.AppVersionLabel.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppVersionLabel.Location = new System.Drawing.Point(241, 69);
            this.AppVersionLabel.Name = "AppVersionLabel";
            this.AppVersionLabel.Size = new System.Drawing.Size(37, 19);
            this.AppVersionLabel.TabIndex = 2;
            this.AppVersionLabel.Text = "v.1.0";
            // 
            // MadeByLabel
            // 
            this.MadeByLabel.AutoSize = true;
            this.MadeByLabel.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MadeByLabel.Location = new System.Drawing.Point(60, 96);
            this.MadeByLabel.Name = "MadeByLabel";
            this.MadeByLabel.Size = new System.Drawing.Size(166, 19);
            this.MadeByLabel.TabIndex = 3;
            this.MadeByLabel.Text = "Made with ❤ by BS Tech";
            // 
            // ClosteBtn
            // 
            this.ClosteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.ClosteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClosteBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClosteBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.ClosteBtn.Location = new System.Drawing.Point(89, 140);
            this.ClosteBtn.Name = "ClosteBtn";
            this.ClosteBtn.Size = new System.Drawing.Size(100, 35);
            this.ClosteBtn.TabIndex = 4;
            this.ClosteBtn.Text = "Close";
            this.ClosteBtn.UseVisualStyleBackColor = true;
            this.ClosteBtn.Click += new System.EventHandler(this.ClosteBtn_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.ClosteBtn);
            this.Controls.Add(this.MadeByLabel);
            this.Controls.Add(this.AppVersionLabel);
            this.Controls.Add(this.AppLogoPB);
            this.Controls.Add(this.AppLogoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppLogoLabel;
        private System.Windows.Forms.PictureBox AppLogoPB;
        private System.Windows.Forms.Label AppVersionLabel;
        private System.Windows.Forms.Label MadeByLabel;
        private System.Windows.Forms.Button ClosteBtn;
    }
}