using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class frmInfoCrmNaoGestante : Form
    {
        public frmInfoCrmNaoGestante()
        {
            InitializeComponent();
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            this.Close();
            var frmicng4 = new frmInfoCrmNaoGestante4();
            frmicng4.Show();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Close();
            var frmicng3 = new frmInfoCrmNaoGestante3();
            frmicng3.Show();
        }
    }
}
