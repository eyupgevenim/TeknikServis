using System;
using System.Windows.Forms;

using BL;
using OBJ;

namespace TeknikServis
{
    public partial class pnlFirmaEkle : UserControl
    {
        public pnlFirmaEkle()
        {
            InitializeComponent();
        }

        private void pnlFirmaEkle_Load(object sender, EventArgs e)
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

        //kaydet buttonu
        private void btn_kaydet3_Click(object sender, EventArgs e)
        {
            if(txt_Adi.Text !="" && txt_email.Text !="" 
                && txt_tel1.Text !="" && txt_tel2.Text != "" && rTxt_Adresi.Text !="")
            {
                OFirma f = new OFirma();
                f.firmaadi = txt_Adi.Text;
                f.email = txt_email.Text;
                f.tel1 = txt_tel1.Text;
                f.tel2 = txt_tel2.Text;
                OAdres a = new OAdres();
                a.adres = rTxt_Adresi.Text;
                a.ilce_ = (int)cBox_ilce.SelectedValue;
                a.il_ = (int)cBox_il.SelectedValue;
                f._adres = a;
                var sonuc = new BSatismusterisi().firmaEkle(f);
                if (sonuc.basarliMi)
                {
                    txt_Adi.Text = "";
                    txt_email.Text = "";
                    txt_tel1.Text = ""; txt_tel2.Text = "";
                    rTxt_Adresi.Text = "";
                }
                else
                {
                    MessageBox.Show(sonuc.hataBilgisi.hataMesaj);
                }
            }
            else
            {
                MessageBox.Show("Alanları boş geçemezsiniz !!!");
            }
        }

    }
}
