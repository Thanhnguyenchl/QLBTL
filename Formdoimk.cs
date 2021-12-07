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
    public partial class Formdoimk : Form
    {
        public Formdoimk()
        {
            InitializeComponent();
        }

        private void but_Doi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đổi mật khẩu thành công");
        }

        private void but_QL_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSVHome svh = new FormSVHome();
            svh.Show();
        }
    }
}
