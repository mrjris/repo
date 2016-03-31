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
    public partial class frmConverter2 : Form
    {
        public frmConverter2()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //lấy ra giá trị số nguyên đã nhập
            int n =0;
            try
            {
                n = Int32.Parse(txtNum.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nhập sai rồi. Lỗi này t không xử lý nhé =))\n" + ee.Message);
            }

            txtBitBuDau.Text = JrisConvert.DecToBitChuanBuDau(n);
            txtBitBu1.Text = JrisConvert.DecToBitChuanBu1(n);
            txtBitBu2.Text = JrisConvert.DecToBitChuanBu2(n);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertReal_Click(object sender, EventArgs e)
        {
            

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
