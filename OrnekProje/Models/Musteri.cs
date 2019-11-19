using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Models
{
    public class Musteri
    {
        public int musteriId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string adres { get; set; }
        public string eposta { get; set; }
        public long telefon { get; set; }
    }
}
