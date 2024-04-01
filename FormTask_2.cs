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
    public partial class FormTask_2 : Form
    {
        private Thread thread;
        private TextBox textBoxTitle;
        private FormWindow formWindow;
        public FormTask_2()
        {
            InitializeComponent();
            radioButtonChangeTitleWindow.CheckedChanged += RadioButtonChangeTitleWindow_CheckedChanged;
        }

        private void RadioButtonChangeTitleWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonChangeTitleWindow.Checked)
            {
                textBoxTitle = new TextBox()
                {
                    Location = new Point(100, 100),
                    Size = new Size(200, 40),
                    Text = "New title",
                    Visible = true
                };
                this.Controls.Add(textBoxTitle);
            }
        }

        [DllImport("USER32.DLL")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        /*
         * IntPtr - функция возвращает данный параметр, как дескриптор ( указатель) , который указывает на область памяти, где хранятся данные
         * lpClassName - имя класса окна, lpWindowName - заголовок окна
         * extern - функция определена вне текущего кода языка C# и будет найдена в библиотеке DLL
         */

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        /*
         * CharSet = CharSet.Auto - функция автоматом выберет нужный набор символов
         * SetLastError = true - установка кода ошибки с помощью GetLasrError
         * 
         */
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        /*
         * hWnd - указатель на окно, которому будет пересылаться сообщение
         * Msg - целочисленный идентификатор сообщения, которое будет отправлено
         * IntPtr wParam - информация о сообщении
         * IntPtr lParam - дополнительная информация о сообщении
         */


        const int WM_CLOSE = 0x0010;
        const int WM_SETTEXT = 0x000C; // идентификаторы сообщений

        private void buttonAPIControl_Click(object sender, EventArgs e)
        {

            // поиск окна FormWindow, которое открывается в другом потоке
            IntPtr hWndFormWindow = FindWindow(null,formWindow.Text);

            if (hWndFormWindow != IntPtr.Zero)
            {
                MessageBox.Show("FormWindow is find!");

                if (radioButtonChangeTitleWindow.Checked && textBoxTitle.Text != "New title")
                {
                    SendMessage(hWndFormWindow, WM_SETTEXT, IntPtr.Zero, Marshal.StringToBSTR(textBoxTitle.Text));
                }

                else if (radioButtonCloseWindow.Checked)
                {
                    SendMessage(hWndFormWindow, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                }
            }
            else
            {
                MessageBox.Show("FormWindow is not find!");
            }
        }

        private void buttonThread_Click(object sender, EventArgs e)
        {
            thread = new Thread(openFormWindow);
            thread.Start();
        }

        private async void openFormWindow()
        {
            formWindow = new FormWindow();
            await Task.Run(() =>
            {
                formWindow.ShowDialog();
            });
            
        }
    }

    public partial class FormWindow : Form
    {
        public FormWindow()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            this.Size = new Size(600, 400);
            this.BackColor = Color.LightCyan;
            this.Text = "FormWindow";


            Label label = new Label()
            {
                Location = new Point(200, 200),
                Font = new Font("Arial", 12),
                Text = "This form waiting to API control",
                Size = new Size(200, 40)
            };

            this.Controls.Add(label);
        }
    }
}
