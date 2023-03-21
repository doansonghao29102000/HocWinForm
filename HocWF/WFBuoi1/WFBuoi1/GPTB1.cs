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
    public partial class GPTB1 : Form
    {
        public GPTB1(string b , string c)
        {
            InitializeComponent();
            txtA.Text = b;
            txtB.Text = c;  
        }

        private void btnGPT_Click(object sender, EventArgs e)
        {
            double a, b, x;
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            if(a == 0)
            {
                if(b == 0)
                {
                    txtNo1.Text = "Phương trình vô số nghiệm";
                }
                else
                {
                    txtNo1.Text = "Phương trình vô nghiệm";
                }
            }
            else
            {
                txtNo1.Text = -b/a +"";
            }
        }
    }
}
