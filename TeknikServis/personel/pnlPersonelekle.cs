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
    public partial class pnlPersonelekle : UserControl
    {
        public pnlPersonelekle()
        {
            InitializeComponent();
        }

        private void pnlPersonelekle_Load(object sender, EventArgs e)
        {
            BAdres _a = new BAdres();
            var sonuc = _a.illeriListele();
            if (sonuc.basarliMi)
            {
                //cBox_il.DropDownStyle = ComboBoxStyle.DropDownList;
                cBox_il.DataSource = sonuc.veri;
                cBox_il.DisplayMember = "il";
                cBox_il.ValueMember = "il_";
                cBox_il.SelectedIndex = 33;


                var ilceler_sonuc = new BAdres().ilcelerAra((int)cBox_il.SelectedValue);
                if (ilceler_sonuc.basarliMi)
                {
                    //cBox_ilce.DropDownStyle = ComboBoxStyle.DropDownList;
                    cBox_ilce.DataSource = ilceler_sonuc.veri;
                    cBox_ilce.DisplayMember = "ilce";
                    cBox_ilce.ValueMember = "ilce_";

                }
                else
                {
                    MessageBox.Show(sonuc.hataBilgisi.hataMesaj);
                }

                this.cBox_il.SelectedIndexChanged +=
                new EventHandler(cBox_il_SelectedIndexChanged);

            }
            else
            {
                MessageBox.Show(sonuc.hataBilgisi.hataMesaj);
            }

            dE_dogumTarih.EditValue = DateTime.Now;
            
            //cBox_cinsiyet.Items.AddRange(new object[] {"Kadın","Erkek"});
            cBox_cinsiyet.SelectedIndex = 0;
            //cBox_cinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;


            //cBox_unvan.Items.AddRange(new object[] { "Yönetici Asistanı", "Satış Elemenı","Sekreter", "Teknik Elemenı" });
            cBox_unvan.SelectedIndex = 0;
            //cBox_unvan.DropDownStyle = ComboBoxStyle.DropDownList;

            //cBox_egitimDurumu.Items.AddRange(new object[] {"İlkokul", "Lise","Üniversite", "Yüksek Lisans" });
            cBox_egitimDurumu.SelectedIndex = 0;
            //cBox_egitimDurumu.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //il combobox değiştiğinde 
        private void cBox_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            BAdres _a = new BAdres();
            //cBox_ilce.Items.Clear();
            var sonuc = _a.ilcelerAra((int)cBox_il.SelectedValue);
            if (sonuc.basarliMi)
            {
                cBox_ilce.DataSource = sonuc.veri;
                cBox_ilce.DisplayMember = "ilce";
                cBox_ilce.ValueMember = "ilce_";

            }
            else
            {
                MessageBox.Show(sonuc.hataBilgisi.hataMesaj);
            }
        }

        // kaydet buttonu click
        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            if (txt_ad.Text != "" && txt_soyad.Text != ""
                && dE_dogumTarih.Text != "" && txt_tcno.Text != ""
                && txt_tel1.Text != "" && txt_tel2.Text != "" && txt_email.Text != ""
                && rTxt_adresi.Text != "")
            {

                OPersonel p = new OPersonel();
                p.adi = txt_ad.Text;
                p.soyadi = txt_soyad.Text;
                p.tcno = txt_tcno.Text;
                p.dogumtarihi = Convert.ToDateTime(dE_dogumTarih.Text);
                p.cinsiyet = cBox_cinsiyet.SelectedIndex == 0 ? "K" : "E";
                //p.cinsiyet = cBox_cinsiyet.SelectedItem.ToString();
                p.egitimdurumu = cBox_egitimDurumu.SelectedIndex + 1;
                //p.maas = Convert.ToDouble(txt_maas.Text);
                p.maas = Convert.ToDouble(nUd_maas.Value);
                p.personelTipi_ = cBox_unvan.SelectedIndex + 2;
                p.email = txt_email.Text;
                p.tel1 = txt_tel1.Text;
                p.tel2 = txt_tel2.Text;
                p.sil = false;
                p.sifre = "202cb962ac59075b964b07152d234b70";
                OAdres a = new OAdres();
                a.il_ = (int)cBox_il.SelectedValue;
                a.ilce_ = (int)cBox_ilce.SelectedValue;
                a.adres = rTxt_adresi.Text;
                p.adres = a;

                var sonuc = new BPersonel().personelEkle(p);
                if (sonuc.basarliMi)
                {
                    txt_ad.Text = "";
                    txt_soyad.Text = "";
                    txt_tcno.Text = "";
                    //dE_dogumTarih.Text = "";
                    txt_tel1.Text = "";
                    txt_tel2.Text = "";
                    txt_email.Text = "";
                    rTxt_adresi.Text = "";
                    nUd_maas.Value = 0;
                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }

            }
            else
            {
                MessageBox.Show("Boş Alan Geçemezsiniz !!!");
            }
        }//kaydet click

    }
}
