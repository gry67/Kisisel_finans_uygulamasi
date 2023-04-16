using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kisisel_finans
{
    internal class HesapDefteri
    {
        public string harcamaAdi { get; set; }
        public double harcamaTutari { get; set; }
        public DateTime harcamaTarihi { get ; set ; }
        public HesapDefteri(string HarcamaAdi, double HarcamaTutari, DateTime HarcamaTarihi)
        {
            harcamaAdi = HarcamaAdi;
            harcamaTutari = HarcamaTutari;
            harcamaTarihi = HarcamaTarihi;
        }
        public override string ToString()
        {
            return "Harcama Adı: " + harcamaAdi + "Harcama Tutarı: " + harcamaTutari + "Harcama Tarihi: " + harcamaTarihi;
        }
    }
}
