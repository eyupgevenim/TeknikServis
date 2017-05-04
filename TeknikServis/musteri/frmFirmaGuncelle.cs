using System;
using System.Windows.Forms;

using BL;
using OBJ;

namespace TeknikServis
{
    public partial class frmFirmaGuncelle : Form
    {
        public pnlFirmaListeleme fl;
        public OFirma f;

        public frmFirmaGuncelle()
        {
            InitializeComponent();
        }

        //form yüklendiğinde
        private void frmFirmaGuncelle_Load(object sender, EventArgs e)
        {
            txt_Adi.Text = f.firmaadi.Trim();
            txt_tel1.Text = f.tel1.Trim();
            txt_tel2.Text = f.tel2.Trim();
            txt_email.Text = f.email.Trim();
            rTxt_Adresi.Text = f._adres.adres.Trim();

            var sonuc = new BAdres().illeriListele();
            if (sonuc.basarliMi)
            {
                cBox_il.DataSource = sonuc.veri;
                cBox_il.DisplayMember = "il";
                cBox_il.ValueMember = "il_";
                cBox_il.SelectedValue = f._adres.il_;


                var ilceler_sonuc = new BAdres().ilcelerAra((int)cBox_il.SelectedValue);
                if (ilceler_sonuc.basarliMi)
                {
                    cBox_ilce.DataSource = ilceler_sonuc.veri;
                    cBox_ilce.DisplayMember = "ilce";
                    cBox_ilce.ValueMember = "ilce_";
                    cBox_ilce.SelectedValue = f._adres.ilce_;

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

        private void cBox_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sonuc = new BAdres().ilcelerAra((int)cBox_il.SelectedValue);
            if (sonuc.basarliMi)
            {
                cBox_ilce.DataSource = sonuc.veri;
                cBox_ilce.DisplayMember = "ilce";
                cBox_ilce.ValueMember = "ilce_";

            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }
        }

        //kaydet buttonu
        private void btn_kaydet3_Click(object sender, EventArgs e)
        {
            if (txt_Adi.Text != "" && txt_email.Text != ""
                && txt_tel1.Text != "" && txt_tel2.Text != "" && rTxt_Adresi.Text != "")
            {
                f.firmaadi = txt_Adi.Text.Trim();
                f.email = txt_email.Text.Trim();
                f.tel1 = txt_tel1.Text.Trim();
                f.tel2 = txt_tel2.Text.Trim();

                f._adres.adres = rTxt_Adresi.Text.Trim();
                f._adres.ilce_ = (int)cBox_ilce.SelectedValue;
                f._adres.il_ = (int)cBox_il.SelectedValue;

                var sonuc= new BSatismusterisi().firmaGuncelle(f);
                if (sonuc.basarliMi)
                {
                    fl.gridView1.SetFocusedRowCellValue("adi", f.firmaadi);
                    fl.gridView1.SetFocusedRowCellValue("email", f.email);
                    fl.gridView1.SetFocusedRowCellValue("tel1", f.tel1);
                    fl.gridView1.SetFocusedRowCellValue("tel2", f.tel2);
                    fl.gridView1.SetFocusedRowCellValue("adres", f._adres.adres);
                    OAdres _ilce = (OAdres)cBox_ilce.SelectedItem;
                    fl.gridView1.SetFocusedRowCellValue("ilce", _ilce.ilce);
                    OAdres _il = (OAdres)cBox_il.SelectedItem;
                    fl.gridView1.SetFocusedRowCellValue("il", _il.il);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
            else
            {
                MessageBox.Show("Alanları boş geçemezsiniz !!!");
            }
        }
        
    }
}
