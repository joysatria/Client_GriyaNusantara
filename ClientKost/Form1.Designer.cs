
namespace ClientKost
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Nama = new System.Windows.Forms.TextBox();
            this.textBox_Waktu = new System.Windows.Forms.TextBox();
            this.textBox_Idkamar = new System.Windows.Forms.TextBox();
            this.textBox_Notelp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPemesanan = new System.Windows.Forms.DataGridView();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pemesanan";
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_save.FlatAppearance.BorderSize = 0;
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Location = new System.Drawing.Point(602, 90);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(100, 31);
            this.bt_save.TabIndex = 1;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(238, 85);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(307, 22);
            this.textBox_ID.TabIndex = 2;
            // 
            // textBox_Nama
            // 
            this.textBox_Nama.Location = new System.Drawing.Point(238, 124);
            this.textBox_Nama.Name = "textBox_Nama";
            this.textBox_Nama.Size = new System.Drawing.Size(307, 22);
            this.textBox_Nama.TabIndex = 3;
            // 
            // textBox_Waktu
            // 
            this.textBox_Waktu.Location = new System.Drawing.Point(238, 201);
            this.textBox_Waktu.Name = "textBox_Waktu";
            this.textBox_Waktu.Size = new System.Drawing.Size(307, 22);
            this.textBox_Waktu.TabIndex = 4;
            // 
            // textBox_Idkamar
            // 
            this.textBox_Idkamar.Location = new System.Drawing.Point(238, 239);
            this.textBox_Idkamar.Name = "textBox_Idkamar";
            this.textBox_Idkamar.Size = new System.Drawing.Size(307, 22);
            this.textBox_Idkamar.TabIndex = 5;
            // 
            // textBox_Notelp
            // 
            this.textBox_Notelp.Location = new System.Drawing.Point(238, 163);
            this.textBox_Notelp.Name = "textBox_Notelp";
            this.textBox_Notelp.Size = new System.Drawing.Size(307, 22);
            this.textBox_Notelp.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama Pemesanan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "No Telepon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Waktu Sewa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID Kamar";
            // 
            // dtPemesanan
            // 
            this.dtPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPemesanan.Location = new System.Drawing.Point(126, 288);
            this.dtPemesanan.Name = "dtPemesanan";
            this.dtPemesanan.RowHeadersWidth = 51;
            this.dtPemesanan.RowTemplate.Height = 24;
            this.dtPemesanan.Size = new System.Drawing.Size(576, 150);
            this.dtPemesanan.TabIndex = 14;
            this.dtPemesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPemesanan_CellContentClick);
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_clear.FlatAppearance.BorderSize = 0;
            this.bt_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_clear.Location = new System.Drawing.Point(602, 206);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(100, 31);
            this.bt_clear.TabIndex = 15;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_delete.FlatAppearance.BorderSize = 0;
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Location = new System.Drawing.Point(602, 168);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(100, 31);
            this.bt_delete.TabIndex = 16;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_update.FlatAppearance.BorderSize = 0;
            this.bt_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_update.Location = new System.Drawing.Point(602, 129);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(100, 31);
            this.bt_update.TabIndex = 17;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_logout.FlatAppearance.BorderSize = 0;
            this.bt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logout.Location = new System.Drawing.Point(602, 456);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(100, 31);
            this.bt_logout.TabIndex = 18;
            this.bt_logout.Text = "Logout";
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.dtPemesanan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Notelp);
            this.Controls.Add(this.textBox_Idkamar);
            this.Controls.Add(this.textBox_Waktu);
            this.Controls.Add(this.textBox_Nama);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Pemesanan";
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Nama;
        private System.Windows.Forms.TextBox textBox_Waktu;
        private System.Windows.Forms.TextBox textBox_Idkamar;
        private System.Windows.Forms.TextBox textBox_Notelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtPemesanan;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_logout;
    }
}

