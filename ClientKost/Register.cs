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
    public partial class Register : Form
    {
        ClientKost.ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Register()
        {
            InitializeComponent();

            TampilData();
            textBoxID.Visible = false;
            bt_update.Enabled = false;
            bt_delete.Enabled = false;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string kategori = comboBoxKategori.Text;
            string a = service.Register(username, password, kategori);

            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || comboBoxKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi.");
            }
            else
            {
                MessageBox.Show(a);
                Refresh();
                TampilData();
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string kategori = comboBoxKategori.Text;
            int id = Convert.ToInt32(textBoxID.Text);
            string a = service.UpdateRegister(username, password, kategori, id);

            if (textBoxUsername.Text == "" || textBoxPassword.Text == "" || comboBoxKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi.");
            }
            else
            {
                MessageBox.Show(a);
                Refresh();
                TampilData();
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;

            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?",
                "Hapus Data?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string a = service.DeleteRegister(username);
                MessageBox.Show(a);
                Clear();
                TampilData();
            }
        }


        private void bt_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void TampilData()
        {
            var list = service.DataRegist();
            dtRegister.DataSource = list;
        }

        private void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            comboBoxKategori.SelectedItem = null;

            bt_save.Enabled = true;
            bt_update.Enabled = false;
            bt_delete.Enabled = false;
        }

        private void dtRegister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[0].Value);
            textBoxUsername.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[1].Value);
            textBoxPassword.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[2].Value);
            comboBoxKategori.Text = Convert.ToString(dtRegister.Rows[e.RowIndex].Cells[3].Value);

            bt_update.Enabled = true;
            bt_delete.Enabled = true;

            bt_save.Enabled = false;
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }
    }
}
