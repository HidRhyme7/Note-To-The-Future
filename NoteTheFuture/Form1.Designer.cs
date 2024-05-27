namespace NoteTheFuture
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_gelecek = new System.Windows.Forms.Button();
            this.btn_gecmis = new System.Windows.Forms.Button();
            this.txt_mesaj = new System.Windows.Forms.RichTextBox();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gelecek
            // 
            this.btn_gelecek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.btn_gelecek.ForeColor = System.Drawing.Color.White;
            this.btn_gelecek.Location = new System.Drawing.Point(529, 20);
            this.btn_gelecek.Name = "btn_gelecek";
            this.btn_gelecek.Size = new System.Drawing.Size(100, 50);
            this.btn_gelecek.TabIndex = 1;
            this.btn_gelecek.Text = "Gelecek";
            this.btn_gelecek.UseVisualStyleBackColor = false;
            this.btn_gelecek.Click += new System.EventHandler(this.btn_gelecek_Click);
            this.btn_gelecek.MouseEnter += new System.EventHandler(this.btn_gelecek_MouseEnter);
            this.btn_gelecek.MouseLeave += new System.EventHandler(this.btn_gelecek_MouseLeave);
            // 
            // btn_gecmis
            // 
            this.btn_gecmis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.btn_gecmis.ForeColor = System.Drawing.Color.White;
            this.btn_gecmis.Location = new System.Drawing.Point(70, 20);
            this.btn_gecmis.Name = "btn_gecmis";
            this.btn_gecmis.Size = new System.Drawing.Size(100, 50);
            this.btn_gecmis.TabIndex = 0;
            this.btn_gecmis.Text = "Geçmiş";
            this.btn_gecmis.UseVisualStyleBackColor = false;
            this.btn_gecmis.Click += new System.EventHandler(this.btn_gecmis_Click);
            this.btn_gecmis.MouseEnter += new System.EventHandler(this.btn_gecmis_MouseEnter);
            this.btn_gecmis.MouseLeave += new System.EventHandler(this.btn_gecmis_MouseLeave);
            // 
            // txt_mesaj
            // 
            this.txt_mesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(208)))), ((int)(((byte)(194)))));
            this.txt_mesaj.Location = new System.Drawing.Point(20, 125);
            this.txt_mesaj.Name = "txt_mesaj";
            this.txt_mesaj.Size = new System.Drawing.Size(609, 116);
            this.txt_mesaj.TabIndex = 4;
            this.txt_mesaj.Text = "Mesajınızı Yazınız ...";
            this.txt_mesaj.Enter += new System.EventHandler(this.txt_mesaj_Enter);
            this.txt_mesaj.Leave += new System.EventHandler(this.txt_mesaj_Leave);
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.CustomFormat = "dd/MM/yyy                                                            HH:mm";
            this.dtp_tarih.Location = new System.Drawing.Point(20, 87);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(609, 22);
            this.dtp_tarih.TabIndex = 2;
            this.dtp_tarih.ValueChanged += new System.EventHandler(this.dtp_tarih_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(479, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(329, 261);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kaydet.Location = new System.Drawing.Point(70, 261);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(85, 50);
            this.btn_kaydet.TabIndex = 8;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            this.btn_kaydet.MouseEnter += new System.EventHandler(this.btn_kaydet_MouseEnter);
            this.btn_kaydet.MouseLeave += new System.EventHandler(this.btn_kaydet_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(20, 261);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(646, 373);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.txt_mesaj);
            this.Controls.Add(this.btn_gecmis);
            this.Controls.Add(this.btn_gelecek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geleceğe Not";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_gelecek;
        private System.Windows.Forms.Button btn_gecmis;
        private System.Windows.Forms.RichTextBox txt_mesaj;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

