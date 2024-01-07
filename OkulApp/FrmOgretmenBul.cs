using OkulApp.BLL;
using OkulApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulApp
{
    public partial class FrmOgretmenBul : Form
    {
        FrmOgretmenKayit frm;
        public FrmOgretmenBul(FrmOgretmenKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnOgretmenAra_Click(object sender, EventArgs e)
        {
            try
            {
                OgretmenBL obl = new OgretmenBL();
                Ogretmen ogrt = obl.OgretmenBul(txtOgretmenTCKimlik.Text.Trim());
                if (ogrt != null)
                {
                    frm.txtOgretmenAd.Text = ogrt.Ad;
                    frm.txtOgretmenSoyad.Text = ogrt.Soyad;
                    frm.txtOgretmenTCKimlik.Text = ogrt.TCKimlik;
                    frm.OgretmenId = ogrt.OgretmenId;

                    this.Close();
                    frm.btnOgretmenSil.Enabled = true;
                    frm.btnOgretmenGuncelle.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Öğretmen bulunamadı!!");
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
