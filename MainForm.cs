using Calculator.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Calculator
{
    public partial class MainForm : Form
    {
        #region Shadow
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //  (
        //      int nLeftRect, // x-coordinate of upper-left corner
        //      int nTopRect, // y-coordinate of upper-left corner
        //      int nRightRect, // x-coordinate of lower-right corner
        //      int nBottomRect, // y-coordinate of lower-right corner
        //      int nWidthEllipse, // height of ellipse
        //      int nHeightEllipse // width of ellipse
        //   );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow 调试获取
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_SHOWWINDOW = 0x18;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION2 = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
     
            switch (m.Msg)
            {
                //case WM_NCPAINT:                        // box shadow
                //    if (m_aeroEnabled)
                //    {
                //        var v = 2;
                //        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                //        MARGINS margins = new MARGINS()
                //        {
                //            bottomHeight = 1,
                //            leftWidth = 1,
                //            rightWidth = 1,
                //            topHeight = 1
                //        };
                //        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                //    }
                //    break;
                case WM_SHOWWINDOW:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION2;

        }
        #endregion

        #region 拖动无窗体的控件
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            //拖动窗体
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        #region 工具栏事件
        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Max_Click(object sender, EventArgs e)
        {
            Image backImage;
            Button btn_Max = (Button)sender;
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                backImage = Resources.Max;
                btn_Max.BackgroundImage = backImage;
                return;
            }
            this.WindowState = FormWindowState.Maximized;
            backImage = Resources.Restore;
            btn_Max.BackgroundImage = backImage;

        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 拉伸窗口
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            //label2.Text = e.Location.ToString();
            if (e.Button == MouseButtons.Left)//左键按下移动，拖拽调整大小
            {

                // MousePosition的参考点是屏幕的左上角，表示鼠标当前相对于屏幕左上角的坐标。this.Left和this.Top的参考点也是屏幕
                if (Cursor == Cursors.SizeNWSE) // 倾斜拖拽 
                {
                    // 改变窗体宽和高的代码，其宽高为鼠标屏幕位置减去窗体的Left，Top距离
                    this.Width = MousePosition.X - this.Left;
                    this.Height = MousePosition.Y - this.Top;
                }
                else if (Cursor == Cursors.SizeWE) // 水平拖拽
                {
                    Width = MousePosition.X - this.Left;
                }
                else if (Cursor == Cursors.SizeNS) // 垂直拖拽
                {
                    Height = MousePosition.Y - this.Top;
                }
                
            }

            //鼠标移动过程中，坐标时刻在改变 
            //当鼠标移动时横坐标距离窗体右边缘5像素以内且纵坐标距离下边缘也在5像素以内时，要将光标变为倾斜的箭头形状
            if (e.Location.X >= this.Width - 5 && e.Location.Y > this.Height - 5)
            {
                this.Cursor = Cursors.SizeNWSE; // 右下角 双向对角线光标
            }
            //当鼠标移动时横坐标距离窗体右边缘5像素以内时，要将光标变为双向水平箭头形状
            else if (e.Location.X >= this.Width - 5)
            {
                this.Cursor = Cursors.SizeWE; // 双向水平光标
            }
            //当鼠标移动时纵坐标距离窗体下边缘5像素以内时，要将光标变为垂直水平箭头形状
            else if (e.Location.Y >= this.Height - 5)
            {
                this.Cursor = Cursors.SizeNS; // 双向垂直光标

            }
            //否则，以外的窗体区域，鼠标星座均为单向箭头（默认）             
            else this.Cursor = Cursors.Arrow;

        }

        private void Main_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;// 移出窗体变为正常
        }
        #endregion

        #region 获取控件
        /// <summary>
        /// 根据指定容器和控件名字，获得控件
        /// </summary>
        /// <param name="obj">容器</param>
        /// <param name="strControlName">控件名字</param>
        /// <returns>控件</returns>
        private object GetControlInstance(object obj, string strControlName)
        {
            IEnumerator Controls = null;//所有控件
            Control c = null;//当前控件
            Object cResult = null;//查找结果
            if (obj.GetType() == this.GetType())//窗体
            {
                Controls = this.Controls.GetEnumerator();
            }
            else//控件
            {
                Controls = ((Control)obj).Controls.GetEnumerator();
            }
            while (Controls.MoveNext())//遍历操作
            {
                c = (Control)Controls.Current;//当前控件
                if (c.HasChildren)//当前控件是个容器
                {
                    cResult = GetControlInstance(c, strControlName);//递归查找
                    if (cResult == null)//当前容器中没有，跳出，继续查找
                        continue;
                    else//找到控件，返回
                        return cResult;
                }
                else if (c.Name == strControlName)//不是容器，同时找到控件，返回
                {
                    return c;
                }
            }
            return null;//控件不存在
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void HistoyrBtnClick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void TestEventClick(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
