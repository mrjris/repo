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
    public partial class frmConverter5 : Form
    {
        public frmConverter5()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs ee)
        {
            try
            {
                string s = txtNum.Text;
                int length = s.Length;
                char[] array = new char[64];
                int cases = 0;
                try
                {
                    array = s.ToCharArray();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                int lastZero = 0;
                //tim kiem vi tri so 0 cuoi cung cua day bit
                for (int i = length - 1; i >= 0; i--)
                    if (array[i] == '1')
                    {
                        lastZero = i + 1;
                        break;
                    }


                string dau = s.Substring(0, 1);
                string expoString = "", frac = "";
                int bias = 0;

                switch (length)
                {
                    case 32:
                        cases = 32;
                        expoString = s.Substring(1, 8);
                        bias = 127;
                        //chet TH so 0

                        frac += s.Substring(9, Math.Max(lastZero - 9, 0));
                        if (frac.Equals("")) frac = "0";
                        break;
                    case 64:
                        cases = 64;
                        expoString = s.Substring(1, 11);
                        bias = 1022;
                        frac = s.Substring(12, Math.Max(lastZero - 12, 0));
                        if (frac.Equals("")) frac = "0";
                        break;

                    default:
                        MessageBox.Show("Nhập đúng nha bạn trẻ. Chỉ áp dụng cho kiểu thực single(32bits)"
                        + " hoặc kiểu thực double(64bits)");

                        return;
                }

                int expo = Convert.ToInt32(expoString, 2);

                txtLength.Text = length.ToString();
                txtS.Text = dau;
                txtExpoString.Text = expoString;
                txtExpo.Text = expo.ToString();
                expo -= bias;
                txtMuThuc.Text = expo.ToString();
                txtFrac.Text = frac;


                //Xét các trường hợp đặc biệt
                int special = -1;
                switch (cases)
                {
                    case 32:
                        if (expoString.Equals(new string('0', 8))) special = 0;
                        if (expoString.Equals(new string('1', 8))) special = 1;
                        break;
                    case 64:
                        if (expoString.Equals(new string('0', 11))) special = 0;
                        if (expoString.Equals(new string('1', 11))) special = 1;
                        break;
                    default:
                        MessageBox.Show("Fail!");
                        break;
                }



                //Kết quả cuối cùng
                switch (special)
                {
                    case -1:
                        txtResult.Text = (dau.Equals("0") ? "+" : "-") + "1," + frac + "x2^" + expo.ToString();
                        break;
                    case 0:
                        if (frac.Equals("0"))
                            txtResult.Text = (dau.Equals("0") ? "+" : "-") + "0";
                        else
                            txtResult.Text = (dau.Equals("0") ? "+" : "-") + "0," + frac + "x2^" + expo.ToString();

                        break;
                    case 1:
                        if (frac.Equals("0"))
                            txtResult.Text = (dau.Equals("0") ? "+" : "-") + "Infinite";
                        else
                            txtResult.Text = "Not A Number";

                        break;
                }
            }
            catch (Exception xe)
            {
                MessageBox.Show("Nhập sai rồi. Lỗi này t không xử lý nhé =))\n" + xe.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFrac_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
