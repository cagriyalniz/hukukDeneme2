using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace hukukDeneme2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

      

        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\muvekkilVeriTabani\\Database.accdb");
        
        void listele()
        {

            //veritabanindaki verilerin listelenmesi
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Tbl_Muvekkil", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;



        }
        private void Form3_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
          
        }
    }
}
