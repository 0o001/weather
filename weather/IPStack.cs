﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace weather
{
    class IPStack
    {
        private const string IPSTACK_API_KEY = "";
        private static string getIP()
        {
            return new WebClient().DownloadString("http://icanhazip.com");
        }

        public static string getLocation()
        {
            string url = "http://api.ipstack.com/" + getIP() + "?access_key=" + IPSTACK_API_KEY + "&format=1&output=xml";

            XmlDocument xml = new XmlDocument();
            xml.Load(url);

            return xml.SelectSingleNode("/result/region_name").InnerText;
        }
    }
}