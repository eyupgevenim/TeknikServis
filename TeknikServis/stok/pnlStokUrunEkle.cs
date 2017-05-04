using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BL;
using OBJ;

namespace TeknikServis
{
    public partial class pnlStokUrunEkle : UserControl
    {
        public pnlStokUrunEkle()
        {
            InitializeComponent();
        }

        private void pnlStokUrunEkle_Load(object sender, EventArgs e)
        {
            var katagori = new BUrun().katagoriListele();
            var marka = new BUrun().markaListele();
            if(katagori.basarliMi && marka.basarliMi)
            {

                cBox_katagori.DataSource = katagori.veri;
                cBox_katagori.ValueMember = "katagori_";
                cBox_katagori.DisplayMember = "katagoriadi";
                cBox_katagori.SelectedIndex = 0;

                cBox_marka.DataSource = marka.veri;
                cBox_marka.ValueMember = "marka_";
                cBox_marka.DisplayMember = "markaadi";
                cBox_marka.SelectedIndex = 0;

            }
            else
            {
                MessageBox.Show(katagori.mesaj + "\n" + marka.mesaj);
            }

        }

        //kaydet buttonu
        private void btn_kaydet01_Click(object sender, EventArgs e)
        {
            if(txt_model.Text !="" && txt_gelisFiyati.Text != "" && dT_kayitTarih.Text !="")
            {
                OKatagori k = new OKatagori();
                k.katagori_ = (int)cBox_katagori.SelectedValue;

                OMarka m = new OMarka();
                m.marka_ = (int)cBox_marka.SelectedValue;

                OUrun u = new OUrun();
                u.modeladi = txt_model.Text;
                u.stoksayisi = (int)nUd_stokAdeti.Value;
                u.ucret = Convert.ToDouble(txt_gelisFiyati.Text);
                u.tarih = dT_kayitTarih.Value;
                u._katagori = k;
                u._marka = m;

                var sonuc = new BUrun().urunEkle(u);
                if (sonuc.basarliMi)
                {
                    txt_model.Text = "";
                    txt_gelisFiyati.Text = "";
                    nUd_stokAdeti.Value = 0;
                    MessageBox.Show("Kayıt Başarlı ");
                }
                else
                {
                    MessageBox.Show(sonuc.hataBilgisi.hataMesaj);
                }
            }
            else
            {
                MessageBox.Show("Boş alan geçemezsiniz !!!");
            }
        }
    }
}
