using EEOE_Satis.Eeoe.Satis.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEOE_Satis
{
    public partial class form1 : Form
    {
        EeoeDbEntities db = new EeoeDbEntities();
        public form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = txtBarkod.Text.Trim();

                if (barkod.Length <= 2)
                {

                    txtMiktar.Text = barkod;
                    txtBarkod.Clear();
                    txtBarkod.Focus();
                    txtBarkod.Text = "";
                }
                else
                {

                    if (db.Urun.Any(x => x.Barkod == barkod))
                    {
                        //Varsa ürün Bulunuyor 
                        var urun = db.Urun.Where(x => x.Barkod == barkod).FirstOrDefault();
                        //Ürün Eklenmişse Üstüne Ekliyoruz 
                        int satirsayisi = gridSatisListesi.Rows.Count;
                        double miktar = Convert.ToDouble(txtMiktar.Text);
                        bool eklenmismi = false;
                        if (satirsayisi > 0)
                        {
                            for (int i = 0; i < satirsayisi; i++)
                            {
                                if (gridSatisListesi.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                                {
                                    gridSatisListesi.Rows[i].Cells["Miktar"].Value =
                                        miktar + Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value);
                                    gridSatisListesi.Rows[i].Cells["Toplam"].Value =
                                       Math.Round(Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Miktar"].Value) *
                                        Convert.ToDouble(gridSatisListesi.Rows[i].Cells["Fiyat"].Value), 2);
                                    eklenmismi = true;
                                }
                            }
                        }

                        if (!eklenmismi)
                        {
                            gridSatisListesi.Rows.Add();
                            gridSatisListesi.Rows[satirsayisi].Cells["Barkod"].Value = barkod;
                            gridSatisListesi.Rows[satirsayisi].Cells["UrunAdi"].Value = urun.UrunAd;
                            gridSatisListesi.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                            gridSatisListesi.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim;
                            gridSatisListesi.Rows[satirsayisi].Cells["Fiyat"].Value = urun.SatisFiyat;
                            gridSatisListesi.Rows[satirsayisi].Cells["Miktar"].Value = urun.Miktar;
                            gridSatisListesi.Rows[satirsayisi].Cells["Toplam"].Value = urun.UrunAd;
                            Math.Round(miktar * (double)urun.SatisFiyat, 2);
                            gridSatisListesi.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat;
                            gridSatisListesi.Rows[satirsayisi].Cells["KdvOrani"].Value = urun.KdvOrani;

                        }


                    }
                }
            }
        }
    }
}
