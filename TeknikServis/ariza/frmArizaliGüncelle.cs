using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BL;
using OBJ;

namespace TeknikServis
{
    public partial class frmArizaliGüncelle : Form
    {
        public pnlServistekiArizaliUrunler sau;
        public pnlTeknikServisEleman tse;
        OArizaliurun a ;

        Image durum = null;
        Image tamirde = Image.FromFile("..\\..\\img\\tamirde64x64.png");
        Image bittiYapildi = Image.FromFile("..\\..\\img\\bittiYapildi64x64.png");
        Image bittiYapilamadi = Image.FromFile("..\\..\\img\\bittiYapilamadi64x64.png");

        public frmArizaliGüncelle()
        {
            InitializeComponent();
        }

        private void frmArizaliGüncelle_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450,50);
            
            if (sau != null)
                a = sau.au;
            else if (tse != null)
                a = tse.au;

            var sonuc = new BPersonel().tipeGoreAra(5);
            if (sonuc.basarliMi)
            {
                cBox_teknikEleman.DataSource = sonuc.veri;
                cBox_teknikEleman.ValueMember = "personel_";
                cBox_teknikEleman.DisplayMember = "adi";
            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }

            txt_urunadi.Text = a.urunadi.Trim();
            txt_urunmodel.Text = a.urunmodel.Trim();
            txt_urunserino.Text = a.urunkodu.Trim();
            txt_urunAksesuar.Text = a.urunaksesuar.Trim();
            txt_urunSifre.Text = a.sifre.Trim();
            txt_urunBilgi.Text = a.aciklama.Trim();
            txt_urunbildirilenariza.Text = a.ariza.Trim();
            rTxt_tespitedilenAriza.Text = a.tespitedilenariza.Trim();
            cBox_teknikEleman.SelectedValue = a._teknik.personel_;
            cBox_durum.SelectedIndex = a.durumu - 1;
        }

        //kaydet buttonu
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_urunadi.Text.Trim() != "" && txt_urunmodel.Text.Trim() != "" 
                && txt_urunserino.Text.Trim() != ""  && txt_urunAksesuar.Text.Trim() != ""
                && txt_urunSifre.Text.Trim() != "" && txt_urunBilgi.Text.Trim() != "" 
                && txt_urunbildirilenariza.Text.Trim() != "" && rTxt_tespitedilenAriza.Text.Trim() != "")
            {
                a.urunadi = txt_urunadi.Text.Trim();
                a.urunmodel = txt_urunmodel.Text.Trim();
                a.urunkodu = txt_urunserino.Text.Trim();
                a.urunaksesuar = txt_urunAksesuar.Text.Trim();
                a.sifre = txt_urunSifre.Text.Trim();
                a.aciklama = txt_urunBilgi.Text.Trim();
                a.ariza = txt_urunbildirilenariza.Text.Trim();
                a.tespitedilenariza = rTxt_tespitedilenAriza.Text.Trim();
                OPersonel t = new OPersonel();
                t.personel_ = (int)cBox_teknikEleman.SelectedValue;
                a._teknik = t;
                a.durumu = cBox_durum.SelectedIndex + 1;

                var sonuc = new BArizaliurun().aUrunGuncelle(a);
                if (sonuc.basarliMi)
                {
                    if (a.durumu == 1) //tamirde
                    {
                        durum = tamirde;
                    }
                    else if (a.durumu == 2) //yapıldı bitti
                    {
                        durum = bittiYapildi;
                    }
                    else if (a.durumu == 3) //yapılamadı bitti
                    {
                        durum = bittiYapilamadi;
                    }

                    if (sau != null)
                    {
                        sau.gridView1.SetFocusedRowCellValue("cihaz", a.urunadi);
                        sau.gridView1.SetFocusedRowCellValue("durum", durum);
                        if(a.durumu == 4)
                            sau.row.Delete();
                        this.Close();
                    }
                    else if (tse != null)
                    {
                        tse.gridView1.SetFocusedRowCellValue("cihaz", a.urunadi);
                        tse.gridView1.SetFocusedRowCellValue("durum", durum);
                        if (a.durumu == 4)
                            sau.row.Delete();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Boş Alan geçemezsiniz !!!");
                }
                

            }
            else
            {
                MessageBox.Show("Boş Alan geçemezsiniz !!!");
            }

        }
    }
}
