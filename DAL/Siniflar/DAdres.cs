using System;
using System.Collections.Generic;
using System.Linq;
using OBJ;

namespace DAL.Siniflar
{
    public class DAdres:DBaglanti
    {
        //Adres ekleme
        protected OIslemSonuc<int> adresEkleme(OAdres _a)
        {
            try
            {
                var yeniAdres = new adres
                {
                    acikadres = _a.adres,
                    ilce_ = _a.ilce_
                };
                Entity.adres.Add(yeniAdres);
                Entity.SaveChanges();
                int adres_ = yeniAdres.adres_;
                if(adres_ > 0 )
                { 
                    return new OIslemSonuc<int>
                    {
                        basarliMi = true,
                        veri = adres_

                    };
                }
                else
                {
                    return new OIslemSonuc<int>
                    {
                        basarliMi = false,
                        veri=-1,
                        mesaj = "Adres kaydedilmedi !"
                    };
                }

            }
            catch (Exception e)
            {
                return new OIslemSonuc<int>
                {
                    basarliMi = false,
                    veri=-1,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DAdres",
                        method = "adresEkle"
                    }

                };
            }
        }//adresEkle()

        //Adres güncelleme
        protected OIslemSonuc<bool> adresGuncelleme(OAdres _a)
        {
            try
            {
                var kayit = (from a in Entity.adres
                                where a.adres_ == _a.adres_
                                select a);
                if (kayit.Count() > 0)
                {
                    var k = kayit.FirstOrDefault();
                    k.acikadres = _a.adres;
                    k.ilce_ = _a.ilce_;
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
                        sinif = "DAdres",
                        method = "adresGuncelle"
                    }

                };
            }
        }//adresGuncelleme()

        //Adres Bilgisi görüntüleme
        protected OIslemSonuc<OAdres> adresBilgisi(int id)
        {
            try
            {
                var kayit = (from a in Entity.adres where a.adres_ == id select a);

                if (kayit.Count() > 0)
                {
                    var _a= kayit.FirstOrDefault();
                    return new OIslemSonuc<OAdres>
                    {
                        basarliMi = true,
                        veri = new OAdres
                        {
                            adres_ = _a.adres_,
                            adres = _a.acikadres,
                            ilce_ = _a.ilce.ilce_,
                            ilce = _a.ilce.ilceadi,
                            il_ = _a.ilce.il.il_,
                            il = _a.ilce.il.iladi
                        }

                    };
                }
                else
                {
                    return new OIslemSonuc<OAdres>
                    {
                        basarliMi = false,
                        mesaj = "Adres kaydedilmedi !"
                    };
                }

            }
            catch (Exception e)
            {
                return new OIslemSonuc<OAdres>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DAdres",
                        method = "adresBilgisi"
                    }

                };
            }
        }//adresBilgisi()

        // Tüm illeri listeleme
        protected OIslemSonuc<List<OAdres>> illeriListele()
        {
            try
            {
                var iller = (from i in Entity.il
                             select new OAdres
                             {
                                 il_ = i.il_,
                                 il = i.iladi
                             });

                return new OIslemSonuc<List<OAdres>>
                {
                    basarliMi = true,
                    veri = iller.ToList()
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OAdres>>
                {
                    basarliMi = false,
                    mesaj="Bir hatayla karşılaştı !!",
                    hataBilgisi=new OHata
                    {
                        hataMesaj=e.Message,
                        sinif="DAdres",
                        method="illeriListele"
                    }
                };
            }
        }

        // illin ilcelerini listeleme
        protected OIslemSonuc<List<OAdres>> ilcelerAra(int _il)
        {
            try
            {
                var ilceler = (from i in Entity.ilce
                               where i.il_== _il
                               select new OAdres
                               {
                                   il_ = i.il.il_,
                                   ilce_ = i.ilce_,
                                   ilce=i.ilceadi
                               });

                return new OIslemSonuc<List<OAdres>>
                {
                    basarliMi = true,
                    veri = ilceler.ToList()
                };
            }
            catch (Exception e)
            {
                return new OIslemSonuc<List<OAdres>>
                {
                    basarliMi = false,
                    mesaj = "Bir hatayla karşılaştı !!",
                    hataBilgisi = new OHata
                    {
                        hataMesaj = e.Message,
                        sinif = "DAdres",
                        method = "ilceAra"
                    }
                };
            }
        }
    }
}
