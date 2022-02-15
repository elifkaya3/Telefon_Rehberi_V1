
namespace Telefon_Rehberi_V1
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
            this.dgvKisiler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.rdbKadın = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.lblID = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnDüzelt = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKisiler
            // 
            this.dgvKisiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKisiler.Location = new System.Drawing.Point(13, 82);
            this.dgvKisiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKisiler.Name = "dgvKisiler";
            this.dgvKisiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKisiler.Size = new System.Drawing.Size(463, 253);
            this.dgvKisiler.TabIndex = 0;
            this.dgvKisiler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKisiler_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(525, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(523, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(523, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(523, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(523, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tel. No:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(612, 119);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(181, 27);
            this.txtAd.TabIndex = 1;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelNo.Location = new System.Drawing.Point(612, 239);
            this.txtTelNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(181, 27);
            this.txtTelNo.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(612, 160);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(181, 27);
            this.txtSoyad.TabIndex = 2;
            // 
            // rdbKadın
            // 
            this.rdbKadın.AutoSize = true;
            this.rdbKadın.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbKadın.Location = new System.Drawing.Point(612, 203);
            this.rdbKadın.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbKadın.Name = "rdbKadın";
            this.rdbKadın.Size = new System.Drawing.Size(66, 23);
            this.rdbKadın.TabIndex = 3;
            this.rdbKadın.TabStop = true;
            this.rdbKadın.Text = "Kadın";
            this.rdbKadın.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbErkek.Location = new System.Drawing.Point(708, 203);
            this.rdbErkek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(65, 23);
            this.rdbErkek.TabIndex = 4;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(608, 82);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(50, 19);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "label6";
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Location = new System.Drawing.Point(504, 301);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(100, 34);
            this.btnYeni.TabIndex = 6;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // btnDüzelt
            // 
            this.btnDüzelt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDüzelt.Location = new System.Drawing.Point(612, 301);
            this.btnDüzelt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDüzelt.Name = "btnDüzelt";
            this.btnDüzelt.Size = new System.Drawing.Size(100, 34);
            this.btnDüzelt.TabIndex = 7;
            this.btnDüzelt.Text = "Düzelt";
            this.btnDüzelt.UseVisualStyleBackColor = true;
            this.btnDüzelt.Click += new System.EventHandler(this.btnDüzelt_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(720, 300);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 34);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(13, 45);
            this.txtAranan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(319, 27);
            this.txtAranan.TabIndex = 15;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(376, 40);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 34);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 385);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDüzelt);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.rdbErkek);
            this.Controls.Add(this.rdbKadın);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKisiler);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Telefon Rehberi v1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKisiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.RadioButton rdbKadın;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnDüzelt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Button btnAra;
    }
}

