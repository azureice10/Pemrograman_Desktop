namespace WinFormsApp2

{
    using System.Diagnostics;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selamat Datang!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // checkBox1.Checked = true;

            //foreach (var item in checkedListBox1.CheckedItems)
            //{
            //    MessageBox.Show(item.ToString());
            //}

            MessageBox.Show(numericUpDown1.Value.ToString());
            label1.Text = "New";

            if (radioButton1.Checked == true)
            {
                MessageBox.Show(radioButton1.Text);
            }
            else
            {
                MessageBox.Show("Wanita");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Click ME!");
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "http://google.com",
                UseShellExecute = true
            });
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            if (progressBar1.Value == 100)
            {
                MessageBox.Show("Finish!");
            }
        }

    }
}