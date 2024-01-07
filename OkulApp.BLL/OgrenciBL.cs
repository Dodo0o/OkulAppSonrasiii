using System;
using OkulApp.Model;
using System.Data.SqlClient;
using OkulApp.DAL;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        private Helper hlp;
        public OgrenciBL()
        {
            hlp = Helper.GetInstance;
        }
        public bool OgrenciKaydet(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = {
                                  new SqlParameter("@Ad",ogr.Ad),
                                  new SqlParameter("@Soyad",ogr.Soyad),
                                  new SqlParameter("@Numara",ogr.Numara)
                            };

                //var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblOgrenciler (Ad,Soyad,Numara) values (@Ad,@Soyad,@Numara)", p) > 0;
             

            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
            }
        }
        public Ogrenci OgrenciBul(string numara)
        {
            //var hlp = new Helper();
            try
            {
                SqlParameter[] p = { new SqlParameter("@Numara", numara) };
                var dr = hlp.ExecuteReader("Select OgrenciId,Ad,Soyad,Numara from tblOgrenciler where Numara=@Numara", p);
                Ogrenci ogr = null;
                if (dr.Read())
                {
                    ogr = new Ogrenci();
                    ogr.Ad = dr["Ad"].ToString();
                    ogr.Soyad = dr["Soyad"].ToString();
                    ogr.Numara = dr["Numara"].ToString();
                    ogr.OgrenciId = Convert.ToInt32(dr["OgrenciId"]);
                }
                dr.Close();
                return ogr;

            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
            finally { hlp.Dispose(); }
        }
        public bool OgrenciSil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Id", id) };
                // Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Delete from tblOgrenciler where OgrenciId=@Id", p) > 0;
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

        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad",ogr.Ad),
            new SqlParameter("@Soyad",ogr.Soyad),
            new SqlParameter("@Numara",ogr.Numara),
            new SqlParameter("@OgrenciId",ogr.OgrenciId)};

                // Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Update tblOgrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara where OgrenciId=@OgrenciId", p) > 0;
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
// SqlConnection cn = null;
// SqlCommand cmd = null;
// try
// {
//     using (cn = new SqlConnection(@"Data Source=DESKTOP-A556OS3\VERITABANI;Initial Catalog=OkulDB;Integrated Security=true"))
//     {
//         using (cmd = new SqlCommand($"Insert into tblOgrenciler values (@Ad,@Soyad,@Numara)", cn))
//         {
//             SqlParameter[] p =
//     {
//         new SqlParameter("@Ad",ogr.Ad),
//         new SqlParameter("@Soyad",ogr.Soyad),
//         new SqlParameter("@Numara",ogr.Numara),
//     };
//             cmd.Parameters.AddRange(p);
//             cn.Open();
//             return cmd.ExecuteNonQuery() > 0;
//         }
//     }

//     //MessageBox.Show(sonuc > 0 ? "Ekleme Başarılı" : "Ekleme Başarısız!!");

// }
// catch (SqlException ex)
// {
//     throw;
//     /*switch (ex.Number)
//     {
//         case 2627:
//             MessageBox.Show("Bu Numara daha önce kaydedilmiş!! ");
//             break;
//         default:
//             MessageBox.Show("Veritabanı Hatası!");
//             break;
//     }*/
// }
// catch (Exception)
// {
//     throw;
//     //MessageBox.Show("Bir Hata Oluştu!"); ;
// }
//// finally
// //{
//     /* if (cn != null && cn.State != ConnectionState.Closed)
//      { cn.Close(); }
//      cn.Dispose();*/



// //}