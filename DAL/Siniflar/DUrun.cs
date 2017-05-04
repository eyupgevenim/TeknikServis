using System;
using System.Collections.Generic;
using System.Linq;
using OBJ;

namespace DAL.Siniflar
{
    public class DUrun : DBaglanti
    {
        //ürün ekleme
        protected OIslemSonuc<bool> urunEkle(OUrun _u)
        {
            try
            {
                var kayit = new urunmodel
                {
                    modeladi=_u.modeladi,
                    modelkodu=_u.modelkodu,
                    ucret=_u.ucret,
                    stoksayisi=_u.stoksayisi,
                    tarih=_u.tarih,
                    sil=false,
                    urunkatagori_=_u._katagori.katagori_,
                    urunmarka_=_u._marka.marka_
                };
                Entity.urunmodel.Add(kayit);
                Entity.SaveChanges();

                return new OIslemSonuc<bool>
                {
                    basarliMi = true,
                    veri = true

                };

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
                        sinif = "DUrun",
                        method = "urunEkle"
                    }
                };
            }
        }//urunEkle()

        //ürün güncelleme
        protected OIslemSonuc<bool> urunGuncelle(OUrun _u)
        {
            try
            {
                var kayitlar = (from u in Entity.urunmodel
                                where u.sil==false &&  u.urunmodel_ == _u.urunmodel_
                                select u);
                if (kayitlar.Count() > 0)
                {
                    var k = kayitlar.FirstOrDefault();
                    k.modeladi = _u.modeladi;
                    k.modelkodu=_u.modelkodu;
                    k.ucret=_u.ucret;
                    k.stoksayisi=_u.stoksayisi;
                    //k.tarih = _u.tarih;
                    k.urunkatagori_ = _u._katagori.katagori_;
                    k.urunmarka_ = _u._marka.marka_;
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
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DUrun",
                        method = "urunGüncelle"
                    }

                };
            }
        }//urunGuncelle()

        //ürün silme
        protected OIslemSonuc<bool> urunSil(int id)
        {
            try
            {
                var kayitlar = (from u in Entity.urunmodel where u.sil == false && u.urunmodel_ == id select u);
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
                        sinif = "DUrun",
                        method = "urunSil",
                    }
                };
            }
        }//urunSil()

        //ürün bilgisi
        protected OIslemSonuc<OUrun> urunBilgisi(int id)
        {
            try
            {
                var kayit = (from u in Entity.urunmodel where u.sil == false && u.urunmodel_ == id select u);
                if (kayit.Count() > 0)
                {
                    var _u = kayit.FirstOrDefault();
                    return new OIslemSonuc<OUrun>
                    {
                        basarliMi = true,
                        veri = new OUrun
                        {
                            urunmodel_ = _u.urunmodel_,
                            modeladi = _u.modeladi,
                            modelkodu = _u.modelkodu,
                            stoksayisi = (int)_u.stoksayisi,
                            ucret = (double)_u.ucret,
                            tarih = (DateTime)_u.tarih,
                            _katagori=new OKatagori
                            {
                                katagori_=_u.urunkatagori.urunkatagori_,
                                katagoriadi=_u.urunkatagori.katagoriadi
                            },
                            _marka=new OMarka
                            {
                                marka_=_u.urunmarka.urunmarka_,
                                markaadi=_u.urunmarka.markaadi
                            }
                           
                        }
                    };
                }
                else
                {
                    return new OIslemSonuc<OUrun>
                    {
                        basarliMi = false,
                        mesaj = "Kayıt bulunamadı."
                    };
                }
            }
            catch (Exception e)
            {

                return new OIslemSonuc<OUrun>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DUrun",
                        method = "urunBilgi"
                    }

                };
            }
        }//urunBilgisi()

        //ürün arama
        protected OIslemSonuc<List<OUrun>> urunAra(string urunModeli,int maraka_,int katahori_)
        {
            try
            {
                
                var kayitlar = (from u in Entity.urunmodel
                            where u.sil==false 
                            && u.urunmarka_==maraka_ 
                            && u.urunkatagori_==katahori_ 
                            && u.modeladi.StartsWith(urunModeli) //
                            select new OUrun
                            {
                                urunmodel_ = u.urunmodel_,
                                modeladi = u.modeladi,
                                modelkodu = u.modelkodu,
                                ucret =(double) u.ucret,
                                stoksayisi=(int)u.stoksayisi,
                                tarih=(DateTime)u.tarih,
                                _katagori = new OKatagori
                                {
                                    katagori_ = u.urunkatagori.urunkatagori_,
                                    katagoriadi = u.urunkatagori.katagoriadi
                                },
                                _marka = new OMarka
                                {
                                    marka_ = u.urunmarka.urunmarka_,
                                    markaadi = u.urunmarka.markaadi
                                }

                            }).ToList();
                
                return new OIslemSonuc<List<OUrun>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };

            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OUrun>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DUrun",
                        method = "urunAra"
                    }

                };
            }
        }//urunAra()

        //ürün görüntüleme
        protected OIslemSonuc<List<OUrun>> urunListele()
        {
            try
            {
                var kayitlar = (from u in Entity.urunmodel
                                where u.sil == false
                                select new OUrun
                                {
                                    urunmodel_ = u.urunmodel_,
                                    modeladi = u.modeladi,
                                    modelkodu = u.modelkodu,
                                    ucret = (double)u.ucret,
                                    stoksayisi = (int)u.stoksayisi,
                                    tarih = (DateTime)u.tarih,
                                    _katagori = new OKatagori
                                    {
                                        katagori_ = u.urunkatagori.urunkatagori_,
                                        katagoriadi = u.urunkatagori.katagoriadi
                                    },
                                    _marka = new OMarka
                                    {
                                        marka_ = u.urunmarka.urunmarka_,
                                        markaadi = u.urunmarka.markaadi
                                    }
                                }).ToList();
                return new OIslemSonuc<List<OUrun>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OUrun>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DUurun",
                        method = "urunListele"
                    }
                };
            }
        }//urunListele()

        //Katagori ekleme
        protected OIslemSonuc<bool> katagoriEkle(OKatagori _k)
        {
            try
            {
                var kayit = new urunkatagori
                {
                    katagoriadi=_k.katagoriadi
                };
                Entity.urunkatagori.Add(kayit);
                Entity.SaveChanges();
                return new OIslemSonuc<bool>
                {
                    basarliMi = true,
                    veri=true
                };
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
                        sinif = "DUrun",
                        method = "katagoriEkle"
                    }

                };
            }
        }//katagoriEkle()

        //Katagori Listeleme
        protected OIslemSonuc<List<OKatagori>> katagoriListele()
        {
            try
            {
                var kayitlar = (from k in Entity.urunkatagori
                                where k.sil == false
                                select new OKatagori
                                {
                                    katagori_=k.urunkatagori_,
                                    katagoriadi=k.katagoriadi
                                }).ToList();
                return new OIslemSonuc<List<OKatagori>>
                {
                    basarliMi=true,
                    veri=kayitlar
                };
            }
            catch (Exception e)
            {

                return new OIslemSonuc<List<OKatagori>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DUrun",
                        method = "katagoriListele"
                    }
                };
            }
        }//katagoriListele()

        //Marka ekleme
        protected OIslemSonuc<bool> markaEkle(OMarka _m)
        {
            try
            {
                var kayit = new urunmarka
                {
                    markaadi=_m.markaadi
                };
                Entity.urunmarka.Add(kayit);
                Entity.SaveChanges();
                return new OIslemSonuc<bool>
                {
                    basarliMi = true,
                    veri = true
                };
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
                        sinif = "DUrun",
                        method = "markaEkle"
                    }

                };
            }
        }//markaEkle()

        //Marka Listeleme
        protected OIslemSonuc<List<OMarka>> markaListele()
        {
            try
            {
                var kayitlar = (from m in Entity.urunmarka
                                where m.sil == false
                                select new OMarka
                                {
                                    marka_=m.urunmarka_,
                                    markaadi=m.markaadi
                                }).ToList();
                return new OIslemSonuc<List<OMarka>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };
            }
            catch (Exception e)
            {

                return new OIslemSonuc<List<OMarka>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DUrun",
                        method = "markaListele"
                    }
                };
            }
        }//markaListele()

        // Katagori ye göre markaları listeleme
        protected OIslemSonuc<List<OMarka>> markaAra(int katagori_)
        {
            try
            {
                var kayitlar = (from m in Entity.urunmarka
                                join u in Entity.urunmodel on m.urunmarka_ equals u.urunmarka_
                                where m.sil == false && u.urunkatagori_ == katagori_
                                select new OMarka
                                {
                                    marka_ = m.urunmarka_,
                                    markaadi = m.markaadi
                                }).ToList();
                return new OIslemSonuc<List<OMarka>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };
            }
            catch (Exception e)
            {

                return new OIslemSonuc<List<OMarka>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DUrun",
                        method = "markaAra"
                    }
                };
            }
        }//markaAra()


    }
}
