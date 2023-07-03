using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp7
{
    public partial class FormLogin : Form
    {
        List<User> users = new();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uName = textBox1.Text;
            string Pass = textBox2.Text;

            User user = users.FirstOrDefault(u => u.Email == uName && u.Password == Pass);

            if (user != null)
            {
                MessageBox.Show("Selamat datang ");
            }
            else
            {
                MessageBox.Show("Login Gagal!");
            }

        }

        private async void FormLogin_Load(object sender, EventArgs e)
        {
            using HttpClient client = new();
            string json = await client.GetStringAsync("https://retoolapi.dev/XS32pF/userdata");
            users = JsonConvert.DeserializeObject<List<User>>(json);
        }
    }
}
