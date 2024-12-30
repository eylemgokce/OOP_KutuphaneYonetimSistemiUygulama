using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KutuphaneYonetimSistemiUygulama
{
    internal class Kitap
    {
        public string isim;
        public string yazar;
        public string kategori;
        public int stok;

        public Kitap(string isim,string yazar,string kategori,int stok)
        {
            this.isim = isim;
            this.yazar = yazar;
            this.kategori = kategori;
            this.stok = stok;
        }

        public void stokEkle(int adet)
        {
            stok = stok + adet;
        }

        public bool stokAzalt()
        {
            if(stok > 0)
            {
                stok--;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Kitap : " + isim + " Yazar : " + yazar + " Kategori : " + kategori + " Stok : " + stok;
        }
    }
}
