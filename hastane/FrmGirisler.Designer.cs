namespace hastane
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btnhasta = new System.Windows.Forms.Button();
            this.btndoktor = new System.Windows.Forms.Button();
            this.btnsekreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhasta
            // 
            this.btnhasta.BackColor = System.Drawing.Color.Transparent;
            this.btnhasta.BackgroundImage = global::hastane.Properties.Resources.patienticon_1;
            this.btnhasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhasta.Location = new System.Drawing.Point(85, 130);
            this.btnhasta.Name = "btnhasta";
            this.btnhasta.Size = new System.Drawing.Size(120, 90);
            this.btnhasta.TabIndex = 0;
            this.btnhasta.UseVisualStyleBackColor = false;
            this.btnhasta.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btndoktor
            // 
            this.btndoktor.BackColor = System.Drawing.Color.Transparent;
            this.btndoktor.BackgroundImage = global::hastane.Properties.Resources.doctoricon_1;
            this.btndoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktor.Location = new System.Drawing.Point(235, 130);
            this.btndoktor.Name = "btndoktor";
            this.btndoktor.Size = new System.Drawing.Size(120, 90);
            this.btndoktor.TabIndex = 1;
            this.btndoktor.UseVisualStyleBackColor = false;
            this.btndoktor.Click += new System.EventHandler(this.Btndoktor_Click);
            // 
            // btnsekreter
            // 
            this.btnsekreter.BackColor = System.Drawing.Color.Transparent;
            this.btnsekreter.BackgroundImage = global::hastane.Properties.Resources.secretericon_1;
            this.btnsekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsekreter.Location = new System.Drawing.Point(385, 130);
            this.btnsekreter.Name = "btnsekreter";
            this.btnsekreter.Size = new System.Drawing.Size(120, 90);
            this.btnsekreter.TabIndex = 2;
            this.btnsekreter.UseVisualStyleBackColor = false;
            this.btnsekreter.Click += new System.EventHandler(this.Btnsekreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(117, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(263, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(407, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 60);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hastanemiz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::hastane.Properties.Resources.background_entire;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsekreter);
            this.Controls.Add(this.btndoktor);
            this.Controls.Add(this.btnhasta);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastanemiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGirisler_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhasta;
        private System.Windows.Forms.Button btndoktor;
        private System.Windows.Forms.Button btnsekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

