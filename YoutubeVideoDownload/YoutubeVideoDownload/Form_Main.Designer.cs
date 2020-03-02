namespace YoutubeVideoDownload
{
    partial class Form_Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Download = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.label_Durum = new System.Windows.Forms.Label();
            this.progressBar_Down = new System.Windows.Forms.ProgressBar();
            this.listBox_Videolar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Download
            // 
            this.button_Download.Location = new System.Drawing.Point(300, 34);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(75, 23);
            this.button_Download.TabIndex = 0;
            this.button_Download.Text = "Video Bilgisi";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video Link";
            // 
            // textBox_URL
            // 
            this.textBox_URL.Location = new System.Drawing.Point(31, 36);
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.Size = new System.Drawing.Size(263, 20);
            this.textBox_URL.TabIndex = 2;
            this.textBox_URL.Text = "https://www.youtube.com/watch?v=Eo_nV-Yrg0s";
            // 
            // label_Durum
            // 
            this.label_Durum.Location = new System.Drawing.Point(28, 72);
            this.label_Durum.Name = "label_Durum";
            this.label_Durum.Size = new System.Drawing.Size(347, 39);
            this.label_Durum.TabIndex = 3;
            this.label_Durum.Text = "Bekleniyor..";
            // 
            // progressBar_Down
            // 
            this.progressBar_Down.Location = new System.Drawing.Point(31, 114);
            this.progressBar_Down.Name = "progressBar_Down";
            this.progressBar_Down.Size = new System.Drawing.Size(344, 23);
            this.progressBar_Down.TabIndex = 4;
            // 
            // listBox_Videolar
            // 
            this.listBox_Videolar.FormattingEnabled = true;
            this.listBox_Videolar.Location = new System.Drawing.Point(31, 143);
            this.listBox_Videolar.Name = "listBox_Videolar";
            this.listBox_Videolar.Size = new System.Drawing.Size(344, 199);
            this.listBox_Videolar.TabIndex = 5;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 420);
            this.Controls.Add(this.listBox_Videolar);
            this.Controls.Add(this.progressBar_Down);
            this.Controls.Add(this.label_Durum);
            this.Controls.Add(this.textBox_URL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Download);
            this.Name = "Form_Main";
            this.Text = "Youtube Video Download";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_URL;
        private System.Windows.Forms.Label label_Durum;
        private System.Windows.Forms.ProgressBar progressBar_Down;
        private System.Windows.Forms.ListBox listBox_Videolar;
    }
}

