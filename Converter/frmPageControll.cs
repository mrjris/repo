using System;
using System.Collections;
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
    public partial class frmPageControll : Form
    {
        public frmPageControll()
        {
            InitializeComponent();
        }

        string[] dim, words;
        int[] a;
     
        private void btnStart_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Init(s);
            if (cbxOpt.Text == "FIFO") FIFO();
            if (cbxOpt.Text == "LRU") LRU();
        }
        private void Init(String s)
        {
            dim = new[] { " ", "\r\n", "\r", "\n", ",", "{", "}", "(", ")", "[", "]", "=", "\r\t", "\t" };
            words = s.Split(dim, StringSplitOptions.RemoveEmptyEntries);
            a = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
                a[i] = Convert.ToInt16(words[i]);
            txtLog.Text = "";
        }

        private void LRU()
        {

            Queue<Int32> q = new Queue<Int32>();
            string Log = "";
            for (int i = 0; i < 3; i++)
            {
                Log += "miss" + a[i] + "\r\n";
                q.Enqueue(a[i]);
            }
            for (int i = 3; i < words.Length; i++)
            {
                if (q.Contains(a[i]))
                {
                    Log += "hit " + a[i] + "\r\n";
                    int head = q.Peek();
                    while (q.Peek() != a[i])
                    {
                        int k = q.Peek();
                        q.Dequeue();
                        q.Enqueue(k);
                    }
                    q.Dequeue();
                    if (head != a[i])
                    {
                        while (q.Peek() != head)
                        {
                            int k = q.Peek();
                            q.Dequeue();
                            q.Enqueue(k);
                        }
                    }

                    q.Enqueue(a[i]);
                }
                else
                {
                    Log += "miss" + a[i];
                    int m = q.Peek();
                    Log += "\r\toverride " + m + "\r\n";

                    q.Dequeue();
                    q.Enqueue(a[i]);
                }
            }

            txtLog.Text = Log;


        }


        private void FIFO()
        {
            string Log = "";

            Queue<Int32> q = new Queue<Int32>();
            for (int i = 0; i < 3; i++)
            {
                Log += "miss" + a[i] + "\r\n";
                q.Enqueue(a[i]);
            }
            for (int i = 3; i < words.Length; i++)
            {
                if (q.Contains(a[i]))
                {
                    Log += "hit " + a[i] + "\r\n";
                }
                else
                {
                    Log += "miss" + a[i];
                    int m = q.Peek();
                    Log += "\r\toverride " + m + "\r\n";

                    q.Dequeue();
                    q.Enqueue(a[i]);
                }
            }

            txtLog.Text = Log;
        }

        private void OPT()
        {
            string Log = "";
            ArrayList list = new ArrayList();
            int[] flag = new int[3];


            int i = 0;
            while (list.Count < 3)
            {
                if (list.BinarySearch(a[i]) < 0)
                {
                    list.Add(a[i]);
                    Log += "miss " + a[i] + "\r\n";
                }
                else
                {
                    Log += "hit " + a[i] + "\r\n";
                    flag[list.BinarySearch(a[i])] = 1;
                }
                i++;
            }
            int p = 0;
            for ( i = i; i < words.Length; i++)
            {
                
            }

        }
    }
}
