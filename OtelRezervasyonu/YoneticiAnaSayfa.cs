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
    public partial class YoneticiAnaSayfa : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
    
      Odalar back = new Odalar();
        public YoneticiAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Listele();
    
            }
            catch 
            {
                MessageBox.Show("Böyle bir TCKN kayıtlı değil...");
                
            }
        }

        void Listele()
        {
            con = new SqlConnection("Data Source = AHK; Initial Catalog = OtelRezerve; Integrated Security = True");
            con.Open();
            da= new SqlDataAdapter( "select* from Musteri where giris = '"  +dateTimePickercikis.Value.ToString("yyyy-MM-dd")+ "' and cikis = '" + dateTimePickercikis.Value.ToString("yyyy-MM-dd") + "';",con);
           
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewyonetici.DataSource = tablo;
            con.Close();
        }

        private void YoneticiAnaSayfa_Load(object sender, EventArgs e)
        {
            
            this.musteriTableAdapter2.Fill(this.otelRezerveDataSet10.Musteri);

            gridviewDoldur();
        }
        void gridviewDoldur()
        {
            con = new SqlConnection("Data Source=AHK;Initial Catalog=OtelRezerve;Integrated Security=True");
            da = new SqlDataAdapter("Select *From Musteri", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Musteri");
            dataGridViewyonetici.DataSource = ds.Tables["Musteri"];
            con.Close();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            back.Show();
            this.Hide();

        }

        private void RezIptal_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow drow in dataGridViewyonetici.SelectedRows)  //Seçili Satırları Silme
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(numara);
            }
            gridviewDoldur();
        }
        void KayıtSil(int numara)
        {

            string sql = "DELETE FROM Musteri WHERE numara=@numara";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@numara", numara);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridViewyonetici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
