using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoclicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timerClick_Tick(object sender, EventArgs e)
        {
            // click
            click();
        }


        //mouse event constants
        const int MOUSEEVENTF_LEFTDOWN = 2;
        const int MOUSEEVENTF_LEFTUP = 4;
        //input type constant
        const int INPUT_MOUSE = 0;

        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        };

        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(int nInputs, ref INPUT pInputs,
                                   int cbSize);

        void click()
        {
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = Cursor.Position.X;
            i.mi.dy = Cursor.Position.Y;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //click();
            timerClick.Interval = int.Parse(textTime.Text);
            timerClick.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerClick.Stop();
        }

    }
}
