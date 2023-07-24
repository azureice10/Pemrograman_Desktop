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
        private readonly movieEntities _movieEntities;
        public Form1()
        {
            InitializeComponent();
            _movieEntities = new movieEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var movieRecord = _movieEntities.tblMovies.ToList();
            dataGridView1.DataSource = movieRecord;

            comboBox1.DataSource = movieRecord;
            comboBox1.DisplayMember = "id";
            comboBox1.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newRecord = new tblMovie()
            {
                title = "judul baru",
                genre = "genre baru"
            };
            _movieEntities.tblMovies.Add(newRecord);
            _movieEntities.SaveChanges();
            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var idtoDelete = 1;
            var deleteRecord = _movieEntities.tblMovies.FirstOrDefault(q => q.id == idtoDelete);
            if (deleteRecord != null)
            {
                _movieEntities.tblMovies.Remove(deleteRecord);
                _movieEntities.SaveChanges();
                loadData();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var idtoUpdate = 2;
            var updateRecord = _movieEntities.tblMovies.FirstOrDefault(q => q.id == idtoUpdate);
            if (updateRecord != null)
            {
                updateRecord.title = "judul baru";
                updateRecord.genre = "genre baru";
                _movieEntities.SaveChanges();
                loadData();
            }
        }
    }
}
