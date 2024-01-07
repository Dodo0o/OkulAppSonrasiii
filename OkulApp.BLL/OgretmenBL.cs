using OkulApp.DAL;
using OkulApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        private Helper hlp;
        public OgretmenBL()
        {
            hlp = Helper.GetInstance;
        }
        public bool OgretmenKaydet(Ogretmen ogretmen)
        {
            try
            {
                SqlParameter[] p = {
                                  new SqlParameter("@Ad",ogretmen.Ad),
                                  new SqlParameter("@Soyad",ogretmen.Soyad),
                                  new SqlParameter("@TCKimlik",ogretmen.TCKimlik)
                            };

                //var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into TblOgretmenler (Ad,Soyad,TCKimlik) values (@Ad,@Soyad,@TCKimlik)", p) > 0;

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
        public Ogretmen OgretmenBul(string TCKimlik)
        {
            //var hlp = new Helper();
            try
            {
                SqlParameter[] p = { new SqlParameter("@TCKimlik", TCKimlik) };
                var dr = hlp.ExecuteReader("Select OgretmenId,Ad,Soyad,TCKimlik from TblOgretmenler where TCKimlik=@TCKimlik", p);
                Ogretmen ogr = null;
                if (dr.Read())
                {
                    ogr = new Ogretmen();
                    ogr.Ad = dr["Ad"].ToString();
                    ogr.Soyad = dr["Soyad"].ToString();
                    ogr.TCKimlik = dr["TCKimlik"].ToString();
                    ogr.OgretmenId = Convert.ToInt32(dr["OgretmenId"]);
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
        }
        public bool OgretmenSil(int OgretmenId)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Id", OgretmenId) };
                // Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Delete from TblOgretmenler where OgretmenId=@OgretmenId", p) > 0;
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

        public bool OgretmenGuncelle(Ogretmen ogr)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad",ogr.Ad),
            new SqlParameter("@Soyad",ogr.Soyad),
            new SqlParameter("@TCKimlik",ogr.TCKimlik),
            new SqlParameter("@OgretmenId",ogr.OgretmenId)};

                // Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Update TblOgretmenler set Ad=@Ad,Soyad=@Soyad,TCKimlik=@TCKimlik where OgretmenId=@OgretmenId", p) > 0;
            }
           
            catch (Exception)
            {

                throw;
            }
        }
    }
}



