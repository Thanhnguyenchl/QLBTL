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
    public partial class FormDSLOP : Form
    {
        public FormDSLOP()
        {
            InitializeComponent();
        }

        private void but_QL_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSVHome svh = new FormSVHome();
            svh.Show();
        }
    }
}
