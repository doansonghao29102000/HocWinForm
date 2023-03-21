using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBuoi1
{
    public partial class HoTen : Form
    {
        public HoTen()
        {
            InitializeComponent();
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblTen.Text = txtTen.Text;
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            lblHoLot.Text = txtHoLot.Text;
        }

        private void btnHoVaTen_Click(object sender, EventArgs e)
        {
            lblHoVaTen.Text = txtHoLot.Text + " " + txtTen.Text;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChagedHoLot(object sender, EventArgs e)
        {
            lblHoLot.Text = txtHoLot.Text;
        }

        private void txtHoLot_KeyDown(object sender, KeyEventArgs e)
        {
            lblHoLot.Text = txtHoLot.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            lblTen.Text = txtTen.Text;
        }
    }
}
