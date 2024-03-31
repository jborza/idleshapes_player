using MovablePython;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace autoclicker
{
    public partial class Form1 : Form
    {
        private Random random;
        int tick = 0;
        int displayHeight;

        public Form1()
        {
            InitializeComponent();
            Hotkey hk = new Hotkey();
            hk.KeyCode = Keys.Oemtilde;
            //hk.KeyCode = Keys.A;
            hk.Pressed += Hk_Pressed;
            hk.Register(this);
            random = new Random();
            Hotkey hkCapture = new Hotkey();
            hkCapture.KeyCode = Keys.D1;
            hkCapture.Pressed += HkCapture_Pressed;
            hkCapture.Register(this);
            displayHeight = Screen.PrimaryScreen.Bounds.Height;
        }

        private void HkCapture_Pressed(object sender, HandledEventArgs e)
        {
            string s = "";
            s += Cursor.Position.X + ",";
            s += Cursor.Position.Y;
            s += Environment.NewLine;
            textBoxCoords.Text += s;
        }

        private void timerClick_Tick(object sender, EventArgs e)
        {
            tick++;
            // click
            if (checkBox2.Checked)
            {
                click();
            }
            if (doMovement)
            {
                moveMouse();
            }
            if (checkBoxIdleShapes.Checked && tick % 40 == 0)
            {
                //move to one of the coords
                const int x = 0;
                const int y = 1;

                var clickY = new int[4] { 532, 571, 615, 487 };
                var coordsToClick = new List<int[]>();
                int shapes = (int)nudShapes.Value;
                coordsToClick = makeCoords(shapes);

                var oldPosition = Cursor.Position;
                var pos = coordsToClick[idleShapesTick % coordsToClick.Count];
                Cursor.Position = new System.Drawing.Point(pos[x], pos[y]);
                click();
                //Cursor.Position = oldPosition;
                idleShapesTick++;
            }
        }

        private List<int[]> makeCoords(int coordCount)
        {
            //var coords_1 = new int[1] { 680 };
            //var coords_2 = new int[2] { 618, 759 };
            //var coords_3 = new int[3] { 545, 690, 832 };
            //var coords_4 = new int[4] { 478, 69, 758, 902 };
            var clickY = new int[4] { 532, 571, 615, 487 };

            var coords = new List<int[]> { null,
                new int[1] { 680 },
                new int[2] { 618, 759 },
                new int[3] { 545, 690, 832 },
                new int[4] { 478, 69, 758, 902 } };

            var myCoords = coords[coordCount];
            var coordsToClick = new List<int[]>();
            for (int i = 0; i < coordCount; i++)
            {
                for (int y = 0; y < 4; y++)
                {
                    coordsToClick.Add(new int[2] { myCoords[i], clickY[y] });
                }
            }
            return coordsToClick;
        }

        private void moveMouse()
        {
            const int MOVEMENT = 200;
            int x = Cursor.Position.X + random.Next(-MOVEMENT, MOVEMENT);
            int y = Cursor.Position.Y + random.Next(-MOVEMENT, MOVEMENT);
            if (y > displayHeight - 20)
            {
                y = displayHeight - 20;
            }
            Cursor.Position = new System.Drawing.Point(x,y);
        }

        bool started = false;
        private bool doMovement = false;
        private int idleShapesTick = 0;


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
            i.mi.time = 0; //we want the system to provide its own timestamp
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            start();
        }

        private void start()
        {
            started = true;
            timerClick.Interval = int.Parse(textTime.Text);
            timerClick.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void stop()
        {
            started = false;
            timerClick.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Hk_Pressed(object sender, HandledEventArgs e)
        {
            if (started)
            {
                stop();
            }
            else
            {
                start();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode + "");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            doMovement = checkBox1.Checked;
        }
    }
}
