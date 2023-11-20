using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Auto_Click_Mouse
{
    public partial class Form1 : Form
    {
        DateTime d = DateTime.Now;
        int a;
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;   /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004;     /* left button up */
        [DllImport("user32.dll",CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private void timer1_Tick(object sender, EventArgs e)  // Frequency timer
        {
            this.BackColor = Color.LimeGreen;
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGreen;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            txtHH.Enabled = false;
            txtForwhile.Enabled = false;
            txtInterval.Enabled = false;
            txtHH.Enabled = false;
            txtMM.Enabled = false;
            txtSS.Enabled = false;
            timer1.Interval = Convert.ToInt32(txtInterval.Text);
            if (txtHH.Text.Length == 2 && txtMM.Text.Length == 2 && txtSS.Text.Length == 2)
                 return;
            if(txtHH.Text.Length == 0 && txtMM.Text.Length == 0 && txtSS.Text.Length == 0)
            {
                 timer1.Start();
                 timer2.Start();
                 return;
            }
            else if (txtHH.Text.Length < 2 || txtMM.Text.Length < 2 || txtSS.Text.Length < 2)
            {
                MessageBox.Show("اطلاعات ساعت اشتباه است");
                btnStop.Enabled = false;
                btnStart.Enabled = true;
                txtHH.Enabled = true;
                txtForwhile.Enabled = true;
                txtInterval.Enabled = true;
                txtHH.Enabled = true;
                txtMM.Enabled = true;
                txtSS.Enabled = true;
                return;
            }
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)   //1 second timer 
        {
            if (txtForwhile.Text.Length > 0)
                a++;
            if (a.ToString() == txtForwhile.Text)
                btnStop_Click(null, null);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            a = 0;
            this.BackColor = Color.Gainsboro;
            timer1.Stop();
            timer2.Stop();
            txtHH.Enabled = true;
            txtMM.Enabled = true;
            txtSS.Enabled = true;
            txtForwhile.Enabled = true;
            txtInterval.Enabled = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;   
        }

        private void txtInterval_TextChanged(object sender, EventArgs e)
        {
            if (txtInterval.Text.Length > 0)
                btnStart.Enabled = true;
            else
                btnStart.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)   // Time timer
        {
            string h;
            string m;
            string s;
            lblTime.Text = DateTime.Now.ToString("  hh:mm:ss   tt");
            h = DateTime.Now.ToString("hh");
            m = DateTime.Now.ToString("mm");
            s = DateTime.Now.ToString("ss");
            if (h == txtHH.Text && m == txtMM.Text && s == txtSS.Text)
            {
                if (btnStart.Enabled == false)
                {
                    timer1.Stop();
                    timer2.Stop();
                }
            }
        }

        private void txtHH_TextChanged(object sender, EventArgs e)
        {
            if (txtHH.Text.Length > 1)
                txtMM.Focus();
        }

        private void txtMM_TextChanged(object sender, EventArgs e)
        {
            if (txtMM.Text.Length > 1)
                txtSS.Focus();
        }

        private void txtSS_TextChanged(object sender, EventArgs e)
        {
            if (txtSS.Text.Length > 1)
                txtForwhile.Focus();
        }
    }   
}