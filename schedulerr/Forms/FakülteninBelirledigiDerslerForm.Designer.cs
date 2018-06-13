namespace schedulerr.Forms
{
    partial class FakülteninBelirledigiDerslerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            atanandersCOMBO = new System.Windows.Forms.ComboBox();
            this.atananderslerBTN = new System.Windows.Forms.Button();
            this.silBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dersidTXT = new System.Windows.Forms.TextBox();
            atananderslerGV = new System.Windows.Forms.DataGridView();
            this.atananders_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ders_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atanan_saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(atananderslerGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1285, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "FAKÜLTE TARAFINDAN ATANAN DERS SAATLERİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(508, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders Seçiniz :";
            // 
            // atanandersCOMBO
            // 
            atanandersCOMBO.FormattingEnabled = true;
            atanandersCOMBO.Location = new System.Drawing.Point(620, 139);
            atanandersCOMBO.Name = "atanandersCOMBO";
            atanandersCOMBO.Size = new System.Drawing.Size(238, 21);
            atanandersCOMBO.TabIndex = 2;
            // 
            // atananderslerBTN
            // 
            this.atananderslerBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.atananderslerBTN.Location = new System.Drawing.Point(512, 185);
            this.atananderslerBTN.Name = "atananderslerBTN";
            this.atananderslerBTN.Size = new System.Drawing.Size(346, 30);
            this.atananderslerBTN.TabIndex = 5;
            this.atananderslerBTN.Text = "Dersin İşleneceği Saatleri Seçiniz";
            this.atananderslerBTN.UseVisualStyleBackColor = true;
            this.atananderslerBTN.Click += new System.EventHandler(this.atananderslerBTN_Click);
            // 
            // silBTN
            // 
            this.silBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBTN.Location = new System.Drawing.Point(620, 322);
            this.silBTN.Name = "silBTN";
            this.silBTN.Size = new System.Drawing.Size(128, 28);
            this.silBTN.TabIndex = 7;
            this.silBTN.Text = "Sil";
            this.silBTN.UseVisualStyleBackColor = true;
            this.silBTN.Click += new System.EventHandler(this.silBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(552, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Silmek istediğiniz dersin ID sini giriniz";
            // 
            // dersidTXT
            // 
            this.dersidTXT.Location = new System.Drawing.Point(620, 284);
            this.dersidTXT.Name = "dersidTXT";
            this.dersidTXT.Size = new System.Drawing.Size(128, 20);
            this.dersidTXT.TabIndex = 9;
            // 
            // atananderslerGV
            // 
            atananderslerGV.BackgroundColor = System.Drawing.Color.White;
            atananderslerGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            atananderslerGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.atananders_id,
            this.ders_adi,
            this.atanan_saat});
            atananderslerGV.Location = new System.Drawing.Point(365, 372);
            atananderslerGV.Name = "atananderslerGV";
            atananderslerGV.Size = new System.Drawing.Size(654, 150);
            atananderslerGV.TabIndex = 10;
            // 
            // atananders_id
            // 
            this.atananders_id.DataPropertyName = "atananders_id";
            this.atananders_id.HeaderText = "ATANAN DERS ID";
            this.atananders_id.Name = "atananders_id";
            // 
            // ders_adi
            // 
            this.ders_adi.DataPropertyName = "ders_adi";
            this.ders_adi.HeaderText = "DERS ADI ";
            this.ders_adi.Name = "ders_adi";
            this.ders_adi.Width = 210;
            // 
            // atanan_saat
            // 
            this.atanan_saat.DataPropertyName = "atanan_saat";
            this.atanan_saat.HeaderText = "ATANAN DERS SAATLERİ";
            this.atanan_saat.Name = "atanan_saat";
            this.atanan_saat.Width = 300;
            // 
            // FakülteninBelirledigiDerslerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(atananderslerGV);
            this.Controls.Add(this.dersidTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.silBTN);
            this.Controls.Add(this.atananderslerBTN);
            this.Controls.Add(atanandersCOMBO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FakülteninBelirledigiDerslerForm";
            this.Text = "FakülteninBelirledigiDerslerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(atananderslerGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button atananderslerBTN;
        private System.Windows.Forms.Button silBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dersidTXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn atananders_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ders_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn atanan_saat;
        public static System.Windows.Forms.ComboBox atanandersCOMBO;
        public static  System.Windows.Forms.DataGridView atananderslerGV;
    }
}