
namespace waffleCaffe
{
    partial class eklesil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eklesil));
            this.baslik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goruntuleBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.guncelleBTN = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.silBtn = new System.Windows.Forms.Button();
            this.geriBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.ForeColor = System.Drawing.Color.Gray;
            this.baslik.Location = new System.Drawing.Point(715, 34);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(487, 44);
            this.baslik.TabIndex = 2;
            this.baslik.Text = "SİPARİŞ GÖRÜNTÜLE VE SİL";
            this.baslik.Click += new System.EventHandler(this.baslik_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 98);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // goruntuleBtn
            // 
            this.goruntuleBtn.Location = new System.Drawing.Point(439, 355);
            this.goruntuleBtn.Name = "goruntuleBtn";
            this.goruntuleBtn.Size = new System.Drawing.Size(138, 54);
            this.goruntuleBtn.TabIndex = 1;
            this.goruntuleBtn.Text = "Görüntüle";
            this.goruntuleBtn.UseVisualStyleBackColor = true;
            this.goruntuleBtn.Click += new System.EventHandler(this.goruntuleBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.guncelleBTN);
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.silBtn);
            this.groupBox3.Controls.Add(this.goruntuleBtn);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(12, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1524, 514);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Masa Tercih Görüntüle Ve Sil";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // guncelleBTN
            // 
            this.guncelleBTN.Location = new System.Drawing.Point(1264, 26);
            this.guncelleBTN.Name = "guncelleBTN";
            this.guncelleBTN.Size = new System.Drawing.Size(161, 64);
            this.guncelleBTN.TabIndex = 9;
            this.guncelleBTN.Text = "Kayıt Güncelleme Sayfası";
            this.guncelleBTN.UseVisualStyleBackColor = true;
            this.guncelleBTN.Click += new System.EventHandler(this.guncelleBTN_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Sienna;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1459, 184);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick_2);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Masa Numarası";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Çikolata Tercihi";
            this.columnHeader2.Width = 233;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Meyve Tercihi";
            this.columnHeader3.Width = 169;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Süs Tercihi";
            this.columnHeader4.Width = 190;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İçecek Tercihi";
            this.columnHeader5.Width = 161;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(794, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOT: Masa Numarasını ÇİFT TIKLAYIP seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(794, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kayıt Silmek İçin İlk Olarak \'Görüntüle\' Butonuna Basınız\r\n\'Masa Numarası\' Alanın" +
    "dan Masa Seçimi Yaptıktan sonra \'Sil\' Butonuna Tıklayınız";
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(821, 355);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(138, 54);
            this.silBtn.TabIndex = 3;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // geriBTN
            // 
            this.geriBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriBTN.Location = new System.Drawing.Point(22, 24);
            this.geriBTN.Name = "geriBTN";
            this.geriBTN.Size = new System.Drawing.Size(138, 54);
            this.geriBTN.TabIndex = 6;
            this.geriBTN.Text = "Önceki Sayfa";
            this.geriBTN.UseVisualStyleBackColor = true;
            this.geriBTN.Click += new System.EventHandler(this.geriBTN_Click);
            // 
            // eklesil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1548, 625);
            this.Controls.Add(this.geriBTN);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.baslik);
            this.Name = "eklesil";
            this.Text = "eklesil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button goruntuleBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button guncelleBTN;
        private System.Windows.Forms.Button geriBTN;
    }
}