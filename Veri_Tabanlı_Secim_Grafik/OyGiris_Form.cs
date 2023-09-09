using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veri_Tabanlı_Secim_Grafik
{
    public partial class OyGiris_Form : Form
    {
        public OyGiris_Form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti= new SqlConnection(@"Data Source=DESKTOP-RGQV57Q;Initial Catalog=Secim;Integrated Security=True");

        private void oygiris_btn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sql_command = new SqlCommand("Insert into ilce_tablo (ilce_ad,a_parti,b_parti,c_parti,d_parti,e_parti) values (@ilcead,@a,@b,@c,@d,@e)",baglanti);
                sql_command.Parameters.AddWithValue("@ilcead", ilceAd_txtbx.Text);
                sql_command.Parameters.AddWithValue("@a", PartiA_txtbx.Text);
                sql_command.Parameters.AddWithValue("@b", PartiB_txtbx.Text);
                sql_command.Parameters.AddWithValue("@c", PartiC_txtbx.Text);
                sql_command.Parameters.AddWithValue("@d", PartiD_txtbx.Text);
                sql_command.Parameters.AddWithValue("@e", PartiE_txtbx.Text);
                int a = 0;
                a = sql_command.ExecuteNonQuery();
                if (a>0)
                {
                    MessageBox.Show("Giriş Başarılı");
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void grafik_btn_Click(object sender, EventArgs e)
        {
            Grafik_Form a = new Grafik_Form();
            a.Show();
        }
    }
}
