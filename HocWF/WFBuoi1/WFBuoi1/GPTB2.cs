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
    public partial class GPTB2 : Form
    {
        public static int cntGPTB1;
        public GPTB2()
        {
            cntGPTB1++;
            InitializeComponent();
        }

        private void btnGPT_Click(object sender, EventArgs e)
        {
            if (txtA.Text.Trim() == "0")
            {
                if(cntGPTB1 + 1 > 0)
                {
                    cntGPTB1++;
                    GPTB1 pt1 = new GPTB1(txtB.Text, txtC.Text);
                    this.Hide();
                    pt1.ShowDialog();
                    this.Show();
                }
                else
                {

                }
            }
            else
            {
                double delta , a , b , c , x1 , x2;
                a = double.Parse(txtA.Text);
                b = double.Parse(txtB.Text);
                c = double.Parse(txtC.Text);
                delta = b * b - 4 * a * c;
                if(delta < 0)
                {
                    txtNo1.Text = "Phương trình vô nghiệm trong R";
                    txtNo2.Visible = false;
                    lbx2.Visible= false;
                    lbx1.Text = "Kết quả ";
                }
                else if(delta == 0)
                {
                    lbx1.Text = "X1 = ";
                    lbx2.Text = "X1 = ";
                    lbx2.Visible = true;
                    txtNo2.Visible = true;

                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    txtNo1.Text = x1.ToString();
                    txtNo2.Text = x1.ToString();

                }
                else
                {
                    lbx1.Text = "X1 = ";
                    lbx2.Text = "X2 = ";
                    lbx2.Visible = true;
                    txtNo2.Visible = true;

                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    txtNo1.Text = x1.ToString();
                    txtNo2.Text = x2 + "";

                }
            }
        }
    }
}
