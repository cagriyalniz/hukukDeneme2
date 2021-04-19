using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hukukDeneme2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\muvekkilVeriTabani\\Database.accdb");


        private void button1_Click(object sender, EventArgs e)
        {
            //giris butonu

            string ad = textBox1.Text;
            string sifre = textBox2.Text;

            OleDbCommand komut2 = new OleDbCommand();
            baglanti.Open();
            komut2.Connection = baglanti;
            komut2.CommandText = "Select * From Tablo1 where kullaniciAdi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
            OleDbDataReader dr = komut2.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("giriş başarılı");
                Form2 frm2 = new Form2();
                frm2.Show();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            baglanti.Close();

        }



        //private void verileriGoruntule()
        //{

        //    baglanti.Open();
        //    OleDbCommand komut = new OleDbCommand();
        //    komut.Connection = baglanti;
        //    komut.CommandText = ("Select * from Tablo1");
        //    OleDbDataReader oku = komut.ExecuteReader();
        //    while (oku.Read())
        //    {
        //        ListViewItem ekle = new ListViewItem();
        //        ekle.Text = oku["kullaniciAdi"].ToString();
        //        ekle.SubItems.Add(oku["sifre"].ToString());

        //        listView1.Items.Add(ekle);

        //    }

        //    oku.Close();
        //    baglanti.Close();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            // kayıt butonu


            //SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-I5C70L2\CAGRI;
            //Initial Catalog=hukukDeneme;
            //User ID=admin;
            //Password=admin123456;");
            //SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBaseDeneme.mdf;Initial Catalog=hukukDeneme;Integrated Security=True;");

            //cnn.Open();
            //SqlCommand komut = new SqlCommand( "Insert Into tbl_kullanici (KullaniciAdi, Sifre) Values ('" + textBox1.Text.ToString()+"' , '" + textBox2.Text.ToString()+"')",cnn);
            //komut.ExecuteNonQuery();
            //cnn.Close();
            //MessageBox.Show("kayıt tamam");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Insert Into tablo1 (kullaniciAdi, Sifre) Values('" + textBox1.Text.ToString() + "' , '" + textBox2.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt tamam");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        //private void verileriTemizle()
        //{
        //    baglanti.Open();
        //    listView1.Items.Clear();
        //    baglanti.Close();

        //}
    }
}
