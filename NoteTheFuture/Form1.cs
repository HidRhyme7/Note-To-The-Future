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
    public partial class Form1 : Form
    {
        string con = "data source = ZAFERPC\\SQLEXPRESS ; initial catalog = NoteToTheFuture ; user id = sa ; password = 1046";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gelecek_Click(object sender, EventArgs e)
        {
            //Gelecek adlı formun yüklenmesi ve bulunduğumuz formun görünmez olması
            gelecek gelecek = new gelecek();
            gelecek.Show();
            this.Hide();
        }

        private void btn_gecmis_Click(object sender, EventArgs e)
        {
            //Geçmiş adlı formun yüklenmesi ve bulunduğumuz formun görünmez olması
            gecmis gecmis = new gecmis();
            gecmis.Show();
            this.Hide();
        }

        private void txt_mesaj_Enter(object sender, EventArgs e)
        {
            //RichTextBox üzerine basıldığında Mesajınızı Yazınız metni silinmektedir
            if(txt_mesaj.Text == "Mesajınızı Yazınız ...")
            {
                txt_mesaj.Text = "";
            }
        }

        private void txt_mesaj_Leave(object sender, EventArgs e)
        {
            //RichTextBox üzerinden çıkıldığında eğer hiçbir şey yazılmamışsa 
            //Mesajınızı Yazınız metni yazılmaktadır
            if ( txt_mesaj.Text == "")
            {
                txt_mesaj.Text = "Mesajınızı Yazınız ...";
            }
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

        private void btn_kaydet_MouseEnter(object sender, EventArgs e)
        {
            //Butonun üstüne gelindiğinde BackColor'ın ve ForeColor'ın renkleri
            int red = 45;
            int green = 149;
            int blue = 150;
            btn_kaydet.BackColor = Color.FromArgb(red, green, blue);
            btn_kaydet.ForeColor = Color.Black;
        }

        private void btn_kaydet_MouseLeave(object sender, EventArgs e)
        {
            //Butonun üstünden çıkılınca BackColor'ın ve ForeColor'ın renkleri
            int red = 38;
            int green = 80;
            int blue = 115;
            btn_kaydet.BackColor = Color.FromArgb(red, green, blue);
            btn_kaydet.ForeColor = Color.White;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            //SQL sorgususunu string değere atamak
            string into = "insert into Notes (MessageText, DisplayDate, CreatedDate) values (@message, @d_date, @c_date)";
            using(SqlConnection conn = new SqlConnection(con))
            {
                //SQL sorgusunu yap
                SqlCommand cmd = new SqlCommand(into, conn);

                //Veritabanımıza değerleri gönderme
                cmd.Parameters.AddWithValue("@message", txt_mesaj.Text);
                cmd.Parameters.AddWithValue("@d_date", DateTime.Parse(dtp_tarih.Text));
                DateTime now = DateTime.Now;
                cmd.Parameters.AddWithValue("c_date", now);

                //Bağlantıyı açıp kapama
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void dtp_tarih_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime bugununTarihi = DateTime.Today;

            // SQL sorgusu
            string sorgu = "SELECT MessageText FROM Notes WHERE DisplayDate = @bugununTarihi";

            using (SqlConnection conn = new SqlConnection(con))
            {
                // SqlCommand ve parametreleri oluşturma
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@bugununTarihi", bugununTarihi);

                // Veritabanı bağlantısını açma
                conn.Open();
                
                // Sorguyu çalıştırma ve sonucu al
                object sonuc = cmd.ExecuteScalar();

                // Sonucun kontrolü ve MessageBox ile gösterimi
                if (sonuc != null)
                {
                    MessageBox.Show("Mesajınız : " + sonuc.ToString(), "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bugün için bir mesaj bulunamadı.","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
