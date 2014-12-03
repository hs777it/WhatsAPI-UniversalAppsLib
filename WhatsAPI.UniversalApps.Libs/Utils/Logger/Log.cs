﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAPI.UniversalApps.Libs.Utils.Logger
{
    class Log
    {
        public static void Write(string message,string uri ="")
        {
#if DEBUG
            var sb = new StringBuilder();
            sb.AppendLine("Url : " + uri);
            sb.AppendLine("Result : " + message);
            System.Diagnostics.Debug.WriteLine(string.Format("Request to Whatsapp Web Service Log : {0}{1}", Environment.NewLine, sb));
#endif
        }
    }
}
