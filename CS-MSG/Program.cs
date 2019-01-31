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
            ///
            /// TODO 在主线程中开启子线程分别执行各个业务，每个业务不交叉不耦合
            /// 例如单点返回结果和策略
            /// 单点成功显示信息，失败显示登录窗口
            /// 登录业务返回结果和策略
            /// 主线程根据策略和结果显示信息窗口
            /// 
            string result = ssoService.SingleSignOn(Properties.Resources.str_app_id, Properties.Resources.str_gateway_ip);
           
            FrmStart.CloseForm();
            //Application.Run(new FrmStart());
        }
    }
}
