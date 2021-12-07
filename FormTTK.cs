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
    public partial class FormTTK : Form
    {
        public FormTTK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTTKGV ttkgv = new FormTTKGV();
            ttkgv.Show();
        }

        private void but_TTKSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTTKSV ttksv = new FormTTKSV();
            ttksv.Show();
        }

        private void but_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDN fdn = new FormDN();
            fdn.Show();
        }

        private void but_TTKAd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTTKAD ttkad = new FormTTKAD();
            ttkad.Show();
        }
    }
}
