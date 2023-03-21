using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBuoi1
{
    public partial class MessageFormater : Form
    {
        public MessageFormater()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lbM.Text = txtName.Text + " " + txtMessage.Text;
            if (radRed.Checked == true)
            {
                lbM.ForeColor = Color.Red;
            }
            else if (radGreen.Checked == true)
            {
                lbM.ForeColor = Color.Green;
            }
            else if (radBlue.Checked == true)
            {
                lbM.ForeColor = Color.Blue;
            }
            else
            {
                lbM.ForeColor = Color.Black;
            }
        }

        private void MessageFormater_Load(object sender, EventArgs e)
        {
            cBBold.Checked = true;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible= false;
            picSmall.Visible= true;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picBig.Visible = true;
            picSmall.Visible = false;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if(radRed.Checked)
            {
                lbM.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lbM.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lbM.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                lbM.ForeColor = Color.Black;
            }
        }

        private void cBBold_CheckedChanged(object sender, EventArgs e)
        {
            if (cBBold.Checked)
            {
                lbM.Font = new Font(lbM.Font, lbM.Font.Style | FontStyle.Bold);
            }
            else
            {
                lbM.Font = new Font(lbM.Font, lbM.Font.Style & ~FontStyle.Bold);
            }
          
        }

        private void cBItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (cBItalic.Checked == true)
            {
                lbM.Font = new Font(lbM.Font, lbM.Font.Style | FontStyle.Italic);
            }
            else
            {
                lbM.Font = new Font(lbM.Font, lbM.Font.Style & ~FontStyle.Italic);
            }
        }

        private void cBUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (cBUnderline.Checked == true)
            {
                lbM.Font = new Font(lbM.Font, lbM.Font.Style | FontStyle.Underline);
            }
            else
            {
                lbM.Font = new Font(lbM.Font, lbM.Font.Style & ~FontStyle.Underline);
            }
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lbM.Text = txtName.Text + " " + txtMessage.Text;
                if (radRed.Checked == true)
                {
                    lbM.ForeColor = Color.Red;
                }
                else if (radGreen.Checked == true)
                {
                    lbM.ForeColor = Color.Green;
                }
                else if (radBlue.Checked == true)
                {
                    lbM.ForeColor = Color.Blue;
                }
                else
                {
                    lbM.ForeColor = Color.Black;
                }
            }
        }

    }
}
