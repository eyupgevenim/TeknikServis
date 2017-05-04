using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Siniflar;
using OBJ;

namespace BL
{
    public class BUrun :DUrun
    {
        //ürün ekleme
        public new OIslemSonuc<bool> urunEkle(OUrun _u)
        {
            return base.urunEkle(_u);
        }//urunEkle()

        //ürün güncelleme
        public new OIslemSonuc<bool> urunGuncelle(OUrun _u)
        {
            return base.urunGuncelle(_u);
        }//urunGuncelle()

        //ürün silme
        public new OIslemSonuc<bool> urunSil(int id)
        {
            return base.urunSil(id);
        }//urunSil()

        //ürün bilgisi
        public new OIslemSonuc<OUrun> urunBilgisi(int id)
        {
            return base.urunBilgisi(id);
        }//urunBilgisi()

        //ürün arama
        public new OIslemSonuc<List<OUrun>> urunAra(string urunModeli, int marka_, int katagori_)
        {
            return base.urunAra(urunModeli,marka_,katagori_);
        }//urunAra()

        //ürün görüntüleme
        public new OIslemSonuc<List<OUrun>> urunListele()
        {
            return base.urunListele();
        }//urunListele()

        //katagori ekleme
        public new OIslemSonuc<bool> katagoriEkle(OKatagori _k)
        {
            return base.katagoriEkle(_k);
        }//katagoriEkle()

        //katatagori listeleme
        public new OIslemSonuc<List<OKatagori>> katagoriListele()
        {
            return base.katagoriListele();
        }//katagoriListele()

        //marka ekleme
        public new OIslemSonuc<bool> markaEkle(OMarka _m)
        {
            return base.markaEkle(_m);
        }//markaEkle()

        //marka listeleme
        public new OIslemSonuc<List<OMarka>> markaListele()
        {
            return base.markaListele();
        }//markaListeleme()

        //Katagoriye göre marka arama
        public new OIslemSonuc<List<OMarka>> markaAra(int katagori_)
        {
            return base.markaAra(katagori_);
        }//markaAra()

    }
}
