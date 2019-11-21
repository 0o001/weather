using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace weather
{
    public partial class frm_weather : Form
    {
        Label[] lbl_days;
        PictureBox[] pcr_days;
        public frm_weather()
        {
            InitializeComponent();

            lbl_days = new Label[] { lbl_day1, lbl_day2, lbl_day3, lbl_day4, lbl_day5 };
            pcr_days = new PictureBox[] { pcr_day1, pcr_day2, pcr_day3, pcr_day4, pcr_day5 };

            pcr_loading.BringToFront();
            cb_city.Hide();
        }

        private void frm_hava_Load(object sender, EventArgs e)
        {
            RefreshWeather(IPStack.getLocation());
        }

        void frm_hava_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (!picturesIsNull(pcr_days))
            {
                pcr_loading.Hide();
            }
        }

        private void lbl_sehir_Click(object sender, EventArgs e)
        {
            cb_city.Show();

            cb_city.DroppedDown = true;
            cb_city.SelectedItem = lbl_city.Text;
            cb_city.Text = lbl_city.Text;
        }

        private void cb_sehir_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pcr_loading.Show();
            cb_city.Hide();

            lbl_city.Text = cb_city.SelectedItem.ToString();
            RefreshWeather(cb_city.SelectedItem.ToString());
        }

        private bool picturesIsNull(PictureBox[] pictures)
        {
            foreach (PictureBox picture in pictures)
            {
                if (picture.Image != null)
                {
                    return false;
                }
            }

            return true;
        }

        private void picturesSetNull(PictureBox[] pictures)
        {
            foreach (PictureBox picture in pictures)
            {
                picture.Image = null;
            }
        }

        private void RefreshWeather(string city)
        {
            if(Internet.IsConnected())
            {
                picturesSetNull(pcr_days);

                int index = 0;
                foreach (WeatherItem weather in WorldWeather.getWeather5Days(city, "TR"))
                {
                    lbl_days[index].Text = weather.DayName;
                    tp_days.SetToolTip(lbl_days[index], weather.Date);

                    pcr_days[index].ImageLocation = weather.ImageLocation;
                    pcr_days[index].LoadCompleted += new AsyncCompletedEventHandler(frm_hava_LoadCompleted);
                    pcr_days[index].LoadAsync();

                    index++;
                }

                lbl_city.Text = city;
                cb_city.Text = city;
            }
            else
            {
                MessageBox.Show("İnternet Bağlantınızı Kontrol Edin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}