using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KutuphaneYonetimSistemiUygulama
{
    internal class Kutuphane
    {
        public List<Kitap> Kitaplar = new List<Kitap>();
        public List<Uye> Uyeler = new List<Uye>();

        public void kitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
            Console.WriteLine(kitap.isim + " kitabı kütüphaneye eklendi.");
        }

        public void kitaplariListele()
        {
            Console.WriteLine("Kütüphanedeki kitaplar : ");
            foreach(var kitap in Kitaplar)
            {
                Console.WriteLine(kitap);
            }
        }

        public void kitapGuncelle(string eskiIsim)
        {
            var kitap = Kitaplar.Find(k=>k.isim.Equals(eskiIsim, StringComparison.OrdinalIgnoreCase));
            if(kitap != null)
            {
                Console.Write("Yeni kitap ismi : ");
                kitap.isim = Console.ReadLine();
                Console.Write("Yeni yazar : ");
                kitap.yazar = Console.ReadLine();
                Console.Write("Yeni kategori : ");
                kitap.kategori = Console.ReadLine();
                Console.Write("Yeni stok : ");
                kitap.stok = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(eskiIsim + " kitabı başarıyla güncellendi.");

            }
            else
            {
                Console.WriteLine(eskiIsim + " isimli kitap bulunamadı.");
            }
        }

        public void uyeEkle(Uye uye)
        {
            Uyeler.Add(uye);
            Console.WriteLine(uye.isim + " adlı üye kütüphaneye eklendi.");
        }

        public void uyeSil(int id)
        {
            var uye = Uyeler.Find(u => u.id == id);
            if(uye != null)
            {
                Uyeler.Remove(uye);
                Console.WriteLine("ID : " + uye.id + " olan üye silindi.");
            }
            else
            {
                Console.WriteLine("ID : " + uye.id + " olan üye silindi.");
            }
        }

        public void uyeleriListele()
        {
            Console.WriteLine("Kütüphane üyeleri : ");
            foreach(var uye in Uyeler)
            {
                Console.WriteLine(uye);
            }
        }

        public void kitapOduncVer(int uyeId,string kitapIsmi)
        {
            var uye = Uyeler.Find(u => u.id == uyeId);
            if(uye == null)
            {
                Console.WriteLine("Üye bulunamadı.");
                return;
            }

            var kitap = Kitaplar.Find(k=>k.isim.Equals(kitapIsmi, StringComparison.OrdinalIgnoreCase)); 
            if(kitap == null)
            {
                Console.WriteLine("Kitap bulunamadı.");
                return;
            }
        }

        public void KitapIadeEt(int uyeId, string kitapIsmi)
        {
            var uye = Uyeler.Find(u => u.id == uyeId);
            if (uye == null)
            {
                Console.WriteLine("Üye bulunamadı.");
                return;
            }

            var kitap = Kitaplar.Find(k => k.isim.Equals(kitapIsmi, StringComparison.OrdinalIgnoreCase));
            if (kitap == null)
            {
                Console.WriteLine("Kitap bulunamadı.");
                return;
            }

            uye.KitapIadeEt(kitap);
        }



    }
}
