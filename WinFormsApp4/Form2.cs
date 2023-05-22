
namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        private string username;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label1.ForeColor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // direktori asal
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            // memfilter ekstensi file
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // label1.Text = openFileDialog1.FileName;
                /*  foreach (var file in openFileDialog1.SafeFileNames)
                  {
                      listBox1.Items.Add(file);
                  }
                */
                string content = File.ReadAllText(openFileDialog1.FileName);
                textBox1.Text = content;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save text Files";
            // jika tidak ada tdk dpt disimpan
            // saveFileDialog1.CheckFileExists = true;
            // saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = saveFileDialog1.FileName;
                string content = textBox1.Text;
                File.WriteAllText(saveFileDialog1.FileName, content);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = "Selamat Datang: " + username;
        }
    }
}
