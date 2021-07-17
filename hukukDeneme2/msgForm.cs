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
    public partial class msgForm : Form
    {

        // yapilan bircok islemden sonra mesaj kutusu ile bilgi verilmesi gerekecek
        // mesaj kutusunun ozellestirilmis olması icin ayri bir form tipi olarak ayarladim
        //ilerleyen asamalarda gorsel uzerinde degisiklikler yapilacak

        public  msgForm()
        {
            InitializeComponent();
            
        }

        public void mesaj(string a)
        {
            

            label2.Text = a;
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
