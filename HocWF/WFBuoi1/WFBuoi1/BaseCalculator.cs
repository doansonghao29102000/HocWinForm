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
    public partial class BaseCalculator : Form
    {
        public static string Reverse(string Input)
        {
            char[] charArray = Input.ToCharArray();
            string reverseString = string.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverseString += charArray[i];
            }
            return reverseString;
        }
        public static bool isSmaller(string str1 , string str2)
        {
            int n1 = str1.Length;
            int n2 = str2.Length;
            if(n1 < n2) return true;
            if(n1 > n2) return false;
            for(int i = 1; i < n1; i++)
            {
                if (str1[i] < str2[i]) return true;
                else if (str1[i] > str2[i]) return false;
            }
            return false;
            
        }
        public BaseCalculator()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            string s1 = Reverse(str1.Text);
            string s2 = Reverse(str2.Text);
            if(s1.Length > s2.Length)
            {
                string temp = s1;
                s1 = s2;
                s2 = temp;
            }
            int n1 = s1.Length;
            int n2 = s2.Length;
            int carry = 0;
            string s = "";
            for(int i = 0; i < n1; i++)
            {
                int sum = ((s1[i] - 48) + (s2[i] - 48)) + carry;
                s = s.Insert(s.Length  , (sum % 10).ToString());
                carry = sum / 10;
            }
            for(int i = n1; i < n2; i++)
            {
                int sum = (s2[i] - 48) + carry;
                s = s.Insert(s.Length , (sum % 10).ToString());
                carry = sum / 10;
            }
            if(carry == 1)
            {
                s = s.Insert(s.Length , carry.ToString()) ;
            }
            str.Text = Reverse(s);
        }

        //private void BaseCalculator_Load(object sender, EventArgs e)
        //{
        //    cbToanTu.Items.Add("+");
        //    cbToanTu.Items.Add("-");
        //    cbToanTu.Items.Add("*");
        //    cbToanTu.Items.Add("/");
        //    cbToanTu.SelectedIndex = 0; 
        //}

        private void sub_Click(object sender, EventArgs e)
        {
            string s1 = str1.Text;
            string s2 = str2.Text;
            if(isSmaller(s1 , s2))
            {
                string temp = s1;
                s1 = s2;
                s2 = temp;
            }
            string st1 = Reverse(s1);
            string st2 = Reverse(s2);
            int n1 = st1.Length;
            int n2 = st2.Length;
            string st = "";
            int carry = 0;
            for(int i = 0; i < n2; i++)
            {
                int sub = ((st1[i] - 48) - (st2[i] - 48)) - carry;
                if(sub < 0)
                {
                    sub = sub + 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                st = st.Insert(st.Length, sub.ToString());
            }
            for(int i = n2; i < n1; i++)
            {
                int sub = (st1[i] - 48) - carry;
                if(sub < 0)
                {
                    sub = sub + 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                st = st.Insert(st.Length , sub.ToString());
            }
            str.Text = Reverse(st);
        }
    }
}
