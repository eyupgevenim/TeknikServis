using System;
using System.Collections.Generic;
using DAL.Siniflar;
using OBJ;


namespace BL
{
    public class BArizaliurun: DArizaliurun
    {
        //Arıza ürün ekleme
        public new OIslemSonuc<bool> aUrunEkle(OArizaliurun _a)
        {
            var sonuc = new BArizamusterisi().aMusteriEkle(_a._musteri);
            if ( sonuc.basarliMi)
            {
                _a._musteri.musteri_ = sonuc.veri;
                return base.aUrunEkle(_a);
            }
            else
            {
                return new OIslemSonuc<bool>
                {
                    basarliMi=false,
                    mesaj="BArizaliurun/aUrunEkle() de",
                    hataBilgisi=sonuc.hataBilgisi
                };
            }
            
        }//aUrunEkle()

        //Arıza ürün ekleme
        public OIslemSonuc<bool> sadeceArizaliUrunEkle(OArizaliurun _a)
        {
            return base.aUrunEkle(_a);

        }//sadeceArizaliUrunEkle()

        //Arıza ürün güncelleme
        public new OIslemSonuc<bool> aUrunGuncelle(OArizaliurun _a)
        {
            return base.aUrunGuncelle(_a);
        }//aUrunGuncelle()

        //Arıza ürün silme
        public new OIslemSonuc<bool> aUrunlSil(int id)
        {
            return base.aUrunlSil(id);
        }//aUrunSil()

        //Arıza ürün bilgisi
        public new OIslemSonuc<OArizaliurun> aUrunBilgisi(int id)
        {
            return base.aUrunBilgisi(id);
        }//aUrunBilgisi()

        // Arıza ürün koduna göre arama
        public new OIslemSonuc<OArizaliurun> aUrunBilgiKodaGore(string urunkodu)
        {
            return base.aUrunBilgiKodaGore(urunkodu);
        }

        //Arıza ürün arama
        public new OIslemSonuc<List<OArizaliurun>> aUrunAra(string ad, DateTime tarih)
        {
            return base.aUrunAra(ad, tarih);
        }//aUrunAra()

        //Arıza ürün görüntüleme
        public new OIslemSonuc<List<OArizaliurun>> aUrunListele()
        {
            return base.aUrunListele();
        }//aUrunListele()

        //Servisteki arzalı ürünler
        public new OIslemSonuc<List<OArizaliurun>> aTamirdekiListesi()
        {
            return base.aTamirdekiListesi();
        }//aTamirdekiListesi()

        //Servisteki tamalanmış arzalı ürünler
        public new OIslemSonuc<List<OArizaliurun>> aTamlanmisListesi()
        {
            return base.aTamlanmisListesi();
        }//aTamlanmisListesi()

        //Geçmişte servite tsmire almış arzalı ürünler
        public new OIslemSonuc<List<OArizaliurun>> aGecmistekiListesi(string ad, DateTime tarih)
        {
            return base.aGecmistekiListesi(ad,tarih);
        }//aGecmistekiListesi()


        ///<ozet>
        ///Arızalı ürün aşaması
        ///</ozet>

        //Arızalı ürün aşaması ekleme
        public new OIslemSonuc<bool> aAsamaEkle(OAsama _a)
        {
            return base.aAsamaEkle(_a);
        }//aAsamaEkle()

        //Arizalı ürün aşaması güncelleme
        public new OIslemSonuc<bool> aAsamaGuncelle(OAsama _a)
        {
            return base.aAsamaGuncelle(_a);
        }//aAsamaGuncelle()

        //Arızalı ürün aşama silme
        public new OIslemSonuc<bool> aAsamaSil(int id)
        {
            return base.aAsamaSil(id);
        }//aAsamaSil()

        //Arızalı ürün aşama çoklu silme
        public new OIslemSonuc<bool> aCokluAsamaSil(int arizaliurun_)
        {
            return base.aCokluAsamaSil(arizaliurun_);
        }//aCokluAsamaSil()

        //Arızalı ürün aşama bilgisi
        public new OIslemSonuc<OAsama> aAsamaBilgisi(int id)
        {
            return base.aAsamaBilgisi(id);
        }//aAsamaBilgisi()

        //Arızalı ürün aşama listesi
        public new OIslemSonuc<List<OAsama>> aAsamaListesi(int arizaliurun_)
        {
            return base.aAsamaListesi(arizaliurun_);
        }//aAsamaListesi()

    }
}
