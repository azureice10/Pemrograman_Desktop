using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FormLogin : Form
    {
        private List<User> _userlist = new();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pass = textBox2.Text;

            var result = _userlist.FirstOrDefault(x => x.Username == uname);
            if (result != null)
            {
                if (result.Password == pass)
                {
                    MessageBox.Show("Berhasil", "Selamat Datang", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 form2 = new(result.Username);
                    this.Hide();
                    form2.Show();
                    form2.Closed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Password Salah!", "Eror!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User tidak ditemukan!", "Eror!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            _userlist.Add(new User("admin", "pass", "admin"));
            _userlist.Add(new User("test", "1234", "user"));
        }
    }
}
