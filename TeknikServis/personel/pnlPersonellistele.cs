using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BL;

namespace TeknikServis
{
    public partial class pnlPersonellistele : UserControl
    {
        public pnlPersonellistele()
        {
            InitializeComponent();
        }

        //panel yüklendiğinde
        private void pnlPersonellistele_Load(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            t.Columns.Add("id", typeof(int));
            t.Columns.Add("adi", typeof(string));
            t.Columns["adi"].Caption = "ADI";
            t.Columns.Add("soyadi", typeof(string));
            t.Columns["soyadi"].Caption = "SOYADI";
            t.Columns.Add("tc", typeof(string));
            t.Columns["tc"].Caption = "TC";
            t.Columns.Add("dogumtarih", typeof(DateTime));
            t.Columns["dogumtarih"].Caption = "DOĞUM TARİHİ";
            t.Columns.Add("cinsiyet", typeof(string));
            t.Columns["cinsiyet"].Caption = "CİNSİYET";
            t.Columns.Add("egitimdurum", typeof(string));
            t.Columns["egitimdurum"].Caption = "EĞİTİM DURUMU";
            t.Columns.Add("unvan", typeof(string));
            t.Columns["unvan"].Caption = "ÜNVANI";
            t.Columns.Add("maas", typeof(double));
            t.Columns["maas"].Caption = "MAAŞI";
            t.Columns.Add("email", typeof(string));
            t.Columns["email"].Caption = "EMAİLİ";
            t.Columns.Add("tel1", typeof(string));
            t.Columns["tel1"].Caption = "TELEFON 1";
            t.Columns.Add("tel2", typeof(string));
            t.Columns["tel2"].Caption = "TELEFON 2";
            t.Columns.Add("adres", typeof(string));
            t.Columns["adres"].Caption = "ADRESİ";
            t.Columns.Add("ilce", typeof(string));
            t.Columns["ilce"].Caption = "İLÇESİ";
            t.Columns.Add("il", typeof(string));
            t.Columns["il"].Caption = "İLİ";


            var sonuc = new BPersonel().personelListele();
            if (sonuc.basarliMi)
            {
                foreach (var p in sonuc.veri)
                {
                    string cinsiyet = p.cinsiyet == "K" ? "Kadın" : "Erkek";
                    string unvan = p.personelTipi_ == 2 ? "Yönetici Asistanı"
                                    : p.personelTipi_ == 3 ? "Satış Elemenı"
                                    : p.personelTipi_ == 4 ? "Sekreter" : "Teknin Elemen";
                    string egitimdurum = p.egitimdurumu == 1 ? "İlkokul"
                                        : p.egitimdurumu == 2 ? "Lise"
                                        : p.egitimdurumu == 3 ? "Üniversite" : "Yökseklisans";

                    t.Rows.Add(p.personel_, p.adi, p.soyadi, p.tcno,
                        p.dogumtarihi, cinsiyet, egitimdurum, unvan, p.maas, p.email, p.tel1, p.tel2,
                        p.adres.adres, p.adres.ilce, p.adres.il);
                }

                gridControl1.DataSource = t;
                gridView1.Columns["id"].Visible = false;

                /*
                bindingSource1.DataSource = sonuc.veri;
                gridControl1.DataSource = bindingSource1;
                */

            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }
        }

        //güncelle click
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow row = gridView1.GetDataRow(rowHandle);
                
                var sonuc = new BPersonel().personelBilgisi((int)row["id"]);
                if (sonuc.basarliMi)
                {

                    frmPersonelGuncelle _g = new frmPersonelGuncelle();
                    _g.p = sonuc.veri;
                    _g.pL = this;
                    _g.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
        }
    }
}
