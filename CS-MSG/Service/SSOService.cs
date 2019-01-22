using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using PNXClientLib;
using CS_MSG.util;

namespace CS_MSG.Service {
    //TODO 统一结果处理接口
    class SSOService {           
        public SSOService() { }
        /**
         *注册COM组件，完成token获取、单点登录 
         */
        private string GetToken(string gateway_ip) {
            string token = null;
            IPNXDataTrans COM = null;
            try {
                COM = new PNXDataTrans();
                token = COM.GetSessionToken(gateway_ip);
            } catch (Exception e) {
                MessageBox.Show(e.Message);
                //TODO release resource
            } finally {
                if (COM.GetLastError() != 0) {
                    string errMSG = COM.GetLastErrorMessage();
                }
            }
            return token;

        }

        /**组装报文，单点登录*/
        public string SingleSignOn(string app_id, string gateway_ip) {
            string token = GetToken(gateway_ip);

            if (String.IsNullOrEmpty(token)) { 
                showLoginForm();
            }
            string auth_xml = Properties.Resources.sso_request;
            auth_xml = String.Format(auth_xml, "127.0.0.1", token, app_id);
            string policy = null;
            try {
                //T+A
                policy = CS_MSG.util.HttpClient.doPost(Properties.Resources.str_login_url, auth_xml);
                Logger.debug(this, policy);
                //单点登录，成功则进入信息窗口，失败则显示登录窗口要求认证；
                if (policy != null && policy.IndexOf("attributes") > 0) {//TODO 准确判断success
                    showProfile();
                } else {
                    showLoginForm();
                }

            } catch (IOException e) {
                MessageBox.Show("单点登录异常，详细信息请查看日志:"+e.Message);
            }
            return policy;
        }

        private void showLoginForm() {
            FrmLogin frmLogin = new FrmLogin();
            Application.Run(frmLogin);
        }

        private void showProfile() { 
            FrmProfile frmProfile = new FrmProfile();
            Application.Run(frmProfile);
        }

    }
}
