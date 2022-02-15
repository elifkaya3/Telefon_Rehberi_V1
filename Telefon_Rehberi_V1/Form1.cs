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

namespace Telefon_Rehberi_V1
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        DataTable dt;
        string baglantiCumlesi= @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=SRehber; User=sa; Pwd=123";
        string sorguCumlesi;
        SqlCommand komut;
        public Form1()
        {
            InitializeComponent();
        }

      void KisileriGetir()
        {
            sorguCumlesi = "SELECT * FROM tblKisiler";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi,baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource=dt;
        }
        void Aktar()
        {
            //dgvKisiler Üzerinde tıklandığında yan tarafa ilgili kaydın değerleirni getireck
            lblID.Text = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            if (dgvKisiler.CurrentRow.Cells[3].Value.ToString()=="K")
            {
                rdbKadın.Checked = true;
            }
            else
            {
                rdbErkek.Checked = true;
            }
            txtTelNo.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();
        }
        void Duzelt()
        {
            string Ad = txtAd.Text;
            string Soyad = txtSoyad.Text;
            char cinsiyet;
            if (rdbKadın.Checked==true)
            {
                cinsiyet = 'K';
            }
            else
            {
                cinsiyet = 'E';
            }
            string tel = txtTelNo.Text;
            string ID = lblID.Text;
            sorguCumlesi = $"UPDATE tblKisiler set Ad='{Ad}',Soyad='{Soyad}',Cinsiyet='{cinsiyet}',Telefon='{tel}' WHERE ID={ID}";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriGetir();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KisileriGetir();
        }

        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        private void btnDüzelt_Click(object sender, EventArgs e)
        {
            Duzelt();
        }
    }
}
