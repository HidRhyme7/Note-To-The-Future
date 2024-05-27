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

namespace NoteTheFuture
{
    public partial class gelecek : Form
    {
        string con = "data source = ZAFERPC\\SQLEXPRESS ; initial catalog = NoteToTheFuture ; user id = sa ; password = 1046";
        public gelecek()
        {
            InitializeComponent();
        }

        private void btn_gecmis_Click(object sender, EventArgs e)
        {
            //Geçmişte Kalan notlar sayfasını açar ve bu sayfa görünmez olur
            gecmis gcms = new gecmis();
            gcms.Show();
            this.Hide();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            //Geleceğe Not sayfasını açar ve bu sayfa görünmez olur
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btn_gecmis_MouseEnter(object sender, EventArgs e)
        {
            int red = 45;
            int green = 149;
            int blue = 150;
            btn_gecmis.BackColor = Color.FromArgb(red, green, blue);
            btn_gecmis.ForeColor = Color.Black;
        }

        private void btn_gecmis_MouseLeave(object sender, EventArgs e)
        {
            int red = 38;
            int green = 80;
            int blue = 115;
            btn_gecmis.BackColor = Color.FromArgb(red, green, blue);
            btn_gecmis.ForeColor = Color.White;
        }

        private void btn_anasayfa_MouseEnter(object sender, EventArgs e)
        {
            int red = 45;
            int green = 149;
            int blue = 150;
            btn_anasayfa.BackColor = Color.FromArgb(red, green, blue);
            btn_anasayfa.ForeColor = Color.Black;
        }

        private void btn_anasayfa_MouseLeave(object sender, EventArgs e)
        {
            int red = 38;
            int green = 80;
            int blue = 115;
            btn_anasayfa.BackColor = Color.FromArgb(red, green, blue);
            btn_anasayfa.ForeColor = Color.White;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_goster_MouseEnter(object sender, EventArgs e)
        {
            int red = 45;
            int green = 149;
            int blue = 150;
            btn_goster.BackColor = Color.FromArgb(red, green, blue);
            btn_goster.ForeColor = Color.Black;
        }

        private void btn_goster_MouseLeave(object sender, EventArgs e)
        {
            int red = 38;
            int green = 80;
            int blue = 115;
            btn_goster.BackColor = Color.FromArgb(red, green, blue);
            btn_goster.ForeColor = Color.White;
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            /*DateTime verilentarih = DateTime.Now;
            List<DateTime> vt_tarihler = new List<DateTime>();

            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select DisplayDate from Notes", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    DateTime tarih = reader.GetDateTime(0);
                    vt_tarihler.Add(tarih);
                }                

                foreach(DateTime tarih in vt_tarihler)
                {
                    if(tarih.CompareTo(verilentarih) < 0)
                    {
                        oncekitarihler.Add(tarih);
                    }
                    else
                    {
                        sonrakitarihler.Add(tarih);
                    }
                }

                dataGridViewgelecek.DataSource = sonrakitarihler;
            }*/

            DateTime verilentarih = DateTime.Now;
            string sonrakitarihler = "select * from Notes where DisplayDate > @verilentarih";

            using(SqlConnection conn = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand(sonrakitarihler, conn);
                cmd.Parameters.AddWithValue("@verilentarih", verilentarih);

                conn.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                conn.Close();

                dataGridViewgelecek.DataSource = dt;
            }
        }

        private void dataGridViewgelecek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //String değerlerine sütun isimlerini kullanarak değerleri alıp atama yapıyoruz
            string crt_date = dataGridViewgelecek.CurrentRow.Cells["CreatedDate"].Value.ToString();
            string dsp_date = dataGridViewgelecek.CurrentRow.Cells["DisplayDate"].Value.ToString();
            string msj = dataGridViewgelecek.CurrentRow.Cells["MessageText"].Value.ToString();

            //Aldığımız değerleri MessageBox ile kullanıcıya gösteriyoruz
            MessageBox.Show("Mesaj : " + msj + "\n" + "Görüntüleneceği Tarih : " + dsp_date + "\n" + "Oluşturulduğu Tarih : " + crt_date,
                "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
