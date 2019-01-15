using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace CS_MSG {
    public partial class FrmStart : Form {
        private ContextMenuStrip contextMenu;
        
        /**
         * 构造函数
         */
        public FrmStart() {
            InitializeComponent();
        }

        /**
         *注册COM组件 
         */
        private bool registerCOM() {
            Type myType = Type.GetTypeFromProgID("IMyLib.MyClass");
            object obj = Activator.CreateInstance(myType);
            object[] args = new object[2];
            args[0] = "Hello";
            args[1] = 3;
            //myType.InvokeMember("MyMethod", BindingFlags.InvokeMethod, obj, args);

            //In .Net 4 something like this

            //Type myType = Type.GetTypeFromProgID("IMyLib.MyClass");
            //dynamic obj = Activator.CreateInstance(myType);
            //obj.MyMethod("Hello", 3);
            return true;
        }

        /**
         *窗体显示出来后，开启后台进程调用PNXClient组件点点登录
         */
        private void FrmStart_Shown(object sender, EventArgs e) {
            
            this.labelCopyRight.Text = "Copy right@长春吉大正元信息技术股份有限公司";
            this.labelCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyRight.ForeColor = System.Drawing.Color.Transparent;
            //TODO 调用PNXClient获取Token做T+A业务                      
            this.workerSSO.RunWorkerAsync();
        }

        /**
         * 取消登录关闭窗口
         */
        private void closeWin(object sender, EventArgs e) {
            if (System.Windows.Forms.Application.MessageLoop) {
                var confirmResult = MessageBox.Show("Are you sure to stop login??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes) {
                    System.Windows.Forms.Application.Exit();
                } else {
                    // If 'No', do something here.
                }
            } else {// Console app                
                System.Environment.Exit(1);
            }
        }

        ///**
        // * 单点登录动画（进度条）
        // */
        //private void animate(object sender, EventArgs e) {
        //    ((ProgressBar)sender).Style = ProgressBarStyle.Marquee;
        //}
        /**
         * 单点登录
         */
        private bool sso(int i)  {
            try {
                double pow = Math.Pow(i, i);
                debug(pow);
                //progressBar1.Invoke(animate, new object[]);
                //Console.WriteLine(pow);
                //using (Graphics gr = progressBar1.CreateGraphics()) {
                //    gr.DrawString(percent + "%",
                //        SystemFonts.DefaultFont,
                //        Brushes.Black,
                //        new PointF(progressBar1.Width / 2 - (gr.MeasureString(percent.ToString() + "%",
                //            SystemFonts.DefaultFont).Width / 2.0F),
                //        progressBar1.Height / 2 - (gr.MeasureString(percent.ToString() + "%",
                //            SystemFonts.DefaultFont).Height / 2.0F)));
                //}

            } catch (Exception e) {
                Console.WriteLine("Error Stack {0} ", e.Message);
            } finally {
                //System.Threading.Thread.Sleep(5000);
            }
            return false;
        }

        /**
         * 后台单点登录工作线程
         */
        private void workerSSO_DoWork(object sender, DoWorkEventArgs e) {
            debug("workerSSO_DoWork");
            //进度条显示
            sso(6);
            for (int j = 0; j <= 100; j++) {                
                workerSSO.ReportProgress(j);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void workerSSO_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            debug(e.ProgressPercentage);
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            // TODO: do something with final calculation.
            MessageBox.Show("Done");
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            System.Windows.Forms.Application.Exit();
        }

        /**
         *注册右键菜单
         */
        private void registerContextMenu() {
            contextMenu = new ContextMenuStrip();
            Image icon = Properties.Resources.img_cancel;
            ToolStripMenuItem menu = new ToolStripMenuItem("Quit", icon, closeWin);
            contextMenu.Items.Add(menu);
            this.ContextMenuStrip = contextMenu;
        }

        /**
         *双击事件
         */
        private void FrmStart_DoubleClick(object sender, EventArgs e) {
            switch (_lastButtonUp) {
                case System.Windows.Forms.MouseButtons.Left:
                    MessageBox.Show("left double click");
                    break;
                case System.Windows.Forms.MouseButtons.Right:
                    MessageBox.Show("right double click");
                    break;
                case System.Windows.Forms.MouseButtons.Middle:
                    MessageBox.Show("middle double click");
                    break;
            }
        }

        MouseButtons _lastButtonUp = MouseButtons.None;
        private void FrmStart_MouseUp(object sender, MouseEventArgs e) {
            _lastButtonUp = e.Button;
        }

        private void debug(object msg) {
            System.Diagnostics.Debug.Write(DateTime.Now.ToString("[yyyy-MM-dd hh:mm:ss] "));
            System.Diagnostics.Debug.WriteLine(msg);
        }

    }
}
