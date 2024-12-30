using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KutuphaneYonetimSistemiUygulama
{
    internal class Uye : Kullanici
    {
        public List<Kitap> OduncAlinanKitaplar = new List<Kitap>();
        public Uye(int id, string isim) : base(id, isim) { }

        public void kitapOduncAl(Kitap kitap)
        {
            if (kitap.stokAzalt())
            {
                OduncAlinanKitaplar.Add(kitap);
                Console.WriteLine(kitap.isim + " kitabı ödünç alındı.");
            }
            else
            {
                Console.WriteLine(kitap.isim + " kitabı stokta yok");
            }
        }

        public void KitapIadeEt(Kitap kitap)
        {
            if (OduncAlinanKitaplar.Contains(kitap))
            {
                OduncAlinanKitaplar.Remove(kitap);
                kitap.stokEkle(1);
                Console.WriteLine(kitap.isim + " kitabı iade edildi.");
            }
            else
            {
                Console.WriteLine(kitap.isim + " kitabı ödünç alınmamış.");
            }
        }
        

    }
}
