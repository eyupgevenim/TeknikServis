using System.Collections.Generic;
using DAL.Siniflar;
using OBJ;

namespace BL
{
    public class BArizamusterisi :DArizalimusterisi
    {
        //Arıza müşterisi ekleme
        public new OIslemSonuc<int> aMusteriEkle(OMusteri _m)
        {
            return base.aMusteriEkle(_m);
        }//aMusteriEkle()

        //Arıza müşterisi güncelleme
        public new OIslemSonuc<bool> aMusteriGuncelle(OMusteri _m)
        {
            return base.aMusteriGuncelle(_m);
        }//aMusteriGuncelle()

        //Arıza müşterisini silme
        public new OIslemSonuc<bool> aMusteriSil(int _m)
        {
            //
            return null;
        }//aMusteriSil()

        // Arıza müşterisinin bilgisi
        public new OIslemSonuc<OMusteri> aMusteriBilgisi(int id)
        {
            return base.aMusteriBilgisi(id);
        }//aMusteriBilgisi()

        //Arıza müşterisini arama
        public new OIslemSonuc<List<OMusteri>> aMusteriAra(string ad, string soyad, string email)
        {
            return base.aMusteriAra(ad,soyad,email);
        }//aMusteriAra()

        //Arıza müşterilerini görüntüleme
        public new OIslemSonuc<List<OMusteri>> aMusteriListele()
        {
            return base.aMusteriListele();
        }//aMusteriListele()
    }
}
