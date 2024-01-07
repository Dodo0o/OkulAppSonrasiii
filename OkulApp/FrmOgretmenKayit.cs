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
        public int OgretmenId { get; set; }
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

        private void btnOgretmenBul_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmOgretmenBul(this);
                frm.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnOgretmenSil_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.OgretmenSil(OgretmenId) ? "Silme Başarılı" : "Başarısız!");
                // Mevcut kayıdı sildikten sonra da textboxları temizler
                txtOgretmenAd.Clear();
                txtOgretmenSoyad.Clear();
                txtOgretmenTCKimlik.Clear();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.OgretmenGuncelle(new Ogretmen { Ad = txtOgretmenAd.Text.Trim(), Soyad = txtOgretmenSoyad.Text.Trim(), TCKimlik = txtOgretmenTCKimlik.Text.Trim(), OgretmenId = OgretmenId }) ? "Güncelleme Başarılı" : "Güncelleme Başarısız!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    
    }
}
