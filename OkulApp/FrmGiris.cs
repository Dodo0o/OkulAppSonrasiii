using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulApp
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btngirisogrencikayit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOgrKayit frmOgrKayit = new FrmOgrKayit();
                frmOgrKayit.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btngirisogretmenkayit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOgretmenKayit frmOgretmenKayit = new FrmOgretmenKayit();
                frmOgretmenKayit.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
