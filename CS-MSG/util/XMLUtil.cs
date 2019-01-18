using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace CS_MSG.util {
    class XMLUtil {
        /**
         * Read by xml document
         */
        public static CS_MSG.Entity.Message readFlow(string xml) {
            XmlTextReader reader = new XmlTextReader(@"..\..\Book.xml");

            CS_MSG.Entity.Message msg = new CS_MSG.Entity.Message();
            List<CS_MSG.Entity.Attribute> attrs = new List<CS_MSG.Entity.Attribute>();

            CS_MSG.Entity.Attribute attr = new CS_MSG.Entity.Attribute();

            while (reader.Read()) {
                if (reader.NodeType == XmlNodeType.Element) {
                    if (reader.Name == "version") {
                        msg.Version = reader.ReadElementContentAsString().Trim();
                    }
                    if (reader.Name == "serviceType") {
                        msg.ServiceType = reader.ReadElementString().Trim();
                    }
                    if (reader.Name == "authResult") {
                        msg.Auth_mode = reader.GetAttribute(0).Trim();
                        msg.Result = Convert.ToBoolean(reader.GetAttribute(1).Trim());
                    }
                    if (reader.Name == "attr") {
                        attr.Name = reader.GetAttribute(0);
                        attr.Name_space = reader.GetAttribute(1);
                        attr.Value = reader.GetAttribute(2);
                    }

                    if (reader.NodeType == XmlNodeType.EndElement) {
                        if (reader.Name == "attr") {
                            attrs.Add(attr);
                            attr = new CS_MSG.Entity.Attribute();
                        }
                    }
                }
            }

            return msg;

        }

        /**
         * Read by flow
         */
        public static CS_MSG.Entity.Message readDoc(string xml) {
            CS_MSG.Entity.Message msg = new CS_MSG.Entity.Message();

            XmlDocument doc = new XmlDocument();
            
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
           // XmlReader reader = null;

            try {
                //reader = XmlReader.Create(Properties.Resources.Message, settings);
                doc.LoadXml(Properties.Resources.Message);
            } catch (Exception ex) {
                Console.WriteLine("err:"+ex.StackTrace);
            }
            //root
            XmlNode xn = doc.SelectSingleNode("message");
            // 得到根节点的所有子节点head/body
            XmlNodeList xnl = xn.ChildNodes;
            foreach (XmlNode xn1 in xnl) {
                if (xn1.Name == "head") {
                    XmlNode version = xn1.SelectSingleNode("version");
                    XmlNode serviceType = xn1.SelectSingleNode("serviceType");
                    msg.Version = version.InnerText.Trim();
                    msg.ServiceType = serviceType.InnerText.Trim();
                } else if (xn1.Name == "body") {
                    //accessControlResult
                    XmlNode acs = xn1.SelectSingleNode("accessControlResult");//reserved
                    //authResult
                    XmlNode au_result = xn1.SelectSingleNode("authResultSet").SelectSingleNode("authResult");
                    // 将节点转换为元素，便于得到节点的属性值
                    XmlElement xe = (XmlElement)au_result;

                    msg.Auth_mode = xe.GetAttribute("authMode");
                    msg.Result = Boolean.Parse(xe.GetAttribute("success").ToString());
                    //attributes
                    XmlNodeList xnattrs = xn1.SelectSingleNode("attributes").ChildNodes;

                    foreach (XmlNode xna in xnattrs) {
                        CS_MSG.Entity.Attribute attr = new CS_MSG.Entity.Attribute();
                        XmlElement xnae = (XmlElement)xna;
                        attr.Name = xnae.GetAttribute("name");
                        attr.Name_space = xnae.GetAttribute("namespace");

                        attr.Value = xnae.InnerText.Trim();
                        msg.Attrs.AddFirst(attr);
                    }
                }
            }
            return msg;
        }

    }
}
