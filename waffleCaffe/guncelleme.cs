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
    public partial class guncelleme : Form
    {
        public guncelleme()
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


            while (oku.Read())
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
        private void guncelleme_Load(object sender, EventArgs e)
        {

        }

        private void gosterBTN_Click(object sender, EventArgs e)
        {
            verigoster();
        }
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            cikolata.Text = listView1.SelectedItems[0].SubItems[1].Text;
            meyve.Text = listView1.SelectedItems[0].SubItems[2].Text;
            sus.Text = listView1.SelectedItems[0].SubItems[3].Text;
            icecek.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void guncelleBTN_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update masaKayit set cikolataTercihi='" + cikolata.Text + "',meyveTercihi='" + meyve.Text + "',susTercihi='" + sus.Text + "',icecekTercihi='" + icecek.Text +  "'where masaNumarasi=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verigoster();
        }

        private void araBTN_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from masaKayit where masaNumarasi like'%" + araTxt.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
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

    }
}

