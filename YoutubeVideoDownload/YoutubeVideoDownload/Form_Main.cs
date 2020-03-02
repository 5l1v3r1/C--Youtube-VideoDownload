using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace YoutubeVideoDownload
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }





        string FilterFormat = "mp4";
        string filterKalite = "1080";


        private async void button_Download_Click(object sender, EventArgs e)
        {
            

            listBox_Videolar.Items.Clear();


            

            var youtube = YouTube.Default;
            var videos = await youtube.GetAllVideosAsync(textBox_URL.Text);

            label_Durum.Text = "Video bilgisi çekiliyor";
            foreach (var video in videos)
            {
                string vAdi = video.Title;
                int vKalite = video.Resolution;
                var vFormat = video.Format;

                string SesDosya = "Ses [" + vKalite.ToString() + "] - " + vAdi;
                string VideoDosya = "Video [" + vKalite.ToString() + "] - " + video.FullName;

                if (FilterFormat.ToLower() == vFormat.ToString().ToLower() 
                    && vKalite != -1
                    && filterKalite.ToLower() == vKalite.ToString().ToLower())

                {

                    string cikti = string.Format("{0} - {1}, {2}", vKalite.ToString(), vKalite.ToString(), vFormat);
                    listBox_Videolar.Items.Add(cikti);

                    // Ses indir
                    SesIndir(SesDosya);

                    // Video indir
                    var client = new HttpClient();
                    long? totalByte = 0;
                    using (Stream output = File.OpenWrite(Application.StartupPath + @"/Downloads/" + VideoDosya))
                    {
                        using (var request = new HttpRequestMessage(HttpMethod.Head, video.Uri))
                        {
                            totalByte = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result.Content.Headers.ContentLength;

                        }
                        using (var input = await client.GetStreamAsync(video.Uri))
                        {
                            byte[] buffer = new byte[16 * 1024];
                            int read;
                            int totalRead = 0;
                            label_Durum.Text = "İndirme başladı";
                            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                output.Write(buffer, 0, read);
                                totalRead += read;
                            }
                            label_Durum.Text = "İndirme bitti";
                        }
                    }

                }
            }

            label_Durum.Text = "Video bilgisi çekildi";
        }



        private async void SesIndir(string ad)
        {
            var youtube = YouTube.Default;
            var video = await youtube.GetAllVideosAsync(textBox_URL.Text);
            var audio = video
            .Where(e => e.AudioFormat == AudioFormat.Aac && e.AdaptiveKind == AdaptiveKind.Audio)
            .ToList();

            string path = Application.StartupPath + @"/Downloads/";
            string fileAAC = ad + ".aac";

            string file = path + fileAAC;
            if (audio.Count > 0)
            {
                byte[] bytes = audio[0].GetBytes();
                File.WriteAllBytes(file, bytes);
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            
        }
    }
}
