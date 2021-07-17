using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hukukDeneme2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            
        }


        

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            // uygulamayi kapatmak icin ozel buton tasarladim
            // tasarim daha sonra degistirilecek
            Application.Exit();
        }

        Form3 frm3;
        
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // bardaki "müvekkiler" butonu

            if (frm3 == null)
            {
                frm3 = new Form3();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
