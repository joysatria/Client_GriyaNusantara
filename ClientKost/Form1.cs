using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientKost
{
    public partial class Form1 : Form
    {

        ClientKost.ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

        public Form1()
        {
            InitializeComponent();

            TampilData();
            bt_update.Enabled = false;
            bt_delete.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textBox_ID.Text;
            string NamaPemesan = textBox_Nama.Text;
            string NoTelpon = textBox_Notelp.Text;
            int WaktuSewa = int.Parse(textBox_Waktu.Text);
            string IDKamar = textBox_Idkamar.Text;


            var a = service.pemesanan(IDPemesanan, NamaPemesan, NoTelpon, WaktuSewa, IDKamar);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textBox_ID.Text;
            string NamaPemesan = textBox_Nama.Text;
            string No_Telpon = textBox_Notelp.Text;

            var a = service.editPemesanan(IDPemesanan, NamaPemesan, No_Telpon);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string IDPemesanan = textBox_ID.Text;

            var a = service.deletePemesanan(IDPemesanan);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            textBox_ID.Clear();
            textBox_Nama.Clear();
            textBox_Notelp.Clear();
            textBox_Waktu.Clear();
            textBox_Idkamar.Clear();

            textBox_Waktu.Enabled = true;
            textBox_Idkamar.Enabled = true;

            bt_save.Enabled = true;
            bt_update.Enabled = false;
            bt_delete.Enabled = false;

            textBox_ID.Enabled = true;
        }

        private void TampilData()
        {
            var List = service.Pemesanan1();
            dtPemesanan.DataSource = List;
        }

        private void dtPemesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ID.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[0].Value);
            textBox_Nama.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[1].Value);
            textBox_Notelp.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[2].Value);
            textBox_Waktu.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[3].Value);
            textBox_Idkamar.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[4].Value);

            textBox_Waktu.Enabled = false;
            textBox_Idkamar.Enabled = false;

            bt_update.Enabled = true;
            bt_delete.Enabled = true;

            bt_save.Enabled = false;
            textBox_ID.Enabled = false;
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }
    }
}
