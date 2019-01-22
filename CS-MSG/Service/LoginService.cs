using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace CS_MSG.Service {
    /**连接网关做认证*/
    class LoginService {
        public static string Login(string auth_xml) {
            string msg = null;
            try {
                msg = CS_MSG.util.HttpClient.doPost(Properties.Resources.str_login_url, auth_xml);
            } catch (IOException e) {
                MessageBox.Show(e.Message);
            }
            return msg;
        }


    }
}
