using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

using BL;
using OBJ;


namespace TeknikServis
{
    public partial class pnlServistekiArizaliUrunler : UserControl
    {
        public pnlSekreter _s;
        public pnlYoneticiAsistanAnaMenu _pnlYoneticiAsistanAnaMenu;
        public pnlTeknikServisTakibi _pnlTeknikServisTakibi;

        DataTable t;
        public OArizaliurun au;
        public DataRow row;

        public pnlServistekiArizaliUrunler()
        {
            InitializeComponent();
        }

        //panel yüklendiğinde
        private void pnlServistekiArizaliUrunler_Load(object sender, EventArgs e)
        {
            if(_s == null && _pnlYoneticiAsistanAnaMenu == null)//yöneticinin girdiği durumda gerçekleşecek
            {
                btn_guncelle.Visible = false;
                btn_sil.Visible = false;
            }
            else if(_s == null)
            {
                btn_sil.Visible = false;
                btn_guncelle.Location = new Point(636, 537);
            }

            t = new DataTable();
            t.Columns.Add("id", typeof(int));
            t.Columns.Add("cihaz", typeof(string));
            t.Columns["cihaz"].Caption = "CİHAZ";
            t.Columns.Add("kayittarih", typeof(string));
            t.Columns["kayittarih"].Caption = "KAYIT TARİHİ";
            t.Columns.Add("durum", typeof(Image));
            t.Columns["durum"].Caption = "DURUMU";

            gridControl1.DataSource = t;
            gridView1.Columns["id"].Visible = false;

            Image durum=null;

            Image tamirde = Image.FromFile("..\\..\\img\\tamirde64x64.png");//iki renk veye ikon daha
            Image bittiYapildi = Image.FromFile("..\\..\\img\\bittiYapildi64x64.png");
            Image bittiYapilamadi = Image.FromFile("..\\..\\img\\bittiYapilamadi64x64.png");
            //bunun gibi 4 durum


            var sonuc = new BArizaliurun().aTamirdekiListesi();
            if (sonuc.basarliMi)
            {
                foreach (var a in sonuc.veri)
                {
                    if(a.durumu == 1) //tamirde
                    {
                        durum = tamirde;
                    }
                    else if(a.durumu == 2) //yapıldı bitti
                    {
                        durum = bittiYapildi;
                    }
                    else if(a.durumu == 3) //yapılamadı bitti
                    {
                        durum = bittiYapilamadi;
                    }

                    t.Rows.Add(a.aurun_,a.urunadi,a.kayittarih ,durum);//Image.FromFile("..\\..\\img\\guncelle32x32.png")

                }
                gridControl1.DataSource = t;
                gridView1.Columns["id"].Visible = false;
                
            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }
        }

        /*
        //satır tıklama
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            int i = e.RowHandle;
            DataRow row = gridView1.GetDataRow(i);
            var sonuc = new BArizaliurun().aUrunBilgisi((int)row["id"]);
            if (sonuc.basarliMi)
            {
                au = sonuc.veri;

                _s.pnlSekreterTemp.Controls.Clear();
                pnlArizaUrunGoruntule aug = new pnlArizaUrunGoruntule();
                aug.sau = this;
                _s.pnlSekreterTemp.Controls.Add(aug);

            }
            else
            {
                MessageBox.Show(sonuc.mesaj);
            }

    
        }
        */

        //------------------satır double click--------
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //if (_s == null) //yönetici girdiğinde oluşacak durum
            //    return;

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
                    if(_s != null)
                    {
                        _s.pnlSekreterTemp.Controls.Clear();
                        pnlArizaUrunGoruntule aug = new pnlArizaUrunGoruntule();
                        aug.sau = this;
                        _s.pnlSekreterTemp.Controls.Add(aug);
                    }
                    else if(_pnlTeknikServisTakibi != null)
                    {
                        _pnlTeknikServisTakibi.pnlArizaTemp.Controls.Clear();
                        pnlArizaUrunGoruntule aug = new pnlArizaUrunGoruntule();
                        aug.sau = this;
                        _pnlTeknikServisTakibi.pnlArizaTemp.Controls.Add(aug);
                    }

                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }

                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
            }
        }
        //----------------------------------------------

        //güncelle buttonu
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
                    ag.sau = this;
                    ag.ShowDialog();
                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
        }

        // sil buttonu
        private void btn_sil_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow row = gridView1.GetDataRow(rowHandle);

                DialogResult dialogResult = MessageBox.Show("Silmek istediğine emin misin?", "Uyarı !!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var sonuc = new BArizaliurun().aUrunlSil((int)row["id"]);
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
