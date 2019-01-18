using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS_MSG {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(FrmLogin_FormClosed);
        }

        private void FrmLogin_FormClosed(object sender, EventArgs e) {
            System.Environment.Exit(1);
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            System.Threading.Thread.Sleep(100);

            FrmProfile frmProfile = new FrmProfile();
            frmProfile.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e) {
            
        }

        private void FrmLogin_Load(object sender, EventArgs e) {

        }
    }
}
