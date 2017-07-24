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

namespace OtelRezervasyonu
{
    public partial class Odalar : Form
    {//burda atanan nesneler globaldir.
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        YoneticiLogin yl = new YoneticiLogin();
        
       
        Muster m = new Muster();

        public Odalar()
        {
            InitializeComponent();
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            this.musteriTableAdapter4.Fill(this.otelRezerveDataSet9.Musteri);
     
            Goster();
         
            m.checkin = dateTimePickergiris.Value.ToString("yyyy-MM-dd");
            m.checkout = dateTimePickercikis.Value.ToString("yyyy-MM-dd");

            m.ad = textTckn.Text;
            m.soyad = textBoxSoyad.Text;
            odalarcombobox.DataSource = Enum.GetValues(typeof(EnumOda));

        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            //musteri kendine göre hesaplamalarını yapıyor.
            m.kisiSayisi = numericUpDownkisi.Value;
            m.ucret = 0;
            m.ekstra = "";
            m.Oda = (EnumOda)odalarcombobox.SelectedItem;

            if (m.kisiSayisi == 0) { MessageBox.Show("Kişi Sayısı seçiniz.."); }
            else
            {
                if (textTckn.Text == "" || textBoxSoyad.Text == "")
                {
                    MessageBox.Show("Ad ve soyad boş geçilememz");
                }
                else
                {

                    if (yamacparasutu.Checked == true) { m.ekstra += "Yamaç Paraşütü"; m.ucret += numericUpDownkisi.Value * 20; }
                    if (rafting.Checked == true) { m.ekstra += "Rafting"; m.ucret += numericUpDownkisi.Value * 20; }
                    if (scuba.Checked == true) { m.ekstra += "Scuba Diving"; m.ucret += numericUpDownkisi.Value * 30; }
                    if (bogazturu.Checked == true) { m.ekstra += "Boğaz Turları"; m.ucret += numericUpDownkisi.Value * 20; }
                    if (bungeejump.Checked == true) { m.ekstra += "Bungee Jumping"; m.ucret += numericUpDownkisi.Value * 20; }
                    if (kültürturları.Checked == true) { m.ekstra += "Kültür Turları"; m.ucret += numericUpDownkisi.Value * 40; }

                    if (odalarcombobox.Text == "Suit") { m.ucret += numericUpDownkisi.Value * 200; }
                    else if (odalarcombobox.Text == "DenizManzaralı") { m.ucret += numericUpDownkisi.Value * 100; }
                    else if (odalarcombobox.Text == "JuniorSuit") { m.ucret += numericUpDownkisi.Value * 150; }
                    else if (odalarcombobox.Text == "StandartOda") { m.ucret += numericUpDownkisi.Value * 50; }


                    Tutar.Items.Add(m.ucret + "TL");
                    Bilgiler.Items.Add(textTckn.Text + " " + textBoxSoyad.Text + m.ekstra + "Tutulan Oda:" + odalarcombobox.Text + "Kişi sayısı" + numericUpDownkisi.Value);
                }
            }
        }


        private void SatinAl_Click(object sender, EventArgs e)
        {
            m.kisiSayisi = numericUpDownkisi.Value;
            m.TCKN = textTckn.Text;

            try
            {
                if (m.kisiSayisi == 0) { MessageBox.Show("Kişi Sayısı seçiniz.."); }
                else
                {
                    if (Muster.odaSayisi == 0) { MessageBox.Show("Tüm Odalar doludur.."); }
                    else
                    {

                            SqlConnection con = new SqlConnection("Data Source=AHK;Initial Catalog=OtelRezerve;Integrated Security=True");
                            //cmd = new SqlCommand();
                            con.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;

                            cmd.CommandText = "INSERT INTO Musteri(tckn,Ad,Soyad,giris,cikis,Oda,KisiSayisi) VALUES('" + textTckn.Text + "','" + textAd.Text + "','" + textBoxSoyad.Text + "','" + dateTimePickergiris.Value.ToString("yyyy-MM-dd") + "','" + dateTimePickercikis.Value.ToString("yyyy-MM-dd") + "','" + odalarcombobox.Text + "'," + numericUpDownkisi.Value + ")";

                            cmd.CommandType = CommandType.Text;
                 
                            SqlDataAdapter da = new SqlDataAdapter();
                            da.SelectCommand = cmd;
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                         

                            con.Close();
                            Muster.odaSayisi = Muster.odaSayisi - 1;


                            MessageBox.Show("Kayıtınız sisteme alındı , Kalan Oda Sayısı = ", Muster.odaSayisi.ToString());
                         

                        }
                    }
                }
            
            catch (Exception)
            {

                MessageBox.Show("Kayıt Tarihi 02.02.2017 veya 02-02-2017 veya 02/02/2017 şeklinde olmalıdır.");
            }
        }

        void Goster()
        {//veri tabanını görüntülemek için
            con = new SqlConnection("Data Source=AHK;Initial Catalog=OtelRezerve;Integrated Security=True");
            da = new SqlDataAdapter("Select *From Musteri", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Musteri");
            dataGridViewsatinalama.DataSource = ds.Tables["Musteri"];
            con.Close();
        }

        private void yonLogin_Click(object sender, EventArgs e)
        {

            yl.Show();
            this.Hide();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewsatinalama_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tutar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }


   
