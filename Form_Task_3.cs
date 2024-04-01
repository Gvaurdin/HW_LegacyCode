using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_LegacyCode
{
    public partial class Form_Task_3 : Form
    {
        [DllImport("Kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);

        [DllImport("User32.dll")]
        public static extern bool MessageBeep(uint uType);

        private CancellationTokenSource cancellation;

        uint[] uints;
        int[] ints;
        Random random;
        public Form_Task_3()
        {
            InitializeComponent();
            uints = new uint[] { 0x10, 0x20, 0x30, 0x40 };
            ints = new int[] { 523, 587, 659, 698, 784, 880, 988, 1047 };
            random = new Random();
            buttonStop.Enabled = false;
        }

        private async void PlayBeep(CancellationToken cancellationToken)
        {
            await Task.Run (() =>
            {
                while (true)
                {
                    foreach (int frequency in ints)
                    {
                        if (cancellationToken.IsCancellationRequested) return;
                        Beep(frequency, 500);

                    }
                }
            });
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = true;
            cancellation = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellation.Token;
            PlayBeep(cancellationToken);

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            cancellation?.Cancel();
            buttonStop.Enabled = false;
            MessageBeep(uints[random.Next(uints.Length - 1)]);
            MessageBox.Show("Playback has been stopped");
        }
    }
}
