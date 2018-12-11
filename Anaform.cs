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

namespace WindowsFormsApp3
{
    public partial class ANAFORM : Form
    {
        public ANAFORM()
        {
            InitializeComponent();
            veri_cek();            
        }

        public static DataGridView uyeTablosu = new DataGridView();
        
        
     public static  SqlConnection baglanti = new SqlConnection("Data Source=zek-bilgisayar\\sqlexpress;Initial Catalog=deneme.com;Integrated Security=True");
         DataTable tablo = new DataTable();

        public void formBagla(DataSet ds)
        {
            baglanti.Open();
            uyeTablosu.DataSource = ds.Tables["Table_1"];
            baglanti.Close();

        }
        public string puancek()
        {
            int secilen = uyeTablosu.SelectedCells[0].RowIndex;
            string puan = Convert.ToString(uyeTablosu.Rows[secilen].Cells[9].Value);
            return puan;
        }
        public void temizle()
        {
            ad.Clear();
            soyad.Clear();
            telno.Clear();
            mail.Clear();
            adres.Clear();
            fakulte.Clear();
            bolum.Clear();
            sinif.SelectedIndex = 0;
            komite.SelectedIndex = 0;
            gorevler.Items.Clear();
            // sınıf, komite ve gorevler
            ayrica.Clear();
           
        }
        public static void veri_cek()
        {
            SqlDataAdapter adaptor = new SqlDataAdapter("Select *From Table_1", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            adaptor.Fill(ds,"Table_1");
            uyeTablosu.DataSource = ds.Tables["Table_1"];
            baglanti.Close();
            /* //ikinci yol
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Table_1", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            
           while(oku.Read())
            {
                dataGridView1.DataSource = adaptor.Fill(tablo);
            }
            baglanti.Close();
            */


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();

            // ÇALIŞMAYAN SqlCommand komut = new SqlCommand("INSERT INTO Table_1(Ad,Soyad,Telefon,Mail,Adres,Fakülte,Bölüm,Sınıf,Komite,Görevler,Ayrıca) VALUES ('" + ad.Text+"','"+soyad.Text+"','"+telno.Text+ "','"+mail.Text+"','"+adres.Text+"','"+fakulte.Text+"','"+bolum.Text + "','" +sinif.SelectedItem + "','" +komite.SelectedItem + "','" +gorevler.Text +"','" +ayrica.Text + "')" ,baglanti);

            SqlCommand ekle = new SqlCommand("INSERT INTO Table_1(Ad,Soyad,Telefon,Mail,Adres,Fakülte,Bölüm,Sınıf,Komite,Görevler,Ayrıca)"
                + "VALUES (@Ad,@Soyad,@Telefon,@Mail,@Adres,@Fakülte,@Bölüm,@Sınıf,@Komite,@Görevler,@Ayrıca)", baglanti);
            
            ekle.Parameters.AddWithValue("@Ad", ad.Text);
            
           ekle.Parameters.AddWithValue("@Soyad", soyad.Text);
           ekle.Parameters.AddWithValue("@Telefon", telno.Text);
           ekle.Parameters.AddWithValue("@Mail", mail.Text);
           ekle.Parameters.AddWithValue("@Adres", adres.Text);
           ekle.Parameters.AddWithValue("@Fakülte", fakulte.Text);
           ekle.Parameters.AddWithValue("@Bölüm", bolum.Text);
           ekle.Parameters.AddWithValue("@Sınıf", sinif.Text);
           ekle.Parameters.AddWithValue("@Komite", komite.Text);
           ekle.Parameters.AddWithValue("@Görevler", gorevler.Text);
           ekle.Parameters.AddWithValue("@Ayrıca", ayrica.Text);
           ekle.ExecuteNonQuery();
           baglanti.Close();
           veri_cek();
           temizle();
       }

       private void button3_Click(object sender, EventArgs e)
       {
            int secilen = uyeTablosu.SelectedCells[0].RowIndex;
            baglanti.Open();
            //SqlCommand guncelle = new SqlCommand("UPDATE Table_1 SET (Ad,Soyad,Telefon,Mail,Adres,Fakülte,Bölüm,Sınıf,Komite,Görevler,Ayrıca) VALUES (@Ad,@Soyad,@Telefon,@Mail,@Adres,@Fakülte,@Bölüm,@Sınıf,@Komite,@Görevler,@Ayrıca) WHERE ID = @ID", baglanti);
            SqlCommand guncelle = new SqlCommand("UPDATE Table_1 SET Ad ='"+ad.Text+"',Soyad ='"+soyad.Text+"',Mail ='"+mail.Text+"',Adres ='"+adres.Text+"',Fakülte ='"+fakulte.Text+"',Bölüm ='"+bolum.Text+"',Sınıf ='"+sinif.Text+"',Komite ='"+komite.Text+"',Görevler ='"+gorevler.Text+"',Ayrıca ='"+ayrica.Text+ "' WHERE ID = @ID", baglanti);

            // guncelle.Parameters.AddWithValue("@ID",dataGridView1.Rows[secilen].Cells[0].Value.ToString());// buradaki hatanı farkındayım fakat çözüm bulamadım
            guncelle.Parameters.AddWithValue("@ID", Convert.ToString(uyeTablosu.Rows[secilen].Cells[0].Value));/*

            guncelle.Parameters.AddWithValue("@Ad", ad.Text);
          guncelle.Parameters.AddWithValue("@Soyad", soyad.Text);
          guncelle.Parameters.AddWithValue("@Telefon", telno.Text);
          guncelle.Parameters.AddWithValue("@Mail", mail.Text);
          guncelle.Parameters.AddWithValue("@Adres", adres.Text);
          guncelle.Parameters.AddWithValue("@Fakülte", fakulte.Text);
          guncelle.Parameters.AddWithValue("@Bölüm", bolum.Text);
          guncelle.Parameters.AddWithValue("@Sınıf", sinif.Text);
          guncelle.Parameters.AddWithValue("@Komite", komite.Text);
         // guncelle.Parameters.AddWithValue("@Görevler", gorevler.Text);
          guncelle.Parameters.AddWithValue("@Ayrıca", ayrica.Text);
         */
            guncelle.ExecuteNonQuery();
           baglanti.Close();
           veri_cek();
            temizle();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();
            SqlCommand sil = new SqlCommand("DELETE FROM Table_1 WHERE ID=@ID", baglanti);
            sil.Parameters.AddWithValue("@ID", uyeTablosu.CurrentRow.Cells[0].Value.ToString());
            sil.ExecuteNonQuery();
            baglanti.Close();
            veri_cek();
            temizle();
        }

        private void puanla_Click(object sender, EventArgs e)
        {
            puanlamaEkrani puanla = new puanlamaEkrani();
            if (Application.OpenForms["puanlamaEkrani"] == null)
            {
                puanla.Show();
            }
            else
            {
                puanla.Focus();
                MessageBox.Show("Formunuz zaten açık");
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            aramaSayfasi ara = new aramaSayfasi();        
            if(Application.OpenForms["aramaSayfasi"] == null )
            {
                ara.Show();
            }
            else
            {
                ara.Focus();
                MessageBox.Show("Formunuz zaten açık");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = uyeTablosu.SelectedCells[0].RowIndex;
            ad.Text = Convert.ToString (uyeTablosu.Rows[secilen].Cells[1].Value);
            soyad.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[2].Value);
            telno.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[3].Value);
            mail.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[4].Value);
            adres.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[5].Value);//kişisel bilgileri bitti

