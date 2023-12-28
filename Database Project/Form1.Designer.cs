namespace Database_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataCridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNo = new System.Windows.Forms.TextBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtMasa = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.BtnArama = new System.Windows.Forms.Button();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataCridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCridView1
            // 
            this.dataCridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCridView1.Location = new System.Drawing.Point(741, 39);
            this.dataCridView1.Name = "dataCridView1";
            this.dataCridView1.RowHeadersWidth = 51;
            this.dataCridView1.RowTemplate.Height = 24;
            this.dataCridView1.Size = new System.Drawing.Size(599, 575);
            this.dataCridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel No";
            // 
            // TxtNo
            // 
            this.TxtNo.BackColor = System.Drawing.Color.DarkRed;
            this.TxtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNo.ForeColor = System.Drawing.Color.Black;
            this.TxtNo.Location = new System.Drawing.Point(399, 127);
            this.TxtNo.Name = "TxtNo";
            this.TxtNo.Size = new System.Drawing.Size(168, 27);
            this.TxtNo.TabIndex = 2;
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.DarkRed;
            this.BtnListele.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnListele.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListele.Location = new System.Drawing.Point(27, 464);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(170, 64);
            this.BtnListele.TabIndex = 3;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 4;
            this.label2.Tag = "  ";
            this.label2.Text = "          Ad           ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "      Soy Ad      ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "        Masa         ";
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.Color.DarkRed;
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAd.ForeColor = System.Drawing.Color.Black;
            this.TxtAd.Location = new System.Drawing.Point(399, 192);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(168, 27);
            this.TxtAd.TabIndex = 7;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BackColor = System.Drawing.Color.DarkRed;
            this.TxtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSoyad.ForeColor = System.Drawing.Color.Black;
            this.TxtSoyad.Location = new System.Drawing.Point(399, 256);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(168, 27);
            this.TxtSoyad.TabIndex = 8;
            // 
            // TxtMasa
            // 
            this.TxtMasa.BackColor = System.Drawing.Color.DarkRed;
            this.TxtMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMasa.ForeColor = System.Drawing.Color.Black;
            this.TxtMasa.Location = new System.Drawing.Point(399, 318);
            this.TxtMasa.Name = "TxtMasa";
            this.TxtMasa.Size = new System.Drawing.Size(168, 27);
            this.TxtMasa.TabIndex = 9;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEkle.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEkle.Location = new System.Drawing.Point(203, 464);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(170, 64);
            this.BtnEkle.TabIndex = 10;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.DarkRed;
            this.BtnSil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSil.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSil.Location = new System.Drawing.Point(379, 464);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(170, 64);
            this.BtnSil.TabIndex = 11;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.DarkRed;
            this.BtnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuncelle.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuncelle.Location = new System.Drawing.Point(555, 464);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(170, 64);
            this.BtnGuncelle.TabIndex = 12;
            this.BtnGuncelle.Text = "Guncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnArama
            // 
            this.BtnArama.BackColor = System.Drawing.Color.DarkRed;
            this.BtnArama.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnArama.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArama.Location = new System.Drawing.Point(288, 550);
            this.BtnArama.Name = "BtnArama";
            this.BtnArama.Size = new System.Drawing.Size(170, 64);
            this.BtnArama.TabIndex = 13;
            this.BtnArama.Text = "Arama";
            this.BtnArama.UseVisualStyleBackColor = false;
            this.BtnArama.Click += new System.EventHandler(this.BtnArama_Click);
            // 
            // Txt_Search
            // 
            this.Txt_Search.BackColor = System.Drawing.Color.DarkRed;
            this.Txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Search.ForeColor = System.Drawing.Color.Black;
            this.Txt_Search.Location = new System.Drawing.Point(491, 571);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(168, 27);
            this.Txt_Search.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1382, 697);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.BtnArama);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtMasa);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataCridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNo;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtMasa;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Button BtnArama;
        private System.Windows.Forms.TextBox Txt_Search;
    }
}

