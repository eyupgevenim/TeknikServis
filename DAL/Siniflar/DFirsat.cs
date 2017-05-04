using System;
using System.Collections.Generic;
using System.Linq;
using OBJ;

namespace DAL.Siniflar
{
    public class DFirsat : DBaglanti
    {
        // Fırsat ekleme
        protected OIslemSonuc<bool> firsatEkle(OFirsat _f)
        {
            try
            {
                var kayit = new urunfirsat
                {
                    urunsiparis_=_f.siparis_,
                    personel_=_f.personel_,
                    firsattarihi=_f.tarih,
                    asamasayisi=_f.asamasayisi,
                    aciklama=_f.aciklama
                };
                Entity.urunfirsat.Add(kayit);
                Entity.SaveChanges();
                return new OIslemSonuc<bool>
                {
                    basarliMi = true
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<bool>
                {
                    basarliMi=false,
                    hataBilgisi=new OHata
                    {
                        hataMesaj=e.Message,
                        sinif="DFirsat",
                        method="firsatEkleme"
                    }
                };
            }
        }//firsatEkle()

        // Fırsat güncelleme
        protected OIslemSonuc<bool> firsatGuncelle(OFirsat _f)
        {
            try
            {

                var kayitlar = (from f in Entity.urunfirsat
                                where f.urunfirsat_ == _f.firsat_
                                select f);
                if (kayitlar.Count() > 0)
                {
                    var k = kayitlar.FirstOrDefault();
                    k.aciklama = _f.aciklama;
                    Entity.SaveChanges();

                    return new OIslemSonuc<bool>
                    {
                        basarliMi = true,
                        veri = true
                    };

                }
                else
                {
                    return new OIslemSonuc<bool>
                    {
                        basarliMi = false,
                        mesaj = "Kayıt bulunamadı."
                    };
                }
            }
            catch (Exception e)
            {
                return new OIslemSonuc<bool>
                {
                    basarliMi = false,
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DFirsat",
                        method = "firsatGuncelle"
                    }
                };
            }
        }//firsatGuncelle()

        // Fırsat sil
        protected OIslemSonuc<bool> firsatSil(int id)
        {
            try
            {
                var kayitlar = (from f in Entity.urunfirsat where f.urunfirsat_ == id select f);
                if (kayitlar.Count() > 0)
                {
                    var firsat = new urunfirsat { urunfirsat_ = id };
                    Entity.urunfirsat.Attach(firsat);
                    Entity.urunfirsat.Remove(firsat);
                    Entity.SaveChanges();

                    return new OIslemSonuc<bool>
                    {
                        basarliMi = true
                    };
                }
                else
                {
                    return new OIslemSonuc<bool>
                    {
                        basarliMi = false,
                        mesaj = "Kayit bulunamadı."
                    };
                }
            }
            catch (Exception e)
            {
                return new OIslemSonuc<bool>
                {
                    basarliMi = false,
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DFirsat",
                        method = "firsatSil",
                    }
                };
            }
        }//firsatSil()

        // Fırsat bilgisi
        protected OIslemSonuc<OFirsat> firsatBilgisi(int id)
        {
            try
            {
                var kayit = (from f in Entity.urunfirsat where f.urunfirsat_ == id select f);
                if (kayit.Count() > 0)
                {
                    var _f = kayit.FirstOrDefault();
                    return new OIslemSonuc<OFirsat>
                    {
                        basarliMi = true,
                        veri = new OFirsat
                        {
                            firsat_=_f.urunfirsat_,
                            siparis_=_f.urunsiparis.urunsiparis_,
                            personel_=_f.personel.personel_,
                            tarih=(DateTime)_f.firsattarihi,
                            asamasayisi=(int)_f.asamasayisi,
                            aciklama=_f.aciklama
                        }
                    };
                }
                else
                {
                    return new OIslemSonuc<OFirsat>
                    {
                        basarliMi = false,
                        mesaj = "Kayıt bulunamadı."
                    };
                }
            }
            catch (Exception e)
            {
                return new OIslemSonuc<OFirsat>
                {
                    basarliMi = false,
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DFirsat",
                        method = "firsatBilgisi"
                    }
                };
            }
        }//firsatBilgisi()

        // Fırsat ara  //!!!!!!!!!!!!!!!!!!
        protected OIslemSonuc<List<OFirsat>> firsatAra(string ad, string soyad, string email,string urun)
        {
            //
            return null;
        }//firsatAra()

        // Fırsatları Listeleme
        protected OIslemSonuc<List<OFirsat>> firsatListele(int siparis_)
        {
            try
            {
                var kayitlar = (from f in Entity.urunfirsat where f.urunsiparis_ == siparis_ select new OFirsat
                {
                    firsat_ = f.urunfirsat_,
                    siparis_ = f.urunsiparis.urunsiparis_,
                    personel_ = f.personel.personel_,
                    tarih = (DateTime)f.firsattarihi,
                    asamasayisi = (int)f.asamasayisi,
                    aciklama = f.aciklama
                }).ToList();
                return new OIslemSonuc<List<OFirsat>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OFirsat>>
                {
                    basarliMi = false,
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DFirsat",
                        method = "firsatListele"
                    }
                };
            }
        }//firsatListele()
    }
}