            fakulte.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[6].Value);
            bolum.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[7].Value);
            sinif.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[8].Value);// eğitim bilgileri bitti

            komite.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[9].Value);
            // gorevler gelcek Cells[10]
            ayrica.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[11].Value);//topluluk bilgileri bitti
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void grvSil_Click_2(object sender, EventArgs e)
        {
            gorevler.Items.Remove(gorevler.SelectedItem);
        }

        private void grvEkle_Click_1(object sender, EventArgs e)
        {
            gorevler.Items.Add(girGorev.Text);
        }

        private void ANAFORM_Load(object sender, EventArgs e)
        {
            veri_cek();
            temizle();
            dataGridView1.Visible = false;
            uyeTablosu.Location = new Point(12,300);
            uyeTablosu.Size = new Size(645, 176);
            uyeTablosu.CellClick += new DataGridViewCellEventHandler(tikla);
            this.Controls.Add(uyeTablosu);
        }
        void tikla(object sender, EventArgs e)
        {
            int secilen = uyeTablosu.SelectedCells[0].RowIndex;
            ad.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[1].Value);
            soyad.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[2].Value);
            telno.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[3].Value);
            mail.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[4].Value);
            adres.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[5].Value);//kişisel bilgileri bitti

            fakulte.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[6].Value);
            bolum.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[7].Value);
            sinif.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[8].Value);// eğitim bilgileri bitti

            komite.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[9].Value);
            // gorevler gelcek Cells[10]
            ayrica.Text = Convert.ToString(uyeTablosu.Rows[secilen].Cells[11].Value);//topluluk bilgileri bitti

        }

    }

}
