namespace schedulerr
{
    partial class SiniflarForm
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
            this.listeleGV = new System.Windows.Forms.DataGridView();
            this.sinif_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinif_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinif_türü = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifidTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sinifsilBTN = new System.Windows.Forms.Button();
            this.sinifguncelleBTN = new System.Windows.Forms.Button();
            this.sinifekleBTN = new System.Windows.Forms.Button();
            this.sinifturuTXT = new System.Windows.Forms.TextBox();
            this.sinifadiTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sinifkaydetBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listeleGV)).BeginInit();
            this.SuspendLayout();
            // 
            // listeleGV
            // 
            this.listeleGV.BackgroundColor = System.Drawing.Color.White;
            this.listeleGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeleGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sinif_id,
            this.sinif_adi,
            this.sinif_türü});
            this.listeleGV.Location = new System.Drawing.Point(322, 270);
            this.listeleGV.Name = "listeleGV";
            this.listeleGV.Size = new System.Drawing.Size(696, 205);
            this.listeleGV.TabIndex = 26;
            // 
            // sinif_id
            // 
            this.sinif_id.DataPropertyName = "sinif_id";
            this.sinif_id.HeaderText = "SINIF ID";
            this.sinif_id.Name = "sinif_id";
            this.sinif_id.Width = 130;
            // 
            // sinif_adi
            // 
            this.sinif_adi.DataPropertyName = "sinif_adi";
            this.sinif_adi.HeaderText = "SINIF ADI";
            this.sinif_adi.Name = "sinif_adi";
            this.sinif_adi.Width = 201;
            // 
            // sinif_türü
            // 
            this.sinif_türü.DataPropertyName = "sinif_türü";
            this.sinif_türü.HeaderText = "SINIF TÜRÜ";
            this.sinif_türü.Name = "sinif_türü";
            this.sinif_türü.Width = 322;
            // 
            // sinifidTXT
            // 
            this.sinifidTXT.Location = new System.Drawing.Point(773, 155);
            this.sinifidTXT.Name = "sinifidTXT";
            this.sinifidTXT.Size = new System.Drawing.Size(155, 20);
            this.sinifidTXT.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(707, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Silmek veya güncellemek istediğiniz ID yi giriniz:";
            // 
            // sinifsilBTN
            // 
            this.sinifsilBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinifsilBTN.Location = new System.Drawing.Point(917, 194);
            this.sinifsilBTN.Name = "sinifsilBTN";
            this.sinifsilBTN.Size = new System.Drawing.Size(92, 30);
            this.sinifsilBTN.TabIndex = 22;
            this.sinifsilBTN.Text = "Sil";
            this.sinifsilBTN.UseVisualStyleBackColor = true;
            this.sinifsilBTN.Click += new System.EventHandler(this.sinifsilBTN_Click);
            // 
            // sinifguncelleBTN
            // 
            this.sinifguncelleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinifguncelleBTN.Location = new System.Drawing.Point(804, 194);
            this.sinifguncelleBTN.Name = "sinifguncelleBTN";
            this.sinifguncelleBTN.Size = new System.Drawing.Size(92, 30);
            this.sinifguncelleBTN.TabIndex = 21;
            this.sinifguncelleBTN.Text = "Güncelle";
            this.sinifguncelleBTN.UseVisualStyleBackColor = true;
            this.sinifguncelleBTN.Click += new System.EventHandler(this.sinifguncelleBTN_Click);
            // 
            // sinifekleBTN
            // 
            this.sinifekleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinifekleBTN.Location = new System.Drawing.Point(691, 194);
            this.sinifekleBTN.Name = "sinifekleBTN";
            this.sinifekleBTN.Size = new System.Drawing.Size(92, 30);
            this.sinifekleBTN.TabIndex = 20;
            this.sinifekleBTN.Text = "Ekle";
            this.sinifekleBTN.UseVisualStyleBackColor = true;
            this.sinifekleBTN.Click += new System.EventHandler(this.sinifekleBTN_Click);
            // 
            // sinifturuTXT
            // 
            this.sinifturuTXT.Location = new System.Drawing.Point(395, 183);
            this.sinifturuTXT.Name = "sinifturuTXT";
            this.sinifturuTXT.Size = new System.Drawing.Size(150, 20);
            this.sinifturuTXT.TabIndex = 19;
            // 
            // sinifadiTXT
            // 
            this.sinifadiTXT.Location = new System.Drawing.Point(395, 139);
            this.sinifadiTXT.Name = "sinifadiTXT";
            this.sinifadiTXT.Size = new System.Drawing.Size(150, 20);
            this.sinifadiTXT.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(317, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sınıf Türü :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(317, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sınıf Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(571, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "SINIFLAR";
            // 
            // sinifkaydetBTN
            // 
            this.sinifkaydetBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinifkaydetBTN.Location = new System.Drawing.Point(882, 494);
            this.sinifkaydetBTN.Name = "sinifkaydetBTN";
            this.sinifkaydetBTN.Size = new System.Drawing.Size(136, 30);
            this.sinifkaydetBTN.TabIndex = 28;
            this.sinifkaydetBTN.Text = "İşlemleri Kaydet";
            this.sinifkaydetBTN.UseVisualStyleBackColor = true;
            this.sinifkaydetBTN.Click += new System.EventHandler(this.sinifkaydetBTN_Click);
            // 
            // SiniflarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.sinifkaydetBTN);
            this.Controls.Add(this.listeleGV);
            this.Controls.Add(this.sinifidTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sinifsilBTN);
            this.Controls.Add(this.sinifguncelleBTN);
            this.Controls.Add(this.sinifekleBTN);
            this.Controls.Add(this.sinifturuTXT);
            this.Controls.Add(this.sinifadiTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SiniflarForm";
            this.Text = "SiniflarForm";
            ((System.ComponentModel.ISupportInitialize)(this.listeleGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView listeleGV;
        private System.Windows.Forms.TextBox sinifidTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sinifsilBTN;
        private System.Windows.Forms.Button sinifguncelleBTN;
        private System.Windows.Forms.Button sinifekleBTN;
        private System.Windows.Forms.TextBox sinifturuTXT;
        private System.Windows.Forms.TextBox sinifadiTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sinifkaydetBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinif_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinif_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinif_türü;
    }
}