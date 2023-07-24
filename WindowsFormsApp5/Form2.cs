using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        private readonly movieEntities _movieEntities;

        public Form2()
        {
            InitializeComponent();
            _movieEntities = new movieEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vEmail = textBox1.Text;
            string vPass = textBox2.Text;
            string vPhone = textBox3.Text;
            var newRecord = new tblUser()
            {
                email = vEmail,
                password = vPass,
                phone = vPhone
            };
            _movieEntities.tblUsers.Add(newRecord);
            _movieEntities.SaveChanges();
        }
    }
}
