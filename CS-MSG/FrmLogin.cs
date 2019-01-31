using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using PNXClientLib;

namespace CS_MSG {
    public partial class FrmLogin : Form {
        private FrmProfile frmProfile;
        private bool needClose;

        public FrmLogin(FrmProfile frmProfile) {
            InitializeComponent();
            this.frmProfile = frmProfile;
            this.FormClosed += new FormClosedEventHandler(FrmLogin_FormClosed);
        }

        private void FrmLogin_FormClosed(object sender, EventArgs e) {
            if (needClose) {
                System.Environment.Exit(1);
            }                                          
        }

        /// <summary>
        /// PKCS#7 signature
        /// </summary>
        /// <returns></returns>
        private string signatureP1(string random, bool isDetach, bool isIncludeCert) {
            string siguature = null;
            IPNXDataTrans COM = null;
            try {
                COM = new PNXDataTrans();
                COM.Initialize("", "<?xml version=\"1.0\" encoding=\"utf-8\"?><authinfo><liblist><lib type=\"SKF\" version=\"1.1\" dllname=\"U2h1dHRsZUNzcDExXzMwMDBHTS5kbGw=\" ><algid val=\"SHA1\" sm2_hashalg=\"SM3\"/></lib><lib type=\"CSP\" version=\"1.0\" dllname=\"RkVJVElBTiBlUGFzc05HIENTUCBGb3IgSklUM0sgVjEuMA==\" ><algid val=\"SHA1\" sm2_hashalg=\"SHA1\"/></lib><lib type=\"CSP\" version=\"1.0\" dllname=\"RW50ZXJTYWZlIGVQYXNzMzAwMyBDU1AgdjEuMA==\" ><algid val=\"SHA1\" sm2_hashalg=\"SHA1\"/></lib><lib type=\"PM\" version=\"1.0\" dllname=\"Q3J5cHRPY3guZGxs\" ><algid val=\"SHA1\" sm2_hashalg=\"SM3\"/></lib><lib type=\"CSP\" version=\"1.0\" dllname=\"RkVJVElBTiBlUGFzc05HIFJTQSBDcnlwdG9ncmFwaGljIFNlcnZpY2UgUHJvdmlkZXI=\" ><algid val=\"SHA1\" sm2_hashalg=\"SHA1\"/></lib><lib type=\"CSP\" version=\"1.0\" dllname=\"SklUIFVTQiBLZXkgQ1NQIHYxLjA=\" ><algid val=\"SHA1\" sm2_hashalg=\"SHA1\"/></lib><lib type=\"CSP\" version=\"1.0\" dllname=\"RW50ZXJTYWZlIGVQYXNzMjAwMSBDU1AgdjEuMA==\" ><algid val=\"SHA1\" sm2_hashalg=\"SHA1\"/></lib><lib type=\"CSP\" version=\"1.0\" dllname=\"SklUIFVTQiBLZXkzMDAzIENTUCB2MS4w\" ><algid val=\"SHA1\" sm2_hashalg=\"SHA1\"/></lib><lib type=\"CSP\" version=\"1.0\" dllname=\"TWljcm9zb2Z0IEVuaGFuY2VkIENyeXB0b2dyYXBoaWMgUHJvdmlkZXIgdjEuMA==\" ><algid val=\"SHA1\" sm2_hashalg=\"SHA1\"/></lib><lib type=\"CSP\" version=\"1.0\" dllname=\"TWljcm9zb2Z0IFN0cm9uZyBDcnlwdG9ncmFwaGljIFByb3ZpZGVy\" ><algid val=\"SHA1\" sm2_hashalg=\"SHA1\"/></lib><lib type=\"CSP\" version=\"1.0\" dllname=\"TWljcm9zb2Z0IEJhc2UgQ3J5cHRvZ3JhcGhpYyBQcm92aWRlciB2MS4w\" ><algid val=\"SHA1\" sm2_hashalg=\"SHA1\"/></lib></liblist></authinfo>");
                siguature = COM.P7SignString(random, isDetach, isIncludeCert);
                if (COM.GetLastError() != 0) {
                    //TODO
                    string errMSG = getErrMsg(COM);
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            } finally {
                COM.Finalize();
            }
            return siguature;

        }

        /// <summary>
        /// 证书登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e) {
            string random = "random";

            string signature = signatureP1(random, true, true);
            string auth_xml = buildAuthXML(random, signature);//TODO call vctk com interface

            string policy = Service.LoginService.Login(auth_xml);

            frmProfile.Show();
            needClose = false;
            this.Hide();
        }

        //组织认证XML
        private string buildAuthXML(string random, string signature) {
            string template = Properties.Resources.auth_request_xml;
            template = String.Format(template, new string[] { Properties.Resources.str_gateway_ip, random, signature });
            return template;
        }
        /// <summary>
        /// get com make sign error message
        /// </summary>
        /// <returns></returns>
        private string getErrMsg(IPNXDataTrans COM) {
            uint errorCode = COM.GetLastError();
            string errorMessage = COM.GetLastErrorMessage();
            string displayMsg = null;

            if ((long)errorCode == -536870815 || errorCode == 3758096481) {
                displayMsg = "没有找到有效的证书，如果使用的是KEY，请确认已经插入key。";
            }
            if (errorCode == 3758096386 || errorCode == 2148532334) {
                displayMsg = "用户取消操作";
            }
            if (!String.IsNullOrEmpty(errorMessage)) {
                if ("对象无效".Equals(errorMessage) || errorCode == 3758096397) {
                    displayMsg = "对象无效";
                } else if (errorCode == 3758096470) {// pin码错误
                    displayMsg = "pin码错误";
                } else {
                    displayMsg = errorMessage;
                }
            }
            return displayMsg;

        }

    }
}
