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
    public partial class pnlFirmaListeleme : UserControl
    {
        DataTable t;

        public pnlFirmaListeleme()
        {
            InitializeComponent();
        }

        private void pnlFirmaArama_Load(object sender, EventArgs e)
        {
            t = new DataTable();
            t.Columns.Add("id", typeof(int));
            t.Columns.Add("adi", typeof(string));
            t.Columns["adi"].Caption = "FİRMA ADI";
            t.Columns.Add("email", typeof(string));
            t.Columns["email"].Caption = "EMAİL";
            t.Columns.Add("tel1", typeof(string));
            t.Columns["tel1"].Caption = "TELEFON 1";
            t.Columns.Add("tel2", typeof(string));
            t.Columns["tel2"].Caption = "TELEFON 2";
            t.Columns.Add("adres", typeof(string));
            t.Columns["adres"].Caption = "ADRES";
            t.Columns.Add("ilce", typeof(string));
            t.Columns["ilce"].Caption = "İLÇE";
            t.Columns.Add("il", typeof(string));
            t.Columns["il"].Caption = "İL";


            var sonuc = new BSatismusterisi().firmaListele();
            if (sonuc.basarliMi)
            {
                foreach (var f in sonuc.veri)
                {
                    t.Rows.Add(f.firma_, f.firmaadi, f.email, f.tel1, f.tel2, f._adres.adres, f._adres.ilce, f._adres.il);
                }
                gridControl1.DataSource = t;
                gridView1.Columns["id"].Visible = false;
            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }
        }

        //güncelle buttonu
        private void btn_firmaguncelle_Click(object sender, EventArgs e)
        {

            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow row = gridView1.GetDataRow(rowHandle);

                var sonuc = new BSatismusterisi().firmaBilgisi((int)row["id"]);
                if (sonuc.basarliMi)
                {
                    frmFirmaGuncelle fg = new frmFirmaGuncelle();
                    fg.f = sonuc.veri;
                    fg.fl = this;
                    fg.ShowDialog();

                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }

        }

        //sil buttonu
        private void btn_firmasil_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow row = gridView1.GetDataRow(rowHandle);

                DialogResult dialogResult = MessageBox.Show("Silmek istediğine emin misin?", "Uyarı !!!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var sonuc = new BSatismusterisi().firmaSil((int)row["id"]);
                    if (sonuc.basarliMi)
                    {
                        row.Delete();
                    }
                    else
                    {
                        MessageBox.Show(sonuc.mesaj);
                    }
                }
                
            }
        }
    }
}
