using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Veri_Tabanlı_Secim_Grafik
{
    public partial class Grafik_Form : Form
    {
        public Grafik_Form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RGQV57Q;Initial Catalog=Secim;Integrated Security=True");

        private void Grafik_Form_Load(object sender, EventArgs e)
        {
            try
            {
                //İlçe Adlarını çekme
                baglanti.Open();
                SqlCommand sql_command= new SqlCommand("Select ilce_ad from ilce_tablo",baglanti);
                SqlDataReader dr = sql_command.ExecuteReader();
                while (dr.Read())
                {
                    ilce_combobox.Items.Add(dr[0]);
                }

                baglanti.Close();
                baglanti.Open();

                //Grafiğe toplam sonuçları getirme
                SqlCommand komut = new SqlCommand("Select SUM(a_parti),SUM(b_parti),SUM(c_parti),SUM(d_parti),SUM(e_parti) FROM ilce_tablo", baglanti);
                SqlDataReader dr2 = komut.ExecuteReader();
                while (dr2.Read())
                {
                    parti_chart.Series["Partiler"].Points.AddXY("A parti", dr2[0]);
                    parti_chart.Series["Partiler"].Points.AddXY("B parti", dr2[1]);
                    parti_chart.Series["Partiler"].Points.AddXY("C parti", dr2[2]);
                    parti_chart.Series["Partiler"].Points.AddXY("D parti", dr2[3]);
                    parti_chart.Series["Partiler"].Points.AddXY("E parti", dr2[4]);
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

        private void ilce_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From ilce_tablo where ilce_ad=@ilcead",baglanti);
                komut.Parameters.AddWithValue("@ilcead", ilce_combobox.Text);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    A_progressBar.Value = int.Parse(dr[2].ToString());
                    B_progressBar.Value = int.Parse(dr[3].ToString());
                    C_progressBar.Value = int.Parse(dr[4].ToString());
                    D_progressBar.Value = int.Parse(dr[5].ToString());
                    E_progressBar.Value = int.Parse(dr[6].ToString());

                    A_lbl.Text = dr[2].ToString();
                    B_lbl.Text = dr[3].ToString();
                    C_lbl.Text = dr[4].ToString();
                    D_lbl.Text = dr[5].ToString();
                    E_lbl.Text = dr[6].ToString();
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
    }
}
