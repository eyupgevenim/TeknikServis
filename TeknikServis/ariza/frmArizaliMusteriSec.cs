using System;
using System.Data;
using System.Windows.Forms;

using BL;
using OBJ;

namespace TeknikServis
{
    public partial class frmArizaliMusteriSec : Form
    {
        public pnlArizaKayit _pnlArizaKayit;
        DataTable t;
        bool satisMusterisiMi =false;

        public frmArizaliMusteriSec()
        {
            InitializeComponent();
        }

        //Yüklendiğinde
        private void frmArizaliMusteriSec_Load(object sender, EventArgs e)
        {
            t = new DataTable();
            t.Columns.Add("id", typeof(int));

            t.Columns.Add("adi", typeof(string));
            t.Columns["adi"].Caption = "ADI";
            t.Columns.Add("soyadi", typeof(string));
            t.Columns["soyadi"].Caption = "SOYADI";
            t.Columns.Add("tel", typeof(string));
            t.Columns["tel"].Caption = "TELEFON";
            t.Columns.Add("email", typeof(string));
            t.Columns["email"].Caption = "EMAİL";
            

            gridControl1.DataSource = t;
            gridView1.Columns["id"].Visible = false;
        }

        //tenizle buttonu
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_ara.Text = "";
            t.Rows.Clear();
        }

        //Ara buttonu
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (txt_ara.Text.Trim() != "")
            {
                if (rBtn_ariza.Checked)//arıza müşterisi arama
                {
                    t.Rows.Clear();
                    var sonuc = new BArizamusterisi().aMusteriAra(txt_ara.Text.Trim(), "", "");
                    if (sonuc.basarliMi)
                    {
                        foreach (var m in sonuc.veri)
                        {
                            t.Rows.Add(m.musteri_, m.adi.Trim(), m.soyadi.Trim(), m.tel.Trim(), m.email.Trim());
                        }
                        gridControl1.DataSource = t;
                        gridView1.Columns["id"].Visible = false;

                        satisMusterisiMi = false;
                    }
                    else
                    {
                        MessageBox.Show(sonuc.mesaj);
                    }
                }
                else//satış müşterisi arama
                {
                    t.Rows.Clear();
                    var sonuc = new BSatismusterisi().sMusteriAra(txt_ara.Text.Trim(), "", "");
                    if (sonuc.basarliMi)
                    {
                        foreach (var m in sonuc.veri)
                        {
                            t.Rows.Add(m.musteri_, m.adi.Trim(), m.soyadi.Trim(), m.tel.Trim(), m.email.Trim());
                        }
                        gridControl1.DataSource = t;
                        gridView1.Columns["id"].Visible = false;

                        satisMusterisiMi = true;
                    }
                    else
                    {
                        MessageBox.Show(sonuc.mesaj);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen arama kelimesi girin !!!","Boş bırakma hatası !!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        //seç buttonu
        private void btn_sec_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow row = gridView1.GetDataRow(rowHandle);

                if (satisMusterisiMi)
                {
                    OMusteri m = new OMusteri();
                    m.adi = row["adi"].ToString();
                    m.soyadi = row["soyadi"].ToString();
                    m.tel = row["tel"].ToString();
                    m.email = row["email"].ToString();
                    m.kayittarihi = DateTime.Now;

                    var sonuc = new BArizamusterisi().aMusteriEkle(m);
                    if (!sonuc.basarliMi)
                    {
                        MessageBox.Show(sonuc.mesaj);
                        return;
                    }

                    _pnlArizaKayit.musteri_ = sonuc.veri;
                }
                else
                {
                    _pnlArizaKayit.musteri_ = (int)row["id"];
                }
                _pnlArizaKayit.btnE_musteriSec.Text= row["adi"].ToString() +" "+ row["soyadi"].ToString();

                this.Close();
            }
            else
            {
                MessageBox.Show("Müşteri seçilmedi !!!");
            }
        }

    }
}
