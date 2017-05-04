using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BL;
using OBJ;

namespace TeknikServis
{
    public partial class frmMusteriGuncelle : Form
    {
        public OMusteri m;
        public pnlMusteriArama mA;

        public frmMusteriGuncelle()
        {
            InitializeComponent();
        }

        //yüklendiğinde
        private void frmMusteriGuncelle_Load(object sender, EventArgs e)
        {
            this.Location = new Point(450, 100);

            txt_ad.Text = m.adi.Trim();
            txt_soyad.Text = m.soyadi.Trim();
            txt_tel.Text = m.tel.Trim();
            txt_email.Text = m.email.Trim();
            rTxt_Adresi.Text = m._adres.adres.Trim();
            
            var sonuc = new BAdres().illeriListele();
            if (sonuc.basarliMi)
            {
                cBox_il.DataSource = sonuc.veri;
                cBox_il.DisplayMember = "il";
                cBox_il.ValueMember = "il_";
                cBox_il.SelectedValue = m._adres.il_;


                var ilceler_sonuc = new BAdres().ilcelerAra((int)cBox_il.SelectedValue);
                if (ilceler_sonuc.basarliMi)
                {
                    cBox_ilce.DataSource = ilceler_sonuc.veri;
                    cBox_ilce.DisplayMember = "ilce";
                    cBox_ilce.ValueMember = "ilce_";
                    cBox_ilce.SelectedValue = m._adres.ilce_;

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

        //kaydet buttonu
        private void btn_kaydet3_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text != "" && txt_soyad.Text != "" && txt_tel.Text != ""
                && txt_email.Text != "" && rTxt_Adresi.Text != "")
            {
                m.adi = txt_ad.Text.Trim();
                m.soyadi = txt_soyad.Text.Trim();
                m.tel = txt_tel.Text.Trim();
                m.email = txt_email.Text.Trim();
                m.dogumtarihi = dE_dogumTarih.DateTime;
                
                m._adres.adres = rTxt_Adresi.Text.Trim();
                m._adres.ilce_ = (int)cBox_ilce.SelectedValue;
                m._adres.il_ = (int)cBox_il.SelectedValue;
                var sonuc = new BSatismusterisi().sMusteriGuncelle(m);
                if (sonuc.basarliMi)
                {

                    mA.gridView1.SetFocusedRowCellValue("adi", m.adi.Trim());
                    mA.gridView1.SetFocusedRowCellValue("soyadi", m.soyadi.Trim());
                    mA.gridView1.SetFocusedRowCellValue("email", m.email.Trim());
                    mA.gridView1.SetFocusedRowCellValue("tel", m.tel.Trim());
                    mA.gridView1.SetFocusedRowCellValue("adres", m._adres.adres.Trim());
                    OAdres _ilce = (OAdres)cBox_ilce.SelectedItem;
                    mA.gridView1.SetFocusedRowCellValue("ilce", _ilce.ilce);
                    OAdres _il = (OAdres)cBox_il.SelectedItem;
                    mA.gridView1.SetFocusedRowCellValue("il", _il.il);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarsız !!!");
                }
            }
            else
            {
                MessageBox.Show("Boş alan geçemezsiniz !!!");
            }
        }
    }
}
