﻿namespace Seri_Port
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGonder = new System.Windows.Forms.Button();
            this.comboPortAdi = new System.Windows.Forms.ComboBox();
            this.lblPortSec = new System.Windows.Forms.Label();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.txtGonderilen = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lstBxDurum = new System.Windows.Forms.ListBox();
            this.txtAlinan = new System.Windows.Forms.TextBox();
            this.comboBaudRate = new System.Windows.Forms.ComboBox();
            this.lblDatabit = new System.Windows.Forms.Label();
            this.comboDataBit = new System.Windows.Forms.ComboBox();
            this.comboParity = new System.Windows.Forms.ComboBox();
            this.lblEslikBit = new System.Windows.Forms.Label();
            this.comboStopBiti = new System.Windows.Forms.ComboBox();
            this.lblStopBit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAlinan = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGonder
            // 
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGonder.Location = new System.Drawing.Point(318, 202);
            this.btnGonder.Margin = new System.Windows.Forms.Padding(4);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(394, 31);
            this.btnGonder.TabIndex = 22;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // comboPortAdi
            // 
            this.comboPortAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboPortAdi.FormattingEnabled = true;
            this.comboPortAdi.Location = new System.Drawing.Point(176, 43);
            this.comboPortAdi.Margin = new System.Windows.Forms.Padding(4);
            this.comboPortAdi.Name = "comboPortAdi";
            this.comboPortAdi.Size = new System.Drawing.Size(66, 24);
            this.comboPortAdi.TabIndex = 9;
            // 
            // lblPortSec
            // 
            this.lblPortSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPortSec.Location = new System.Drawing.Point(13, 43);
            this.lblPortSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortSec.Name = "lblPortSec";
            this.lblPortSec.Size = new System.Drawing.Size(155, 24);
            this.lblPortSec.TabIndex = 1;
            this.lblPortSec.Text = "Port Seçiniz";
            // 
            // btnBaglan
            // 
            this.btnBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglan.Location = new System.Drawing.Point(13, 202);
            this.btnBaglan.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(297, 31);
            this.btnBaglan.TabIndex = 16;
            this.btnBaglan.Text = "BAĞLAN";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaudRate.Location = new System.Drawing.Point(13, 75);
            this.lblBaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(155, 24);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Veri Hızı (Baud Rate)";
            // 
            // txtGonderilen
            // 
            this.txtGonderilen.Location = new System.Drawing.Point(318, 37);
            this.txtGonderilen.Margin = new System.Windows.Forms.Padding(4);
            this.txtGonderilen.Multiline = true;
            this.txtGonderilen.Name = "txtGonderilen";
            this.txtGonderilen.Size = new System.Drawing.Size(394, 158);
            this.txtGonderilen.TabIndex = 18;
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTemizle.Location = new System.Drawing.Point(318, 489);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(394, 32);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lstBxDurum
            // 
            this.lstBxDurum.FormattingEnabled = true;
            this.lstBxDurum.ItemHeight = 16;
            this.lstBxDurum.Location = new System.Drawing.Point(13, 277);
            this.lstBxDurum.Margin = new System.Windows.Forms.Padding(4);
            this.lstBxDurum.Name = "lstBxDurum";
            this.lstBxDurum.Size = new System.Drawing.Size(297, 244);
            this.lstBxDurum.TabIndex = 17;
            // 
            // txtAlinan
            // 
            this.txtAlinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlinan.Location = new System.Drawing.Point(318, 277);
            this.txtAlinan.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlinan.Multiline = true;
            this.txtAlinan.Name = "txtAlinan";
            this.txtAlinan.ReadOnly = true;
            this.txtAlinan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAlinan.Size = new System.Drawing.Size(394, 204);
            this.txtAlinan.TabIndex = 23;
            // 
            // comboBaudRate
            // 
            this.comboBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBaudRate.FormattingEnabled = true;
            this.comboBaudRate.Items.AddRange(new object[] {
            "75",
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBaudRate.Location = new System.Drawing.Point(176, 75);
            this.comboBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBaudRate.Name = "comboBaudRate";
            this.comboBaudRate.Size = new System.Drawing.Size(128, 24);
            this.comboBaudRate.TabIndex = 10;
            // 
            // lblDatabit
            // 
            this.lblDatabit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDatabit.Location = new System.Drawing.Point(13, 107);
            this.lblDatabit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatabit.Name = "lblDatabit";
            this.lblDatabit.Size = new System.Drawing.Size(155, 24);
            this.lblDatabit.TabIndex = 3;
            this.lblDatabit.Text = "Data Bit";
            // 
            // comboDataBit
            // 
            this.comboDataBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboDataBit.FormattingEnabled = true;
            this.comboDataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboDataBit.Location = new System.Drawing.Point(176, 107);
            this.comboDataBit.Margin = new System.Windows.Forms.Padding(4);
            this.comboDataBit.Name = "comboDataBit";
            this.comboDataBit.Size = new System.Drawing.Size(128, 24);
            this.comboDataBit.TabIndex = 11;
            // 
            // comboParity
            // 
            this.comboParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboParity.FormattingEnabled = true;
            this.comboParity.Items.AddRange(new object[] {
            "None  (0)",
            "Odd    (1)",
            "Even   (2)",
            "Mark  (3)",
            "Space (4)"});
            this.comboParity.Location = new System.Drawing.Point(176, 139);
            this.comboParity.Margin = new System.Windows.Forms.Padding(4);
            this.comboParity.Name = "comboParity";
            this.comboParity.Size = new System.Drawing.Size(128, 24);
            this.comboParity.TabIndex = 12;
            // 
            // lblEslikBit
            // 
            this.lblEslikBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEslikBit.Location = new System.Drawing.Point(13, 140);
            this.lblEslikBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEslikBit.Name = "lblEslikBit";
            this.lblEslikBit.Size = new System.Drawing.Size(155, 24);
            this.lblEslikBit.TabIndex = 4;
            this.lblEslikBit.Text = "Parity (Eşlik Biti)";
            // 
            // comboStopBiti
            // 
            this.comboStopBiti.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "One",
            "Two",
            "One"});
            this.comboStopBiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboStopBiti.FormattingEnabled = true;
            this.comboStopBiti.Items.AddRange(new object[] {
            "None (0)",
            "One (1)",
            "Two (2)",
            "OnePointFive (3)"});
            this.comboStopBiti.Location = new System.Drawing.Point(176, 171);
            this.comboStopBiti.Margin = new System.Windows.Forms.Padding(4);
            this.comboStopBiti.Name = "comboStopBiti";
            this.comboStopBiti.Size = new System.Drawing.Size(128, 24);
            this.comboStopBiti.TabIndex = 13;
            // 
            // lblStopBit
            // 
            this.lblStopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStopBit.Location = new System.Drawing.Point(13, 172);
            this.lblStopBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStopBit.Name = "lblStopBit";
            this.lblStopBit.Size = new System.Drawing.Size(155, 24);
            this.lblStopBit.TabIndex = 5;
            this.lblStopBit.Text = "Stop Bit";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(318, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(394, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "GÖNDERİLEN VERİ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlinan
            // 
            this.lblAlinan.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblAlinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlinan.Location = new System.Drawing.Point(318, 244);
            this.lblAlinan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlinan.Name = "lblAlinan";
            this.lblAlinan.Size = new System.Drawing.Size(394, 29);
            this.lblAlinan.TabIndex = 8;
            this.lblAlinan.Text = "ALINAN VERİ";
            this.lblAlinan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYeni
            // 
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Location = new System.Drawing.Point(176, 202);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(134, 31);
            this.btnYeni.TabIndex = 25;
            this.btnYeni.Text = "YENİ";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(13, 244);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(297, 29);
            this.lblDurum.TabIndex = 42;
            this.lblDurum.Text = "DURUM";
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(249, 43);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(55, 24);
            this.btnYenile.TabIndex = 43;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.Cyan;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(13, 9);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(291, 24);
            this.lblBaslik.TabIndex = 44;
            this.lblBaslik.Text = "ARETİAS BİLİŞİM";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 532);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lblAlinan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblStopBit);
            this.Controls.Add(this.comboStopBiti);
            this.Controls.Add(this.lblEslikBit);
            this.Controls.Add(this.comboParity);
            this.Controls.Add(this.comboDataBit);
            this.Controls.Add(this.lblDatabit);
            this.Controls.Add(this.comboBaudRate);
            this.Controls.Add(this.txtAlinan);
            this.Controls.Add(this.lstBxDurum);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtGonderilen);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.lblPortSec);
            this.Controls.Add(this.comboPortAdi);
            this.Controls.Add(this.btnGonder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PortConn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.ComboBox comboPortAdi;
        private System.Windows.Forms.Label lblPortSec;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.TextBox txtGonderilen;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox lstBxDurum;
        private System.Windows.Forms.ComboBox comboBaudRate;
        private System.Windows.Forms.Label lblDatabit;
        private System.Windows.Forms.ComboBox comboDataBit;
        private System.Windows.Forms.ComboBox comboParity;
        private System.Windows.Forms.Label lblEslikBit;
        private System.Windows.Forms.ComboBox comboStopBiti;
        private System.Windows.Forms.Label lblStopBit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAlinan;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.TextBox txtAlinan;
    }
}

