using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_bài_tập_lớn
{
    public partial class FormTTKGV : Form
    {
        public FormTTKGV()
        {
            InitializeComponent();
        }

        private void but_tiep_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_magv.Text = "";
            txt_tk.Text = "";
            txt_mk.Text = "";
            txt_xmmk.Text = "";
            txt_email.Text = "";
            rad_nam.Checked = false;
            rad_nu.Checked = false;
        }

        private void but_TTK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tạo tài khoản thành công!");
        }

        private void but_QL_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTTK fttk = new FormTTK();
            fttk.Show();
        }
    }
}
