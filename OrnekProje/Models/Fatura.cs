using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Models
{
    public class Fatura
    {
        public int faturaId { get; set; }
        public DateTime faturaTarihi { get; set; }
        public decimal genelToplam { get; set; }
        public string faturaNo { get; set; }
    }
}
