using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class frmConverter3 : Form
    {
        public frmConverter3()
        {
            InitializeComponent();
        }

        private void btnConvertReal_Click(object sender, EventArgs e)
        {
            try
            {
                double n = 0;
                try
                {
                    n = Double.Parse(txtFloat.Text);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Nhập sai rồi. Lỗi này t không xử lý nhé =))\n" + ee.Message);
                }

                long n1 = (long)n / 1;
                double n2 = Math.Abs(n % 1);
                string s2 = JrisConvert.DoubleTo16Bit88(n);
                txtBit88.Text = s2;



                //Dấu phẩy động single 32bit

                char[] array;
                bool neg = n < 0;
                array = s2.ToCharArray();
                int exp = 127;
                int k = 0;
                for (k = 0; k < array.Length; k++)
                    if (array[k] == '1')
                    {
                        exp += 7 - k;
                        break;
                    }

                //Xu ly S
                txtS.Text = neg ? "1" : "0";

                //Xu ly phan exp
                string sexp = Convert.ToString(exp, 2);
                sexp = new string('0', 8 - sexp.Length) + sexp;
                txtExpo.Text = sexp;

                //Xu ly phan frac
                string frac = s2.Substring(k + 1, s2.Length - k - 1);
                frac += new string('0', 23 - frac.Length);
                txtFrac.Text = frac;

                //Tong hop
                txtSingle.Text = txtS.Text + txtExpo.Text + txtFrac.Text;


                //Dấu phẩy động double 64bit
                array = s2.ToCharArray();
                exp = 1023;
                k = 0;
                for (k = 0; k < array.Length; k++)
                    if (array[k] == '1')
                    {
                        exp += 7 - k;
                        break;
                    }

                //Xu ly S
                string S = neg ? "1" : "0";

                //Xu ly phan exp
                sexp = Convert.ToString(exp, 2);
                sexp = new string('0', 11 - sexp.Length) + sexp;


                //Xu ly phan frac
                frac = s2.Substring(k + 1, s2.Length - k - 1);
                frac += new string('0', 52 - frac.Length);

                txtDouble.Text = S + sexp + frac;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nhập sai rồi. Lỗi này t không xử lý nhé =))\n" + ee.Message);
            }
        }

        private void txtDouble_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
