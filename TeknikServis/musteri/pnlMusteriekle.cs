using System;
using System.Windows.Forms;

using BL;
using OBJ;

namespace TeknikServis
{
    public partial class pnlMusteriekle : UserControl
    {
        public int firma_ = 1;

        public pnlMusteriekle()
        {
            InitializeComponent();
        }

        //panel yüklendiğinde
        private void pnlMusteriekle_Load(object sender, EventArgs e)
        {
            BAdres _a = new BAdres();
            var sonuc = _a.illeriListele();
            if (sonuc.basarliMi)
            {
                cBox_il.DataSource = sonuc.veri;
                cBox_il.DisplayMember = "il";
                cBox_il.ValueMember = "il_";
                cBox_il.SelectedIndex = 33;


                var ilceler_sonuc = new BAdres().ilcelerAra((int)cBox_il.SelectedValue);
                if (ilceler_sonuc.basarliMi)
                {
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
        }

        //il combobox değiştiğinde 
        private void cBox_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            BAdres _a = new BAdres();
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

        //firma seçe buttonu
        private void btnE_firmaAd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmFirmaSec fa = new frmFirmaSec();
            fa.mE = this;
            fa.ShowDialog();
        }
        
        // firma check box ı değiştiğinde 
        private void cBox_firma_CheckedChanged(object sender, EventArgs e)
        {
            if (check_firma.Checked)
            {
                btnE_firmaAd.Enabled = true;
            }
            else
            {
                btnE_firmaAd.Enabled = false;
                firma_ = 1;
            }
        }

        // kaydet buttonu
        private void btn_kaydet3_Click(object sender, EventArgs e)
        {
            if(txt_ad.Text !="" && txt_soyad.Text !="" && txt_tel.Text !="" 
                && txt_email.Text !="" && rTxt_Adresi.Text != "")
            {
                if (firma_==1 && check_firma.Checked)
                {
                    MessageBox.Show("Firmayı seçmelisiniz !!!");
                }
                else
                {
                    OMusteri m = new OMusteri();
                    m.adi = txt_ad.Text.Trim();
                    m.soyadi= txt_soyad.Text.Trim();
                    m.tel= txt_tel.Text.Trim();
                    m.email= txt_email.Text.Trim();
                    m.dogumtarihi = dE_dogumTarih.DateTime;
                    m.kayittarihi = DateTime.Now;
                    OAdres a = new OAdres();
                    a.adres = rTxt_Adresi.Text;
                    a.ilce_ = (int)cBox_ilce.SelectedValue;
                    a.il_ = (int)cBox_il.SelectedValue;
                    OFirma f = new OFirma();
                    f.firma_ = firma_;
                    m._adres = a;
                    m._firma = f;
                    var sonuc = new BSatismusterisi().sMusteriEkle(m);
                    if (sonuc.basarliMi)
                    {
                        txt_ad.Text = "";
                        txt_soyad.Text = "";
                        txt_tel.Text = "";
                        txt_email.Text = "";
                        rTxt_Adresi.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Başarsız !!!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Boş alan geçemezsiniz !!!");
            }
        }

    }
}
