using Newtonsoft.Json;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private List<Costumer> userData;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using HttpClient client = new();
            string json = await client.GetStringAsync("https://retoolapi.dev/VFa5wi/data");
            userData = JsonConvert.DeserializeObject<List<Costumer>>(json);
            dataGridView1.DataSource = userData;
        }
    }
}