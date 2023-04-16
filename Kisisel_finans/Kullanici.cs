using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisisel_finans
{
    internal class Kullanici
    {
        private string Eposta { get; set; }
        private string Sifre { get; set; }
        private HesapDefteri _hesapDefteri { get; set; }
        public List<HesapDefteri> harcamalar { get; set; }

        public string eposta 
        {
            get { return Eposta; }
            set { Eposta = value; }
        }
        public string sifre 
        {
            get { return Sifre; }
            set { Sifre = value; }
        }
        public HesapDefteri HesapDefteri
        {
            get { return _hesapDefteri; }
            set { _hesapDefteri = value; }
        }


        public Kullanici(string ePosta, string Sifre) 
        { 
           eposta = ePosta;
            sifre = Sifre;
            harcamalar = new List<HesapDefteri>();
        }
        public override string ToString()
        {
            return $"Kullanıcı adı: {eposta}, Şifre: {sifre}";
        }
    }
}
