using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisisel_finans
{
    internal interface IKullanici
    {
       string ePosta { get; set; }
       string sifre { get; set;}
       List<HesapDefteri> Defterlist { get; set; }
    }
}
