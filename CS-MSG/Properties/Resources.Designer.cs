﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CS_MSG.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CS_MSG.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;message&gt;
        ///	&lt;head&gt;
        ///		&lt;version&gt;1.0&lt;/version&gt;
        ///		&lt;serviceType&gt;AuthenService&lt;/serviceType&gt;
        ///	&lt;/head&gt;
        ///	&lt;body&gt;
        ///		&lt;clientInfo&gt;
        ///			&lt;clientIP&gt;{0}&lt;/clientIP&gt;
        ///		&lt;/clientInfo&gt;
        ///		&lt;appId&gt;UIAS&lt;/appId&gt;
        ///		&lt;authen&gt;
        ///			&lt;authCredential authMode=&quot;cert&quot;&gt;
        ///        &lt;original&gt;{1}&lt;/original&gt;
        ///				&lt;detach&gt;{2}&lt;/detach&gt;
        ///			&lt;/authCredential&gt;
        ///		&lt;/authen&gt;
        ///		&lt;accessControl&gt;true&lt;/accessControl&gt;
        ///		&lt;attributes attributeType=&quot;all&quot; /&gt;
        ///	&lt;/body&gt;
        ///&lt;/message&gt;.
        /// </summary>
        internal static string auth_request_xml {
            get {
                return ResourceManager.GetString("auth_request_xml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap balloom {
            get {
                object obj = ResourceManager.GetObject("balloom", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap bridge {
            get {
                object obj = ResourceManager.GetObject("bridge", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap img_cancel {
            get {
                object obj = ResourceManager.GetObject("img_cancel", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap img_close {
            get {
                object obj = ResourceManager.GetObject("img_close", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap img_girl {
            get {
                object obj = ResourceManager.GetObject("img_girl", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap img_ok {
            get {
                object obj = ResourceManager.GetObject("img_ok", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap img_qrcode {
            get {
                object obj = ResourceManager.GetObject("img-qrcode", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;message&gt;
        ///  &lt;head&gt;
        ///    &lt;version&gt;1.0&lt;/version&gt;
        ///    &lt;serviceType&gt;AuthenService&lt;/serviceType&gt;
        ///    &lt;messageState&gt;false&lt;/messageState&gt;
        ///  &lt;/head&gt;
        ///  &lt;body&gt;
        ///    &lt;accessControlResult&gt;Permit&lt;/accessControlResult&gt;
        ///    &lt;authResultSet allFailed=&quot;true&quot;&gt;
        ///      &lt;authResult authMode=&quot;cert&quot; success=&quot;true&quot; /&gt;
        ///    &lt;/authResultSet&gt;
        ///    &lt;attributes&gt;
        ///      &lt;attr name=&quot;X509Certificate.SubjectDN&quot;
        ///				namespace=&quot;http://www.jit.com.cn/cinas/ias/ns/saml/saml11/X.509&quot;&gt;CN=yanming_dai, [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Message {
            get {
                return ResourceManager.GetString("Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap moss {
            get {
                object obj = ResourceManager.GetObject("moss", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap sand_sea {
            get {
                object obj = ResourceManager.GetObject("sand_sea", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap sky {
            get {
                object obj = ResourceManager.GetObject("sky", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;message&gt;
        ///	&lt;head&gt;
        ///		&lt;version&gt;1.0&lt;/version&gt;
        ///		&lt;serviceType&gt;msg_ta_service&lt;/serviceType&gt;
        ///	&lt;/head&gt;
        ///	&lt;body&gt;
        ///		&lt;clientInfo&gt;
        ///			&lt;clientIP&gt;{0}&lt;/clientIP&gt;
        ///		&lt;/clientInfo&gt;
        ///		&lt;token&gt;{1}&lt;/token&gt;
        ///		&lt;appId&gt;{2}&lt;/appId &gt;
        ///		&lt;CustomAttributes&gt;&lt;/CustomAttributes&gt;
        ///	&lt;/body&gt;
        ///&lt;/message&gt;
        ///.
        /// </summary>
        internal static string sso_request {
            get {
                return ResourceManager.GetString("sso_request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UIAS.
        /// </summary>
        internal static string str_app_id {
            get {
                return ResourceManager.GetString("str_app_id", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 关闭.
        /// </summary>
        internal static string str_close {
            get {
                return ResourceManager.GetString("str_close", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 192.168.9.112.
        /// </summary>
        internal static string str_gateway_ip {
            get {
                return ResourceManager.GetString("str_gateway_ip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 证书登录.
        /// </summary>
        internal static string str_login_cert {
            get {
                return ResourceManager.GetString("str_login_cert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://172.16.7.80:6180/MessageService.
        /// </summary>
        internal static string str_login_url {
            get {
                return ResourceManager.GetString("str_login_url", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 报文认证示例.
        /// </summary>
        internal static string str_title_demo_msg {
            get {
                return ResourceManager.GetString("str_title_demo_msg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 认证信息.
        /// </summary>
        internal static string str_title_profile {
            get {
                return ResourceManager.GetString("str_title_profile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap token_wind {
            get {
                object obj = ResourceManager.GetObject("token_wind", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap wind {
            get {
                object obj = ResourceManager.GetObject("wind", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
