using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Siniflar;
using OBJ;


namespace BL
{
    public class BAdres:DAdres
    {
        //Adres ekleme
        public new OIslemSonuc<int> adresEkleme(OAdres _a)
        {
            return base.adresEkleme(_a);
        }//adresEkle()

        //Adres güncelleme
        public new OIslemSonuc<bool> adresGuncelleme(OAdres _a)
        {
            return base.adresGuncelleme(_a);
        }//adresGuncelleme()

        //Adres Bilgisi görüntüleme
        public new OIslemSonuc<OAdres> adresBilgisi(int id)
        {
            return base.adresBilgisi(id);
        }//adresBilgisi()

        // tüm iller listesi
        public new OIslemSonuc<List<OAdres>> illeriListele()
        {
            return base.illeriListele();
        }

        // Bir ilin ilce listesi
        public new OIslemSonuc<List<OAdres>> ilcelerAra(int _il)
        {
            return base.ilcelerAra(_il);
        }
    }
}
