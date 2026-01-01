using System.Data;
using System.Data.SqlClient;

namespace Sube1.OkulApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //tasarým kodlarýný çaðýrýr
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                 cn = new SqlConnection("Data Source=HASRET; Initial Catalog=NesneTabanlý_25;Integrated Security=true;TrustServerCertificate=true"); //baðlantý cümlesi

                SqlCommand cmd = new SqlCommand($"insert into tblOgrenciler (Ad,Soyad,Numara) values ('{txtAd.Text.Trim()}','{txtSoyad.Text.Trim()}',{txtNumara.Text.Trim()})", cn); // sql komutu
                cn.Open(); //baðlantý açar 
                cmd.ExecuteNonQuery();// komut çalýþtýrýr
                cn.Close(); //baðlantý kapatýr
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (cn!= null && cn.State != ConnectionState.Closed)
                {
                    
                }

            }

        }

      
    }
}
//ADO.NET veri iþlemleri için kullandýðý fremeworkdür.