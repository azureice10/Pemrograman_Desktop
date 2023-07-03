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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        readonly string connectionString = "Server=localhost;Database=test;Uid=root;Pwd=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    RefreshGrid(connection);

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

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Person newUser = new Person
                    {
                        name = textBox1.Text,
                        email = textBox2.Text,
                        password = textBox3.Text
                    };

                    string query = "INSERT INTO person (name, email, password) VALUES (@name, @email, @password)";
                    int rowsAffected = connection.Execute(query, newUser);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New user record added successfully!");
                        RefreshGrid(connection);
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

        private void RefreshGrid(MySqlConnection connection)
        {
            string query2 = "SELECT * FROM person";
            List<Person> userList = connection.Query<Person>(query2).ToList();
            dataGridView1.DataSource = userList;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int userIdToDelete = Convert.ToInt32(textBox4.Text);


                    string query = "DELETE FROM person WHERE Id = @UserId";
                    int rowsAffected = connection.Execute(query, new { UserId = userIdToDelete });

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"User ID:{userIdToDelete} deleted successfully!");
                        RefreshGrid(connection);
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

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int userIdToUpdate = Convert.ToInt32(textBox4.Text);

                    string selectQuery = "SELECT * FROM person WHERE id = @UserId";
                    Person existingUser = connection.QuerySingleOrDefault<Person>(selectQuery, new { UserId = userIdToUpdate });

                    if (existingUser != null)
                    {
                        // Update the properties of the existing user record
                        existingUser.name = textBox1.Text;
                        existingUser.email = textBox2.Text;
                        existingUser.password = textBox3.Text;

                        string updateQuery = "UPDATE person SET name = @name, email = @email, Password = @password WHERE Id = @UserId";
                        int rowsAffected = connection.Execute(updateQuery, existingUser);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"User ID:{userIdToUpdate} updated successfully!");
                            RefreshGrid(connection);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No user record found to update!");
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected User object from the DataGridView's DataBoundItem property
                Person selectedUser = dataGridView1.SelectedRows[0].DataBoundItem as Person;

                // Display the selected User object's value in the TextBox
                if (selectedUser != null)
                {
                    textBox4.Text = selectedUser.id.ToString();
                    textBox1.Text = selectedUser.name;
                    textBox2.Text = selectedUser.email;
                    textBox3.Text = selectedUser.password;

                }
            }
        }
    }
}
