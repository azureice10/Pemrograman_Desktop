using System.Drawing.Printing;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = new();
            // papersize 
            pageSetupDialog1.PageSettings.PaperSize = new PaperSize("A4", width: 400, height: 300);
            pageSetupDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox2.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(10, 10));
            e.Graphics.DrawString(numericUpDown1.Value.ToString(), new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(10, 40));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewControl1.Document = printDocument1;
        }
    }
}