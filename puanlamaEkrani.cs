using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class puanlamaEkrani : Form
    {
        public puanlamaEkrani()
        {
            InitializeComponent();
        }


        int puan;
        public void puanYaz()
        {
            if (ANAFORM.uyeTablosu.SelectedCells.Count > 0)
            {
                int sec = ANAFORM.uyeTablosu.SelectedCells[0].RowIndex;
                button1.Text = Convert.ToString(ANAFORM.uyeTablosu.Rows[sec].Cells[12].Value);
                label2.Text = Convert.ToString(ANAFORM.uyeTablosu.Rows[sec].Cells[1].Value);
            }
        }

        private void puanlamaEkrani_Load(object sender, EventArgs e)
        {
            puanYaz();
        }

        private void btnPuanEkle_Click(object sender, EventArgs e)
        {
            int sec = ANAFORM.uyeTablosu.SelectedCells[0].RowIndex;
            puan = Convert.ToInt32(button1.Text);
            int degisiklik = Convert.ToInt32(textBox1.Text);
            puan += degisiklik;
            ANAFORM.baglanti.Open();
            SqlCommand puanEkle = new SqlCommand("update Table_1 set Puan ='"+Convert.ToString(puan)+"' where ID = @ID",ANAFORM.baglanti);
            puanEkle.Parameters.AddWithValue("@ID", Convert.ToString(ANAFORM.uyeTablosu.Rows[sec].Cells[0].Value));
            puanEkle.ExecuteNonQuery();
            ANAFORM.baglanti.Close();
            ANAFORM.veri_cek();
            puanYaz();
        }

        private void btnPuanSil_Click(object sender, EventArgs e)
        {
            int sec = ANAFORM.uyeTablosu.SelectedCells[0].RowIndex;
            puan = Convert.ToInt32(button1.Text);
            int degisiklik = Convert.ToInt32(textBox1.Text);
            puan -= degisiklik;                          
            ANAFORM.baglanti.Open();
            SqlCommand puanEkle = new SqlCommand("update Table_1 set Puan ='" + Convert.ToString(puan) + "' where ID = @ID", ANAFORM.baglanti);
            puanEkle.Parameters.AddWithValue("@ID", Convert.ToString(ANAFORM.uyeTablosu.Rows[sec].Cells[0].Value));
            puanEkle.ExecuteNonQuery();
            ANAFORM.baglanti.Close();
            ANAFORM.veri_cek();
            puanYaz();
        }
    }
}
