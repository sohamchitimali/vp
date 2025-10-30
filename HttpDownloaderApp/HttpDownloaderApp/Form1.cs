using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpDownloaderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string url = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a URL.");
                return;
            }

            
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
