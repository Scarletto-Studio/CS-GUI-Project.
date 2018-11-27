using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using System.IO;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select Path" })
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                var youtubes = YouTube.Default;
                var video = await youtubes.GetVideoAsync(UrlBox.Text);
                StatusLabel.Text = "Downloading..";
                File.WriteAllBytes(fbd.SelectedPath + video.FullName, await video.GetBytesAsync());
                StatusLabel.Text = "Download Complete!";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
