using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace waffleCaffe
{
    public partial class masaekleWaffle : Form
    {
        public masaekleWaffle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-IQCFEBU\SQLEXPRESS;Initial Catalog=waffleOto;Integrated Security=True");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void masaSecBtn_Click(object sender, EventArgs e)
        {

        }

        private void masa1_Click(object sender, EventArgs e)
        {
            masaSecTxt.Text = "1";

        }

        private void masa2_Click(object sender, EventArgs e)
        {
            masaSecTxt.Text = "2";

        }

        private void masa3_Click(object sender, EventArgs e)
        {
            masaSecTxt.Text = "3";

        }

        private void masa4_Click(object sender, EventArgs e)
        {
            masaSecTxt.Text = "4";

        }

        private void masa5_Click(object sender, EventArgs e)
        {
            masaSecTxt.Text = "5";

        }

        private void masa6_Click(object sender, EventArgs e)
        {
            masaSecTxt.Text = "6";

        }

        private void masa7_Click(object sender, EventArgs e)
        {
            masaSecTxt.Text = "7";

        }

        private void masa8_Click(object sender, EventArgs e)
        {
            masaSecTxt.Text = "8";

        }

        private void masa9_Click(object sender, EventArgs e)
        {
            masaSecTxt.Text = "9";

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void verisil()
        {
            ekoCikolata.Items.Clear();
            ekoSus.Items.Clear();
            ekoMeyve.Items.Clear();
            luksCikolata.Items.Clear();
            luksMeyve.Items.Clear();
            luksSus.Items.Clear();
            icecek.Items.Clear();
        }


        private void icecekEkleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();





            SqlCommand komut = new SqlCommand("insert into masaKayit (masaNumarasi,cikolataTercihi,meyveTercihi,susTercihi,icecekTercihi) " +
                "values( '" + masaSecTxt.Text + "','" + ekoCikolata.Text + luksCikolata.Text + "','" + ekoMeyve.Text + luksMeyve.Text + "','" + ekoSus.Text + luksSus.Text + "','" + icecek.Text +  "')", baglanti);



            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Masa Kaydı Alındı Ekle Sil Sayfasından Görüntüleyebilirsiniz","Bilgi Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);



            verisil();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void eklesilBTN_Click(object sender, EventArgs e)
        {
            eklesil degis = new eklesil();
            degis.Show();
            this.Hide();

           
        }

        private void masaekleWaffle_Load(object sender, EventArgs e)
        {

        }

        private void masaSecTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
