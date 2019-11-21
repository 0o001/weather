﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;

namespace weather
{
    class WeatherItem
    {
        public string Date { get; set; }
        public string DayName
        {
            get
            {
                return CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)DateTime.Parse(this.Date).DayOfWeek];
            }
        }
        public string ImageLocation { get; set; }
    }

    class WorldWeather
    {
        private const string WORLDWEARTHER_PREMIUM_API_KEY = "";
        public static List<WeatherItem> getWeather5Days(string city, string country)
        {
            string url = @"http://api.worldweatheronline.com/premium/v1/weather.ashx?q=" + city + "," + country + "&format=xml&num_of_days=5&key=" + WORLDWEARTHER_PREMIUM_API_KEY;

            XmlDocument xml = new XmlDocument();
            xml.Load(url);

            XmlNodeList weatherNodes = xml.SelectNodes("/data/weather");
            List<WeatherItem> weathers = new List<WeatherItem>();
            foreach (XmlNode weatherNode in weatherNodes)
            {
                WeatherItem weather = new WeatherItem();
                weather.Date = weatherNode["date"].InnerText;
                weather.ImageLocation = weatherNode.SelectNodes("hourly")[(int) (DateTime.Now.Hour / 3)]["weatherIconUrl"].FirstChild.InnerText;
                weathers.Add(weather);
            }

            return weathers;
        }
    }
}