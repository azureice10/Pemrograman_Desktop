using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void menu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test Menu 2");
        }

        private void menu1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test Menu Strip");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click Me!";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void toolStripComboBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
