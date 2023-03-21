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
    public partial class Weather_Report : Form
    {
        public Weather_Report()
        {
            InitializeComponent();
        }
        private void Weather_Report_Load(object sender, EventArgs e)
        {
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
        }
        private void rdB1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdB1.Checked == true)
            {
                pic1.Visible = true;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
            }

        }

        private void rdB2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdB2.Checked == true)
            {
                pic1.Visible = false;
                pic2.Visible = true;
                pic3.Visible = false;
                pic4.Visible = false;
            }

        }

        private void rdB3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdB3.Checked == true)
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = true;
                pic4.Visible = false;
            }
        }

        private void rdB4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdB4.Checked == true)
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string ms = "";
            if (rdB1.Checked == true)
            {
                ms = " Hôm nay trời có mây";
            }
            else if (rdB2.Checked == true)
            {
                ms = " Hôm nay trời có mưa";
            }
            else if (rdB3.Checked == true)
            {
                ms = " Hôm nay trời có tuyến";
            }
            else if (rdB4.Checked == true)
            {
                ms = "Hôm nay trời có nắng";
            }
            lblDisplay.Text = "Xin chào " + txtName.Text + ms;
        }
    }
}
