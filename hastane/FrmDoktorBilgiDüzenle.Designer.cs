namespace hastane
{
    partial class FrmDoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDüzenle));
            this.btnbilgigüncelle = new System.Windows.Forms.Button();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.lblbrans = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btngizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbilgigüncelle
            // 
            this.btnbilgigüncelle.BackColor = System.Drawing.Color.White;
            this.btnbilgigüncelle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbilgigüncelle.Location = new System.Drawing.Point(172, 194);
            this.btnbilgigüncelle.Name = "btnbilgigüncelle";
            this.btnbilgigüncelle.Size = new System.Drawing.Size(101, 31);
            this.btnbilgigüncelle.TabIndex = 7;
            this.btnbilgigüncelle.Text = "Güncelle";
            this.btnbilgigüncelle.UseVisualStyleBackColor = false;
            this.btnbilgigüncelle.Click += new System.EventHandler(this.Btnbilgigüncelle_Click);
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
            this.txtsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoyad_KeyPress);
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
            this.lblcinsiyet.Location = new System.Drawing.Point(91, 162);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(56, 23);
            this.lblcinsiyet.TabIndex = 31;
            this.lblcinsiyet.Text = "Şifre:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.BackColor = System.Drawing.Color.Transparent;
            this.lbltc.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Location = new System.Drawing.Point(15, 89);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(132, 23);
            this.lbltc.TabIndex = 28;
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
            this.lblsoyad.TabIndex = 27;
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
            this.lblad.TabIndex = 26;
            this.lblad.Text = "Ad:";
            // 
            // cmbbrans
            // 
            this.cmbbrans.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbbrans.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbbrans.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(153, 124);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(139, 31);
            this.cmbbrans.TabIndex = 4;
            // 
            // lblbrans
            // 
            this.lblbrans.AutoSize = true;
            this.lblbrans.BackColor = System.Drawing.Color.Transparent;
            this.lblbrans.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbrans.Location = new System.Drawing.Point(82, 124);
            this.lblbrans.Name = "lblbrans";
            this.lblbrans.Size = new System.Drawing.Size(65, 23);
            this.lblbrans.TabIndex = 39;
            this.lblbrans.Text = "Branş:";
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
            // btngizle
            // 
            this.btngizle.BackColor = System.Drawing.Color.Transparent;
            this.btngizle.BackgroundImage = global::hastane.Properties.Resources.eye_close;
            this.btngizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngizle.Location = new System.Drawing.Point(298, 162);
            this.btngizle.Name = "btngizle";
            this.btngizle.Size = new System.Drawing.Size(25, 25);
            this.btngizle.TabIndex = 6;
            this.btngizle.UseVisualStyleBackColor = false;
            this.btngizle.Click += new System.EventHandler(this.btngizle_Click);
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AcceptButton = this.btnbilgigüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::hastane.Properties.Resources.background_doctoricon_update;
            this.ClientSize = new System.Drawing.Size(334, 241);
            this.Controls.Add(this.btngizle);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.lblbrans);
            this.Controls.Add(this.btnbilgigüncelle);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lblcinsiyet);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lblad);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "Doktor Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbilgigüncelle;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.Label lblbrans;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btngizle;
    }
}