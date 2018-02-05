using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECS188
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // INITIALIZE DLLs
        [DllImport("user32.dll")]   
        private static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("gdi32.dll")]   
        private static extern int GetPixel(IntPtr hdc, Point p);
        [DllImport("gdi32.dll")]
        private static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(int vKey);
        const int VK_LBUTTON = 0x01; //left mouse button

        const int MOUSEEVENTF_MOVE = 0x0001;      // MOVE
        const int MOUSEEVENTF_LEFTDOWN = 0x0002; 
        const int MOUSEEVENTF_LEFTUP = 0x0004; 
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008; 
        const int MOUSEEVENTF_RIGHTUP = 0x0010; 
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; 
        const int MOUSEEVENTF_MIDDLEUP = 0x0040; 
        const int MOUSEEVENTF_ABSOLUTE = 0x8000; 
        int LMODOWN;

        int sizeX;
        int sizeY;
        Size capSize;
        IntPtr winIntPtr;
        Bitmap bmp;
        Point capAbsPt;
        Point capPt;
        Rectangle capRange;
        System.Windows.Forms.Timer tim;
        Thread aiTh;
        int inc;
        bool dynSpd;
        bool trigEnb;
        int speedX;
        int speedY;
        int ignX;
        int ignY;
        int sensitivity;

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*moho = new MouseHook();
            moho.OnMouseActivity += moho_OnMouseActivity;
            moho.Start();
            appCheck();*/

            //capRange = new Rectangle(new Point(Convert.ToInt32(dectXText.Text) - 100, Convert.ToInt32(dectYText.Text) - 50), new Size(201, 201));

            // Initialize Capture Rectangle
            sizeX = 300;
            sizeY = 200;
            capAbsPt = new Point(960, 540);
            capSize = new Size(sizeX + 1, sizeY + 1);
            capPt = new Point(capAbsPt.X - capSize.Width / 2, capAbsPt.Y - capSize.Height / 2);
            capRange = new Rectangle(capPt, capSize);
            winIntPtr = FindWindow(null, "Windowed Projector (Preview)");
            capView.Image = GetScreenCapture(capRange);

            aiTh = new Thread(Run);

            speedX = Convert.ToInt32(XSpeedText.Text);
            speedY = Convert.ToInt32(YSpeedText.Text);
            
            tim = new System.Windows.Forms.Timer();
            inc = 2;

            

            LMODOWN = 0;
            
            capView.BackColor = Color.Black;
            
            /*while(true)
            {
                tim_Tick();
            }*/
            
        }


        private void moControl()
        {
            capRange = new Rectangle(new Point(MousePosition.X - 100, MousePosition.Y - 50), new Size(201, 201)); // -100 - 50
            int hit = 0;

            //if(testBox.Checked)
            //capRange = new Rectangle(new Point(MousePosition.X, MousePosition.Y), new Size(201, 101));

            bmp = GetScreenCapture(capRange);

            capView.Image = bmp;
            int disU = 100 - CheckUP(bmp);
            int disD = CheckDown(bmp) - 100;
            int disL = 100 - CheckLeft(bmp);
            int disR = CheckRight(bmp) - 100;

            int movX = 0;
            int movY = 0;

            if (disU != 101 || disD != -101)
            {

                movY = disD - disU;
                if (disD == -101)
                    movY = -100;
                else if (disU == 101)
                    movY = 100;
            }

            if (disL != 101 || disR != -101)
            {
                movX = disR - disL;
                if (disR == -101)
                    movX = -50;
                else if (disL == 101)
                    movX = 50;
            }
                new Thread(() =>
                {
                    mouse_event(MOUSEEVENTF_MOVE, 0, movY, 0, 0);
                    
                    mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                }).Start();
            Application.DoEvents();

                
            
            ColorLabel.Text = disU + " " + disD + " " + disL + " " + disR;
            capRange = new Rectangle(new Point(MousePosition.X - 100 + movX, MousePosition.Y - 50 + movY), new Size(201, 201));
            bmp = GetScreenCapture(capRange);

            capView.Image = bmp;

        }

        private void tim_Tick(object sender, EventArgs e)
        {
            //Point p = new Point(MousePosition.X, MousePosition.Y);//  
            //Point p = new Point(960, 531);// 487~502 UPPERer
            //p.X = 960;
            //p.Y = 493;


            //capRange = new Rectangle(new Point(960 - 100, 560 - 50), new Size(201, 201)); // -100 - 50
            capRange = new Rectangle(new Point(MousePosition.X - 100, MousePosition.Y - 50), new Size(201, 201)); // -100 - 50
            int hit = 0;
            
            //if(testBox.Checked)
                //capRange = new Rectangle(new Point(MousePosition.X, MousePosition.Y), new Size(201, 101));

            bmp = GetScreenCapture(capRange);
            
            capView.Image = bmp;
            //label2.Text = " " + CheckUP(bmp) + " " + CheckDown(bmp) + " " + CheckLeft(bmp) + " " + CheckRight(bmp);
            int disU = CheckUP(bmp);
            int disD = CheckDown(bmp);
            int disL = CheckLeft(bmp);
            int disR = CheckRight(bmp);

            if (disU != -1)
                disU = 100 - disU;
            if (disD != -1)
                disD -= 100;
            if (disL != -1)
                disL = 100 - disL;
            if (disR != -1)
                disR -= 100;

                if (testBox.Checked)
            {
                Color clr = bmp.GetPixel(0, 0);
                ColorLabel.Text = clr.R + " " + clr.G + " " + clr.B;
            }
            //else
                //ColorLabel.Text = disU + " " + disD + " " + disL + " " + disR;

            int movX = 0;
            int movY = 0;

            if (disU != 101 || disD != -101)
            {
                movY = disD - disU;
                if (disD == -101)
                    movY = -disU;
                else if (disU == 101)
                    movY = disD;
            }

            if (disL != 101 || disR != -101)
            {
                movX = disR - disL;
                if (disR == -101)
                    movX = -disL;
                else if (disL == 101)
                    movX = disR;
            }
            new Thread(() =>
            {
                mouse_event(MOUSEEVENTF_MOVE, movX, movY, 0, 0);
            }).Start();


            ColorLabel.Text = movX + ", " + movY;
            
            
            /*if (  hit > 5 && hit < 20)
            {
                ColorLabel.Text = "<<<<";
                mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            }*/
        }

        public Bitmap GetScreenCapture(Rectangle fov)
        {
            // Define the size of the screencopy.
            var screenCopy = new Bitmap(fov.Width, fov.Height, PixelFormat.Format24bppRgb);

            using (var gdest = Graphics.FromImage(screenCopy))

            //using (var gsrc = Graphics.FromHwnd(IntPtr.Zero))
            using (var gsrc = Graphics.FromHwnd(winIntPtr))
            {
                var hSrcDc = gsrc.GetHdc();
                try
                {
                    var retval = BitBlt(gdest.GetHdc(), 0, 0, fov.Width, fov.Height, hSrcDc, fov.X, fov.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
                catch { }
                
            }

            return screenCopy;
        }

        

        private int CheckUP(Bitmap img)
        {
            
            for (int y = sizeY /2; y > 0; y-=inc)
            {
                for (int x = sizeX / 4; x < sizeX * 3 / 4; x+=inc)
                {
                    if (ColorCheck(img.GetPixel(x, y)))
                        return y;
                }
            }
            return -1;
        }

        private int CheckDown(Bitmap img)
        {

            for (int y = sizeY / 2; y < sizeY; y+=inc)
            {
                for (int x = sizeX / 4; x < sizeX * 3 / 4; x +=inc)
                {
                    if (ColorCheck(img.GetPixel(x, y)))
                        return y;
                }
            }
            return -1;
        }
        private int CheckLeft(Bitmap img)
        {

            for (int x = sizeX / 2; x > 0; x-= inc)
            {
                for (int y = sizeY / 4; y < sizeY * 3 / 4; y += inc)
                {
                    if (ColorCheck(img.GetPixel(x, y)))
                        return x;
                }
            }
            return -1;
        }
        private int CheckRight(Bitmap img)
        {

            for (int x = sizeX / 2; x < sizeX; x +=inc)
            {
                for (int y = sizeY / 4; y < sizeY * 3 / 4; y += inc)
                {
                    if (ColorCheck(img.GetPixel(x, y)))
                        return x;
                }
            }
            return -1;
        }


        private bool ColorCheck(Color clr)
        {
            if (clr.R < 210 && clr.R > 160 && clr.G > 10 && clr.G < 40 && clr.B < 80 && clr.B > 20)
                return true;
            else
                return false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           //moho.Stop();
        }

        private void testBox_CheckedChanged(object sender, EventArgs e)
        {
            //if(testBox.Checked == true)
                //winIntPtr = IntPtr.Zero;
        }

        private void ColorLabel_Click(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            if (startBtn.Text == "START" && (appCheck() || testBox.Checked == true))
            {
                startBtn.Text = "STOP";
                
                tim.Interval = 1000 / Convert.ToInt32(sensiText.Text);
                //tim.Tick += tim_Tick;
                //tim.Start();
                
                aiTh.Start();
            }
            else
            {
                startBtn.Text = "START";
                tim.Stop();
                if(aiTh.IsAlive)
                    aiTh.Abort();
            }
        }

        private void Run()
        {
            while(true)
            {
                if(GetAsyncKeyState(VK_LBUTTON) < 0)
                {
                    capRange = new Rectangle(new Point(MousePosition.X - sizeX / 2, MousePosition.Y - 50), new Size(sizeX + 1 , sizeY + 1)); // -100 - 50


                    bmp = GetScreenCapture(capRange);

                    int disU = CheckUP(bmp);
                    int disD = CheckDown(bmp);
                    int disL = CheckLeft(bmp);
                    int disR = CheckRight(bmp);

                    if (disU != -1)
                        disU = sizeY/2 - disU;
                    if (disD != -1)
                        disD -= sizeY/2;
                    if (disL != -1)
                        disL = sizeX/2 - disL;
                    if (disR != -1)
                        disR -= sizeX/2;

                    int difX = 0;
                    int difY = 0;

                    

                    if (disL > ignX && disR > ignX)
                        difX = disR - disL;
                    else if (disL > ignX && disR == -1)
                        difX = -disL;
                    else if (disL == -1 && disR > ignX)
                        difX = disR;

                    if (disU > ignY && disD > ignY)
                        difY = disD - disU;
                    else if (disU > ignY && disD == -1)
                        difY = -disU;
                    else if (disU == -1 && disD > ignY)
                        difY = disD;

                    int modi;

                    // Dynamic Speed
                    int movX = difX;
                    int movY = difY;

                    //nst Speed
                    if(!dynSpd)
                    {
                        if (difX > 0)
                            movX = speedX;
                        if (difX < 0)
                            movX = -speedX;
                        if (difY > 0)
                            movY = speedY;
                        if (difY < 0)
                            movY = -speedY;
                    }
                    /*
                    movX = difX / 2;
                    movY = difY / 2;
                    */
                    new Thread(() =>
                    {
                        mouse_event(MOUSEEVENTF_MOVE, movX, movY, 0, 0);
                    }).Start();

                    if (trigEnb)
                    {
                        new Thread(() =>
                        {
                            mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                        }).Start();
                    }

                    /*new Thread(() =>
                    {
                        mouse_event(MOUSEEVENTF_MOVE, movX, movY, 0, 0);
                    }).Start();

                    new Thread(() =>
                    {
                        mouse_event(MOUSEEVENTF_MOVE, movX, movY, 0, 0);
                    }).Start();*/

                    bmp.Dispose();
                    bmp = null;
                }
                Thread.Sleep(1);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked)
            {
                ignX = 25;
                ignY = 15;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("没有帮助 蟹蟹");
        }

        private bool appCheck()
        {
            winIntPtr = FindWindow(null, "Windowed Projector (Preview)");
            if (FindWindow(null, "Overwatch") == IntPtr.Zero)
            {
                OBSStatus.Text = "OPEN Overwatch FIRST";
                return false;
            }
            else
            {
                if (winIntPtr == IntPtr.Zero)
                {
                    OBSStatus.Text = "OPEN OBS FIRST";
                    return false;
                }
                return true;
            }
        }

        private void XSpeedText_TextChanged(object sender, EventArgs e)
        {
            speedX = Convert.ToInt32(XSpeedText.Text);
        }

        private void YSpeedText_TextChanged(object sender, EventArgs e)
        {
            speedY = Convert.ToInt32(YSpeedText.Text);
        }

        private void dynSpdCheck_CheckedChanged(object sender, EventArgs e)
        {
            dynSpd = dynSpdCheck.Checked;
            XSpeedText.Enabled = !dynSpd;
            YSpeedText.Enabled = !dynSpd;

        }

        private void trigCheck_CheckedChanged(object sender, EventArgs e)
        {
            trigEnb = trigCheck.Checked;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked)
            {
                ignX = 1;
                ignY = 1;
            }
        }

        private void sensiText_TextChanged(object sender, EventArgs e)
        {
            sensitivity = Convert.ToInt32(sensiText.Text);
        }
    }
}
