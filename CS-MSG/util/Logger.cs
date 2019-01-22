using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_MSG.util {
    class Logger {
        public static void debug(object sender, object msg) {
            
            System.Diagnostics.Debug.Write(DateTime.Now.ToString("[yyyy-MM-dd hh:mm:ss] "));
            System.Diagnostics.Debug.Write(sender);
            System.Diagnostics.Debug.WriteLine(msg);
        }
    }
}
