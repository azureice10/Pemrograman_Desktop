using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Order
    {
        public Guid Id { get; set; } 
        public string Item { get; set; } = string.Empty;
        public int Jumlah { get; set; }

        public string email { get; set; } = string.Empty;

        public DateTime Waktu { get; set; }
    }
}
