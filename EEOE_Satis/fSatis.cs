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
                        var urun = db.Urun.Where(x => x.Barkod == barkod).FirstOrDefault();

                    }
                }
            }
        }
    }
}
