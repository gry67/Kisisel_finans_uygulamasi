using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisisel_finans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kullanici> klist = new List<Kullanici>();
            string oturumAcanKullanici = "";

            if (klist.Count()==0) 
            {
                Console.WriteLine("listede hiçbir kullanıcı yok. Kullanıcı oluşturalım.");
                Console.WriteLine("Yeni Kullanici epostası giriniz");
                string eposta=Console.ReadLine();
                Console.WriteLine("Yeni kullanici sifresi giriniz");
                string sifre=Console.ReadLine();
                Kullanici kullanici=new Kullanici(eposta, sifre);
                klist.Add(kullanici);
                oturumAcanKullanici = eposta;
            }
            else
            {
                byte sayac = 0;
                while (sayac!=1)
                {
                    Console.WriteLine("Kullanıcı eposta gir: ");
                    string kadi = Console.ReadLine();
                    Console.WriteLine("Kullanici sifresi gir: ");
                    string sifre = Console.ReadLine();
                    foreach (Kullanici k in klist)
                    {
                        if (k.eposta == kadi && k.sifre == sifre)
                        {
                            Console.WriteLine($"Hoşgeldiniz {kadi}");
                            oturumAcanKullanici=k.eposta;
                            sayac=1;
                            break;
                        }
                        else { Console.WriteLine("kullanici bulunamadı. Tekrar dene\n"); }
                    }
                }
            }
            
            byte dongu = 0;
            while (dongu != 1)
            {
                Console.WriteLine($"\nMerhaba {oturumAcanKullanici}. Ne yapmak istersiniz ? \n 1. Yeni Hesap Oluştur\n2.Harcama Ekle\n3.Harcamaları Göster\n4.Uygulamayı kapat");
                byte istek = Convert.ToByte(Console.ReadLine());

                switch (istek)
                {
                    case 1:
                        Console.WriteLine("Sizin için bir kullanıcı oluşturalım");
                        Console.WriteLine("e-posta giriniz...");
                        string post = Console.ReadLine();
                        Console.WriteLine("sifre giriniz...");
                        string sifr = Console.ReadLine();
                        Kullanici yenihesap = new Kullanici(post, sifr);
                        klist.Add(yenihesap);
                        break;
                   
                    case 2:
                        Console.WriteLine("harcama Adı nedir");
                        string hisim= Console.ReadLine();
                        Console.WriteLine("harcama tutari kaç ?");
                        double htutar = Convert.ToDouble(Console.ReadLine());
                        DateTime hzamani = DateTime.Now;
                        HesapDefteri yeniHarcama = new HesapDefteri(hisim,htutar,hzamani);
                        foreach (Kullanici k in klist)
                        {
                            if (oturumAcanKullanici!=""&& k.eposta==oturumAcanKullanici)
                            {
                                k.harcamalar.Add(yeniHarcama);
                                Console.WriteLine("harcama başarıyla eklendi.");
                                break;
                            }
                        }
                        break;
                        case 3:
                        Console.WriteLine(oturumAcanKullanici);
                        foreach (Kullanici k in klist)
                        {
                            if (k.eposta==oturumAcanKullanici)
                            {
                                foreach (HesapDefteri harcamalar in k.harcamalar)
                                {
                                    Console.WriteLine(" "+harcamalar+"\n");
                                }
                            }
                        }break;

                    case 4:
                        dongu = 1;
                        break;
                    default:
                        Console.WriteLine("anlasilamadi. Luften gecerli sayi girin...");
                        break;
                }
            }
            Console.WriteLine("çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
