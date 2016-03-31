using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    class JrisConvert
    {
        public static string BitChuanBuDauToDec(string args)
        {
             string s = args.Substring(1, args.Length - 1);
             int n=0;
             try
             {
                 if (args[0] == '0')
                     n = Convert.ToInt32(s, 2);
                 else
                     n = -Convert.ToInt32(s, 2);
             }
             catch (Exception e)
             {
                 MessageBox.Show("Nhập sai rồi. Lỗi này t không xử lý nhé =))\n" + e.Message);
             }

            
             return n.ToString();
        }

        public static string BitChuanBu1ToDec(string args)
        {
            int m = 0;
            try
            {
                string s = args.Substring(0, args.Length);
                char[] c = s.ToCharArray();
                if (c[0] == '0') return Convert.ToInt32(s, 2).ToString();
                for (int i = 0; i < c.Length; i++)
                    c[i] = c[i] == '0' ? '1' : '0';
                s = new String(c);
                m = -Convert.ToInt32(s, 2);
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Nhập sai rồi. Lỗi này t không xử lý nhé =))\n" + e.Message);
            }

            return m.ToString();
        }

        public static string BitChuanBu2ToDec(string args)
        {
            string s = args.Substring(0, args.Length);
            char[] c = s.ToCharArray();
            if (c[0] == '0') return Convert.ToInt32(s, 2).ToString();
            for (int i = c.Length - 1; i >= 0; i--)
                if (c[i] == '0') c[i] = '1';
                else
                {
                    c[i] = '0';
                    break;
                }
            for (int i = 0; i < c.Length; i++)
                c[i] = c[i] == '0' ? '1' : '0';
            s = new String(c);
            int m = -Convert.ToInt32(s, 2);
            return m.ToString();
        }

        public static string DecToBitChuanBuDau(int n)
        {
            bool neg = n < 0;
            n = neg ? -n : n;
            return (neg ? "1" : "0") + new string('0', 15 - Convert.ToString(n, 2).Length) + Convert.ToString(n, 2);
        }

        public static string DecToBitChuanBu1(int n)
        {
            char[] array = new char[16];
            bool neg = n < 0;
            n = neg ? -n : n;
            if (!neg) return new string('0', 16 - Convert.ToString(n, 2).Length) + Convert.ToString(n, 2);
            else
            {
                string s3 = new string('0', 16 - Convert.ToString(n, 2).Length) + Convert.ToString(n, 2);
                array = s3.ToCharArray();
                for (int i = 0; i < 16; i++)
                    array[i] = array[i] == '0' ? '1' : '0';
                s3 = new string(array);
                return s3;
            }
            
        }

        public static string DecToBitChuanBu2(int n)
        { 
            
            char[] array = new char[16];
            bool neg = n < 0;
            n = neg ? -n : n;
            if (!neg) return new string('0', 16 - Convert.ToString(n, 2).Length) + Convert.ToString(n, 2);
            else
            {
                string s3 = new string('0', 16 - Convert.ToString(n, 2).Length) + Convert.ToString(n, 2);
                array = s3.ToCharArray();
                for (int i = 0; i < 16; i++)
                    array[i] = array[i] == '0' ? '1' : '0';
                //cong 1 bit
                for (int i = array.Length - 1; i >= 0; i--)
                    if (array[i] == '1' && i != -1) array[i] = '0';
                    else
                    {
                        array[i] = '1';
                        break;
                    }
                s3 = new string(array);
                return s3;
            }
        }

        public static string DoubleTo16Bit88(double n)
        {
            long n1 = (long)n / 1;
            double n2 = Math.Abs(n % 1);

            bool neg = n < 0;
            n1 = neg ? -n1 : n1;//lay tri tuyet doi
            //convert
            string s1 = new string('0', 8 - Convert.ToString(n1, 2).Length) + Convert.ToString(n1, 2);
            //s1 luubieu dien nhi phan cua phan nguyen


            //s2 luu bieu dien nhi phan cua phan thap phan
            string s2 = "";
            char[] array = new char[8];
            double dtemp = n2;
            for (int i = 0; i < 8; i++)
            {
                dtemp *= 2;
                if (dtemp >= 1)
                {
                    array[i] = '1';
                    dtemp -= 1;
                }
                else
                    array[i] = '0';
            }
            s2 = new string(array);
            if (!neg)
                return s1 + s2;

            string s = s1 + s2;
            array = s.ToCharArray();
            //Chuyen doi sang dang bit chuan bu 2
            //dao bit
            for (int i = 0; i < 16; i++)
                array[i] = array[i] == '0' ? '1' : '0';
            //cong 1 bit
            for (int i = array.Length - 1; i >= 0; i--)
                if (array[i] == '1' && i != -1) array[i] = '0';
                else
                {
                    array[i] = '1';
                    break;
                }


            return new string(array);
        }

        public static double Bit88ToDouble(string s)
        {
            double n = 0;
            try
            {
                string s1 = s.Substring(0, 8);
                string s2 = s.Substring(8, 8);
                double temp = 0;
                for (int i = 0; i < 8; i++)
                {
                    temp += Math.Pow(2, -(i + 1)) * Int32.Parse(s2.Substring(i, 1));
                }
                n = (double)(Convert.ToInt64(s1, 2)) + temp;
            }
            catch (Exception )
            {
                MessageBox.Show("Nhập sai rồi. Lỗi này t không xử lý nhé =))\n"
                    +"Cái này chỉ dịch dãy bit 8/8 sang số thực thôi");
            }

            return n;
        }
    }
}
