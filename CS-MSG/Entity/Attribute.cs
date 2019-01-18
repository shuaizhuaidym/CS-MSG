using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_MSG.Entity {
    class Attribute {

        string name;
        string value;

        string name_space;

        public string Name {
            get { return name; }
            set { this.name = value; }
        }

        public string Value {
            get { return value; }
            set { this.value = value; }
        }

        public string Name_space {
            get { return this.name_space; }
            set { name_space = value; }
        }

    }
}
