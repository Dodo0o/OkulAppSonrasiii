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
using OkulApp.BLL;

namespace OkulApp
{
    
    public partial class FrmOgrKayit : Form
    {
        public int OgrenciId { get; set; }
        public FrmOgrKayit()
        {
            InitializeComponent();

        }

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var obl = new OgrenciBL();
            try
            {
                bool sonuc = obl.OgrenciKaydet(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı" : "Ekleme Başarısız");

                txtAd.Clear();
                txtSoyad.Clear();
                txtNumara.Clear();

            }
            
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu Numara daha önce kaydedilmiş!! ");
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

        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmOgrBul(this);
                frm.Show();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                MessageBox.Show(obl.OgrenciSil(OgrenciId) ? "Silme Başarılı" : "Başarısız!");
                txtAd.Clear();
                txtSoyad.Clear();
                txtNumara.Clear();
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                MessageBox.Show(obl.OgrenciGuncelle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim(), OgrenciId = OgrenciId }) ? "Güncelleme Başarılı" : "Güncelleme Başarısız!");
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


   /* interface TransferIslemleri
    {
        int Eft(string gondereniban, string aliciiban, double tutar);
        int Havale(string gondereniban, string aliciiban, double tutar);
    }*/


}

//n Katmanlı Mimari

//Öğrenci bulunma durumuna göre Sil ve Güncelle Butonları Aktifliği
//Textbox'ların text'lerinin temizlenmesi
//Öğrenci bulunduğunda bul formunun kapanması
//Try-Catch'ler Katmanlar arası exception yönetimi
//Dispose Pattern - IDisposeble Interface
//Singleton Design Pattern
