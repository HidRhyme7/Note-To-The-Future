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
    public partial class gecmis : Form
    {
        string con = "data source = ZAFERPC\\SQLEXPRESS ; initial catalog = NoteToTheFuture ; user id = sa ; password = 1046";
        public gecmis()
        {
            InitializeComponent();
        }

        private void btn_gelecek_Click(object sender, EventArgs e)
        {
            gelecek glck = new gelecek();
            glck.Show();
            this.Hide();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();    
            frm.Show();
            this.Hide();
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

        private void btn_gelecek_MouseEnter(object sender, EventArgs e)
        {
            int red = 45;
            int green = 149;
            int blue = 150;
            btn_gelecek.BackColor = Color.FromArgb(red, green, blue);
            btn_gelecek.ForeColor = Color.Black;
        }

        private void btn_gelecek_MouseLeave(object sender, EventArgs e)
        {
            int red = 38;
            int green = 80;
            int blue = 115;
            btn_gelecek.BackColor = Color.FromArgb(red, green, blue);
            btn_gelecek.ForeColor = Color.White;
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

        private void btn_goster_Click(object sender, EventArgs e)
        {
            DateTime verilentarih = DateTime.Now;
            string oncekitarihler = "select * from Notes where DisplayDate < @verilentarih";
            using(SqlConnection conn = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand(oncekitarihler, conn);
                cmd.Parameters.AddWithValue("@verilentarih", verilentarih);

                conn.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                conn.Close();

                dataGridViewgecmis.DataSource = dt;
            }
        }

        private void dataGridViewgecmis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //String değerlerine sütun isimlerini kullanarak değerleri alıp atama yapıyoruz
            string crt_date = dataGridViewgecmis.CurrentRow.Cells["CreatedDate"].Value.ToString();
            string disp_date = dataGridViewgecmis.CurrentRow.Cells["DisplayDate"].Value.ToString();
            string msj = dataGridViewgecmis.CurrentRow.Cells["MessageText"].Value.ToString();

            //Aldığımız değerleri MessageBox ile kullanıcıya gösteriyoruz
            MessageBox.Show("Mesaj :" + msj + "\n" + "Görüntülendiği Tarih : " + disp_date + "\n" + "Oluşturulduğu Tarih : " + crt_date,
                "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
