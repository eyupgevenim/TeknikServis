using System;
using System.Drawing;
using System.Windows.Forms;

using BL;
using OBJ;

namespace TeknikServis
{
    public partial class frmBilgileriniGuncelle : Form
    {
        public OPersonel p;
        public frmYonetici _frmYonetici;
        public frmYoneticiAsistan _frmYoneticiAsistan;
        public frmSatisEleman _frmSatisEleman;
        public frmSekreter _frmSekreter;
        public frmTeknikEleman _frmTeknikEleman;

        public frmBilgileriniGuncelle()
        {
            InitializeComponent();
        }

        private void frmBilgileriniGuncelle_Load(object sender, EventArgs e)
        {
            if (_frmYonetici == null)
            {
                this.ClientSize=new Size(333, 480);
                this.Location= new Point(400, 100);

                gC_kisiselBilgiler.Visible = false;
                gC_iletisimBilgiler.Location = new Point(0, 0);

                btn_kaydet.Location = new Point(185, 9);
                btn_İptal.Location = new Point(9, 9);

            }

            if (_frmYonetici != null)
            {
                p = new BPersonel().personelBilgisi(_frmYonetici.personel_).veri;
                this.Location = new Point(350, 100);
            }
            else if (_frmYoneticiAsistan != null)
            {
                p = new BPersonel().personelBilgisi(_frmYoneticiAsistan.personel_).veri;
            }
            else if (_frmSatisEleman != null)
            {
                p = new BPersonel().personelBilgisi(_frmSatisEleman.personel_).veri;
            }
            else if (_frmSekreter != null)
            {
                p = new BPersonel().personelBilgisi(_frmSekreter.personel_).veri;
            }
            else if (_frmTeknikEleman != null)
            {
                p = new BPersonel().personelBilgisi(_frmTeknikEleman.personel_).veri;
            }


            txt_ad.Text = p.adi.Trim();
            txt_soyad.Text = p.soyadi.Trim();
            txt_tcno.Text = p.tcno.Trim();
            dE_dogumTarih.DateTime = p.dogumtarihi;

            cBox_cinsiyet.SelectedIndex = p.cinsiyet == "K" ? 0 : 1;

            cBox_egitimDurumu.SelectedIndex = p.egitimdurumu == 1 ? 0
                : p.egitimdurumu == 2 ? 1
                : p.egitimdurumu == 3 ? 2 : 3;

            cBox_unvan.Enabled = false;
            cBox_unvan.SelectedIndex = p.personelTipi_ == 1 ? 0
                : p.personelTipi_ == 2 ? 1
                : p.personelTipi_ == 3 ? 2 : 3;

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
