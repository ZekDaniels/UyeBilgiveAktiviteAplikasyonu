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
    public partial class aramaSayfasi : Form
    {
        public aramaSayfasi()
        {
            InitializeComponent();
        }
        
       
        private void aramaSayfasi_Load(object sender, EventArgs e)
        {
            adAra.Clear();
            soyadAra.Clear();
            telnoAra.Clear();
            fakulteAra.Clear();
            bolumAra.Clear();
            komiteAra.SelectedIndex = 0;
        }

        private void btnAraForm_Click(object sender, EventArgs e)
        {
            
            
           ANAFORM.baglanti.Open();
            SqlCommand bul = new SqlCommand("SELECT *FROM Table_1 WHERE Ad LIKE '%"+adAra.Text+"%' OR Soyad LIKE '%"+soyadAra.Text+
                "%' OR Telefon LIKE'%"+telnoAra.Text+"%' OR Fakülte LIKE '%"+fakulteAra.Text+"%' OR Bölüm LIKE '%"+bolumAra.Text+"%'OR Komite LIKE '%"+komiteAra.Text+"%'",ANAFORM.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(bul);
            DataSet ds = new DataSet();
            da.Fill(ds,"Table_1");
           ANAFORM.uyeTablosu.DataSource = ds.Tables["Table_1"];
           ANAFORM.baglanti.Close();
            
        }

        private void btnTemizleAraForm_Click(object sender, EventArgs e)
        {
            adAra.Clear();
            soyadAra.Clear();
            telnoAra.Clear();
            fakulteAra.Clear();
            bolumAra.Clear();
            komiteAra.SelectedIndex = 0;
            ANAFORM.veri_cek();
        }
    }
}
