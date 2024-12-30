using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KutuphaneYonetimSistemiUygulama
{
    internal class Kullanici
    {
        public int id;
        public string isim;

        public Kullanici(int id,string isim)
        {
            this.id = id;
            this.isim = isim;
        }

        public override string ToString()
        {
            return "ID : " + id + " İsim : " + isim;
        }
    }
}
