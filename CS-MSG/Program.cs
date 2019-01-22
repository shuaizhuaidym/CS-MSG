using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CS_MSG {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmStart.ShowSplashScreen();

            Service.SSOService ssoService = new Service.SSOService();

            ssoService.SingleSignOn(Properties.Resources.str_app_id, Properties.Resources.str_gateway_ip);
            //MainForm mainForm = new MainForm(); //this takes ages

            FrmStart.CloseForm();
            //Application.Run(new FrmStart());
        }
    }
}
