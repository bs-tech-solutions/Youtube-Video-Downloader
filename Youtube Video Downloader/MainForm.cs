using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using VideoLibrary;
using Youtube_Video_Downloader.Forms;

namespace Youtube_Video_Downloader
{    
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private bool mouseDown;
        private Point lastLocation;

        private bool openSettings = false;
        private static string link;

        private static string appPath = "\\Youtube Video Downloder\\Downloads\\";
        private static string destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + appPath;


        private YouTubeVideo video;
        private YouTube youtube = YouTube.Default;
        private IEnumerable<YouTubeVideo> videos;

        public MainForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));

            UrlStatusLabel.Text = "";
            VideoTitleLabel.Text = "";
            LoadingPB.Visible = false;
            DownloadBtn.Enabled = false;

            OpenSettingsPanel();

            DestinationLabel.Text = destinationPath;
            Directory.CreateDirectory(destinationPath);

            UrlTB.GotFocus += UrlTB_GotFocus;
        }

        private void UrlTB_GotFocus(object sender, EventArgs e)
        {
            link = Clipboard.GetText();            
            startFetchingVideo();
        }

        public static bool validateURL(string link)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
                request.Method = "HEAD";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return response.ResponseUri.ToString().Contains("youtube.com") ? true : false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void startFetchingVideo()
        {
            if (!validateURL(link))
            {
                UrlStatusLabel.ForeColor = Color.Red;
                UrlStatusLabel.Text = "Copy URL from Youtube!!!";
                return;
            }
            UrlTB.Text = link;
            UrlStatusLabel.Text = "";
            if (!FetchVideoDetailsBGW.IsBusy)
                FetchVideoDetailsBGW.RunWorkerAsync();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            openSettings = !openSettings;
            OpenSettingsPanel();
        }

        private void OpenSettingsPanel()
        {
            if (openSettings)
            {
                SettingsPanel.Visible = true;
                this.Width = 800;
                this.Height = this.Height + SettingsPanel.Height;
            }
            else
            {
                SettingsPanel.Visible = false;
                this.Width = 800;
                this.Height = this.Height - SettingsPanel.Height;
            }
        }

        public void updateVideoDetails()
        {
            var uri = new Uri(link);
            var query = HttpUtility.ParseQueryString(uri.Query);
            var videoId = string.Empty;
            if (query.AllKeys.Contains("v"))
                videoId = query["v"];
            else
                videoId = uri.Segments.Last();
            WebClient webClient = new WebClient();
            var thumbNailLink = string.Format("http://img.youtube.com/vi/{0}/hq720.jpg", videoId);
            var imgBytes = webClient.DownloadData(thumbNailLink);
            MemoryStream ms = new MemoryStream(imgBytes);
            VideoThumbnailPB.Image = Image.FromStream(ms);
        }

        private void FetchVideoDetailsBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            updateVideoDetails();
            videos = youtube.GetAllVideos(link);
            videos = videos.Where(r =>
                r.AdaptiveKind == AdaptiveKind.Video &&
                (r.AudioFormat == AudioFormat.Mp3 || r.AudioFormat == AudioFormat.Aac)
            ).Select(r => r);
            foreach (var item in videos.ToList())
            {
                var option = $"{item.Format}, {item.Resolution}p, {item.Fps} fps, {item.AudioFormat}";
                if (!ResolutionsCMB.Items.Contains(option))
                {
                    ResolutionsCMB.Invoke((MethodInvoker)(() => ResolutionsCMB.Items.Add(option)));
                }
            }
            if (ResolutionsCMB.Items.Count > 0)
            {
                ResolutionsCMB.Invoke((MethodInvoker)(() => ResolutionsCMB.Sorted = true));
                ResolutionsCMB.Invoke((MethodInvoker)(() => ResolutionsCMB.SelectedIndex = 0));
                ResolutionsCMB.Invoke((MethodInvoker)(() =>
                    video = videos.Where(r =>
                        $"{r.Format}, {r.Resolution}p, {r.Fps} fps, {r.AudioFormat}" == ResolutionsCMB.SelectedItem.ToString()
                    ).Select(r => r).ToList()[0]
                ));
            }
            VideoTitleLabel.Invoke((MethodInvoker)(() => VideoTitleLabel.Text = video.FullName));
            FetchVideoDetailsBGW.ReportProgress(1);
        }

        private void FetchVideoDetailsBGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            DownloadBtn.Enabled = true;
        }

        private void ChooseDestinationBtn_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    destinationPath = dialog.SelectedPath + "\\";
                    DestinationLabel.Text = destinationPath;
                }

            }
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            LoadingPB.Visible = true;
            if (!DownloadVideoBGW.IsBusy)
                DownloadVideoBGW.RunWorkerAsync();
        }

        private void DownloadVideoBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            var bytes = video.GetBytes();
            File.WriteAllBytes(destinationPath + video.FullName, bytes);
            DownloadVideoBGW.ReportProgress(1);
        }

        private void DownloadVideoBGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MessageBox.Show("Video downloaded successfully..");
            LoadingPB.Visible = false;
        }

        private void ResolutionsCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            video = videos.Where(r =>
                        $"{r.Format}, {r.Resolution}p, {r.Fps} fps, {r.AudioFormat}" == ResolutionsCMB.SelectedItem.ToString()
                    ).Select(r => r).ToList()[0];
        }
    }
}
