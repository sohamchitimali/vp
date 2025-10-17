using System;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HttpDownloaderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            string url = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a URL.");
                return;
            }

            // Save to Documents folder
            string localPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\downloaded_file.txt";

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, localPath);
                }

                MessageBox.Show($" File downloaded successfully to:\n{localPath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error: " + ex.Message);
            }


        }
    }
}