using System;
using System.Collections.Generic;
using System.Linq;
using OBJ;

namespace DAL.Siniflar
{
    public class DArizalimusterisi : DBaglanti
    {
        //Arıza müşterisi ekleme
        protected OIslemSonuc<int> aMusteriEkle(OMusteri _m)
        {
            try
            {
                var kayit = new arizamusterisi
                {
                    adi = _m.adi,
                    soyadi = _m.soyadi,
                    tel = _m.tel,
                    email = _m.email,
                    sil=false,
                    kayittarihi = _m.kayittarihi //sorun oluyor olabilir
                    //adres_ = adres_

                };
                Entity.arizamusterisi.Add(kayit);
                Entity.SaveChanges();
                int musteri_ = kayit.arizamusterisi_;

                return new OIslemSonuc<int>
                {
                    basarliMi = true,
                    veri = musteri_
                };

            }
            catch (Exception e)
            {
                return new OIslemSonuc<int>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizalimusterisi",
                        method = "aMusteriEkle"
                    }

                };
            }
        }//aMusteriEkle()

        //Arıza müşterisi güncelleme
        protected OIslemSonuc<bool> aMusteriGuncelle(OMusteri _m)
        {
            try
            {
                var kayitlar = (from m in Entity.arizamusterisi
                                where m.sil == false && m.arizamusterisi_ == _m.musteri_
                                select m);
                if (kayitlar.Count() > 0)
                {
                    var k = kayitlar.FirstOrDefault();
                    k.adi = _m.adi;
                    k.soyadi = _m.soyadi;
                    k.email = _m.email;
                    k.kayittarihi = _m.kayittarihi;
                    k.tel = _m.tel;
                    k.adres.acikadres = _m._adres.adres;
                    k.adres.ilce_ = _m._adres.ilce_;
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
                        veri = false,
                        mesaj = "Kayıt bulunamadı."
                    };
                }

            }
            catch (Exception e)
            {
                return new OIslemSonuc<bool>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizalimusterisi",
                        method = "aMusteriGuncelle"
                    }

                };
            }
        }//aMusteriGuncelle()

        //Arıza müşterisini silme
        protected OIslemSonuc<bool> aMusteriSil(int id)
        {
            try
            {
                var kayitlar = (from m in Entity.arizamusterisi where m.sil == false && m.arizamusterisi_ == id select m);
                if (kayitlar.Count() > 0)
                {
                    var kayit = kayitlar.FirstOrDefault();
                    kayit.sil = true;
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
                        mesaj = "Kayit bulunamadı."
                    };
                }
            }
            catch (Exception e)
            {
                return new OIslemSonuc<bool>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizalimusterisi",
                        method = "aMusteriSil"
                    }

                };
            }
        }//aMusteriSil()

        // Arıza müşterisinin bilgisi
        protected OIslemSonuc<OMusteri> aMusteriBilgisi(int id)
        {
            try
            {
                var kayit = (from m in Entity.arizamusterisi where m.sil == false && m.arizamusterisi_ == id select m);
                if (kayit.Count() > 0)
                {
                    var _m = kayit.FirstOrDefault();
                    return new OIslemSonuc<OMusteri>
                    {
                        basarliMi = true,
                        veri = new OMusteri
                        {
                            musteri_ = _m.arizamusterisi_,
                            adi = _m.adi,
                            soyadi = _m.soyadi,
                            email = _m.email,
                            kayittarihi = (DateTime)_m.kayittarihi,
                            tel = _m.tel,
                            _adres = new OAdres
                            {
                                adres_ = _m.adres.adres_,
                                adres = _m.adres.acikadres,
                                ilce_ = _m.adres.ilce.ilce_,
                                ilce = _m.adres.ilce.ilceadi,
                                il_ = _m.adres.ilce.il.il_,
                                il = _m.adres.ilce.il.iladi
                            }
                        }
                    };
                }
                else
                {
                    return new OIslemSonuc<OMusteri>
                    {
                        basarliMi = false,
                        mesaj = "Kayıt bulunamadı."
                    };
                }
            }
            catch (Exception e)
            {
                return new OIslemSonuc<OMusteri>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizalimusterisi",
                        method = "aMusteriBilgisi"
                    }

                };
            }
        }//aMusteriBilgisi()

        //Arıza müşterisini arama
        protected OIslemSonuc<List<OMusteri>> aMusteriAra(string ad, string soyad, string email)
        {
            try
            {
                var kayitlar = (from _m in Entity.arizamusterisi
                                where _m.sil == false && (_m.adi.StartsWith(ad) || _m.soyadi.StartsWith(soyad) || _m.email.StartsWith(email))
                                select new OMusteri
                                {
                                    musteri_ = _m.arizamusterisi_,
                                    adi = _m.adi,
                                    soyadi = _m.soyadi,
                                    email = _m.email,
                                    kayittarihi = (DateTime)_m.kayittarihi,
                                    tel = _m.tel,
                                    //_adres = new OAdres
                                    //{
                                    //    adres_ = _m.adres.adres_,
                                    //    adres = _m.adres.acikadres,
                                    //    ilce_ = _m.adres.ilce.ilce_,
                                    //    ilce = _m.adres.ilce.ilceadi,
                                    //    il_ = _m.adres.ilce.il.il_,
                                    //    il = _m.adres.ilce.il.iladi
                                    //}
                                }).ToList();
                
                return new OIslemSonuc<List<OMusteri>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OMusteri>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizalimusterisi",
                        method = "aMusteriAra"
                    }

                };
            }
        }//aMusteriAra()

        //Arıza müşterilerini görüntüleme
        protected OIslemSonuc<List<OMusteri>> aMusteriListele()
        {
            try
            {
                var kayitlar = (from _m in Entity.arizamusterisi
                                where _m.sil == false
                                select new OMusteri
                                {
                                    musteri_ = _m.arizamusterisi_,
                                    adi = _m.adi,
                                    soyadi = _m.soyadi,
                                    email = _m.email,
                                    kayittarihi = (DateTime)_m.kayittarihi,
                                    tel = _m.tel,
                                    _adres = new OAdres
                                    {
                                        adres_ = _m.adres.adres_,
                                        adres = _m.adres.acikadres,
                                        ilce_ = _m.adres.ilce.ilce_,
                                        ilce = _m.adres.ilce.ilceadi,
                                        il_ = _m.adres.ilce.il.il_,
                                        il = _m.adres.ilce.il.iladi
                                    }
                                }).ToList();
                return new OIslemSonuc<List<OMusteri>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OMusteri>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizalimusterisi",
                        method = "aMusteriListele"
                    }

                };
            }
        }//aMusteriListele()
    }
}
