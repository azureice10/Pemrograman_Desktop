using CsvHelper;
using CsvHelper.Configuration;
using QRCoder;
using System.Globalization;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,

            };
            var records = new List<Pelanggan>
            {
                new Pelanggan { Id = 1, Nama = "Nama", Alamat= "Jakarta" },
            };

            using var writer = new StreamWriter("file.csv", append: true);
            using var csv = new CsvWriter(writer, config);
            csv.WriteRecords(records);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using var reader = new StreamReader("file.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<Pelanggan>();
            dataGridView1.DataSource = records.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenerator = new();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://poltekssn.ac.id/", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pictureBox1.Image = qrCodeImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime waktu1 = DateTime.Now;
            var guid = Guid.NewGuid();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,

            };
            var records = new List<Order>
            {
                
                new Order {Id=guid, Item = comboBox1.Text, Jumlah = Convert.ToInt16(numericUpDown1.Value), email= textBox1.Text, Waktu=waktu1 },
            };

            using var writer = new StreamWriter("order.csv", append:true);
            using var csv = new CsvWriter(writer, config);
            csv.WriteRecords(records);

            QRCodeGenerator qrGenerator = new();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(guid.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pictureBox1.Image = qrCodeImage;
        }
    }
}