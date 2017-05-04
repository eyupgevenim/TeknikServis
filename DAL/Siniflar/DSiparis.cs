using System;
using System.Collections.Generic;
using System.Linq;
using OBJ;

namespace DAL.Siniflar
{
    public class DSiparis : DBaglanti
    {
        /// <ozet>
        /// sipariş işlemleri
        /// </ozet>
        
        //Siparis ürün ekleme
        protected OIslemSonuc<int> siparisEkle(OSiparis _s)
        {
            try
            {
                var kayit = new urunsiparis
                {
                    urunmusteri_ = _s.musteri_,
                    siparistarih=_s.tarih,
                    toplamucret=_s.toplamucret,
                    siparisdurumu=1,
                    //odemetip=_s.odemetipi,
                    personel_=_s.personel_
                };
                Entity.urunsiparis.Add(kayit);
                Entity.SaveChanges();
                int siparis_ = kayit.urunsiparis_;

                /*
                _s.sepat.ForEach(se => Entity.urunsepeti.Add(new urunsepeti
                {
                    urunsiparis_ = siparis_,
                    urunmodel_ = se._urun.urunmodel_,
                    urunsayisi = se.urunsayisi,
                    toplamucret = se.toplamucret
                }) );
                int kayitsayisi = Entity.SaveChanges();
                */

                foreach (var s in _s.sepat)
                {
                    var k = new urunsepeti
                    {
                        urunsiparis_=siparis_,
                        urunmodel_=s._urun.urunmodel_,
                        urunsayisi=s.urunsayisi,
                        toplamucret=s.toplamucret
                    };
                    Entity.urunsepeti.Add(k);
                }
                int kayitsayisi=Entity.SaveChanges();
                
                if (kayitsayisi > 0)
                {
                    return new OIslemSonuc<int>
                    {
                        basarliMi = true,
                        veri=siparis_
                    };
                }
                else
                {
                    return new OIslemSonuc<int>
                    {
                        basarliMi = false,
                        mesaj="sepet eklenemedi",
                        hataBilgisi = new OHata
                        {
                            sinif = "DSiparis",
                            method = "siparisEkle"
                        }
                    };
                }
            }
            catch (Exception e)
            {
                return new OIslemSonuc<int>
                {
                    basarliMi = false,
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DSiparis",
                        method = "siparisEkle"
                    }
                };
            }
        }//siparisEkle()

