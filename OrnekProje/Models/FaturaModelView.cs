using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Models
{
    public class FaturaModelView
    {
        public AlinanUrun[] alinanUruns { get; set; }
        public Musteri musteri { get; set; }
        public Fatura fatura { get; set; }
        public string ad { get; set; }
    }
}
