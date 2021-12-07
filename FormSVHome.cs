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
    public partial class FormSVHome : Form
    {
        public FormSVHome()
        {
            InitializeComponent();
        }

        private void but_DX_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDN fdn = new FormDN();
            fdn.Show();
        }

        private void but_doimk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formdoimk doimk = new Formdoimk();
            doimk.Show();
        }

        private void but_dslop_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSLOP dsl = new FormDSLOP();
            dsl.Show();
        }

        private void but_xemdiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSDIEM dsd = new FormDSDIEM();
            dsd.Show();
        }

        private void but_danglam_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDetaiDL dtdl = new FormDetaiDL();
            dtdl.Show();
        }
    }
}
