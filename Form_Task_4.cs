using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW_LegacyCode
{

    public partial class Form_Task_4 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr RoundedButton(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private const int WM_SETFONT = 0x30;

        public Form_Task_4() => InitializeComponent();

        private void buttonShowText_Click(object sender, EventArgs e)
        {
            string msg = textBox.Text;
            MessageBox.Show(msg);
        }

        private void buttonShowText_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = RoundedButton(1, 1, buttonShowText.Width, buttonShowText.Height, 30, 30);
            buttonShowText.Region = Region.FromHrgn(ptr);
        }

        private void roundedButtonShowText_Click(object sender, EventArgs e)
        {
            string msg = textBox.Text;
            MessageBox.Show(msg);
        }

        private void Form_Task_4_Load(object sender, EventArgs e)
        {
            Font timesNewRoman16 = new Font("Times New Roman", 12);
            SendMessage(textBox.Handle,WM_SETFONT, timesNewRoman16.ToHfont(), (IntPtr)(-1));
        }
    }
}
