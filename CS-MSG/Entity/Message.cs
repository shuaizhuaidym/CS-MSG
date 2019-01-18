using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_MSG.Entity {
    class Message {
        private string version;
        private string serviceType;

        public string ServiceType {
            get { return serviceType; }
            set { serviceType = value; }
        }

        private bool result;

        public bool Result {
            get { return result; }
            set { result = value; }
        }

        private string auth_mode;

        public string Auth_mode {
            get { return auth_mode; }
            set { auth_mode = value; }
        }
        private string token;

        public string Token {
            get { return token; }
            set { token = value; }
        }

        private LinkedList<Attribute> attrs = new LinkedList<Attribute>();

        internal LinkedList<Attribute> Attrs {
            get { return attrs; }
            set { attrs = value; }
        }

        public string Version {
            get { return version; }
            set { version = value; }
        }

    }
}
