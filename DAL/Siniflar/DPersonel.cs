using System;
using System.Collections.Generic;
using System.Linq;
using OBJ;

namespace DAL.Siniflar
{
    public class DPersonel:DBaglanti
    {
        //Kullanıcı Giriş
        protected OIslemSonuc<OPersonel> Login(string _email, string _sifre)
        {
            try
            {
                var kayitlar = (from p in Entity.personel
                                where p.email == _email && p.sifre == _sifre && p.sil == false
                                select p);
                if (kayitlar.Count() > 0)
                {
                    var kayit = kayitlar.FirstOrDefault();
                    return new OIslemSonuc<OPersonel>
                    {
                        basarliMi = true,
                        veri = new OPersonel
                        {
                            personel_ = kayit.personel_,
                            adi = kayit.adi,
                            soyadi = kayit.soyadi,
                            email = kayit.email,
                            personelTipi_ = kayit.personeltip.personeltip_
                        }
                    };
                }
                else
                {
                    return new OIslemSonuc<OPersonel>
                    {
                        basarliMi = false,
                        mesaj = "Kayit bulunamadı !"
                    };
                }
            }
            catch (Exception hata)
            {

                return new OIslemSonuc<OPersonel>
                {
                    basarliMi = false,
                    hataBilgisi = new OHata
                    {
                        hataMesaj = hata.Message,
                        method = "Login",
                        sinif = "DPersonel"
                    },
                    mesaj = "Bir hata ile karşılaşıldı !"
                };
            }
        }//Login()

        // Personel ekleme
        protected OIslemSonuc<bool> personelEkle(OPersonel _p)
        {
            try
            {
                var yeniAdres = new adres
                {
                    acikadres=_p.adres.adres,
                    ilce_=_p.adres.ilce_
                };
                Entity.adres.Add(yeniAdres);
                Entity.SaveChanges();

                int adres_ = yeniAdres.adres_;

                if (adres_ >0)
                {
                    var kayit = new personel
                    {
                        adi = _p.adi,
                        soyadi = _p.soyadi,
                        tc = _p.tcno,
                        tel1 = _p.tel1,
                        tel2 = _p.tel2,
                        email = _p.email,
                        cinsiyet = _p.cinsiyet,
                        dogumtarihi = _p.dogumtarihi,
                        maas = _p.maas,
                        egitimdurum = _p.egitimdurumu,
                        adres_ = adres_,
                        personeltip_ = _p.personelTipi_,
                        sifre = _p.sifre,
                        sil=_p.sil
                    };
                    Entity.personel.Add(kayit);
                    Entity.SaveChanges();

                    return new OIslemSonuc<bool>
                    {
                        basarliMi = true,
                        veri=true

                    };
                }
                else
                {
                    return new OIslemSonuc<bool>
                    {
                        basarliMi = false,
                        veri=false,
                        mesaj = "Adres kaydedilmedi !"
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
                        sinif = "DPersonel",
                        method = "personelEkle"
                    }

                };
            }
        }//personelEkle()

        // Personel güncelleme
        protected OIslemSonuc<bool> personelGuncelle(OPersonel _p)
        {
            try
            {
                /* 
                var kayitlar = (from p in Entity.personel 
                                join a in Entity.adres on p.adres_ equals a.adres_
                                where p.sil == false && p.personel_ == _p.personel_
                                select new { p,a});
                if(kayitlar.Count() > 0)
                {
                    var k = kayitlar.FirstOrDefault();
                    k.p.adi = _p.adi;
                    k.p.soyadi = _p.soyadi;
                    k.p.tc = _p.tcno;
                    k.p.email = _p.email;
                    k.p.cinsiyet = _p.cinsiyet;
                    k.p.dogumtarihi = _p.dogumtarihi;
                    k.p.tel1 = _p.tel1;
                    k.p.tel2 = _p.tel2;
                    k.p.maas = _p.maas;
                    k.p.egitimdurum = _p.egitimdurumu;
                    k.p.personeltip_ = _p.personelTipi_;
                    k.a.acikadres = _p.adres.adres;
                    k.a.ilce_ = _p.adres.ilce_;
                    Entity.SaveChanges();
                    */
                var kayitlar = (from p in Entity.personel
                                   where p.sil == false && p.personel_ == _p.personel_
                                   select p);
                   if (kayitlar.Count() > 0)
                   {
                       var k = kayitlar.FirstOrDefault();
                       k.adi = _p.adi;
                       k.soyadi = _p.soyadi;
                       k.tc = _p.tcno;
                       k.email = _p.email;
                       k.cinsiyet = _p.cinsiyet;
                       k.dogumtarihi = _p.dogumtarihi;
                       k.tel1 = _p.tel1;
                       k.tel2 = _p.tel2;
                       k.maas = _p.maas;
                       k.egitimdurum = _p.egitimdurumu;
                       k.personeltip_ = _p.personelTipi_;
                       k.adres.acikadres = _p.adres.adres;
                       k.adres.ilce_ = _p.adres.ilce_;
                       Entity.SaveChanges();
                   
                    return new OIslemSonuc<bool>
                    {
                        basarliMi = true,
                        veri=true
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
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DPersonel",
                        method = "personelGüncelle"
                    }

                };
            }
        }//personelGuncelle()

