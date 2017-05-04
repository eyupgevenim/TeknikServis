using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using BL;
using OBJ;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace TeknikServis
{
    public partial class pnlTeknikServisEleman : UserControl
    {
        public frmTeknikEleman _frmTeknikEleman;
        DataTable t;
        public OArizaliurun au;
        public DataRow row;

        public pnlTeknikServisEleman()
        {
            InitializeComponent();
        }

        private void pnlTeknikServisEleman_Load(object sender, EventArgs e)
        {
            t = new DataTable();
            t.Columns.Add("id", typeof(int));
            t.Columns.Add("cihaz", typeof(string));
            t.Columns["cihaz"].Caption = "CİHAZ";
            t.Columns.Add("durum", typeof(Image));
            t.Columns["durum"].Caption = "DURUM";

            gridControl1.DataSource = t;
            gridView1.Columns["id"].Visible = false;

            Image durum = null;

            Image tamirde = Image.FromFile("..\\..\\img\\tamirde64x64.png");//iki renk veye ikon daha
            Image bittiYapildi = Image.FromFile("..\\..\\img\\bittiYapildi64x64.png");
            Image bittiYapilamadi = Image.FromFile("..\\..\\img\\bittiYapilamadi64x64.png");
            //bunun gibi 4 durum


            var sonuc = new BArizaliurun().aTamirdekiListesi();
            if (sonuc.basarliMi)
            {
                foreach (var a in sonuc.veri)
                {
                    if (a.durumu == 1) //tamirde
                    {
                        durum = tamirde;
                    }
                    else if (a.durumu == 2) //yapıldı bitti
                    {
                        durum = bittiYapildi;
                    }
                    else if (a.durumu == 3) //yapılamadı bitti
                    {
                        durum = bittiYapilamadi;
                    }

                    t.Rows.Add(a.aurun_, a.urunadi, durum);//Image.FromFile("..\\..\\img\\guncelle32x32.png")

                }
                gridControl1.DataSource = t;
                gridView1.Columns["id"].Visible = false;

            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }
        }

        //------------------satır double click--------
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();

               row = gridView1.GetDataRow(info.RowHandle);
                var sonuc = new BArizaliurun().aUrunBilgisi((int)row["id"]);
                if (sonuc.basarliMi)
                {
                    au = sonuc.veri;

                    pnlTeknikTemp.Controls.Clear();
                    pnlArizaUrunGoruntule aug = new pnlArizaUrunGoruntule();
                    aug.tse = this;
                    pnlTeknikTemp.Controls.Add(aug);

                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }

                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
            }
        }

        //----------------------------------------------

        // güncelle buttonu
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                row = gridView1.GetDataRow(rowHandle);

                var sonuc = new BArizaliurun().aUrunBilgisi((int)row["id"]);
                if (sonuc.basarliMi)
                {
                    au = sonuc.veri;
                    frmArizaliGüncelle ag = new frmArizaliGüncelle();
                    ag.tse = this;
                    ag.ShowDialog();
                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
        }

        

    }
}
