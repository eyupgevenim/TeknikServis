using System;
using System.Windows.Forms;

using BL;
using OBJ;

namespace TeknikServis
{
    public partial class frmStokGüncelle : Form
    {
        public pnlStokArama uA;
        public pnlTumUrunListesi tul;
        public OUrun u;

        public frmStokGüncelle()
        {
            InitializeComponent();
        }

        //form yüklendiğinde
        private void frmStokGüncelle_Load(object sender, EventArgs e)
        {
            var katagori = new BUrun().katagoriListele();
            var marka = new BUrun().markaListele();
            if (katagori.basarliMi && marka.basarliMi)
            {

                cBox_katagori.DataSource = katagori.veri;
                cBox_katagori.ValueMember = "katagori_";
                cBox_katagori.DisplayMember = "katagoriadi";
                cBox_katagori.SelectedValue = u._katagori.katagori_;

                cBox_marka.DataSource = marka.veri;
                cBox_marka.ValueMember = "marka_";
                cBox_marka.DisplayMember = "markaadi";
                cBox_marka.SelectedValue = u._marka.marka_;

            }
            else
            {
                MessageBox.Show(katagori.hataBilgisi.hataMesaj + "\n" + marka.hataBilgisi.hataMesaj);
            }

            txt_model.Text = u.modeladi.Trim();
            nUd_stokAdeti.Value = u.stoksayisi;
            txt_gelisfiyat.Text = u.ucret.ToString();
            dT_tarih.Value = u.tarih;

        }

        //kaydet buttonu
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_model.Text != "" && txt_gelisfiyat.Text != "" && dT_tarih.Text != "")
            {
                OKatagori k = (OKatagori)cBox_katagori.SelectedItem;

                OMarka m = (OMarka)cBox_marka.SelectedItem;
                
                u.modeladi = txt_model.Text;
                u.stoksayisi = (int)nUd_stokAdeti.Value;
                u.ucret = Convert.ToDouble(txt_gelisfiyat.Text);
                u.tarih = dT_tarih.Value;
                u._katagori = k;
                u._marka = m;

                var sonuc = new BUrun().urunGuncelle(u);
                if (sonuc.basarliMi)
                {
                    if(uA != null)
                    {
                        uA.gridView1.SetFocusedRowCellValue("model", u.modeladi);
                        uA.gridView1.SetFocusedRowCellValue("stokadeti", u.stoksayisi);
                        uA.gridView1.SetFocusedRowCellValue("ucret", u.ucret);
                        uA.gridView1.SetFocusedRowCellValue("tarih", u.tarih);
                        uA.gridView1.SetFocusedRowCellValue("marka", m.markaadi);
                        uA.gridView1.SetFocusedRowCellValue("katagori", k.katagoriadi);
                    }
                    else if(tul != null)
                    {
                        tul.gridView1.SetFocusedRowCellValue("model", u.modeladi);
                        tul.gridView1.SetFocusedRowCellValue("stokadeti", u.stoksayisi);
                        tul.gridView1.SetFocusedRowCellValue("ucret", u.ucret);
                        tul.gridView1.SetFocusedRowCellValue("tarih", u.tarih);
                        tul.gridView1.SetFocusedRowCellValue("marka", m.markaadi);
                        tul.gridView1.SetFocusedRowCellValue("katagori", k.katagoriadi);
                    }
                    

                    this.Close();
                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
            else
            {
                MessageBox.Show("Boş alan geçemezsiniz !!!");
            }
        }
    }
}
