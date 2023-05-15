
using System.ComponentModel;
using System.Diagnostics;

namespace WinFormsApp3
{
    public partial class Form4 : Form
    {
        int imgNum = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length != 4)
            {
                errorProvider1.SetError(textBox1, "Harus 4 digit!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("File baru dibuat!");
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            MessageBox.Show("File telah direname!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[2];
            //Process.Start("notepad");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[imgNum];
            if (imgNum == 2)
            {
                imgNum = 0;
            }
            else  
            {
                imgNum++;
            }
        }
    }
}
