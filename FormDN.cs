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
    public partial class FormDN : Form
    {
        public FormDN()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_TTK_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdDN fadn = new FormAdDN();
            fadn.Show();
        }

        private void but_DN_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSVHome fsvh = new FormSVHome();
            fsvh.Show();
        }
    }
}