        // Personel silme
        protected OIslemSonuc<bool> personelSil(int id)
        {
            try
            {
                
                var kayitlar = (from p in Entity.personel where p.sil == false && p.personel_ == id select p);
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
                        mesaj="Kayit bulunamadı."
                    };
                }
            }
            catch (Exception e)
            {
                return new OIslemSonuc<bool>
                {
                    basarliMi = false,
                    hataBilgisi=new OHata
                    {
                        hataMesaj = e.Message,
                        sinif ="DPersonel",
                        method="personelSil",
                    }
                };
            }
        }//personelSil()

        // Personel bilgisi
        protected OIslemSonuc<OPersonel> personelBilgisi(int id)
        {
            try
            {
                var kayit = (from p in Entity.personel where p.sil==false && p.personel_ == id select p);
                if (kayit.Count() > 0)
                {
                    var _p = kayit.FirstOrDefault();
                    return new OIslemSonuc<OPersonel>
                    {
                        basarliMi = true,
                        veri = new OPersonel
                        {
                            personel_ = _p.personel_,
                            adi=_p.adi,
                            soyadi=_p.soyadi,
                            tcno=_p.tc,
                            email=_p.email,
                            dogumtarihi=(DateTime)_p.dogumtarihi,
                            personelTipi_=(int)_p.personeltip_,
                            tel1=_p.tel1,
                            tel2 = _p.tel2,
                            maas =(double) _p.maas,
                            egitimdurumu =(int) _p.egitimdurum,
                            cinsiyet =_p.cinsiyet,
                            adres=new OAdres
                            {
                                adres_ =_p.adres.adres_,
                                adres =_p.adres.acikadres,
                                ilce_ =_p.adres.ilce.ilce_,
                                ilce =_p.adres.ilce.ilceadi,
                                il_ =_p.adres.ilce.il.il_,
                                il = _p.adres.ilce.il.iladi
                            }
                        }
                    };
                }
                else
                {
                    return new OIslemSonuc<OPersonel>
                    {
                        basarliMi=false,
                        mesaj="Kayıt bulunamadı."
                    };
                }
            }
            catch (Exception e)
            {

                return new OIslemSonuc<OPersonel>
                {
                    basarliMi=false,
                    mesaj="Bir hatayla karşılaştı !",
                    hataBilgisi=new OHata
                    {
                        hataMesaj = e.Message,
                        sinif ="DPersonel",
                        method="personelBilgi"
                    }
                    
                };
            }
        }//personelBilgisi()

        // Personel arama
        protected OIslemSonuc<List<OPersonel>> personelAra(string ad,string soyad,string tc,string email)
        {
            try
            {
                var kayitlar = (from _p in Entity.personel where _p.personel_ == 0 select new OPersonel { }).ToList();
                if (ad != "")
                 {
                        kayitlar = (from _p in Entity.personel where _p.adi.Contains(ad + "%") select new OPersonel
                        {
                            personel_ = _p.personel_,
                            adi = _p.adi,
                            soyadi = _p.soyadi,
                            tcno = _p.tc,
                            email = _p.email,
                            dogumtarihi = (DateTime)_p.dogumtarihi,
                            personelTipi_ = (int)_p.personeltip_,
                            tel1 = _p.tel1,
                            tel2 = _p.tel2,
                            maas =(double) _p.maas,
                            egitimdurumu =(int) _p.egitimdurum,
                            cinsiyet = _p.cinsiyet,
                            adres = new OAdres
                            {
                                adres_ = _p.adres.adres_,
                                adres = _p.adres.acikadres,
                                ilce_ = _p.adres.ilce.ilce_,
                                ilce = _p.adres.ilce.ilceadi,
                                il_ = _p.adres.ilce.il.il_,
                                il = _p.adres.ilce.il.iladi
                            }
                        }).ToList();
                    }
                    else if (soyad != "")
                    {
                        kayitlar = (from _p in Entity.personel where _p.soyadi.Contains(soyad + "%") select new OPersonel
                        {
                            personel_ = _p.personel_,
                            adi = _p.adi,
                            soyadi = _p.soyadi,
                            tcno = _p.tc,
                            email = _p.email,
                            dogumtarihi = (DateTime)_p.dogumtarihi,
                            personelTipi_ = (int)_p.personeltip_,
                            tel1 = _p.tel1,
                            tel2 = _p.tel2,
                            maas = (double)_p.maas,
                            egitimdurumu = (int)_p.egitimdurum,
                            cinsiyet = _p.cinsiyet,
                            adres = new OAdres
                            {
                                adres_ = _p.adres.adres_,
                                adres = _p.adres.acikadres,
                                ilce_ = _p.adres.ilce.ilce_,
                                ilce = _p.adres.ilce.ilceadi,
                                il_ = _p.adres.ilce.il.il_,
                                il = _p.adres.ilce.il.iladi
                            }
                        }).ToList();
                    }
                    else if (tc != "")
                    {
                       kayitlar = (from _p in Entity.personel where _p.tc.Contains(tc + "%") select new OPersonel
                       {
                           personel_ = _p.personel_,
                           adi = _p.adi,
                           soyadi = _p.soyadi,
                           tcno = _p.tc,
                           email = _p.email,
                           dogumtarihi = (DateTime)_p.dogumtarihi,
                           personelTipi_ = (int)_p.personeltip_,
                           tel1 = _p.tel1,
                           tel2 = _p.tel2,
                           maas = (double)_p.maas,
                           egitimdurumu = (int)_p.egitimdurum,
                           cinsiyet = _p.cinsiyet,
                           adres = new OAdres
                           {
                               adres_ = _p.adres.adres_,
                               adres = _p.adres.acikadres,
                               ilce_ = _p.adres.ilce.ilce_,
                               ilce = _p.adres.ilce.ilceadi,
                               il_ = _p.adres.ilce.il.il_,
                               il = _p.adres.ilce.il.iladi
                           }
                       }).ToList();
                    }
                    else if (email != "")
                    {
                        kayitlar = (from _p in Entity.personel where _p.email.Contains(email + "%") select new OPersonel
                        {
                            personel_ = _p.personel_,
                            adi = _p.adi,
                            soyadi = _p.soyadi,
                            tcno = _p.tc,
                            email = _p.email,
                            dogumtarihi = (DateTime)_p.dogumtarihi,
                            personelTipi_ = (int)_p.personeltip_,
                            tel1 = _p.tel1,
                            tel2 = _p.tel2,
                            maas = (double)_p.maas,
                            egitimdurumu = (int)_p.egitimdurum,
                            cinsiyet = _p.cinsiyet,
                            adres = new OAdres
                            {
                                adres_ = _p.adres.adres_,
                                adres = _p.adres.acikadres,
                                ilce_ = _p.adres.ilce.ilce_,
                                ilce = _p.adres.ilce.ilceadi,
                                il_ = _p.adres.ilce.il.il_,
                                il = _p.adres.ilce.il.iladi
                            }
                        }).ToList();
                    }
                return new OIslemSonuc<List<OPersonel>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };

            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OPersonel>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DPersonel",
                        method = "personelAra"
                    }

                };
            }
        }//personelAra()

        // Personel tipine göre arama
        protected OIslemSonuc<List<OPersonel>> tipeGoreAra(int personeltip_)
        {
            try
            {
                var kayitlar = (from _p in Entity.personel
                                where _p.sil==false && _p.personeltip_ == personeltip_
                                select new OPersonel
                                {
                                    personel_ = _p.personel_,
                                    adi = _p.adi,
                                    soyadi = _p.soyadi,
                                    tcno = _p.tc,
                                    email = _p.email,
                                    dogumtarihi = (DateTime)_p.dogumtarihi,
                                    personelTipi_ = (int)_p.personeltip_,
                                    tel1 = _p.tel1,
                                    tel2 = _p.tel2,
                                    maas = (double)_p.maas,
                                    egitimdurumu = (int)_p.egitimdurum,
                                    cinsiyet = _p.cinsiyet,
                                    adres = new OAdres
                                    {
                                        adres_ = _p.adres.adres_,
                                        adres = _p.adres.acikadres,
                                        ilce_ = _p.adres.ilce.ilce_,
                                        ilce = _p.adres.ilce.ilceadi,
                                        il_ = _p.adres.ilce.il.il_,
                                        il = _p.adres.ilce.il.iladi
                                    }
                                }).ToList();
                return new OIslemSonuc<List<OPersonel>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };

            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OPersonel>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DPersonel",
                        method = "tipeGoreAra"
                    }

                };
            }
        }//tipeGoreAra()

        // Personelleri Listeleme
        protected OIslemSonuc<List<OPersonel>> personelListele()
        {
            try
            {
                var kayitlar = (from _p in Entity.personel
                             where _p.sil == false && _p.personeltip_ > 1
                             select new OPersonel
                             {
                                 personel_ = _p.personel_,
                                 adi = _p.adi,
                                 soyadi = _p.soyadi,
                                 tcno = _p.tc,
                                 email = _p.email,
                                 dogumtarihi = (DateTime)_p.dogumtarihi,
                                 personelTipi_ = (int)_p.personeltip_,
                                 tel1 = _p.tel1,
                                 tel2 = _p.tel2,
                                 maas = (double)_p.maas,
                                 egitimdurumu = (int)_p.egitimdurum,
                                 cinsiyet = _p.cinsiyet,
                                 adres = new OAdres
                                 {
                                     adres_ = _p.adres.adres_,
                                     adres = _p.adres.acikadres,
                                     ilce_ = _p.adres.ilce.ilce_,
                                     ilce = _p.adres.ilce.ilceadi,
                                     il_ = _p.adres.ilce.il.il_,
                                     il = _p.adres.ilce.il.iladi
                                 }
                             }).ToList();
                return new OIslemSonuc<List<OPersonel>>
                {
                    basarliMi=true,
                    veri=kayitlar
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OPersonel>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi =new OHata
                    {
                        hataMesaj=e.Message,
                        sinif="DPersonel",
                        method="personelListele"
                    }
                };
            }
        }//personelListele()

        // Personel şifre değiştirme
        protected OIslemSonuc<bool> sifreDegistirme(int personel_, string sifre)
        {
            try
            {

                var kayitlar = (from p in Entity.personel
                                where p.sil == false && p.personel_ == personel_ select p);
                if (kayitlar.Count() > 0)
                {
                    var kayit = kayitlar.FirstOrDefault();
                    kayit.sifre = sifre;
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
                        sinif = "DPersonel",
                        method = "sifreDegistirme",
                    }
                };
            }
        }//sifreDegistirme()

        // Personel emailini sorgulama
        protected OIslemSonuc<int> emailSorgu(string email)
        {
            try
            {
                var kayitlar = (from p in Entity.personel
                                where p.sil == false && p.email == email
                                select p);
                if (kayitlar.Count() > 0)
                {
                    var kayit = kayitlar.FirstOrDefault();
                    return new OIslemSonuc<int>
                    {
                        basarliMi = true,
                        veri=kayit.personel_
                    };
                }
                else
                {
                    return new OIslemSonuc<int>
                    {
                        basarliMi = false,
                        mesaj = "Kayit bulunamadı !"
                    };
                }
            }
            catch (Exception hata)
            {

                return new OIslemSonuc<int>
                {
                    basarliMi = false,
                    mesaj = "Bir hata ile karşılaşıldı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = hata.Message,
                        method = "emailSorgu",
                        sinif = "DPersonel"
                    }
                };
            }
        }

    }
}
