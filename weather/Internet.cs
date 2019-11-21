﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace weather
{
    class Internet
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool IsConnected()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }
    }
}