using Konscious.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private readonly movieEntities _movieEntities;

        public Form1()
        {
            InitializeComponent();
            _movieEntities = new movieEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pass = textBox2.Text;

            var userRecord = _movieEntities.tblUsers.ToList();
            var loggedInUser = userRecord.FirstOrDefault(user => user.email == uname && user.password == pass);
            if (loggedInUser != null)
            {
                MessageBox.Show("Berhasil");
            }
            else
            {
                MessageBox.Show("Gagal");
            }

            // hashing(uname, pass);

        }

        private static string hashing(string uname, string pass)
        {
            byte[] salt = Encoding.ASCII.GetBytes("rahasia");
            byte[] userUuidBytes = Encoding.ASCII.GetBytes(uname);

            byte[] password = Encoding.ASCII.GetBytes(pass);
            var argon2 = new Argon2i(password)
            {
                DegreeOfParallelism = 16,
                MemorySize = 8192,
                Iterations = 40,
                Salt = salt,
                AssociatedData = userUuidBytes
            };
            var hash = argon2.GetBytes(128);
            string hashedValue = Encoding.ASCII.GetString(hash);
            return hashedValue;
        }
    }
}
