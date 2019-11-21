namespace weather
{
    partial class frm_weather
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_weather));
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_day1 = new System.Windows.Forms.Label();
            this.lbl_day2 = new System.Windows.Forms.Label();
            this.lbl_day3 = new System.Windows.Forms.Label();
            this.lbl_day4 = new System.Windows.Forms.Label();
            this.tp_days = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_day5 = new System.Windows.Forms.Label();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.pcr_day5 = new System.Windows.Forms.PictureBox();
            this.pcr_day4 = new System.Windows.Forms.PictureBox();
            this.pcr_day3 = new System.Windows.Forms.PictureBox();
            this.pcr_day2 = new System.Windows.Forms.PictureBox();
            this.pcr_day1 = new System.Windows.Forms.PictureBox();
            this.pcr_loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_day5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_day4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_day3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_day2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_day1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_city
            // 
            this.lbl_city.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_city.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_city.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.ForeColor = System.Drawing.Color.White;
            this.lbl_city.Location = new System.Drawing.Point(0, 141);
            this.lbl_city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(562, 33);
            this.lbl_city.TabIndex = 0;
            this.lbl_city.Text = "-";
            this.lbl_city.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_city.Click += new System.EventHandler(this.lbl_sehir_Click);
            // 
            // lbl_day1
            // 
            this.lbl_day1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_day1.Location = new System.Drawing.Point(12, 106);
            this.lbl_day1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day1.Name = "lbl_day1";
            this.lbl_day1.Size = new System.Drawing.Size(85, 25);
            this.lbl_day1.TabIndex = 6;
            this.lbl_day1.Text = "day1";
            this.lbl_day1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_day2
            // 
            this.lbl_day2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_day2.Location = new System.Drawing.Point(129, 106);
            this.lbl_day2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day2.Name = "lbl_day2";
            this.lbl_day2.Size = new System.Drawing.Size(85, 25);
            this.lbl_day2.TabIndex = 7;
            this.lbl_day2.Text = "day2";
            this.lbl_day2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_day3
            // 
            this.lbl_day3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_day3.Location = new System.Drawing.Point(240, 106);
            this.lbl_day3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day3.Name = "lbl_day3";
            this.lbl_day3.Size = new System.Drawing.Size(85, 25);
            this.lbl_day3.TabIndex = 8;
            this.lbl_day3.Text = "day3";
            this.lbl_day3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_day4
            // 
            this.lbl_day4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_day4.Location = new System.Drawing.Point(351, 106);
            this.lbl_day4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day4.Name = "lbl_day4";
            this.lbl_day4.Size = new System.Drawing.Size(85, 25);
            this.lbl_day4.TabIndex = 9;
            this.lbl_day4.Text = "day4";
            this.lbl_day4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_day5
            // 
            this.lbl_day5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_day5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_day5.Location = new System.Drawing.Point(463, 106);
            this.lbl_day5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day5.Name = "lbl_day5";
            this.lbl_day5.Size = new System.Drawing.Size(85, 25);
            this.lbl_day5.TabIndex = 10;
            this.lbl_day5.Text = "day5";
            this.lbl_day5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_city
            // 
            this.cb_city.AllowDrop = true;
            this.cb_city.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_city.DropDownHeight = 150;
            this.cb_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_city.DropDownWidth = 121;
            this.cb_city.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_city.FormattingEnabled = true;
            this.cb_city.IntegralHeight = false;
            this.cb_city.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlı Urfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak "});
            this.cb_city.Location = new System.Drawing.Point(183, 143);
            this.cb_city.Margin = new System.Windows.Forms.Padding(4);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(187, 27);
            this.cb_city.TabIndex = 12;
            this.cb_city.SelectionChangeCommitted += new System.EventHandler(this.cb_sehir_SelectionChangeCommitted);
            // 
            // pcr_day5
            // 
            this.pcr_day5.BackColor = System.Drawing.Color.White;
            this.pcr_day5.InitialImage = null;
            this.pcr_day5.Location = new System.Drawing.Point(463, 15);
            this.pcr_day5.Margin = new System.Windows.Forms.Padding(4);
            this.pcr_day5.Name = "pcr_day5";
            this.pcr_day5.Size = new System.Drawing.Size(64, 64);
            this.pcr_day5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcr_day5.TabIndex = 5;
            this.pcr_day5.TabStop = false;
            // 
            // pcr_day4
            // 
            this.pcr_day4.BackColor = System.Drawing.Color.White;
            this.pcr_day4.InitialImage = null;
            this.pcr_day4.Location = new System.Drawing.Point(351, 15);
            this.pcr_day4.Margin = new System.Windows.Forms.Padding(4);
            this.pcr_day4.Name = "pcr_day4";
            this.pcr_day4.Size = new System.Drawing.Size(64, 64);
            this.pcr_day4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcr_day4.TabIndex = 4;
            this.pcr_day4.TabStop = false;
            // 
            // pcr_day3
            // 
            this.pcr_day3.BackColor = System.Drawing.Color.White;
            this.pcr_day3.InitialImage = null;
            this.pcr_day3.Location = new System.Drawing.Point(240, 15);
            this.pcr_day3.Margin = new System.Windows.Forms.Padding(4);
            this.pcr_day3.Name = "pcr_day3";
            this.pcr_day3.Size = new System.Drawing.Size(64, 64);
            this.pcr_day3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcr_day3.TabIndex = 3;
            this.pcr_day3.TabStop = false;
            // 
            // pcr_day2
            // 
            this.pcr_day2.BackColor = System.Drawing.Color.White;
            this.pcr_day2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcr_day2.InitialImage = null;
            this.pcr_day2.Location = new System.Drawing.Point(129, 15);
            this.pcr_day2.Margin = new System.Windows.Forms.Padding(4);
            this.pcr_day2.Name = "pcr_day2";
            this.pcr_day2.Size = new System.Drawing.Size(64, 64);
            this.pcr_day2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcr_day2.TabIndex = 2;
            this.pcr_day2.TabStop = false;
            // 
            // pcr_day1
            // 
            this.pcr_day1.BackColor = System.Drawing.Color.White;
            this.pcr_day1.InitialImage = null;
            this.pcr_day1.Location = new System.Drawing.Point(12, 15);
            this.pcr_day1.Margin = new System.Windows.Forms.Padding(4);
            this.pcr_day1.Name = "pcr_day1";
            this.pcr_day1.Size = new System.Drawing.Size(64, 64);
            this.pcr_day1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcr_day1.TabIndex = 1;
            this.pcr_day1.TabStop = false;
            // 
            // pcr_loading
            // 
            this.pcr_loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcr_loading.Image = global::weather.Properties.Resources.loading;
            this.pcr_loading.Location = new System.Drawing.Point(0, 0);
            this.pcr_loading.Margin = new System.Windows.Forms.Padding(4);
            this.pcr_loading.Name = "pcr_loading";
            this.pcr_loading.Size = new System.Drawing.Size(562, 174);
            this.pcr_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcr_loading.TabIndex = 13;
            this.pcr_loading.TabStop = false;
            // 
            // frm_weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 174);
            this.Controls.Add(this.cb_city);
            this.Controls.Add(this.lbl_day5);
            this.Controls.Add(this.lbl_day4);
            this.Controls.Add(this.lbl_day3);
            this.Controls.Add(this.lbl_day2);
            this.Controls.Add(this.lbl_day1);
            this.Controls.Add(this.pcr_day5);
            this.Controls.Add(this.pcr_day4);
            this.Controls.Add(this.pcr_day3);
            this.Controls.Add(this.pcr_day2);
            this.Controls.Add(this.pcr_day1);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.pcr_loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_weather";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Hava Durumu";
            this.Load += new System.EventHandler(this.frm_hava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_day5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_day4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_day3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_day2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_day1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.PictureBox pcr_day1;
        private System.Windows.Forms.PictureBox pcr_day2;
        private System.Windows.Forms.PictureBox pcr_day3;
        private System.Windows.Forms.PictureBox pcr_day4;
        private System.Windows.Forms.PictureBox pcr_day5;
        private System.Windows.Forms.Label lbl_day1;
        private System.Windows.Forms.Label lbl_day2;
        private System.Windows.Forms.Label lbl_day3;
        private System.Windows.Forms.Label lbl_day4;
        private System.Windows.Forms.ToolTip tp_days;
        private System.Windows.Forms.Label lbl_day5;
        private System.Windows.Forms.ComboBox cb_city;
        private System.Windows.Forms.PictureBox pcr_loading;


    }
}
