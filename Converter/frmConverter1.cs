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
    public partial class frmConverter1 : Form
    {
        public frmConverter1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Reset du lieu
            txtResult1.Text = "";
            txtResult2.Text = "";
            txtResult3.Text = "";

            if (!txtNum.Text.Equals(""))
            {
                try
                {
                    //Decode ver 2
                    txtResult1.Text = JrisConvert.BitChuanBuDauToDec(txtNum.Text);
                    txtResult2.Text = JrisConvert.BitChuanBu1ToDec(txtNum.Text);
                    txtResult3.Text = JrisConvert.BitChuanBu2ToDec(txtNum.Text);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Lỗi này t không xử lý nhé =))\n"+ee.Message);
                }
            }
            else
            {
                MessageBox.Show("Nhập cho tử tế đi bạn trẻ. Không nhập thì sao làm :v");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
