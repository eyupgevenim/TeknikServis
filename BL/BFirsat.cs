using System.Collections.Generic;
using DAL.Siniflar;
using OBJ;

namespace BL
{
    public class BFirsat :DFirsat
    {
        // Fırsat ekleme
        public new OIslemSonuc<bool> firsatEkle(OFirsat _f)
        {
            return base.firsatEkle(_f);
        }//firsatEkle()

        // Fırsat güncelleme
        public new OIslemSonuc<bool> firsatGuncelle(OFirsat _f)
        {
            return base.firsatGuncelle(_f);
        }//firsatGuncelle()

        // Fırsat sil
        public new OIslemSonuc<bool> firsatSil(int id)
        {
            return base.firsatSil(id);
        }//firsatSil()

        // Fırsat bilgisi
        public new OIslemSonuc<OFirsat> firsatBilgisi(int id)
        {
            return base.firsatBilgisi(id);
        }//firsatBilgisi()

        // Fırsat ara  //!!!!!!!!!!!!!!!!
        public new OIslemSonuc<List<OFirsat>> firsatAra(string ad, string soyad, string email, string urun)
        {
            //
            return null;
        }//firsatAra()

        // Fırsatları Listeleme
        public new OIslemSonuc<List<OFirsat>> firsatListele(int siparis_)
        {
            return base.firsatListele(siparis_);
        }//firsatListele()
    }
}
