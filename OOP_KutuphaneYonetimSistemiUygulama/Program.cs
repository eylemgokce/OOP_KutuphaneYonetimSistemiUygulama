using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KutuphaneYonetimSistemiUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Uygulama temel olarak bu özellikleri sağlamaktadır.
              1.Kitap yönetimi
              *kitap ekleme,silme,güncelleme
              *kitapların bilgilerini görüntüleme(isim,yazar,kategori,stok adedi vb.)
              2.Üye yönetimi
              *üye ekleme,silme,güncelleme
              *üye bilgilerini görüntüleme
              3.Kitap ödünç alma ve iade
              *bir üyenin kitap ödünç alması ve iade etmesi
              *kitap stoklarının buna göre güncellenmesi     
             */

            Kutuphane kutuphane = new Kutuphane();
            Console.WriteLine("Kütüphane Sistemi");

            while(true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
                Console.WriteLine("1-Kitap ekle" +
                    "\n2-Üye ekle" +
                    "\n3-Üye sil" +
                    "\n4-Kitapları listele" +
                    "\n5-Üyeleri listele" +
                    "\n6-Kitap güncelle" +
                    "\n7-Kitap ödünç al" +
                    "\n8-Kitap iade et" +
                    "\n9-Çıkış");
                Console.Write("Seçiminizi yapın : ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.Write("Kitap ismi : ");
                        string kitapIsmi = Console.ReadLine();
                        Console.Write("Yazar : ");
                        string yazar = Console.ReadLine();
                        Console.Write("Kategori: ");
                        string kategori = Console.ReadLine();
                        Console.Write("Stok: ");
                        int stok = int.Parse(Console.ReadLine());
                        Kitap yeniKitap = new Kitap(kitapIsmi, yazar, kategori, stok);
                        kutuphane.kitapEkle(yeniKitap);
                        break;

                    case 2:
                        Console.Write("Üye ID : ");
                        int uyeId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Üye ismi : ");
                        string uyeIsmi = Console.ReadLine();
                        Uye yeniUye = new Uye(uyeId, uyeIsmi);
                        kutuphane.uyeEkle(yeniUye);
                        break;

                    case 3:
                        Console.Write("Silinecek üye ID : ");
                        int silinecekId = Convert.ToInt32(Console.ReadLine());
                        kutuphane.uyeSil(silinecekId);
                        break;

                    case 4:
                        kutuphane.kitaplariListele();
                        break;

                    case 5:
                        kutuphane.uyeleriListele();
                        break;

                    case 6:
                        Console.Write("Güncellenecek kitap ismi : ");
                        string guncellenecekIsim = Console.ReadLine();
                        kutuphane.kitapGuncelle(guncellenecekIsim);
                        break;

                    case 7:
                        Console.Write("Üye ID : ");
                        int oduncUyeId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ödünç verilecek kitap ismi : ");
                        string oduncKitapIsmi = Console.ReadLine();
                        kutuphane.kitapOduncVer(oduncUyeId, oduncKitapIsmi);
                        break;

                    case 8:
                        Console.WriteLine("Üye ID: ");
                        int iadeUyeId = int.Parse(Console.ReadLine());
                        Console.Write("Kitap İsmi: ");
                        string iadeKitapIsmi = Console.ReadLine();
                        kutuphane.KitapIadeEt(iadeUyeId, iadeKitapIsmi);
                        break;

                    case 9:
                        Console.WriteLine("Programdan çıkılıyor...");
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }
                Console.WriteLine();
            }

        }
    }
}
