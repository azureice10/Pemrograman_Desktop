using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp3
{
    public partial class FormLogin : Form
    {
        readonly string connectionString = "Server=localhost;Database=test;Uid=root;Pwd=;";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string uname = textBox1.Text;
                string pass  = textBox2.Text;    
                try
                {
                    connection.Open();
                    var users = connection.Query<Person>("SELECT * FROM person WHERE email = @uname AND password = @pass",
                        new { uname, pass });

                    if (users.Any())
                    {
                        MessageBox.Show("Login successful!");
                        this.Hide();
                        Form1 mainForm = new Form1();
                        mainForm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }

                }
                catch (MySqlException Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
