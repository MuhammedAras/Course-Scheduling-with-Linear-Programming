namespace schedulerr
{
    partial class AnasayfaForm
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
            this.kayitlidersprogramiacBTN = new System.Windows.Forms.Button();
            this.dersprogramiPANEL = new System.Windows.Forms.Panel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.anasayfayageriBTN = new System.Windows.Forms.Button();
            this.hazırlaBTN = new System.Windows.Forms.Button();
            this.dersBTN = new System.Windows.Forms.Button();
            this.hocaBTN = new System.Windows.Forms.Button();
            this.sinifBTN = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.yenidersprogramiac = new System.Windows.Forms.Button();
            this.dersprogramiPANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // kayitlidersprogramiacBTN
            // 
            this.kayitlidersprogramiacBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitlidersprogramiacBTN.Location = new System.Drawing.Point(794, 266);
            this.kayitlidersprogramiacBTN.Name = "kayitlidersprogramiacBTN";
            this.kayitlidersprogramiacBTN.Size = new System.Drawing.Size(255, 213);
            this.kayitlidersprogramiacBTN.TabIndex = 0;
            this.kayitlidersprogramiacBTN.Text = "KAYITLI DERS PROGRAMI AÇ";
            this.kayitlidersprogramiacBTN.UseVisualStyleBackColor = true;
            this.kayitlidersprogramiacBTN.Click += new System.EventHandler(this.kayitlidersprogramiacBTN_Click);
            // 
            // dersprogramiPANEL
            // 
            this.dersprogramiPANEL.BackColor = System.Drawing.Color.Transparent;
            this.dersprogramiPANEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dersprogramiPANEL.Controls.Add(this.circularProgressBar1);
            this.dersprogramiPANEL.Controls.Add(this.label1);
            this.dersprogramiPANEL.Controls.Add(this.anasayfayageriBTN);
            this.dersprogramiPANEL.Controls.Add(this.hazırlaBTN);
            this.dersprogramiPANEL.Controls.Add(this.dersBTN);
            this.dersprogramiPANEL.Controls.Add(this.hocaBTN);
            this.dersprogramiPANEL.Controls.Add(this.sinifBTN);
            this.dersprogramiPANEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dersprogramiPANEL.Location = new System.Drawing.Point(0, 0);
            this.dersprogramiPANEL.Name = "dersprogramiPANEL";
            this.dersprogramiPANEL.Size = new System.Drawing.Size(1339, 676);
            this.dersprogramiPANEL.TabIndex = 1;
            this.dersprogramiPANEL.Visible = false;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 200;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(567, 429);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.White;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 25;
            this.circularProgressBar1.ProgressColor = System.Drawing.SystemColors.HotTrack;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(221, 204);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.SystemColors.Highlight;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 8;
            this.circularProgressBar1.Text = "Hazırlanıyor...";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            this.circularProgressBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yükleniyor...";
            this.label1.Visible = false;
            // 
            // anasayfayageriBTN
            // 
            this.anasayfayageriBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anasayfayageriBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfayageriBTN.ForeColor = System.Drawing.Color.Black;
            this.anasayfayageriBTN.Location = new System.Drawing.Point(216, 587);
            this.anasayfayageriBTN.Name = "anasayfayageriBTN";
            this.anasayfayageriBTN.Size = new System.Drawing.Size(209, 46);
            this.anasayfayageriBTN.TabIndex = 5;
            this.anasayfayageriBTN.Text = "Anasayfa";
            this.anasayfayageriBTN.UseVisualStyleBackColor = true;
            this.anasayfayageriBTN.Click += new System.EventHandler(this.anasayfayageriBTN_Click);
            // 
            // hazırlaBTN
            // 
            this.hazırlaBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hazırlaBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hazırlaBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hazırlaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.hazırlaBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hazırlaBTN.Location = new System.Drawing.Point(932, 216);
            this.hazırlaBTN.Name = "hazırlaBTN";
            this.hazırlaBTN.Size = new System.Drawing.Size(209, 180);
            this.hazırlaBTN.TabIndex = 3;
            this.hazırlaBTN.Text = "HAZIRLA";
            this.hazırlaBTN.UseVisualStyleBackColor = false;
            this.hazırlaBTN.Click += new System.EventHandler(this.hazırlaBTN_Click);
            // 
            // dersBTN
            // 
            this.dersBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dersBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dersBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dersBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dersBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dersBTN.Location = new System.Drawing.Point(698, 216);
            this.dersBTN.Name = "dersBTN";
            this.dersBTN.Size = new System.Drawing.Size(209, 180);
            this.dersBTN.TabIndex = 2;
            this.dersBTN.Text = "DERSLER";
            this.dersBTN.UseVisualStyleBackColor = false;
            this.dersBTN.Click += new System.EventHandler(this.dersBTN_Click);
            // 
            // hocaBTN
            // 
            this.hocaBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hocaBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hocaBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hocaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.hocaBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hocaBTN.Location = new System.Drawing.Point(466, 216);
            this.hocaBTN.Name = "hocaBTN";
            this.hocaBTN.Size = new System.Drawing.Size(209, 180);
            this.hocaBTN.TabIndex = 1;
            this.hocaBTN.Text = "ÖĞRETİM GÖREVLİLERİ";
            this.hocaBTN.UseVisualStyleBackColor = false;
            this.hocaBTN.Click += new System.EventHandler(this.hocaBTN_Click);
            // 
            // sinifBTN
            // 
            this.sinifBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sinifBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sinifBTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.sinifBTN.FlatAppearance.BorderSize = 2;
            this.sinifBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sinifBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sinifBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sinifBTN.Location = new System.Drawing.Point(216, 216);
            this.sinifBTN.Name = "sinifBTN";
            this.sinifBTN.Size = new System.Drawing.Size(209, 180);
            this.sinifBTN.TabIndex = 0;
            this.sinifBTN.Text = "SINIFLAR";
            this.sinifBTN.UseVisualStyleBackColor = false;
            this.sinifBTN.Click += new System.EventHandler(this.sinifBTN_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // yenidersprogramiac
            // 
            this.yenidersprogramiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenidersprogramiac.Location = new System.Drawing.Point(365, 266);
            this.yenidersprogramiac.Name = "yenidersprogramiac";
            this.yenidersprogramiac.Size = new System.Drawing.Size(255, 213);
            this.yenidersprogramiac.TabIndex = 2;
            this.yenidersprogramiac.Text = "YENİ DERS PROGRAMI OLUŞTUR ";
            this.yenidersprogramiac.UseVisualStyleBackColor = true;
            this.yenidersprogramiac.Click += new System.EventHandler(this.yenidersprogramiac_Click);
            // 
            // AnasayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1339, 676);
            this.Controls.Add(this.dersprogramiPANEL);
            this.Controls.Add(this.yenidersprogramiac);
            this.Controls.Add(this.kayitlidersprogramiacBTN);
            this.Name = "AnasayfaForm";
            this.Text = "AnasayfaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.dersprogramiPANEL.ResumeLayout(false);
            this.dersprogramiPANEL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kayitlidersprogramiacBTN;
        private System.Windows.Forms.Panel dersprogramiPANEL;
        private System.Windows.Forms.Button hazırlaBTN;
        private System.Windows.Forms.Button dersBTN;
        private System.Windows.Forms.Button hocaBTN;
        private System.Windows.Forms.Button sinifBTN;
        private System.Windows.Forms.Button anasayfayageriBTN;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button yenidersprogramiac;
        public CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}