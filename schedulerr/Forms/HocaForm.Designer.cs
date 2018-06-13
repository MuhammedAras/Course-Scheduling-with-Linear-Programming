namespace schedulerr
{
    partial class HocaForm
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
            this.hocaGV = new System.Windows.Forms.DataGridView();
            this.hoca_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolu_saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocaislemlerikaydetBTN = new System.Windows.Forms.Button();
            this.hocaIdTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hocaSilBTN = new System.Windows.Forms.Button();
            this.hocaGuncelleBTN = new System.Windows.Forms.Button();
            this.hocaEkleBTN = new System.Windows.Forms.Button();
            this.hocaadsoyadTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.unvanCOMBO = new System.Windows.Forms.ComboBox();
            this.dolusaatBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hocaGV)).BeginInit();
            this.SuspendLayout();
            // 
            // hocaGV
            // 
            this.hocaGV.BackgroundColor = System.Drawing.Color.White;
            this.hocaGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hocaGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoca_id,
            this.unvan,
            this.adsoyad,
            this.dolu_saat});
            this.hocaGV.Location = new System.Drawing.Point(246, 384);
            this.hocaGV.Margin = new System.Windows.Forms.Padding(4);
            this.hocaGV.Name = "hocaGV";
            this.hocaGV.Size = new System.Drawing.Size(887, 220);
            this.hocaGV.TabIndex = 61;
            // 
            // hoca_id
            // 
            this.hoca_id.DataPropertyName = "hoca_id";
            this.hoca_id.HeaderText = "HOCA ID";
            this.hoca_id.Name = "hoca_id";
            this.hoca_id.Width = 120;
            // 
            // unvan
            // 
            this.unvan.DataPropertyName = "unvan";
            this.unvan.HeaderText = "ÜNVAN";
            this.unvan.Name = "unvan";
            // 
            // adsoyad
            // 
            this.adsoyad.DataPropertyName = "adsoyad";
            this.adsoyad.HeaderText = "AD SOYAD";
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Width = 200;
            // 
            // dolu_saat
            // 
            this.dolu_saat.DataPropertyName = "dolu_saat";
            this.dolu_saat.HeaderText = "DOLU OLDUĞU SAATLER";
            this.dolu_saat.Name = "dolu_saat";
            this.dolu_saat.Width = 424;
            // 
            // hocaislemlerikaydetBTN
            // 
            this.hocaislemlerikaydetBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hocaislemlerikaydetBTN.Location = new System.Drawing.Point(988, 640);
            this.hocaislemlerikaydetBTN.Margin = new System.Windows.Forms.Padding(4);
            this.hocaislemlerikaydetBTN.Name = "hocaislemlerikaydetBTN";
            this.hocaislemlerikaydetBTN.Size = new System.Drawing.Size(145, 28);
            this.hocaislemlerikaydetBTN.TabIndex = 60;
            this.hocaislemlerikaydetBTN.Text = "İşlemleri Kaydet";
            this.hocaislemlerikaydetBTN.UseVisualStyleBackColor = true;
            this.hocaislemlerikaydetBTN.Click += new System.EventHandler(this.hocaislemlerikaydetBTN_Click);
            // 
            // hocaIdTXT
            // 
            this.hocaIdTXT.Location = new System.Drawing.Point(846, 189);
            this.hocaIdTXT.Margin = new System.Windows.Forms.Padding(4);
            this.hocaIdTXT.Name = "hocaIdTXT";
            this.hocaIdTXT.Size = new System.Drawing.Size(219, 22);
            this.hocaIdTXT.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(780, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Silmek veya güncellemek istediğiniz hocanın ID sini giriniz:";
            // 
            // hocaSilBTN
            // 
            this.hocaSilBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hocaSilBTN.Location = new System.Drawing.Point(1041, 230);
            this.hocaSilBTN.Margin = new System.Windows.Forms.Padding(4);
            this.hocaSilBTN.Name = "hocaSilBTN";
            this.hocaSilBTN.Size = new System.Drawing.Size(72, 28);
            this.hocaSilBTN.TabIndex = 57;
            this.hocaSilBTN.Text = "Sil";
            this.hocaSilBTN.UseVisualStyleBackColor = true;
            this.hocaSilBTN.Click += new System.EventHandler(this.hocaSilBTN_Click);
            // 
            // hocaGuncelleBTN
            // 
            this.hocaGuncelleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hocaGuncelleBTN.Location = new System.Drawing.Point(929, 230);
            this.hocaGuncelleBTN.Margin = new System.Windows.Forms.Padding(4);
            this.hocaGuncelleBTN.Name = "hocaGuncelleBTN";
            this.hocaGuncelleBTN.Size = new System.Drawing.Size(72, 28);
            this.hocaGuncelleBTN.TabIndex = 56;
            this.hocaGuncelleBTN.Text = "Güncelle";
            this.hocaGuncelleBTN.UseVisualStyleBackColor = true;
            this.hocaGuncelleBTN.Click += new System.EventHandler(this.hocaGuncelleBTN_Click);
            // 
            // hocaEkleBTN
            // 
            this.hocaEkleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hocaEkleBTN.Location = new System.Drawing.Point(815, 230);
            this.hocaEkleBTN.Margin = new System.Windows.Forms.Padding(4);
            this.hocaEkleBTN.Name = "hocaEkleBTN";
            this.hocaEkleBTN.Size = new System.Drawing.Size(72, 28);
            this.hocaEkleBTN.TabIndex = 55;
            this.hocaEkleBTN.Text = "Ekle";
            this.hocaEkleBTN.UseVisualStyleBackColor = true;
            this.hocaEkleBTN.Click += new System.EventHandler(this.hocaEkleBTN_Click);
            // 
            // hocaadsoyadTXT
            // 
            this.hocaadsoyadTXT.Location = new System.Drawing.Point(385, 215);
            this.hocaadsoyadTXT.Margin = new System.Windows.Forms.Padding(4);
            this.hocaadsoyadTXT.Name = "hocaadsoyadTXT";
            this.hocaadsoyadTXT.Size = new System.Drawing.Size(199, 22);
            this.hocaadsoyadTXT.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(244, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Ad Soyad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(244, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Ünvan :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(523, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 37);
            this.label8.TabIndex = 50;
            this.label8.Text = "DERS HOCALARI";
            // 
            // unvanCOMBO
            // 
            this.unvanCOMBO.FormattingEnabled = true;
            this.unvanCOMBO.Location = new System.Drawing.Point(385, 178);
            this.unvanCOMBO.Name = "unvanCOMBO";
            this.unvanCOMBO.Size = new System.Drawing.Size(199, 24);
            this.unvanCOMBO.TabIndex = 62;
            // 
            // dolusaatBTN
            // 
            this.dolusaatBTN.Location = new System.Drawing.Point(385, 253);
            this.dolusaatBTN.Name = "dolusaatBTN";
            this.dolusaatBTN.Size = new System.Drawing.Size(199, 23);
            this.dolusaatBTN.TabIndex = 63;
            this.dolusaatBTN.Text = "Görüntüle";
            this.dolusaatBTN.UseVisualStyleBackColor = true;
            this.dolusaatBTN.Click += new System.EventHandler(this.dolusaatBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Dolu Olduğu Saatler :";
            // 
            // HocaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dolusaatBTN);
            this.Controls.Add(this.unvanCOMBO);
            this.Controls.Add(this.hocaGV);
            this.Controls.Add(this.hocaislemlerikaydetBTN);
            this.Controls.Add(this.hocaIdTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hocaSilBTN);
            this.Controls.Add(this.hocaGuncelleBTN);
            this.Controls.Add(this.hocaEkleBTN);
            this.Controls.Add(this.hocaadsoyadTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HocaForm";
            this.Text = "HocaForm";
            ((System.ComponentModel.ISupportInitialize)(this.hocaGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView hocaGV;
        private System.Windows.Forms.Button hocaislemlerikaydetBTN;
        private System.Windows.Forms.TextBox hocaIdTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button hocaSilBTN;
        private System.Windows.Forms.Button hocaGuncelleBTN;
        private System.Windows.Forms.Button hocaEkleBTN;
        private System.Windows.Forms.TextBox hocaadsoyadTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoca_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolu_saat;
        private System.Windows.Forms.ComboBox unvanCOMBO;
        private System.Windows.Forms.Button dolusaatBTN;
        private System.Windows.Forms.Label label1;
    }
}