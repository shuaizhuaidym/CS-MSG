using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;

namespace CS_MSG {
    public partial class FrmStart : Form {
        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static FrmStart splashForm;

        /**
         * 构造函数
         */
        public FrmStart() {
            InitializeComponent();
        }

        public static void ShowSplashScreen() {
            // Make sure it is only launched once.
            if (splashForm != null) {
                return;
            }
            Thread thread = new Thread(new ThreadStart(FrmStart.ShowForm));
            //thread.IsBackground = true;
            //thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        static private void ShowForm() {
            splashForm = new FrmStart();
            splashForm.Show();
            //splashForm.BringToFront();
            //Application.Run(splashForm);
        }

        static public void CloseForm() {
            splashForm.Invoke(new CloseDelegate(FrmStart.CloseFormInternal));
        }

        static private void CloseFormInternal() {
            splashForm.Hide();
            splashForm.Close();
            splashForm = null;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            System.Windows.Forms.Application.Exit();
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

        private void FrmStart_Load(object sender, EventArgs e) {

        }

        private void progressBar1_Click(object sender, EventArgs e) {

        }

    }
}
