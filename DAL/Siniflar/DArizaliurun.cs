using System;
using System.Collections.Generic;
using System.Linq;
using OBJ;


namespace DAL.Siniflar
{
    public class DArizaliurun : DBaglanti
    {
        //Arıza ürün ekleme
        protected OIslemSonuc<bool> aUrunEkle(OArizaliurun _a)
        {
            try
            {
                var kayit = new arizaliurun
                {
                    urunadi = _a.urunadi,
                    urunkodu = _a.urunkodu,
                    model=_a.urunmodel,
                    urunaksesuar=_a.urunaksesuar,
                    aciklama=_a.aciklama,
                    arizabedeli=_a.arizabedeli,
                    tespitedilenariza = _a.tespitedilenariza,
                    ariza = _a.ariza,
                    sifre = _a.sifre,
                    durumu = _a.durumu,
                    serviskapsam=_a.serviskapsam,
                    personel_ = _a._personel.personel_,
                    teknikeleman_=_a._teknik.personel_,
                    arizamusterisi_ = _a._musteri.musteri_,
                    kayittarih=_a.kayittarih
                };
                Entity.arizaliurun.Add(kayit);
                Entity.SaveChanges();
                int urun_ = kayit.arizaliurun_;
                
                if(_a._foto != null)
                foreach (var f in _a._foto)
                {
                    var fotolar = new arizaliurunfotograf
                    {
                        arizaliurun_=urun_,
                        url=f.url
                    };
                    Entity.arizaliurunfotograf.Add(fotolar);
                    Entity.SaveChanges();
                }

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
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizaliurun",
                        method = "aUrunEkle"
                    }

                };
            }
        }//aUrunEkle()

        //Arıza ürün güncelleme
        protected OIslemSonuc<bool> aUrunGuncelle(OArizaliurun _a)
        {
            try
            {
                var kayitlar = (from a in Entity.arizaliurun
                                where a.arizaliurun_ == _a.aurun_
                                select a);
                if (kayitlar.Count() > 0)
                {
                    var k = kayitlar.FirstOrDefault();
                    k.urunadi = _a.urunadi;
                    k.model = _a.urunmodel;
                    k.urunkodu = _a.urunkodu;
                    k.urunaksesuar = _a.urunaksesuar;
                    k.tespitedilenariza = _a.tespitedilenariza;
                    k.ariza = _a.ariza;
                    k.sifre = _a.sifre;
                    k.durumu = _a.durumu;
                    k.arizabedeli = _a.arizabedeli;
                    k.aciklama = _a.aciklama;
                    k.serviskapsam = _a.serviskapsam;
                    k.teknikeleman_ = _a._teknik.personel_;
                    
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
                        sinif = "DArizaliurun",
                        method = "aUrunGüncelle"
                    }

                };
            }
        }//aUrunGuncelle()

        //Arıza ürün silme
        protected OIslemSonuc<bool> aUrunlSil(int id)
        {
            try
            {
                var kayitlar = (from a in Entity.arizaliurun
                                where  a.arizaliurun_ == id select a);
                if (kayitlar.Count() > 0)
                {
                    var aAsama = (from aa in Entity.arizaliurunasamasi
                                 where aa.arizaliurun_ == id
                                 select aa);
                    if (aAsama.Count() > 0)
                    {
                        Entity.arizaliurunasamasi.Where(aa_ => aa_.arizaliurun_ == id)
                            .ToList().ForEach(aa_ => Entity.arizaliurunasamasi.Remove(aa_));
                        Entity.SaveChanges();
                    }


                    var aFoto = (from se in Entity.arizaliurunfotograf
                                 where se.arizaliurun_ == id
                                 select se);
                    if (aFoto.Count() > 0)
                    {
                        Entity.arizaliurunfotograf.Where(f => f.arizaliurun_ == id)
                            .ToList().ForEach(f => Entity.arizaliurunfotograf.Remove(f));
                        Entity.SaveChanges();
                    }


                    var kayit = kayitlar.FirstOrDefault();
                    Entity.arizaliurun.Attach(kayit);
                    Entity.arizaliurun.Remove(kayit);
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
                        sinif = "DArizaliurun",
                        method = "aUrunSil",
                    }
                };
            }
        }//aUrunSil()

        //Arıza ürün bilgisi
        protected OIslemSonuc<OArizaliurun> aUrunBilgisi(int id)
        {
            try
            {
                var kayit = (from a in Entity.arizaliurun where  a.arizaliurun_ == id select a);
                if (kayit.Count() > 0)
                {
                    var _a = kayit.FirstOrDefault();
                    return new OIslemSonuc<OArizaliurun>
                    {
                        basarliMi = true,
                        veri = new OArizaliurun
                        {
                            aurun_ = _a.arizaliurun_,
                            urunadi = _a.urunadi,
                            urunmodel = _a.model,
                            urunkodu = _a.urunkodu,
                            tespitedilenariza = _a.tespitedilenariza,
                            ariza = _a.ariza,
                            sifre = _a.sifre,
                            durumu = (int)_a.durumu,
                            urunaksesuar = _a.urunaksesuar,
                            aciklama = _a.aciklama,
                            arizabedeli = (int)_a.arizabedeli,
                            serviskapsam = (int)_a.serviskapsam,
                            _teknik = new OPersonel { personel_ = (int)_a.teknikeleman_ },
                            _personel =new OPersonel {personel_=_a.personel.personel_ },//genişletilebilir
                            _musteri=new OMusteri
                            {
                                musteri_ =_a.arizamusterisi.arizamusterisi_,
                                adi= _a.arizamusterisi.adi,
                                soyadi= _a.arizamusterisi.soyadi,
                                tel= _a.arizamusterisi.tel

                            },//genişletilebilir
                            _foto =_a.arizaliurunfotograf.Select(r=>new OFotograf {url=r.url } ).ToList(),
                            _asama=_a.arizaliurunasamasi.Select(a_=>new OAsama
                            {
                                asama_ =a_.arizaliurunasamasi_,
                                //asamasayisi =(int)a_.asamasayisi,
                                aciklama=a_.aciklama,
                                personel_=a_.personel.personel_,
                                _personel=new OPersonel
                                {
                                    personel_ = a_.personel.personel_,
                                    adi= a_.personel.adi,
                                    soyadi= a_.personel.soyadi
                                },
                                tarih=(DateTime)a_.tarih,
                                gordu=(bool)a_.gordu
                            }).ToList()
                        }
                    };
                }
                else
                {
                    return new OIslemSonuc<OArizaliurun>
                    {
                        basarliMi = false,
                        mesaj = "Kayıt bulunamadı."
                    };
                }
            }
            catch (Exception e)
            {
                return new OIslemSonuc<OArizaliurun>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizaliurun",
                        method = "aUrunBilgi"
                    }
                };
            }
        }//aUrunBilgisi()

        // Arıza ürün koduna göre arama
        protected OIslemSonuc<OArizaliurun> aUrunBilgiKodaGore(string urunkodu)
        {
            try
            {
                var kayit = (from a in Entity.arizaliurun where a.urunkodu == urunkodu select a);
                if (kayit.Count() > 0)
                {
                    var _a = kayit.FirstOrDefault();
                    return new OIslemSonuc<OArizaliurun>
                    {
                        basarliMi = true,
                        veri = new OArizaliurun
                        {
                            aurun_ = _a.arizaliurun_,
                            urunadi = _a.urunadi,
                            urunkodu = _a.urunkodu,
                            tespitedilenariza = _a.tespitedilenariza,
                            ariza = _a.ariza,
                            sifre = _a.sifre,
                            durumu = (int)_a.durumu,
                            _personel = new OPersonel { personel_ = _a.personel.personel_ },//genişletilebilir
                            _musteri = new OMusteri { musteri_ = _a.arizamusterisi.arizamusterisi_ },//genişletilebilir
                            _foto = _a.arizaliurunfotograf.Select(r => new OFotograf { url = r.url }).ToList(),
                            _asama = _a.arizaliurunasamasi.Select(a => new OAsama
                            {
                                asama_ = a.arizaliurunasamasi_,
                                asamasayisi = (int)a.asamasayisi,
                                aciklama = a.aciklama,
                                personel_ = a.personel.personel_
                            }).ToList()
                        }
                    };
                }
                else
                {
                    return new OIslemSonuc<OArizaliurun>
                    {
                        basarliMi = false,
                        mesaj = "Kayıt bulunamadı."
                    };
                }
            }
            catch (Exception e)
            {
                return new OIslemSonuc<OArizaliurun>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizaliurun",
                        method = "aUrunBilgiKodaGore"
                    }
                };
            }
        }//aUrunBilgiKodaGore()

        //Arıza ürün arama 
        protected OIslemSonuc<List<OArizaliurun>> aUrunAra(string ad, DateTime tarih)
        {
            try
            {
                var kayitlar = (from _a in Entity.arizaliurun
                                join _m in Entity.arizamusterisi on _a.arizamusterisi_ equals _m.arizamusterisi_
                                join _p in Entity.personel on _a.personel_ equals _p.personel_
                                join _t in Entity.personel on _a.teknikeleman_ equals _t.personel_
                             where _a.durumu < 4 
                             &&  _m.adi.StartsWith(ad) 
                             || _m.soyadi.StartsWith(ad) 
                             || _m.email.StartsWith(ad) 
                                select new OArizaliurun
                             {
                                 aurun_ = _a.arizaliurun_,
                                 urunadi = _a.urunadi,
                                 urunmodel = _a.model,
                                 urunkodu = _a.urunkodu,
                                 tespitedilenariza = _a.tespitedilenariza,
                                 ariza = _a.ariza,
                                 sifre = _a.sifre,
                                 durumu = (int)_a.durumu,
                                 urunaksesuar = _a.urunaksesuar,
                                 aciklama = _a.aciklama,
                                 arizabedeli = (int)_a.arizabedeli,
                                 serviskapsam = (int)_a.serviskapsam,
                                 kayittarih=_a.kayittarih,
                                 _teknik = new OPersonel { personel_ = _t.personel_,adi=_t.adi,soyadi=_t.soyadi},
                                 _personel =new OPersonel { personel_ = _p.personel_,adi=_p.adi,soyadi=_p.soyadi },//genişletilebilir
                                 _musteri = new OMusteri { musteri_ = _m.arizamusterisi_ ,adi=_m.adi,soyadi=_m.soyadi,tel=_m.tel},//genişletilebilir
                                 _foto = _a.arizaliurunfotograf.Select(r => new OFotograf { url = r.url }).ToList(),
                                 _asama = _a.arizaliurunasamasi.Select(a => new OAsama
                                 {
                                     asama_ = a.arizaliurunasamasi_,
                                     //asamasayisi = (int)a.asamasayisi,
                                     aciklama = a.aciklama,
                                     personel_ = a.personel.personel_
                                 }).ToList()
                             }).ToList();

                return new OIslemSonuc<List<OArizaliurun>>
                {
                    basarliMi = true,
                    veri =kayitlar
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OArizaliurun>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizaliurun",
                        method = "aUrunAra"
                    }
                };
            }
        }//aUrunAra()

        //Arıza ürün görüntüleme
        protected OIslemSonuc<List<OArizaliurun>> aUrunListele()
        {
            try
            {
                var kayitlar = (from a in Entity.arizaliurun select new OArizaliurun
                {
                    aurun_ = a.arizaliurun_,
                    urunadi = a.urunadi,
                    urunmodel=a.model,
                    urunkodu = a.urunkodu,
                    tespitedilenariza = a.tespitedilenariza,
                    ariza = a.ariza,
                    sifre = a.sifre,
                    durumu = (int)a.durumu,
                    urunaksesuar=a.urunaksesuar,
                    aciklama=a.aciklama,
                    arizabedeli=(int)a.arizabedeli,
                    serviskapsam=(int)a.serviskapsam,
                    _teknik = new OPersonel { personel_ = (int)a.teknikeleman_ },
                    _personel = new OPersonel { personel_ = a.personel.personel_ },//genişletilebilir
                    _musteri = new OMusteri { musteri_ = a.arizamusterisi.arizamusterisi_ },//genişletilebilir
                    _foto = a.arizaliurunfotograf.Select(r => new OFotograf { url = r.url }).ToList(),
                    _asama = a.arizaliurunasamasi.Select(_a => new OAsama
                    {
                        asama_ = _a.arizaliurunasamasi_,
                        asamasayisi = (int)_a.asamasayisi,
                        aciklama = _a.aciklama,
                        personel_ = _a.personel.personel_
                    }).ToList()
                }).ToList();
                return new OIslemSonuc<List<OArizaliurun>>
                {
                    basarliMi=true,
                    veri=kayitlar
                };

            }
            catch (Exception e)
            {
                return new OIslemSonuc<List< OArizaliurun>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizaliurun",
                        method = "aUrunListesi"
                    }
                };
            }
        }//aUrunListele()

        //Servisteki arzalı ürünler
        protected OIslemSonuc<List<OArizaliurun>> aTamirdekiListesi()
        {
            try
            {
                var kayitlar = (from a in Entity.arizaliurun 
                                where a.durumu < 4
                                select new OArizaliurun
                                {
                                    aurun_ = a.arizaliurun_,
                                    urunadi = a.urunadi,
                                    urunkodu = a.urunkodu,
                                    tespitedilenariza = a.tespitedilenariza,
                                    ariza = a.ariza,
                                    sifre = a.sifre,
                                    durumu = (int)a.durumu,
                                    kayittarih=a.kayittarih
                                    /*
                                    _personel = new OPersonel { personel_ = a.personel.personel_ },//genişletilebilir
                                    _musteri = new OMusteri { musteri_ = a.arizamusterisi.arizamusterisi_ },//genişletilebilir
                                    _foto = a.arizaliurunfotograf.Select(r => new OFotograf { url = r.url }).ToList(),
                                    _asama = a.arizaliurunasamasi.Select(_a => new OAsama
                                    {
                                        asama_ = _a.arizaliurunasamasi_,
                                        asamasayisi = (int)_a.asamasayisi,
                                        aciklama = _a.aciklama,
                                        personel_ = _a.personel.personel_
                                    }).ToList()
                                    */
                                }).ToList();
                return new OIslemSonuc<List<OArizaliurun>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };

            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OArizaliurun>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizaliurun",
                        method = "aTamirdekeiUrunler"
                    }
                };
            }
        }//aTamirdekeiListesi()

        //Servisteki tamalanmış arzalı ürünler
        protected OIslemSonuc<List<OArizaliurun>> aTamlanmisListesi()
        {
            try
            {
                var kayitlar = (from a in Entity.arizaliurun
                                where a.durumu == 1
                                select new OArizaliurun
                                {
                                    aurun_ = a.arizaliurun_,
                                    urunadi = a.urunadi,
                                    urunkodu = a.urunkodu,
                                    tespitedilenariza = a.tespitedilenariza,
                                    ariza = a.ariza,
                                    sifre = a.sifre,
                                    durumu = (int)a.durumu,
                                    _personel = new OPersonel { personel_ = a.personel.personel_ },//genişletilebilir
                                    _musteri = new OMusteri { musteri_ = a.arizamusterisi.arizamusterisi_ },//genişletilebilir
                                    _foto = a.arizaliurunfotograf.Select(r => new OFotograf { url = r.url }).ToList(),
                                    _asama = a.arizaliurunasamasi.Select(_a => new OAsama
                                    {
                                        asama_ = _a.arizaliurunasamasi_,
                                        asamasayisi = (int)_a.asamasayisi,
                                        aciklama = _a.aciklama,
                                        personel_ = _a.personel.personel_
                                    }).ToList()
                                }).ToList();
                return new OIslemSonuc<List<OArizaliurun>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };

            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OArizaliurun>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizaliurun",
                        method = "aTamlanmisUrunler"
                    }
                };
            }
        }//aTamlanmisListesi()

        //Geçmişte servite tsmire almış arzalı ürünler
        protected OIslemSonuc<List<OArizaliurun>> aGecmistekiListesi(string ad, DateTime tarih)
        {
            try
            {
                if(ad != "" && tarih != Convert.ToDateTime("1.01.0001 00:00:00"))//ikisi doluysa
                {

                    var kayitlar = (from _a in Entity.arizaliurun
                                    join _m in Entity.arizamusterisi on _a.arizamusterisi_ equals _m.arizamusterisi_
                                    join _p in Entity.personel on _a.personel_ equals _p.personel_
                                    join _t in Entity.personel on _a.teknikeleman_ equals _t.personel_
                                    where _a.durumu == 4
                                    && ((_m.adi.StartsWith(ad) || _m.soyadi.StartsWith(ad) || _m.email.StartsWith(ad))
                                    && (_a.kayittarih.Value.Year == tarih.Year && _a.kayittarih.Value.Month == tarih.Month && _a.kayittarih.Value.Day == tarih.Day))
                                    select new OArizaliurun
                                    {
                                        aurun_ = _a.arizaliurun_,
                                        urunadi = _a.urunadi,
                                        urunmodel = _a.model,
                                        urunkodu = _a.urunkodu,
                                        tespitedilenariza = _a.tespitedilenariza,
                                        ariza = _a.ariza,
                                        sifre = _a.sifre,
                                        durumu = (int)_a.durumu,
                                        urunaksesuar = _a.urunaksesuar,
                                        aciklama = _a.aciklama,
                                        arizabedeli = (int)_a.arizabedeli,
                                        serviskapsam = (int)_a.serviskapsam,
                                        kayittarih = _a.kayittarih,
                                        _teknik = new OPersonel { personel_ = _t.personel_, adi = _t.adi, soyadi = _t.soyadi },
                                        _personel = new OPersonel { personel_ = _p.personel_, adi = _p.adi, soyadi = _p.soyadi },//genişletilebilir
                                        _musteri = new OMusteri { musteri_ = _m.arizamusterisi_, adi = _m.adi, soyadi = _m.soyadi, tel = _m.tel },//genişletilebilir
                                        _foto = _a.arizaliurunfotograf.Select(r => new OFotograf { url = r.url }).ToList(),
                                        _asama = _a.arizaliurunasamasi.Select(a => new OAsama
                                        {
                                            asama_ = a.arizaliurunasamasi_,
                                            //asamasayisi = (int)a.asamasayisi,
                                            aciklama = a.aciklama,
                                            personel_ = a.personel.personel_
                                        }).ToList()
                                    }).ToList();
                    return new OIslemSonuc<List<OArizaliurun>>
                    {
                        basarliMi = true,
                        veri = kayitlar
                    };
                }
                else if(ad != "")//sadece ad doluysa
                {
                    var kayitlar = (from _a in Entity.arizaliurun
                                    join _m in Entity.arizamusterisi on _a.arizamusterisi_ equals _m.arizamusterisi_
                                    join _p in Entity.personel on _a.personel_ equals _p.personel_
                                    join _t in Entity.personel on _a.teknikeleman_ equals _t.personel_
                                    where _a.durumu == 4 
                                    && ( _m.adi.StartsWith(ad) || _m.soyadi.StartsWith(ad) || _m.email.StartsWith(ad) )
                                    select new OArizaliurun
                                    {
                                        aurun_ = _a.arizaliurun_,
                                        urunadi = _a.urunadi,
                                        urunmodel = _a.model,
                                        urunkodu = _a.urunkodu,
                                        tespitedilenariza = _a.tespitedilenariza,
                                        ariza = _a.ariza,
                                        sifre = _a.sifre,
                                        durumu = (int)_a.durumu,
                                        urunaksesuar = _a.urunaksesuar,
                                        aciklama = _a.aciklama,
                                        arizabedeli = (int)_a.arizabedeli,
                                        serviskapsam = (int)_a.serviskapsam,
                                        kayittarih = _a.kayittarih,
                                        _teknik = new OPersonel { personel_ = _t.personel_, adi = _t.adi, soyadi = _t.soyadi },
                                        _personel = new OPersonel { personel_ = _p.personel_, adi = _p.adi, soyadi = _p.soyadi },//genişletilebilir
                                        _musteri = new OMusteri { musteri_ = _m.arizamusterisi_, adi = _m.adi, soyadi = _m.soyadi, tel = _m.tel },//genişletilebilir
                                        _foto = _a.arizaliurunfotograf.Select(r => new OFotograf { url = r.url }).ToList(),
                                        _asama = _a.arizaliurunasamasi.Select(a => new OAsama
                                        {
                                            asama_ = a.arizaliurunasamasi_,
                                            //asamasayisi = (int)a.asamasayisi,
                                            aciklama = a.aciklama,
                                            personel_ = a.personel.personel_
                                        }).ToList()
                                    }).ToList();
                    return new OIslemSonuc<List<OArizaliurun>>
                    {
                        basarliMi = true,
                        veri = kayitlar
                    };
                }
                else //sadece tarih doluysa
                {
                    var kayitlar = (from _a in Entity.arizaliurun
                                    join _m in Entity.arizamusterisi on _a.arizamusterisi_ equals _m.arizamusterisi_
                                    join _p in Entity.personel on _a.personel_ equals _p.personel_
                                    join _t in Entity.personel on _a.teknikeleman_ equals _t.personel_
                                    where _a.durumu == 4
                                    && (_a.kayittarih.Value.Year == tarih.Year && _a.kayittarih.Value.Month == tarih.Month && _a.kayittarih.Value.Day == tarih.Day)
                                    select new OArizaliurun
                                    {
                                        aurun_ = _a.arizaliurun_,
                                        urunadi = _a.urunadi,
                                        urunmodel = _a.model,
                                        urunkodu = _a.urunkodu,
                                        tespitedilenariza = _a.tespitedilenariza,
                                        ariza = _a.ariza,
                                        sifre = _a.sifre,
                                        durumu = (int)_a.durumu,
                                        urunaksesuar = _a.urunaksesuar,
                                        aciklama = _a.aciklama,
                                        arizabedeli = (int)_a.arizabedeli,
                                        serviskapsam = (int)_a.serviskapsam,
                                        kayittarih = _a.kayittarih,
                                        _teknik = new OPersonel { personel_ = _t.personel_, adi = _t.adi, soyadi = _t.soyadi },
                                        _personel = new OPersonel { personel_ = _p.personel_, adi = _p.adi, soyadi = _p.soyadi },//genişletilebilir
                                        _musteri = new OMusteri { musteri_ = _m.arizamusterisi_, adi = _m.adi, soyadi = _m.soyadi, tel = _m.tel },//genişletilebilir
                                        _foto = _a.arizaliurunfotograf.Select(r => new OFotograf { url = r.url }).ToList(),
                                        _asama = _a.arizaliurunasamasi.Select(a => new OAsama
                                        {
                                            asama_ = a.arizaliurunasamasi_,
                                            //asamasayisi = (int)a.asamasayisi,
                                            aciklama = a.aciklama,
                                            personel_ = a.personel.personel_
                                        }).ToList()
                                    }).ToList();
                    return new OIslemSonuc<List<OArizaliurun>>
                    {
                        basarliMi = true,
                        veri = kayitlar
                    };
                }
                

            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OArizaliurun>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizaliurun",
                        method = "aGecmistekiUrunler"
                    }
                };
            }
        }//aGecmistekiListesi()

        ///<ozet>
        ///Arızalı ürün aşaması
        ///</ozet>

        //Arızalı ürün aşaması ekleme
        protected OIslemSonuc<bool> aAsamaEkle(OAsama _a)
        {
            try
            {
                var kayit = new arizaliurunasamasi
                {
                    arizaliurun_ = _a.arizaliurun_,
                    personel_ = _a._personel.personel_,
                    //personel_=_a.personel_,
                    //asamasayisi =_a.asamasayisi,
                    aciklama = _a.aciklama,
                    tarih = _a.tarih,
                    gordu=_a.gordu
                    
                };
                Entity.arizaliurunasamasi.Add(kayit);
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
                        sinif = "DArizaliurun",
                        method = "aAsamaEkle"
                    }

                };
            }
        }//aAsamaEkle()

        //Arizalı ürün aşaması güncelleme
        protected OIslemSonuc<bool> aAsamaGuncelle(OAsama _a)
        {
            try
            {
                var kayitlar = (from a in Entity.arizaliurunasamasi
                                where a.arizaliurunasamasi_ == _a.asama_
                                select a);
                if (kayitlar.Count() > 0)
                {
                    var k = kayitlar.FirstOrDefault();
                    k.aciklama = _a.aciklama;
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
                        sinif = "DArizaliurun",
                        method = "aAsamaGuncelle"
                    }

                };
            }
        }//AsamaGuncelle()

        //Arızalı ürün aşama silme
        protected OIslemSonuc<bool> aAsamaSil(int id)
        {
            try
            {
                var kayitlar = (from a in Entity.arizaliurunasamasi where a.arizaliurunasamasi_ == id select a);
                if (kayitlar.Count() > 0)
                {
                    var kayit = kayitlar.FirstOrDefault();
                    Entity.arizaliurunasamasi.Attach(kayit);
                    Entity.arizaliurunasamasi.Remove(kayit);
                    Entity.SaveChanges();
                }
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
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizaliurun",
                        method = "aAsamaSil",
                    }
                };
            }
        }//aAsamaSil()

        //Arızalı ürün aşama çoklu silme
        protected OIslemSonuc<bool> aCokluAsamaSil(int arizaliurun_)
        {
            try
            {
                var kayitlar = (from a in Entity.arizaliurunasamasi where a.arizaliurun_ == arizaliurun_ select a);
                if (kayitlar.Count() > 0)
                {
                    var kayit = new arizaliurunasamasi { arizaliurun_ = arizaliurun_ };
                    Entity.arizaliurunasamasi.Attach(kayit);
                    Entity.arizaliurunasamasi.Remove(kayit);
                    Entity.SaveChanges();
                }
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
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizaliurun",
                        method = "acokluAsamaSil",
                    }
                };
            }
        }//aCokluAsamaSil()

        //Arızalı ürün aşama bilgisi
        protected OIslemSonuc<OAsama> aAsamaBilgisi(int id)
        {
            try
            {
                var kayit = (from a in Entity.arizaliurunasamasi where a.arizaliurunasamasi_== id select a);
                if (kayit.Count() > 0)
                {
                    var _a = kayit.FirstOrDefault();
                    return new OIslemSonuc<OAsama>
                    {
                        basarliMi = true,
                        veri = new OAsama
                        {
                            asama_ = _a.arizaliurunasamasi_,
                            asamasayisi = (int)_a.asamasayisi,
                            aciklama = _a.aciklama,
                            personel_ = _a.personel.personel_
                        }
                    };
                }
                else
                {
                    return new OIslemSonuc<OAsama>
                    {
                        basarliMi = false,
                        mesaj = "Kayıt bulunamadı."
                    };
                }
            }
            catch (Exception e)
            {
                return new OIslemSonuc<OAsama>
                {
                    basarliMi = false,
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizaliurun",
                        method = "aAsamaBilgisi"
                    }
                };
            }
        }//aAsamaBilgisi()

        //Arızalı ürün aşama listesi
        protected OIslemSonuc<List<OAsama>> aAsamaListesi(int arizaliurun_)
        {
            try
            {
                var kayitlar = (from a in Entity.arizaliurunasamasi where a.arizaliurun_ == arizaliurun_ select new OAsama
                {
                    asama_ = a.arizaliurunasamasi_,
                    asamasayisi = (int)a.asamasayisi,
                    aciklama = a.aciklama,
                    personel_ = a.personel.personel_
                }).ToList();
                return new OIslemSonuc<List<OAsama>>
                {
                    basarliMi = true,
                    veri = kayitlar
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OAsama>>
                {
                    basarliMi = false,
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DArizaliurun",
                        method = "aAsamalistesi"
                    }
                };
            }
        }//aAsamaListesi()

    }
}
