using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using BL;
using OBJ;


namespace TeknikServis
{
    public partial class pnlSiparisEkle3 : UserControl
    {
        DataTable t;

        public OSiparis siparis=new OSiparis();
        public OPersonel personel=new OPersonel();
        

        public pnlSiparisEkle3()
        {
            InitializeComponent();
        }

        //panel yüklendiğinde
        private void pnlSiparisEkle3_Load(object sender, EventArgs e)
        {
            t = new DataTable();
            t.Columns.Add("id", typeof(int));

            t.Columns.Add("katagori", typeof(string));
            t.Columns["katagori"].Caption = "KATAGORİ";
            t.Columns.Add("marka", typeof(string));
            t.Columns["marka"].Caption = "MARKA";
            t.Columns.Add("model", typeof(string));
            t.Columns["model"].Caption = "MODEL";
            t.Columns.Add("adet", typeof(int));
            t.Columns["adet"].Caption = "ÜRÜN ADETİ";
            t.Columns.Add("ucret", typeof(double));
            t.Columns["ucret"].Caption = "GELİŞ FİYATI";
            t.Columns.Add("toplam", typeof(double));
            t.Columns["toplam"].Caption = "TOPLAM FİYAT";
            t.Columns.Add("sil", typeof(Image));
            t.Columns["sil"].Caption = "SİLME";

            gridControl1.DataSource = t;
            gridView1.Columns["id"].Visible = false;
            gridView1.Columns["sil"].Visible = false;

            gridView1.Columns["toplam"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["toplam"].SummaryItem.DisplayFormat = "Toplam = {0}";
            
        }
        
        //gonder buttonu
        private void btn_gonder_Click(object sender, EventArgs e)
        {
            if(rTxt_firsat.Text.Trim() != "")
            {
                OFirsat f = new OFirsat();
                f.siparis_ = siparis.siparis_;
                f.personel_ = personel.personel_;
                f.aciklama = rTxt_firsat.Text.Trim();
                f.tarih = DateTime.Now;
                var sonuc = new BFirsat().firsatEkle(f);
                if (sonuc.basarliMi)
                {
                    yeniKonusma();
                    rTxt_firsat.Text = "";
                }
                else
                {
                    MessageBox.Show(sonuc.mesaj);
                }
            }
            else
            {
                MessageBox.Show("Fütfen mesajınız varsa önce mesajınızı yazın sonra göndere basınız !",
                    "Boş bırakma hatası !!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //konuşmalar groupControl
        public void Komusmalar(List<OFirsat> _f)
        {
            int i = 0;
            foreach (OFirsat f in _f)
            {
                GroupControl gC_ = new GroupControl();
                gC_.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                gC_.AppearanceCaption.ForeColor = Color.Blue;
                gC_.Location = new Point(3, 3);//gerek kalmayabilir
                gC_.Name = "gC_" + i.ToString();
                gC_.Size = new Size(410, 102);
                gC_.TabIndex = 0;
                gC_.Text = f._personel.adi.Trim()+" "+f._personel.soyadi.Trim()+" | "+f.tarih;

                Label lbl = new Label();
                lbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                lbl.Location = new Point(8, 30);
                lbl.Size = new System.Drawing.Size(400, 70);
                lbl.Name = "konusma";
                lbl.Text =f.aciklama.Trim();

                gC_.Controls.Add(lbl);
                flpnl_konusma.Controls.Add(gC_);
                
                flpnl_konusma.ScrollControlIntoView(gC_);//ekleninin scrollu ayarlar - yani scrollu sonuna getirir

                i++;
            }

        }

        //yeni konuşma ekleme
        private void yeniKonusma()
        {
            int i = flpnl_konusma.Controls.Count;

            GroupControl gC_ = new GroupControl();
            gC_.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            gC_.AppearanceCaption.ForeColor = Color.Blue;
            gC_.Location = new Point(3, 3);//gerek kalmayabilir
            gC_.Name = "gC_" + i.ToString();
            gC_.Size = new Size(410, 102);
            gC_.TabIndex = 0;
            gC_.Text = personel.adi + " | " +DateTime.Now;//personelin adı ve soyadı

            Label lbl = new Label();
            lbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, 
                System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lbl.Location = new Point(8, 30);
            lbl.Size = new System.Drawing.Size(400, 70);
            lbl.Name = "konusma";
            lbl.Text = rTxt_firsat.Text.Trim();

            gC_.Controls.Add(lbl);
            flpnl_konusma.Controls.Add(gC_);

            flpnl_konusma.ScrollControlIntoView(gC_);//ekleninin scrollu ayarlar - yani scrollu sonuna getirir
        }

    }
}
