using System;
using System.Collections.Generic;
using System.Linq;
using OBJ;

namespace DAL.Siniflar
{
    public class DSatismusterisi : DBaglanti
    {
        //Satış müşterisi ekleme
        protected OIslemSonuc<bool> sMusteriEkle(OMusteri _m)
        {
            try
            {
                var yeniAdres = new adres
                {
                    acikadres = _m._adres.adres,
                    ilce_ = _m._adres.ilce_
                };
                Entity.adres.Add(yeniAdres);
                Entity.SaveChanges();
                int adres_ = yeniAdres.adres_;

                if(adres_ > 0)
                {
                    var kayit = new urunmusteri
                    {
                        adi = _m.adi,
                        soyadi = _m.soyadi,
                        //tc = _m.tcno,
                        tel = _m.tel,
                        //tel2=_m.tel2,
                        email = _m.email,
                        //email2 = _m.email2,
                        //cinsiyet = _m.cinsiyet,
                        kayittarihi = _m.kayittarihi,
                        adres_ = adres_,
                        //musteritip = _m.musteritip
                        firma_=_m._firma.firma_,
                        sil=false
                        
                    };
                    Entity.urunmusteri.Add(kayit);
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
                        veri=false,
                        mesaj="Adres kayıt edilmedi !"

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
                        sinif = "DSatismusterisi",
                        method = "sMusteriEkle"
                    }

                };
            }
        }//sMusteriEkle()

