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
    public partial class TienDien : Form
    {
        public TienDien()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            long dinhMuc, soCu, soMoi, gia1, gia2 , tong;
            dinhMuc = long.Parse(nUDDinhMuc.Value.ToString());
            soCu = long.Parse(textBoxSoCu.Text);
            soMoi = long.Parse(textBoxSoMoi.Text);
            gia1 = long.Parse(textBoxGia1.Text);
            gia2 = long.Parse(textBoxGia2.Text);
            if(soMoi - soCu > dinhMuc)
            {
                tong = gia2*(soMoi - soCu);
                textBoxTong.Text = tong.ToString();
            }
            else
            {
                tong = gia1*(soMoi - soCu);
                textBoxTong.Text = tong.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