        //Siparis ürün güncelleme
        protected OIslemSonuc<bool> siparisGuncelle(OSiparis _s)
        {
            try
            {
                var kayitlar = (from s in Entity.urunsiparis
                                where  s.urunsiparis_ == _s.siparis_
                                select s);

                if (kayitlar.Count() > 0)
                {
                    var k = kayitlar.FirstOrDefault();
                    k.urunmusteri_ = _s.musteri_;
                    k.toplamucret = _s.toplamucret;
                    //k.odemetip = _s.odemetipi;
                    //k.siparisdurumu = _s.durumu;
                    Entity.SaveChanges();

                    var sonuc = cokluSepettenSil(_s.siparis_);
                    if (sonuc.basarliMi)
                    {
                        return cokluSepeteEkleme(_s.sepat);
                    }
                    else
                    {
                        return sonuc;
                    }

                    //return new OIslemSonuc<bool>
                    //{
                    //    basarliMi = true,
                    //    veri = true
                    //};

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
                        sinif = "DSiparis",
                        method = "siparisGüncelle"
                    }

                };
            }
        }//siparisGuncelle()

        //Siparis ürün silme
        protected OIslemSonuc<bool> siparisSil(int id)
        {
            try
            {
                var kayitlar = (from s in Entity.urunsiparis
                                where  s.urunsiparis_ == id
                                select s);
                if (kayitlar.Count() > 0)
                {
                    var sepet= (from se in Entity.urunsepeti
                                    where se.urunsiparis_ == id
                                   select se);
                    if(sepet.Count() > 0)
                    {
                        Entity.urunsepeti.Where(us => us.urunsiparis_ == id)
                            .ToList().ForEach(us => Entity.urunsepeti.Remove(us));
                        Entity.SaveChanges();
                    }


                    //Console.WriteLine(id.ToString());

                    //çok kayıtlı silme
                    //var _sepet = Entity.urunsepeti.Where(_s => _s.urunsiparis_ == id).FirstOrDefault<urunsepeti>();
                    //Entity.Entry(_sepet).State = System.Data.Entity.EntityState.Deleted;
                    //Entity.SaveChanges();


                    var firsatlar = (from f in Entity.urunfirsat
                                     where f.urunsiparis_ == id
                                     select f);
                    if (firsatlar.Count() > 0)
                    {
                        Entity.urunfirsat.Where(uf => uf.urunsiparis_ == id)
                            .ToList().ForEach(uf => Entity.urunfirsat.Remove(uf));
                        Entity.SaveChanges();
                        //çok katyıtlı silme
                        //var _firsat = Entity.urunfirsat.Where(_s => _s.urunsiparis_ == id).FirstOrDefault<urunfirsat>();
                        //Entity.Entry(_firsat).State = System.Data.Entity.EntityState.Deleted;
                        //Entity.SaveChanges();
                    }

                    // tek kayıt silme
                    var kayit = kayitlar.FirstOrDefault();
                    Entity.urunsiparis.Attach(kayit);
                    Entity.urunsiparis.Remove(kayit);
                    Entity.SaveChanges();

                    //tek kayıtlı silme
                    //var _siparis = new urunsiparis { urunsiparis_ = id };
                    //Entity.urunsiparis.Attach(_siparis);
                    //Entity.urunsiparis.Remove(_siparis);
                    //Entity.SaveChanges();

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
                        sinif = "DSiparis",
                        method = "siparisSil",
                    }
                };
            }
        }//siparisSil()

        //Siparis ürün bilgisi
        protected OIslemSonuc<OSiparis> siparisBilgisi(int id)
        {
            try
            {
                var kayitlar = (from s in Entity.urunsiparis where s.urunsiparis_ == id select s);
                if (kayitlar.Count() > 0)
                {
                    var _s = kayitlar.FirstOrDefault();
                    return new OIslemSonuc<OSiparis>
                    {
                        basarliMi = true,
                        veri = new OSiparis
                        {
                            siparis_ = _s.urunsiparis_,
                            musteri_ = _s.urunmusteri.urunmusteri_,
                            tarih = (DateTime)_s.siparistarih,
                            toplamucret = (double)_s.toplamucret,
                            //odemetipi = (int)_s.odemetip,
                            durumu = (int)_s.siparisdurumu,
                            personel_ = _s.personel.personel_,
                            sepat = _s.urunsepeti.Select(se => new OSepet
                            {
                                sepet_ = se.urunsepeti_,
                                _urun = new OUrun { urunmodel_ = se.urunmodel.urunmodel_},
                                urunsayisi = (int)se.urunsayisi,
                                toplamucret = (double)se.toplamucret
                            }).ToList(),
                            firsat = _s.urunfirsat.Select(uf=>new OFirsat
                            {
                                firsat_=uf.urunfirsat_,

                                _personel=new OPersonel
                                {
                                    personel_ = uf.personel.personel_,
                                    adi=uf.personel.adi,
                                    soyadi=uf.personel.soyadi
                                },
                                tarih=(DateTime)uf.firsattarihi,
                                asamasayisi=(int)uf.asamasayisi,
                                aciklama=uf.aciklama
                            }).ToList()

                        }
                    };
                }
                else
                {
                    return new OIslemSonuc<OSiparis>
                    {
                        basarliMi = false,
                        mesaj = "Kayit bulunamadı."
                    };
                }
            }
            catch (Exception e)
            {
                return new OIslemSonuc<OSiparis>
                {
                    basarliMi = false,
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DSiparis",
                        method = "siparisBilgisi",
                    }
                };
            }
        }//siparisBilgisi()

        //Siparis ürün arama 
        protected OIslemSonuc<List<OSiparis>> siparisAra(string ad)
        {
            try
            {
                var kayitlar = (from _s in Entity.urunsiparis
                                join _m in Entity.urunmusteri on _s.urunmusteri_ equals _m.urunmusteri_
                                where _s.siparisdurumu == 3 && (_m.adi.StartsWith(ad) || _m.soyadi.StartsWith(ad) || _m.email.StartsWith(ad))
                                select new OSiparis
                                {
                                    siparis_ = _s.urunsiparis_,
                                    musteri_ = _s.urunmusteri.urunmusteri_,
                                    tarih = (DateTime)_s.siparistarih,
                                    toplamucret = (double)_s.toplamucret,
                                    satisfiyat= (double)_s.satisfiyat,
                                    //odemetipi = (int)_s.odemetip,
                                    durumu = (int)_s.siparisdurumu,
                                    personel_ = _s.personel.personel_,
                                    sepat = _s.urunsepeti.Select(se => new OSepet
                                    {
                                        sepet_ = se.urunsepeti_,
                                        _urun = new OUrun { urunmodel_ = se.urunmodel.urunmodel_ },
                                        urunsayisi = (int)se.urunsayisi,
                                        toplamucret = (double)se.toplamucret
                                    }).ToList()

                                }).ToList();
                return new OIslemSonuc<List<OSiparis>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OSiparis>>
                {
                    basarliMi = false,
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DSiparis",
                        method = "siparisListele",
                    }
                };
            }
        }//siparisAra()

        //Siparis ürün görüntüleme
        protected OIslemSonuc<List<OSiparis>> siparisListele()
        {
            try
            {
                var kayitlar = (from _s in Entity.urunsiparis
                                where _s.siparisdurumu == 1
                                select new OSiparis
                                {
                                    siparis_ = _s.urunsiparis_,
                                    musteri_ = _s.urunmusteri.urunmusteri_,
                                    tarih = (DateTime)_s.siparistarih,
                                    toplamucret = (double)_s.toplamucret,
                                    //odemetipi = (int)_s.odemetip,
                                    durumu = (int)_s.siparisdurumu,
                                    personel_ = _s.personel.personel_,
                                    sepat = _s.urunsepeti.Select(se => new OSepet
                                    {
                                        sepet_ = se.urunsepeti_,
                                        _urun = new OUrun { urunmodel_ = se.urunmodel.urunmodel_ },
                                        urunsayisi = (int)se.urunsayisi,
                                        toplamucret = (double)se.toplamucret
                                    }).ToList(),
                                    firsat = _s.urunfirsat.Select(uf => new OFirsat
                                    {
                                        firsat_ = uf.urunfirsat_,
                                        personel_ = uf.personel.personel_,
                                        tarih = (DateTime)uf.firsattarihi,
                                        asamasayisi = (int)uf.asamasayisi,
                                        aciklama = uf.aciklama
                                    }).ToList()

                                }).ToList();
                return new OIslemSonuc<List<OSiparis>>
                {
                    basarliMi=true,
                    veri=kayitlar
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OSiparis>>
                {
                    basarliMi = false,
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DSiparis",
                        method = "siparisListele",
                    }
                };
            }
        }//siparisListele()

        //Siparis ürün görüntüleme
        protected OIslemSonuc<List<OSiparis>> teslimEdilmemisSiparisListele()
        {
            try
            {
                var kayitlar = (from _s in Entity.urunsiparis
                                where _s.siparisdurumu == 2
                                select new OSiparis
                                {
                                    siparis_ = _s.urunsiparis_,
                                    musteri_ = _s.urunmusteri.urunmusteri_,
                                    tarih = (DateTime)_s.siparistarih,
                                    toplamucret = (double)_s.toplamucret,
                                    satisfiyat=(double)_s.satisfiyat,
                                    //odemetipi = (int)_s.odemetip,
                                    durumu = (int)_s.siparisdurumu,
                                    personel_ = _s.personel.personel_,
                                    sepat = _s.urunsepeti.Select(se => new OSepet
                                    {
                                        sepet_ = se.urunsepeti_,
                                        _urun = new OUrun { urunmodel_ = se.urunmodel.urunmodel_ },
                                        urunsayisi = (int)se.urunsayisi,
                                        toplamucret = (double)se.toplamucret
                                    }).ToList(),
                                    firsat = _s.urunfirsat.Select(uf => new OFirsat
                                    {
                                        firsat_ = uf.urunfirsat_,
                                        personel_ = uf.personel.personel_,
                                        tarih = (DateTime)uf.firsattarihi,
                                        asamasayisi = (int)uf.asamasayisi,
                                        aciklama = uf.aciklama
                                    }).ToList()

                                }).ToList();
                return new OIslemSonuc<List<OSiparis>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OSiparis>>
                {
                    basarliMi = false,
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DSiparis",
                        method = " teslimEdilmemisSiparisListele",
                    }
                };
            }
        }// teslimEdilmemisSiparisListele()

        //siparis durum güncellemesi
        protected OIslemSonuc<bool> siparisDurumGuncelle(OSiparis _s)
        {
            try
            {

                var kayitlar = (from s in Entity.urunsiparis where s.urunsiparis_ == _s.siparis_ select s);
                if (kayitlar.Count() > 0)
                {
                    var kayit = kayitlar.FirstOrDefault();
                    kayit.siparisdurumu = _s.durumu;
                    kayit.satisfiyat = _s.satisfiyat;
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
                    mesaj="Beklenmedik bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DSiparis",
                        method = "siparisDurumGuncelle",
                    }
                };
            }
        }//siparisDurumGuncelle()


        ///<ozet>
        /// Sepet işlemleri
        ///</ozet>

        // Sepete bir ürün ekleme
        protected OIslemSonuc<bool> sepeteEkle(OSepet _s)
        {
            try
            {
                var k = new urunsepeti
                {
                    urunsiparis_ = _s.siparis_,
                    urunmodel_ = _s._urun.urunmodel_,
                    urunsayisi = _s.urunsayisi,
                    toplamucret = _s.toplamucret
                };
                Entity.urunsepeti.Add(k);
                Entity.SaveChanges();
                return new OIslemSonuc<bool>
                {
                    basarliMi=true
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<bool>
                {
                    basarliMi = false,
                    hataBilgisi=new OHata
                    {
                        hataMesaj=e.Message,
                        sinif="DSiparis",
                        method="sepeteEkle"
                    }
                };
            }
        }//sepeteEkle()

        //sepete bir çok ürün ekleme
        protected OIslemSonuc<bool> cokluSepeteEkleme(List<OSepet> _s)
        {
            try
            {
                _s.ForEach(s => Entity.urunsepeti.Add(new urunsepeti
                {
                    urunsiparis_ = s.siparis_,
                    urunmodel_ = s._urun.urunmodel_,
                    urunsayisi = s.urunsayisi,
                    toplamucret = s.toplamucret
                }));
                int kayitsayisi = Entity.SaveChanges();
                if(kayitsayisi > 0)
                {
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
                        mesaj="Ürünler sepete eklemedi !"
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
                        sinif = "DSiparis",
                        method = "cokluSepeteEkleme"
                    }
                };
            }
        }//cokluSepeteEkleme()

        //sepetten bir ürün silme
        protected OIslemSonuc<bool> sepettenSil(int id)
        {
            try
            {
                var kayit = new urunsepeti { urunsepeti_ = id };
                Entity.urunsepeti.Attach(kayit);
                Entity.urunsepeti.Remove(kayit);
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
                    basarliMi = false,
                    hataBilgisi=new OHata
                    {
                        hataMesaj=e.Message,
                        sinif="DSiparis",
                        method="sepettenSil"
                    }
                };
            }
        }//sepettenSil()

        //bir sepetteki tüm ürünleri silme
        protected OIslemSonuc<bool> cokluSepettenSil(int siparis_)
        {
            try
            {
                var sepet = (from se in Entity.urunsepeti
                             where se.urunsiparis_ == siparis_
                             select se);
                if (sepet.Count() > 0)
                {
                    Entity.urunsepeti.Where(us => us.urunsiparis_ == siparis_)
                        .ToList().ForEach(us => Entity.urunsepeti.Remove(us));
                    Entity.SaveChanges();
                }

                //var _sepet = Entity.urunsepeti.Where(_s => _s.urunsiparis_ == siparis_).FirstOrDefault<urunsepeti>();
                //Entity.Entry(_sepet).State = System.Data.Entity.EntityState.Deleted;
                //Entity.SaveChanges();

                return new OIslemSonuc<bool>
                {
                    basarliMi = true
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<bool>
                {
                    basarliMi = false,
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DSiparis",
                        method = "cokluSepettenSil"
                    }
                };
            }
        }//cokluSepettenSil()

        //bir sepetteki ürünleri listeleme
        protected OIslemSonuc<List<OSepet>> sepettekiler(int siparis_)
        {
            try
            {
                var kayitlar = (from s in Entity.urunsepeti
                                where s.urunsiparis_ == siparis_
                                select new OSepet
                                {
                                    sepet_ = s.urunsepeti_,
                                    siparis_=s.urunsiparis.urunsiparis_,
                                    _urun = new OUrun
                                    {
                                        urunmodel_ = s.urunmodel.urunmodel_,
                                        modeladi = s.urunmodel.modeladi,
                                        modelkodu = s.urunmodel.modelkodu,
                                        stoksayisi = (int)s.urunmodel.stoksayisi,
                                        ucret = (double)s.urunmodel.ucret,
                                    },
                                    urunsayisi = (int)s.urunsayisi,
                                    toplamucret = (double)s.toplamucret
                                }).ToList();
                return new OIslemSonuc<List<OSepet>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OSepet>>
                {
                    basarliMi = false,
                    hataBilgisi=new OHata
                    {
                        hataMesaj=e.Message,
                        sinif="DSiparis",
                        method= "sepettekiler"
                    }
                };
            }
        }//sepettekiler()


        

    }
}
