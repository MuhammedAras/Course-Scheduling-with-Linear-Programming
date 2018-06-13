namespace schedulerr
{
    partial class DersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label13 = new System.Windows.Forms.Label();
            this.dershocasiCOMBO = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dersGV = new System.Windows.Forms.DataGridView();
            this.ders_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ders_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ders_sinifturu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ders_tipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oturum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oturum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ders_donemi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ders_hocaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersislemlerikaydetBTN = new System.Windows.Forms.Button();
            this.dersidTXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.derssilBTN = new System.Windows.Forms.Button();
            this.dersguncelleBTN = new System.Windows.Forms.Button();
            this.dersekleBTN = new System.Windows.Forms.Button();
            this.dersadiTXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sinifturuCOMBO = new System.Windows.Forms.ComboBox();
            this.derstipiCOMBO = new System.Windows.Forms.ComboBox();
            this.dersdonemCOMBO = new System.Windows.Forms.ComboBox();
            this.oturum1TXT = new System.Windows.Forms.TextBox();
            this.oturum2TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teopraCOMBO = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.atananBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(255, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 16);
            this.label13.TabIndex = 101;
            this.label13.Text = "Toplam Saat :";
            // 
            // dershocasiCOMBO
            // 
            this.dershocasiCOMBO.FormattingEnabled = true;
            this.dershocasiCOMBO.Location = new System.Drawing.Point(405, 297);
            this.dershocasiCOMBO.Name = "dershocasiCOMBO";
            this.dershocasiCOMBO.Size = new System.Drawing.Size(217, 19);
            this.dershocasiCOMBO.TabIndex = 100;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(258, 298);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 16);
            this.label15.TabIndex = 98;
            this.label15.Text = "Ders Hocası :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(258, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 97;
            this.label16.Text = "Ders Yılı :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(258, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 95;
            this.label14.Text = "Ders Tipi :";
            // 
            // dersGV
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dersGV.BackgroundColor = System.Drawing.Color.White;
            this.dersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dersGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ders_id,
            this.ders_adi,
            this.ders_sinifturu,
            this.ders_tipi,
            this.oturum1,
            this.oturum2,
            this.ders_donemi,
            this.ders_hocaid});
            this.dersGV.Location = new System.Drawing.Point(258, 342);
            this.dersGV.Name = "dersGV";
            this.dersGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dersGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dersGV.Size = new System.Drawing.Size(865, 190);
            this.dersGV.TabIndex = 93;
            this.dersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dersGV_CellContentClick);
            // 
            // ders_id
            // 
            this.ders_id.DataPropertyName = "ders_id";
            this.ders_id.HeaderText = "DERS ID";
            this.ders_id.Name = "ders_id";
            this.ders_id.Width = 82;
            // 
            // ders_adi
            // 
            this.ders_adi.DataPropertyName = "ders_adi";
            this.ders_adi.HeaderText = "DERS ADI";
            this.ders_adi.Name = "ders_adi";
            this.ders_adi.Width = 200;
            // 
            // ders_sinifturu
            // 
            this.ders_sinifturu.DataPropertyName = "ders_sinifturu";
            this.ders_sinifturu.HeaderText = "SINIF TÜRÜ";
            this.ders_sinifturu.Name = "ders_sinifturu";
            this.ders_sinifturu.Width = 80;
            // 
            // ders_tipi
            // 
            this.ders_tipi.DataPropertyName = "ders_tipi";
            this.ders_tipi.HeaderText = "DERS TİPİ";
            this.ders_tipi.Name = "ders_tipi";
            // 
            // oturum1
            // 
            this.oturum1.DataPropertyName = "oturum1";
            this.oturum1.HeaderText = "OTURUM-1";
            this.oturum1.Name = "oturum1";
            // 
            // oturum2
            // 
            this.oturum2.DataPropertyName = "oturum2";
            this.oturum2.HeaderText = "OTURUM-2";
            this.oturum2.Name = "oturum2";
            // 
            // ders_donemi
            // 
            this.ders_donemi.DataPropertyName = "ders_donemi";
            this.ders_donemi.HeaderText = "DERS YILI";
            this.ders_donemi.Name = "ders_donemi";
            this.ders_donemi.Width = 80;
            // 
            // ders_hocaid
            // 
            this.ders_hocaid.DataPropertyName = "ders_hocaid";
            this.ders_hocaid.HeaderText = "HOCA ID";
            this.ders_hocaid.Name = "ders_hocaid";
            this.ders_hocaid.Width = 80;
            // 
            // dersislemlerikaydetBTN
            // 
            this.dersislemlerikaydetBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersislemlerikaydetBTN.ForeColor = System.Drawing.Color.Black;
            this.dersislemlerikaydetBTN.Location = new System.Drawing.Point(926, 553);
            this.dersislemlerikaydetBTN.Name = "dersislemlerikaydetBTN";
            this.dersislemlerikaydetBTN.Size = new System.Drawing.Size(197, 28);
            this.dersislemlerikaydetBTN.TabIndex = 92;
            this.dersislemlerikaydetBTN.Text = "İşlemleri  Kaydet";
            this.dersislemlerikaydetBTN.UseVisualStyleBackColor = true;
            this.dersislemlerikaydetBTN.Click += new System.EventHandler(this.dersislemlerikaydetBTN_Click);
            // 
            // dersidTXT
            // 
            this.dersidTXT.Location = new System.Drawing.Point(855, 167);
            this.dersidTXT.Name = "dersidTXT";
            this.dersidTXT.Size = new System.Drawing.Size(181, 20);
            this.dersidTXT.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(770, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(343, 16);
            this.label9.TabIndex = 90;
            this.label9.Text = "Silmek veya güncellemek istediğiniz dersin ID sini giriniz:";
            // 
            // derssilBTN
            // 
            this.derssilBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.derssilBTN.ForeColor = System.Drawing.Color.Black;
            this.derssilBTN.Location = new System.Drawing.Point(1024, 201);
            this.derssilBTN.Name = "derssilBTN";
            this.derssilBTN.Size = new System.Drawing.Size(99, 26);
            this.derssilBTN.TabIndex = 89;
            this.derssilBTN.Text = "Sil";
            this.derssilBTN.UseVisualStyleBackColor = true;
            this.derssilBTN.Click += new System.EventHandler(this.derssilBTN_Click);
            // 
            // dersguncelleBTN
            // 
            this.dersguncelleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersguncelleBTN.ForeColor = System.Drawing.Color.Black;
            this.dersguncelleBTN.Location = new System.Drawing.Point(898, 201);
            this.dersguncelleBTN.Name = "dersguncelleBTN";
            this.dersguncelleBTN.Size = new System.Drawing.Size(98, 26);
            this.dersguncelleBTN.TabIndex = 88;
            this.dersguncelleBTN.Text = "Güncelle";
            this.dersguncelleBTN.UseVisualStyleBackColor = true;
            this.dersguncelleBTN.Click += new System.EventHandler(this.dersguncelleBTN_Click);
            // 
            // dersekleBTN
            // 
            this.dersekleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersekleBTN.ForeColor = System.Drawing.Color.Black;
            this.dersekleBTN.Location = new System.Drawing.Point(773, 201);
            this.dersekleBTN.Name = "dersekleBTN";
            this.dersekleBTN.Size = new System.Drawing.Size(98, 26);
            this.dersekleBTN.TabIndex = 87;
            this.dersekleBTN.Text = "Ekle";
            this.dersekleBTN.UseVisualStyleBackColor = true;
            this.dersekleBTN.Click += new System.EventHandler(this.dersekleBTN_Click);
            // 
            // dersadiTXT
            // 
            this.dersadiTXT.Location = new System.Drawing.Point(405, 132);
            this.dersadiTXT.Name = "dersadiTXT";
            this.dersadiTXT.Size = new System.Drawing.Size(217, 20);
            this.dersadiTXT.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(258, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 84;
            this.label10.Text = "Sınıf Türü :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(258, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 83;
            this.label11.Text = "Ders Adı :";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(639, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 37);
            this.label12.TabIndex = 82;
            this.label12.Text = "DERSLER";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sinifturuCOMBO
            // 
            this.sinifturuCOMBO.FormattingEnabled = true;
            this.sinifturuCOMBO.Location = new System.Drawing.Point(405, 201);
            this.sinifturuCOMBO.Name = "sinifturuCOMBO";
            this.sinifturuCOMBO.Size = new System.Drawing.Size(217, 19);
            this.sinifturuCOMBO.TabIndex = 103;
            // 
            // derstipiCOMBO
            // 
            this.derstipiCOMBO.FormattingEnabled = true;
            this.derstipiCOMBO.Location = new System.Drawing.Point(405, 224);
            this.derstipiCOMBO.Name = "derstipiCOMBO";
            this.derstipiCOMBO.Size = new System.Drawing.Size(217, 19);
            this.derstipiCOMBO.TabIndex = 104;
            // 
            // dersdonemCOMBO
            // 
            this.dersdonemCOMBO.FormattingEnabled = true;
            this.dersdonemCOMBO.Location = new System.Drawing.Point(405, 249);
            this.dersdonemCOMBO.Name = "dersdonemCOMBO";
            this.dersdonemCOMBO.Size = new System.Drawing.Size(217, 19);
            this.dersdonemCOMBO.TabIndex = 105;
            // 
            // oturum1TXT
            // 
            this.oturum1TXT.Location = new System.Drawing.Point(405, 271);
            this.oturum1TXT.Name = "oturum1TXT";
            this.oturum1TXT.Size = new System.Drawing.Size(89, 20);
            this.oturum1TXT.TabIndex = 106;
            // 
            // oturum2TXT
            // 
            this.oturum2TXT.Location = new System.Drawing.Point(527, 271);
            this.oturum2TXT.Name = "oturum2TXT";
            this.oturum2TXT.Size = new System.Drawing.Size(96, 20);
            this.oturum2TXT.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(502, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 108;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(258, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 109;
            this.label2.Text = "Teo-Pra :";
            // 
            // teopraCOMBO
            // 
            this.teopraCOMBO.FormattingEnabled = true;
            this.teopraCOMBO.Location = new System.Drawing.Point(405, 156);
            this.teopraCOMBO.Name = "teopraCOMBO";
            this.teopraCOMBO.Size = new System.Drawing.Size(217, 19);
            this.teopraCOMBO.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(319, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 13);
            this.label3.TabIndex = 111;
            this.label3.Text = "*Ders Teorik ve Pratik olarak işleniyorsa Teo-Pra seçilmelidir.";
            // 
            // atananBTN
            // 
            this.atananBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.atananBTN.ForeColor = System.Drawing.Color.Black;
            this.atananBTN.Location = new System.Drawing.Point(773, 286);
            this.atananBTN.Name = "atananBTN";
            this.atananBTN.Size = new System.Drawing.Size(350, 33);
            this.atananBTN.TabIndex = 112;
            this.atananBTN.Text = "SABİT DERS ATA";
            this.atananBTN.UseVisualStyleBackColor = true;
            this.atananBTN.Click += new System.EventHandler(this.atananBTN_Click);
            // 
            // DersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 635);
            this.Controls.Add(this.atananBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teopraCOMBO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oturum2TXT);
            this.Controls.Add(this.oturum1TXT);
            this.Controls.Add(this.dersdonemCOMBO);
            this.Controls.Add(this.derstipiCOMBO);
            this.Controls.Add(this.sinifturuCOMBO);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dershocasiCOMBO);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dersGV);
            this.Controls.Add(this.dersislemlerikaydetBTN);
            this.Controls.Add(this.dersidTXT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.derssilBTN);
            this.Controls.Add(this.dersguncelleBTN);
            this.Controls.Add(this.dersekleBTN);
            this.Controls.Add(this.dersadiTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DersForm";
            this.Text = "DersForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox dershocasiCOMBO;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dersGV;
        private System.Windows.Forms.Button dersislemlerikaydetBTN;
        private System.Windows.Forms.TextBox dersidTXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button derssilBTN;
        private System.Windows.Forms.Button dersguncelleBTN;
        private System.Windows.Forms.Button dersekleBTN;
        private System.Windows.Forms.TextBox dersadiTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox sinifturuCOMBO;
        private System.Windows.Forms.ComboBox derstipiCOMBO;
        private System.Windows.Forms.ComboBox dersdonemCOMBO;
        private System.Windows.Forms.TextBox oturum1TXT;
        private System.Windows.Forms.TextBox oturum2TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ders_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ders_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ders_sinifturu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ders_tipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn oturum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oturum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ders_donemi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ders_hocaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox teopraCOMBO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button atananBTN;
    }
}