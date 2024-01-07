using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net;

namespace OkulApp.DAL
{
    public class Helper : IDisposable
    {
        public void Dispose()
        {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                    cn = null;
                }

                if (cmd != null)
                {
                   
                    cmd.Dispose();
                    cmd = null;
                }
            
        }
        private static Helper instance;
        private SqlConnection cn;
        private SqlCommand cmd;
        private string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        private Helper() { }
        public static Helper GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Helper();
                }
                return instance;
            }
        }
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            try
            {
                using (cn = new SqlConnection(cstr))
                {
                    using (cmd = new SqlCommand(cmdtext, cn))
                    {
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                        cn.Open();
                        return cmd.ExecuteNonQuery();
                    }

                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p = null)
        {
            try
            {
                cn = new SqlConnection(cstr);
                cmd = new SqlCommand(cmdtext, cn);
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                cn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                
                throw;
            }
            finally { Dispose(); }

        }
        
    }
}
