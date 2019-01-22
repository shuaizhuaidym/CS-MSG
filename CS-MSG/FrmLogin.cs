using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

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
            string auth_xml = "";//TODO call vctk com interface
            Service.LoginService.Login(auth_xml);

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
