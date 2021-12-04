
namespace Youtube_Video_Downloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AppLogoLabel = new System.Windows.Forms.Label();
            this.AppLogoPB = new System.Windows.Forms.PictureBox();
            this.MinimizeBtn = new FontAwesome.Sharp.IconButton();
            this.AboutBtn = new FontAwesome.Sharp.IconButton();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.UrlStatusLabel = new System.Windows.Forms.Label();
            this.UrlTB = new System.Windows.Forms.TextBox();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.VideoDetailsPanel = new System.Windows.Forms.Panel();
            this.ResolutionsCMB = new System.Windows.Forms.ComboBox();
            this.VideoTitleLabel = new System.Windows.Forms.Label();
            this.VideoResolutionsLabel = new System.Windows.Forms.Label();
            this.VideoTitle = new System.Windows.Forms.Label();
            this.VideoThumbnailPB = new System.Windows.Forms.PictureBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.LoadingPB = new System.Windows.Forms.PictureBox();
            this.SettingsBtn = new FontAwesome.Sharp.IconButton();
            this.DownloadBtn = new FontAwesome.Sharp.IconButton();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.SaveToLabel = new System.Windows.Forms.Label();
            this.ChooseDestinationBtn = new FontAwesome.Sharp.IconButton();
            this.FetchVideoDetailsBGW = new System.ComponentModel.BackgroundWorker();
            this.DownloadVideoBGW = new System.ComponentModel.BackgroundWorker();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPB)).BeginInit();
            this.InputPanel.SuspendLayout();
            this.VideoDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoThumbnailPB)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPB)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.LightGray;
            this.TopPanel.Controls.Add(this.AppLogoLabel);
            this.TopPanel.Controls.Add(this.AppLogoPB);
            this.TopPanel.Controls.Add(this.MinimizeBtn);
            this.TopPanel.Controls.Add(this.AboutBtn);
            this.TopPanel.Controls.Add(this.CloseBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 50);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // AppLogoLabel
            // 
            this.AppLogoLabel.AutoSize = true;
            this.AppLogoLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppLogoLabel.Location = new System.Drawing.Point(44, 15);
            this.AppLogoLabel.Name = "AppLogoLabel";
            this.AppLogoLabel.Size = new System.Drawing.Size(219, 23);
            this.AppLogoLabel.TabIndex = 4;
            this.AppLogoLabel.Text = "Youtube Video Downloader";
            this.AppLogoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.AppLogoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.AppLogoLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // AppLogoPB
            // 
            this.AppLogoPB.Image = global::Youtube_Video_Downloader.Properties.Resources.logo;
            this.AppLogoPB.Location = new System.Drawing.Point(13, 13);
            this.AppLogoPB.Name = "AppLogoPB";
            this.AppLogoPB.Size = new System.Drawing.Size(25, 25);
            this.AppLogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppLogoPB.TabIndex = 3;
            this.AppLogoPB.TabStop = false;
            this.AppLogoPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.AppLogoPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.AppLogoPB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.MinimizeBtn.IconColor = System.Drawing.Color.ForestGreen;
            this.MinimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeBtn.IconSize = 35;
            this.MinimizeBtn.Location = new System.Drawing.Point(732, 12);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.MinimizeBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimizeBtn.TabIndex = 2;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.FlatAppearance.BorderSize = 0;
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.AboutBtn.IconColor = System.Drawing.Color.LightSlateGray;
            this.AboutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AboutBtn.IconSize = 35;
            this.AboutBtn.Location = new System.Drawing.Point(701, 12);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.AboutBtn.Size = new System.Drawing.Size(25, 25);
            this.AboutBtn.TabIndex = 1;
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CloseBtn.IconColor = System.Drawing.Color.Firebrick;
            this.CloseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseBtn.IconSize = 35;
            this.CloseBtn.Location = new System.Drawing.Point(763, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.CloseBtn.Size = new System.Drawing.Size(25, 25);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InputPanel.Controls.Add(this.UrlStatusLabel);
            this.InputPanel.Controls.Add(this.UrlTB);
            this.InputPanel.Controls.Add(this.UrlLabel);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputPanel.Location = new System.Drawing.Point(0, 50);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(800, 70);
            this.InputPanel.TabIndex = 1;
            // 
            // UrlStatusLabel
            // 
            this.UrlStatusLabel.AutoSize = true;
            this.UrlStatusLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlStatusLabel.Location = new System.Drawing.Point(59, 48);
            this.UrlStatusLabel.Name = "UrlStatusLabel";
            this.UrlStatusLabel.Size = new System.Drawing.Size(47, 20);
            this.UrlStatusLabel.TabIndex = 8;
            this.UrlStatusLabel.Text = "status";
            this.UrlStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UrlTB
            // 
            this.UrlTB.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlTB.Location = new System.Drawing.Point(57, 13);
            this.UrlTB.Name = "UrlTB";
            this.UrlTB.Size = new System.Drawing.Size(700, 34);
            this.UrlTB.TabIndex = 1;
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlLabel.Location = new System.Drawing.Point(9, 16);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(42, 23);
            this.UrlLabel.TabIndex = 0;
            this.UrlLabel.Text = "URL";
            // 
            // VideoDetailsPanel
            // 
            this.VideoDetailsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.VideoDetailsPanel.Controls.Add(this.ResolutionsCMB);
            this.VideoDetailsPanel.Controls.Add(this.VideoTitleLabel);
            this.VideoDetailsPanel.Controls.Add(this.VideoResolutionsLabel);
            this.VideoDetailsPanel.Controls.Add(this.VideoTitle);
            this.VideoDetailsPanel.Controls.Add(this.VideoThumbnailPB);
            this.VideoDetailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VideoDetailsPanel.Location = new System.Drawing.Point(0, 120);
            this.VideoDetailsPanel.Name = "VideoDetailsPanel";
            this.VideoDetailsPanel.Size = new System.Drawing.Size(800, 150);
            this.VideoDetailsPanel.TabIndex = 2;
            // 
            // ResolutionsCMB
            // 
            this.ResolutionsCMB.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolutionsCMB.FormattingEnabled = true;
            this.ResolutionsCMB.Location = new System.Drawing.Point(358, 92);
            this.ResolutionsCMB.Name = "ResolutionsCMB";
            this.ResolutionsCMB.Size = new System.Drawing.Size(200, 31);
            this.ResolutionsCMB.TabIndex = 4;
            this.ResolutionsCMB.SelectedIndexChanged += new System.EventHandler(this.ResolutionsCMB_SelectedIndexChanged);
            // 
            // VideoTitleLabel
            // 
            this.VideoTitleLabel.AutoSize = true;
            this.VideoTitleLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoTitleLabel.Location = new System.Drawing.Point(354, 24);
            this.VideoTitleLabel.MaximumSize = new System.Drawing.Size(380, 0);
            this.VideoTitleLabel.Name = "VideoTitleLabel";
            this.VideoTitleLabel.Size = new System.Drawing.Size(42, 23);
            this.VideoTitleLabel.TabIndex = 3;
            this.VideoTitleLabel.Text = "Title";
            // 
            // VideoResolutionsLabel
            // 
            this.VideoResolutionsLabel.AutoSize = true;
            this.VideoResolutionsLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoResolutionsLabel.Location = new System.Drawing.Point(234, 92);
            this.VideoResolutionsLabel.Name = "VideoResolutionsLabel";
            this.VideoResolutionsLabel.Size = new System.Drawing.Size(101, 23);
            this.VideoResolutionsLabel.TabIndex = 2;
            this.VideoResolutionsLabel.Text = "Resolutions";
            // 
            // VideoTitle
            // 
            this.VideoTitle.AutoSize = true;
            this.VideoTitle.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoTitle.Location = new System.Drawing.Point(234, 24);
            this.VideoTitle.Name = "VideoTitle";
            this.VideoTitle.Size = new System.Drawing.Size(97, 23);
            this.VideoTitle.TabIndex = 1;
            this.VideoTitle.Text = "Video Title";
            // 
            // VideoThumbnailPB
            // 
            this.VideoThumbnailPB.Location = new System.Drawing.Point(12, 12);
            this.VideoThumbnailPB.Name = "VideoThumbnailPB";
            this.VideoThumbnailPB.Size = new System.Drawing.Size(200, 125);
            this.VideoThumbnailPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VideoThumbnailPB.TabIndex = 0;
            this.VideoThumbnailPB.TabStop = false;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ControlPanel.Controls.Add(this.LoadingPB);
            this.ControlPanel.Controls.Add(this.SettingsBtn);
            this.ControlPanel.Controls.Add(this.DownloadBtn);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 270);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(800, 60);
            this.ControlPanel.TabIndex = 3;
            // 
            // LoadingPB
            // 
            this.LoadingPB.Image = global::Youtube_Video_Downloader.Properties.Resources.loading;
            this.LoadingPB.Location = new System.Drawing.Point(707, 5);
            this.LoadingPB.Name = "LoadingPB";
            this.LoadingPB.Size = new System.Drawing.Size(50, 50);
            this.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingPB.TabIndex = 5;
            this.LoadingPB.TabStop = false;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.SettingsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SettingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsBtn.IconSize = 50;
            this.SettingsBtn.Location = new System.Drawing.Point(12, 5);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.SettingsBtn.Size = new System.Drawing.Size(50, 50);
            this.SettingsBtn.TabIndex = 4;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.FlatAppearance.BorderSize = 0;
            this.DownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadBtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.DownloadBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DownloadBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DownloadBtn.IconSize = 50;
            this.DownloadBtn.Location = new System.Drawing.Point(637, 5);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.DownloadBtn.Size = new System.Drawing.Size(50, 50);
            this.DownloadBtn.TabIndex = 3;
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SettingsPanel.Controls.Add(this.DestinationLabel);
            this.SettingsPanel.Controls.Add(this.SaveToLabel);
            this.SettingsPanel.Controls.Add(this.ChooseDestinationBtn);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 330);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(800, 120);
            this.SettingsPanel.TabIndex = 4;
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.Location = new System.Drawing.Point(151, 37);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(117, 20);
            this.DestinationLabel.TabIndex = 7;
            this.DestinationLabel.Text = "destination path";
            this.DestinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveToLabel
            // 
            this.SaveToLabel.AutoSize = true;
            this.SaveToLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToLabel.Location = new System.Drawing.Point(69, 35);
            this.SaveToLabel.Name = "SaveToLabel";
            this.SaveToLabel.Size = new System.Drawing.Size(74, 23);
            this.SaveToLabel.TabIndex = 6;
            this.SaveToLabel.Text = "Save to:";
            this.SaveToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseDestinationBtn
            // 
            this.ChooseDestinationBtn.FlatAppearance.BorderSize = 0;
            this.ChooseDestinationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseDestinationBtn.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.ChooseDestinationBtn.IconColor = System.Drawing.Color.Goldenrod;
            this.ChooseDestinationBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ChooseDestinationBtn.IconSize = 50;
            this.ChooseDestinationBtn.Location = new System.Drawing.Point(13, 23);
            this.ChooseDestinationBtn.Name = "ChooseDestinationBtn";
            this.ChooseDestinationBtn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ChooseDestinationBtn.Size = new System.Drawing.Size(50, 50);
            this.ChooseDestinationBtn.TabIndex = 5;
            this.ChooseDestinationBtn.UseVisualStyleBackColor = true;
            this.ChooseDestinationBtn.Click += new System.EventHandler(this.ChooseDestinationBtn_Click);
            // 
            // FetchVideoDetailsBGW
            // 
            this.FetchVideoDetailsBGW.WorkerReportsProgress = true;
            this.FetchVideoDetailsBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FetchVideoDetailsBGW_DoWork);
            this.FetchVideoDetailsBGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.FetchVideoDetailsBGW_ProgressChanged);
            // 
            // DownloadVideoBGW
            // 
            this.DownloadVideoBGW.WorkerReportsProgress = true;
            this.DownloadVideoBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownloadVideoBGW_DoWork);
            this.DownloadVideoBGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DownloadVideoBGW_ProgressChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.VideoDetailsPanel);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Video Downloader";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPB)).EndInit();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.VideoDetailsPanel.ResumeLayout(false);
            this.VideoDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoThumbnailPB)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPB)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Panel VideoDetailsPanel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel SettingsPanel;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private FontAwesome.Sharp.IconButton MinimizeBtn;
        private FontAwesome.Sharp.IconButton AboutBtn;
        private System.Windows.Forms.PictureBox AppLogoPB;
        private System.Windows.Forms.Label AppLogoLabel;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.TextBox UrlTB;
        private System.Windows.Forms.PictureBox VideoThumbnailPB;
        private System.Windows.Forms.Label VideoTitleLabel;
        private System.Windows.Forms.Label VideoResolutionsLabel;
        private System.Windows.Forms.Label VideoTitle;
        private System.Windows.Forms.ComboBox ResolutionsCMB;
        private FontAwesome.Sharp.IconButton SettingsBtn;
        private FontAwesome.Sharp.IconButton DownloadBtn;
        private System.Windows.Forms.PictureBox LoadingPB;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label SaveToLabel;
        private FontAwesome.Sharp.IconButton ChooseDestinationBtn;
        private System.Windows.Forms.Label UrlStatusLabel;
        private System.ComponentModel.BackgroundWorker FetchVideoDetailsBGW;
        private System.ComponentModel.BackgroundWorker DownloadVideoBGW;
    }
}

