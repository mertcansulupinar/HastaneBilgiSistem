namespace hastane
{
    partial class FrmBilgiDüzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDüzenleme));
            this.btngüncelle = new System.Windows.Forms.Button();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.btngizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.White;
            this.btngüncelle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.Location = new System.Drawing.Point(172, 231);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(101, 31);
            this.btngüncelle.TabIndex = 8;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.Btngüncelle_Click);
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(153, 194);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(139, 31);
            this.cmbcinsiyet.TabIndex = 6;
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(153, 159);
            this.txtsifre.MaxLength = 10;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(139, 29);
            this.txtsifre.TabIndex = 5;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // msktelefon
            // 
            this.msktelefon.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktelefon.Location = new System.Drawing.Point(153, 124);
            this.msktelefon.Mask = "(599) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(139, 29);
            this.msktelefon.TabIndex = 4;
            // 
            // msktc
            // 
            this.msktc.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktc.Location = new System.Drawing.Point(153, 89);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(139, 29);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(153, 54);
            this.txtsoyad.MaxLength = 20;
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(139, 29);
            this.txtsoyad.TabIndex = 2;
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(153, 19);
            this.txtad.MaxLength = 20;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(139, 29);
            this.txtad.TabIndex = 1;
            this.txtad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtad_KeyPress);
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.lblcinsiyet.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcinsiyet.Location = new System.Drawing.Point(63, 194);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(84, 23);
            this.lblcinsiyet.TabIndex = 18;
            this.lblcinsiyet.Text = "Cinsiyet:";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.BackColor = System.Drawing.Color.Transparent;
            this.lblsifre.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.Location = new System.Drawing.Point(91, 162);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(56, 23);
            this.lblsifre.TabIndex = 17;
            this.lblsifre.Text = "Şifre:";
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.BackColor = System.Drawing.Color.Transparent;
            this.lbltelefon.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltelefon.Location = new System.Drawing.Point(69, 124);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(78, 23);
            this.lbltelefon.TabIndex = 16;
            this.lbltelefon.Text = "Telefon:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.BackColor = System.Drawing.Color.Transparent;
            this.lbltc.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Location = new System.Drawing.Point(15, 89);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(132, 23);
            this.lbltc.TabIndex = 15;
            this.lbltc.Text = "TC Kimlik No:";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblsoyad.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.Location = new System.Drawing.Point(80, 54);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(67, 23);
            this.lblsoyad.TabIndex = 14;
            this.lblsoyad.Text = "Soyad:";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.BackColor = System.Drawing.Color.Transparent;
            this.lblad.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Location = new System.Drawing.Point(107, 19);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(40, 23);
            this.lblad.TabIndex = 13;
            this.lblad.Text = "Ad:";
            // 
            // btngizle
            // 
            this.btngizle.BackColor = System.Drawing.Color.Transparent;
            this.btngizle.BackgroundImage = global::hastane.Properties.Resources.eye_close;
            this.btngizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngizle.Location = new System.Drawing.Point(298, 162);
            this.btngizle.Name = "btngizle";
            this.btngizle.Size = new System.Drawing.Size(25, 25);
            this.btngizle.TabIndex = 7;
            this.btngizle.UseVisualStyleBackColor = false;
            this.btngizle.Click += new System.EventHandler(this.btngizle_Click);
            // 
            // FrmBilgiDüzenleme
            // 
            this.AcceptButton = this.btngüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::hastane.Properties.Resources.background_update;
            this.ClientSize = new System.Drawing.Size(329, 271);
            this.Controls.Add(this.btngizle);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lblcinsiyet);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lbltelefon);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lblad);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDüzenleme";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDüzenleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Button btngizle;
    }
}