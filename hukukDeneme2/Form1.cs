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
using DevExpress.XtraEditors;


namespace hukukDeneme2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
          

        }
        // giris ekrani
        //kullanilmayan sql komutlari mevcut. dokumentasyon sonrasinda o kodlar silinecek

        // access veri tabani ile baglanti kurma islemi
       public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\muvekkilVeriTabani\\Database.accdb");
        

        private void button1_Click(object sender, EventArgs e)
        {
            //giris butonu

        
            
            Form2 frm2 = new Form2(); // giris butonuna tiklayinca ikinci pencerenin acilmasi icin form2'yi olusturdum
            msgForm frm3 = new msgForm();  // basarili ve basarisiz girislerin bilgisini verecek mesaj kutusunun oluşturdum

            string ad = textBox1.Text; 
            string sifre = textBox2.Text;
            // kullanici adi ve sifre kontrolu yapmak icin ilgili textboxlardaki degerlerin alinmasi icin olusturdum

            OleDbCommand komut2 = new OleDbCommand(); // veritabani islemlerini gerceklestirmek icin komut

            baglanti.Open();
            komut2.Connection = baglanti;
            komut2.CommandText = "Select * From Tablo1 where kullaniciAdi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
            OleDbDataReader dr = komut2.ExecuteReader();
            //veritabanindaki verilerle bir tablo olusturdum. 
            //kullanici adi ve sifreye yazilan veriler, tabloda eslesiyorsa giris basarili 
            //eslesmiyorsa basarisiz olacak

            if (dr.Read())
            {
              
                frm3.mesaj("Giriş Başarılı");
                
                frm2.Show();
                frm3.Show();
                this.Hide();
                                                
            }
            else
            {
                               
                frm3.mesaj("Kullanıcı adı ya da şifre yanlış");
                frm3.Show();
            }

            baglanti.Close();

        }

        //public void deneme(string a)
        //{
            
        //    label2.Text = a;
        //}
        
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

            baglanti.Open(); //veritabanini baglanti acildi

            OleDbCommand komut = new OleDbCommand("Insert Into tablo1 (kullaniciAdi, Sifre) Values('" + textBox1.Text.ToString() + "' , '" + textBox2.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            //kullanici adi ve sifre veritabanina eklendi

            baglanti.Close();
            MessageBox.Show("Kayıt Tamam");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // uygulamayi kapatmak icin ozel buton tasarladim
            // tasarim daha sonra degistirilecek
            Application.Exit();
        }
        
        //private void verileriTemizle()
        //{
        //    baglanti.Open();
        //    listView1.Items.Clear();
        //    baglanti.Close();

        //}

        // textbox ların propertieslerindeki tabindex=0 olan textboxda imleç açılışta gözüküyor
    }
}
