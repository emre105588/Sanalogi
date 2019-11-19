using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Models
{
    public class AlinanUrun
    {
        public int alinanUrunId { get; set; }
        [Required(ErrorMessage = "Lütfen Ürün Adını Giriniz.")]
        public string urunAdi { get; set; }
        [Required(ErrorMessage = "Lütfen Adeti Giriniz.")]
        public int adet { get; set; }
        [Required(ErrorMessage = "Lütfen Birim Fiyatı Giriniz.")]
        public decimal birimFiyat { get; set; }
        [Required(ErrorMessage = "Lütfen Toplam Fiyatı Giriniz.")]
        public decimal toplam { get; set; }
        public virtual Musteri musteri { get; set; }
        public virtual Fatura fatura{ get; set; }
    }
}
