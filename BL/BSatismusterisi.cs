using System.Collections.Generic;
using DAL.Siniflar;
using OBJ;

namespace BL
{
    public class BSatismusterisi :DSatismusterisi
    {
        //Satış müşterisi ekleme
        public new OIslemSonuc<bool> sMusteriEkle(OMusteri _m)
        {
            return base.sMusteriEkle(_m);
        }//sMusteriEkle()

        //Satış müşterisi güncelleme
        public new OIslemSonuc<bool> sMusteriGuncelle(OMusteri _m)
        {
            return base.sMusteriGuncelle(_m);
        }//sMusteriGuncelle()

        //Satış müşterisini silme
        public new OIslemSonuc<bool> sMusterilSil(int id)
        {
            return base.sMusterilSil(id);
        }//sMusteriSil()

        //Satış müşterisinin bilgisi
        public new OIslemSonuc<OMusteri> sMusterilBilgisi(int id)
        {
            return base.sMusterilBilgisi(id);
        }//sMusteriBilgisi()

        //Satış müşterisini arama
        public new OIslemSonuc<List<OMusteri>> sMusteriAra(string ad, string soyad, string email)
        {
            return base.sMusteriAra(ad,soyad,email);
        }//sMusteriAra()

        //Satış müşterilerini görüntüleme
        public new OIslemSonuc<List<OMusteri>> sMusteriListele()
        {
            return base.sMusteriListele();
        }//sMusteriListele()


        /// <ozet>
        /// firma  işlemleri fonksiyonları
        /// </ozet>

        //firma ekleme
        public new OIslemSonuc<bool> firmaEkle(OFirma _f)
        {
            return base.firmaEkle(_f);
        }//firmaEkle()

        //firma güncelleme
        public new OIslemSonuc<bool> firmaGuncelle(OFirma _f)
        {
            return base.firmaGuncelle(_f);
        }//firmaGuncelle()

        //firma silme
        public new OIslemSonuc<bool> firmaSil(int id)
        {
            return base.firmaSil(id);
        }//firmaSil()

        //firma bilgisi
        public new OIslemSonuc<OFirma> firmaBilgisi(int id)
        {
            return base.firmaBilgisi(id);
        }//firmaBilgisi()

        //firma listeleme
        public new OIslemSonuc<List<OFirma>> firmaListele()
        {
            return base.firmaListele();
        }//firmaListele()
        

    }
}
