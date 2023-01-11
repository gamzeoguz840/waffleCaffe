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
    public partial class eklesil : Form
    {
        public eklesil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-IQCFEBU\\SQLEXPRESS;Initial Catalog=waffleOto;Integrated Security=True");

        private void verigoster()
        {
            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from masaKayit", baglanti);
            SqlDataReader oku = komut.ExecuteReader();


            while(oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                //ekle.Text = oku["musteriid"].ToString();
                ekle.Text = oku["masaNumarasi"].ToString();
              //ekle.SubItems.Add( oku["masaNumarasi"].ToString());
                ekle.SubItems.Add(oku["cikolataTercihi"].ToString());
                ekle.SubItems.Add(oku["meyveTercihi"].ToString());
                ekle.SubItems.Add(oku["susTercihi"].ToString());
                ekle.SubItems.Add(oku["icecekTercihi"].ToString());


                listView1.Items.Add(ekle);


            }


            baglanti.Close();
           

        }

        private void baslik_Click(object sender, EventArgs e)
        {

        }

        private void goruntuleBtn_Click(object sender, EventArgs e)
        {
            verigoster();
        }

  
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

  

        int id =0;
        private void listView1_DoubleClick_2(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
        }



        private void silBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from masaKayit where masaNumarasi=(" + id+")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verigoster();
        }
      
        private void guncelleBTN_Click(object sender, EventArgs e)
        {


            guncelleme degis2 = new guncelleme();
            degis2.Show();
            this.Hide();


        }

        private void geriBTN_Click(object sender, EventArgs e)
        {
            masaekleWaffle degis3 = new masaekleWaffle();
            degis3.Show();
            this.Hide();

        }
    }
    }

