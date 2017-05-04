using System;
using System.Windows.Forms;
using System.Drawing;

using BL;
using OBJ;


namespace TeknikServis
{
    public partial class frmPersonelGuncelle : Form
    {
        public OPersonel p;
        public pnlPersonellistele pL;

        public frmPersonelGuncelle()
        {
            InitializeComponent();
        }

        private void frmPersonelguncelle_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 100);

            txt_ad.Text = p.adi.Trim();
            txt_soyad.Text = p.soyadi.Trim();
            txt_tcno.Text = p.tcno.Trim();
            dE_dogumTarih.DateTime = p.dogumtarihi;
            cBox_cinsiyet.SelectedIndex = p.cinsiyet == "K" ? 0 : 1;
            cBox_egitimDurumu.SelectedIndex = p.egitimdurumu == 1 ? 0
                : p.egitimdurumu == 2 ? 1
                : p.egitimdurumu == 3 ? 2 : 3;
            cBox_unvan.SelectedIndex = p.personelTipi_ == 2 ? 0
                : p.personelTipi_ == 3 ? 1
                : p.personelTipi_ == 4 ? 2 : 3;
            txt_tel1.Text = p.tel1.Trim();
            txt_tel2.Text = p.tel2.Trim();
            txt_email.Text = p.email.Trim();
            rTxt_adresi.Text = p.adres.adres.Trim();
            nUd_maas.Value = (int)p.maas;

            var sonuc = new BAdres().illeriListele();
            if (sonuc.basarliMi)
            {
                cBox_il.DataSource = sonuc.veri;
                cBox_il.DisplayMember = "il";
                cBox_il.ValueMember = "il_";
                cBox_il.SelectedValue = p.adres.il_;


                var ilceler_sonuc = new BAdres().ilcelerAra((int)cBox_il.SelectedValue);
                if (ilceler_sonuc.basarliMi)
                {
                    cBox_ilce.DataSource = ilceler_sonuc.veri;
                    cBox_ilce.DisplayMember = "ilce";
                    cBox_ilce.ValueMember = "ilce_";
                    cBox_ilce.SelectedValue = p.adres.ilce_;

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

        }

        // il comboboxı değiştiğinde 
        private void cBox_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cBox_ilce.Items.Clear();
            var sonuc = new BAdres().ilcelerAra((int)cBox_il.SelectedValue);
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

        // kaydet buttonu
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text != "" && txt_soyad.Text != ""
                && dE_dogumTarih.Text != "" && txt_tcno.Text != ""
                && txt_tel1.Text != "" && txt_tel2.Text != "" && txt_email.Text != ""
                && rTxt_adresi.Text != "")
            {
                
                p.adi = txt_ad.Text;
                p.soyadi = txt_soyad.Text;
                p.tcno = txt_tcno.Text;
                p.dogumtarihi = Convert.ToDateTime(dE_dogumTarih.Text);
                p.cinsiyet = cBox_cinsiyet.SelectedIndex == 0 ? "K" : "E";
                p.egitimdurumu = cBox_egitimDurumu.SelectedIndex + 1;
                p.maas = Convert.ToDouble(nUd_maas.Value);
                p.personelTipi_ = cBox_unvan.SelectedIndex + 2;
                p.email = txt_email.Text;
                p.tel1 = txt_tel1.Text;
                p.tel2 = txt_tel2.Text;

                OAdres a = new OAdres();
                a.il_ = (int)cBox_il.SelectedValue;
                a.ilce_ = (int)cBox_ilce.SelectedValue;
                a.adres = rTxt_adresi.Text;
                p.adres = a;


                var sonuc = new BPersonel().personelGuncelle(p);
                if (sonuc.basarliMi)
                {
                    pL.gridView1.SetFocusedRowCellValue("adi", p.adi);
                    pL.gridView1.SetFocusedRowCellValue("soyadi", p.soyadi);
                    pL.gridView1.SetFocusedRowCellValue("tc", p.tcno);
                    pL.gridView1.SetFocusedRowCellValue("dogumtarih", p.dogumtarihi);
                    pL.gridView1.SetFocusedRowCellValue("cinsiyet", cBox_cinsiyet.SelectedItem);
                    pL.gridView1.SetFocusedRowCellValue("egitimdurum", cBox_egitimDurumu.SelectedItem);
                    pL.gridView1.SetFocusedRowCellValue("unvan", cBox_unvan.SelectedItem);
                    pL.gridView1.SetFocusedRowCellValue("maas", p.maas);
                    pL.gridView1.SetFocusedRowCellValue("email", p.email);
                    pL.gridView1.SetFocusedRowCellValue("tel1", p.tel1);
                    pL.gridView1.SetFocusedRowCellValue("tel2", p.tel2);
                    pL.gridView1.SetFocusedRowCellValue("adres", p.adres.adres);
                    OAdres _ilce = (OAdres)cBox_ilce.SelectedItem;
                    pL.gridView1.SetFocusedRowCellValue("ilce", _ilce.ilce);
                    OAdres _il = (OAdres)cBox_il.SelectedItem;
                    pL.gridView1.SetFocusedRowCellValue("il", _il.il);

                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show(sonuc.hataBilgisi.hataMesaj);
                }

            }
            else
            {
                MessageBox.Show("Boş Alan Geçemezsiniz !!!");
            }
        }

        //iptal buttonu
        private void btn_İptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
