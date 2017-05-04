using System.Collections.Generic;
using DAL.Siniflar;
using OBJ;

namespace BL
{
    public class BSiparis :DSiparis
    {
        //Siparis ürün ekleme
        public new OIslemSonuc<int> siparisEkle(OSiparis _s)
        {
            return base.siparisEkle(_s);
        }//siparisEkle()

        //Siparis ürün güncelleme
        public new OIslemSonuc<bool> siparisGuncelle(OSiparis _s)
        {
            return base.siparisGuncelle(_s);
        }//siparisGuncelle()

        //Siparis ürün silme
        public new OIslemSonuc<bool> siparisSil(int id)
        {
            return base.siparisSil(id);
        }//siparisSil()

        //Siparis ürün bilgisi
        public new OIslemSonuc<OSiparis> siparisBilgisi(int id)
        {
            return base.siparisBilgisi(id);
        }//siparisBilgisi()

        //Siparis ürün arama 
        public new OIslemSonuc<List<OSiparis>> siparisAra(string ad)
        {
            return base.siparisAra(ad);
        }//siparisAra()

        //Siparis ürün görüntüleme
        public new OIslemSonuc<List<OSiparis>> siparisListele()
        {
            return base.siparisListele();
        }//siparisListele()

        //Siparis ürün görüntüleme
        public new OIslemSonuc<List<OSiparis>> teslimEdilmemisSiparisListele()
        {
            return base.teslimEdilmemisSiparisListele();
        }//teslimEdilmemisSiparisListele()


        //siparis durum güncellemesi
        public new OIslemSonuc<bool> siparisDurumGuncelle(OSiparis _s)
        {
            return base.siparisDurumGuncelle(_s);
        }//siparisDurumGuncelle()

        // Sepete bir ürün ekleme
        public new OIslemSonuc<bool> sepeteEkle(OSepet _s)
        {
            return base.sepeteEkle(_s);
        }//sepeteEkle()

        //sepete bir çok ürün ekleme
        public new OIslemSonuc<bool> cokluSepeteEkleme(List<OSepet> _s)
        {
            return base.cokluSepeteEkleme(_s);
        }//cokluSepeteEkleme()

        //sepetten bir ürün silme
        public new OIslemSonuc<bool> sepettenSil(int id)
        {
            return base.sepettenSil(id);
        }//sepettenSil()

        //bir sepetteki tüm ürünleri silme
        public new OIslemSonuc<bool> cokluSepettenSil(int siparis_)
        {
            return base.cokluSepettenSil(siparis_);
        }//cokluSepettenSil()

        //bir sepetteki ürünleri listeleme
        public new OIslemSonuc<List<OSepet>> sepettekiler(int siparis_)
        {
            return base.sepettekiler(siparis_);
        }//sepettekiler()

    }
}
