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
    public partial class FrmOgretmenKayit : Form
    {
        public FrmOgretmenKayit()
        {
            InitializeComponent();
        }

        private void btnOgretmenKaydet_Click(object sender, EventArgs e)
        {
            var ogtbl = new OgretmenBL();
            try
            {
                bool sonuc = ogtbl.OgretmenKaydet(new Ogretmen { Ad = txtOgretmenAd.Text.Trim(), Soyad = txtOgretmenSoyad.Text.Trim(), TCKimlik = txtOgretmenTCKimlik.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı" : "Ekleme Başarısız");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu Kimlik daha önce kaydedilmiş!! ");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası!");
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu!");
            }
        }
    }
}