        //Satış müşterisi güncelleme
        protected OIslemSonuc<bool> sMusteriGuncelle(OMusteri _m)
        {
            try
            {
                var kayitlar = (from m in Entity.urunmusteri
                                where m.sil == false && m.urunmusteri_ == _m.musteri_
                                select m);
                if (kayitlar.Count() > 0)
                {
                    var k = kayitlar.FirstOrDefault();
                    k.adi = _m.adi;
                    k.soyadi = _m.soyadi;
                    //k.tc = _m.tcno;
                    k.tel = _m.tel;
                    //k.tel2 = _m.tel2;
                    k.email = _m.email;
                    //k.email2 = _m.email2;
                    //k.cinsiyet = _m.cinsiyet;
                    k.kayittarihi = _m.kayittarihi;
                    //k.musteritip = _m.musteritip;
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
                        veri=false,
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
                        sinif = "DSatısmusterisi",
                        method = "sMusteriGüncelle"
                    }

                };
            }
        }//sMusteriGuncelle()

        //Satış müşterisini silme
        protected OIslemSonuc<bool> sMusterilSil(int id)
        {
            try
            {
                var kayitlar = (from m in Entity.urunmusteri where m.sil == false && m.urunmusteri_ == id select m);
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
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DSatısmusterisi",
                        method = "smusteriSil",
                    }
                };
            }
        }//sMusteriSil()

        //Satış müşterisinin bilgisi
        protected OIslemSonuc<OMusteri> sMusterilBilgisi(int id)
        {
            try
            {
                var kayit = (from m in Entity.urunmusteri
                             where m.sil == false && m.urunmusteri_ == id
                             select m);
                if (kayit.Count() > 0)
                {
                    var _m = kayit.FirstOrDefault();
                    return new OIslemSonuc<OMusteri>
                    {
                        basarliMi = true,
                        veri = new OMusteri
                        {
                            musteri_ = _m.urunmusteri_,
                            adi = _m.adi,
                            soyadi = _m.soyadi,
                            //tcno = _p.tc,
                            tel = _m.tel,
                            //tel2 = _m.tel2,
                            email = _m.email,
                            //email2 = _m.email2,
                            kayittarihi = (DateTime)_m.kayittarihi,
                            //musteritip = (int)_m.musteritip,
                            //cinsiyet = _p.cinsiyet,
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
                        sinif = "DSatısmusteri",
                        method = "sMusteriBilgi"
                    }

                };
            }
        }//sMusteriBilgisi()

        //Satış müşterisini arama
        protected OIslemSonuc<List<OMusteri>> sMusteriAra(string ad, string soyad, string email)
        {
            try
            {
                var kayitlar = (from _m in Entity.urunmusteri
                                where _m.sil==false && (_m.adi.StartsWith(ad) || _m.soyadi.StartsWith(soyad) || _m.email.StartsWith(email) )
                                select new OMusteri
                                {
                                    musteri_ = _m.urunmusteri_,
                                    adi = _m.adi,
                                    soyadi = _m.soyadi,
                                    //tcno = _p.tc,
                                    tel = _m.tel,
                                    //tel2 = _m.tel2,
                                    email = _m.email,
                                    //email2 = _m.email2,
                                    kayittarihi = (DateTime)_m.kayittarihi,
                                    //musteritip = (int)_m.musteritip,
                                    //cinsiyet = _p.cinsiyet,
                                    _firma = new OFirma
                                    {
                                        firma_ = _m.firma.firma_,
                                        firmaadi = _m.firma.firmaadi
                                    },
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
                        sinif = "DSatismusterisi",
                        method = "sMusteriAra"
                    }

                };
            }
        }//sMusteriAra()

        //Satış müşterilerini görüntüleme
        protected OIslemSonuc<List<OMusteri>> sMusteriListele()
        {
            try
            {
                var kayitlar = (from _m in Entity.urunmusteri
                                where _m.sil == false
                                select new OMusteri
                                {
                                    musteri_ = _m.urunmusteri_,
                                    adi = _m.adi,
                                    soyadi = _m.soyadi,
                                    //tcno = _p.tc,
                                    email = _m.email,
                                    kayittarihi = (DateTime)_m.kayittarihi,
                                    musteritip = (int)_m.musteritip,
                                    tel = _m.tel,
                                    //cinsiyet = _p.cinsiyet,
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
                        sinif = "DSatismusterisi",
                        method = "sMusteriListele"
                    }
                };
            }
        }//sMusteriListele()


        /// <ozet>
        /// firma veri taban işlemleri
        /// </ozet>

        //firma ekleme
        protected OIslemSonuc<bool> firmaEkle(OFirma _f)
        {
            try
            {
                var yeniAdres = new adres
                {
                    acikadres = _f._adres.adres,
                    ilce_ = _f._adres.ilce_
                };
                Entity.adres.Add(yeniAdres);
                Entity.SaveChanges();
                int adres_ = yeniAdres.adres_;

                if (adres_ > 0)
                {
                    var kayit = new firma
                    {
                        firmaadi=_f.firmaadi,
                        tel1=_f.tel1,
                        tel2=_f.tel2,
                        email1=_f.email,
                        //email2
                        adres_=adres_,
                        sil=false

                    };
                    Entity.firma.Add(kayit);
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
                        mesaj = "Adres kayıt edilmedi !"

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
                        sinif = "DSatismusterisi",
                        method = "firmaEkle"
                    }

                };
            }
        }//firmaEkle()

        //firma güncelleme
        protected OIslemSonuc<bool> firmaGuncelle(OFirma _f)
        {
            try
            {
                var kayitlar = (from f in Entity.firma
                                join a in Entity.adres on f.adres_ equals a.adres_
                                where f.sil == false && f.firma_ == _f.firma_
                                select new {f,a });
                if (kayitlar.Count() > 0)
                {
                    var k = kayitlar.FirstOrDefault();
                    k.f.firmaadi = _f.firmaadi;
                    k.f.tel1 = _f.tel1;
                    k.f.tel2 = _f.tel2;
                    k.f.email1 = _f.email;
                    k.a.acikadres = _f._adres.adres;
                    k.a.ilce_ = _f._adres.ilce_;
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
                        sinif = "DSatısmusterisi",
                        method = "firmaGuncelle"
                    }

                };
            }
        }//firmaGuncelle()

        //firma silme
        protected OIslemSonuc<bool> firmaSil(int id)
        {
            try
            {
                var kayitlar = (from f in Entity.firma
                                where f.sil == false && f.firma_ == id
                                select f);
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
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DSatısmusterisi",
                        method = "firmaSil",
                    }
                };
            }
        }//firmaSil()

        //firma bilgisi
        protected OIslemSonuc<OFirma> firmaBilgisi(int id)
        {
            try
            {
                var kayit= (from f in Entity.firma
                                join a in Entity.adres on f.adres_ equals a.adres_
                                where f.sil == false
                                select new {f,a });
                if (kayit.Count() > 0)
                {
                    var k = kayit.FirstOrDefault();
                    return new OIslemSonuc<OFirma>
                    {
                        basarliMi = true,
                        veri = new OFirma
                        {
                            firma_ = k.f.firma_,
                            firmaadi = k.f.firmaadi,
                            email = k.f.email1,
                            tel1 = k.f.tel1,
                            tel2 = k.f.tel2,
                            _adres = new OAdres
                            {
                                adres_ = k.a.adres_,
                                adres = k.a.acikadres,
                                ilce_ = k.a.ilce.ilce_,
                                ilce = k.a.ilce.ilceadi,
                                il_ = k.a.ilce.il.il_,
                                il = k.a.ilce.il.iladi
                            }
                        }
                    };
                }
                else
                {
                    return new OIslemSonuc<OFirma>
                    {
                        basarliMi = false,
                        mesaj = "Kayıt bulunamadı."
                    };
                }
            }
            catch (Exception e)
            {
                return new OIslemSonuc<OFirma>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DSatismusterisi",
                        method = "firmaListele"
                    }
                };
            }
        }//firmaBilgisi()

        //firma Listeleme
        protected OIslemSonuc<List<OFirma>> firmaListele()
        {
            try
            {
                var kayitlar = (from f in Entity.firma
                                join a in Entity.adres on f.adres_ equals a.adres_
                                where f.sil == false
                                select new OFirma
                                {
                                    firma_=f.firma_,
                                    firmaadi = f.firmaadi,
                                    email = f.email1,
                                    tel1 = f.tel1,
                                    tel2 = f.tel2,
                                    _adres=new OAdres
                                    {
                                        adres_ = a.adres_,
                                        adres = a.acikadres,
                                        ilce_ = a.ilce.ilce_,
                                        ilce = a.ilce.ilceadi,
                                        il_ = a.ilce.il.il_,
                                        il = a.ilce.il.iladi
                                    }
                                }).ToList();
                return new OIslemSonuc<List<OFirma>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OFirma>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DSatismusterisi",
                        method = "firmaListele"
                    }
                };
            }
        }//firmaListele()
        
    }
}
