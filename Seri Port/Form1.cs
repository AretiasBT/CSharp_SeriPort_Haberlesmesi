using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;


namespace Seri_Port
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        SerialPort serialPort1;
        string port;
        int baud;
        int databit;
        Parity eslik;
        StopBits dur;
       

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            string[] portlar = SerialPort.GetPortNames();
            comboPortAdi.Items.Clear();
            foreach (string prt in portlar)
            {
                comboPortAdi.Items.Add(prt);
            }
            label7.Hide();
            lblAlinan.Hide();
            txtGonderilen.Hide();
            txtAlinan.Hide();
            btnGonder.Hide();
            btnTemizle.Hide();
            btnYeni.Hide();
            this.Size = new Size(333, 571);
            this.MaximumSize = new Size(333, 571);
            this.MinimumSize = new Size(333, 571);
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                lstBxDurum.Items.Clear();
                port = comboPortAdi.SelectedItem.ToString();
                lstBxDurum.Items.Add("Port: "+port);
                switch (comboBaudRate.SelectedIndex)
                {
                    case 0:
                        baud = 75;
                        break;
                    case 1:
                        baud = 110;
                        break;
                    case 2:
                        baud = 300;
                        break;
                    case 3:
                        baud = 1200;
                        break;
                    case 4:
                        baud = 2400;
                        break;
                    case 5:
                        baud = 4800;
                        break;
                    case 6:
                        baud = 9600;
                        break;
                    case 7:
                        baud = 19200;
                        break;
                    case 8:
                        baud = 38400;
                        break;
                    case 9:
                        baud = 57600;
                        break;
                    case 10:
                        baud = 115200;
                        break;
                    default:
                        baud = 9600;
                        break;
                }
                lstBxDurum.Items.Add("Veri Hızı: "+baud.ToString());
                switch (comboDataBit.SelectedIndex)
                {
                    case 0:
                        databit=5;
                        break;
                    case 1:
                        databit=6;
                        break;
                    case 2:
                        databit=7;
                        break;
                    case 3:
                        databit = 8;
                        break;
                    default:
                        databit = 8;
                        break;
                }
                lstBxDurum.Items.Add("Veri Biti Sayısı: "+databit);
                
                switch (comboParity.SelectedIndex)
                {
                    case 0:
                        eslik = Parity.None;
                        break;
                    case 1:
                        eslik = Parity.Odd;
                        break;
                    case 2:
                        eslik = Parity.Even;
                        break;
                    case 3:
                        eslik = Parity.Mark;
                        break;
                    case 4:
                        eslik = Parity.Space;
                        break;
                    default:
                        eslik = Parity.None;
                        break;
                }
                lstBxDurum.Items.Add("Parity (Eşlik): "+eslik);
                switch (comboStopBiti.SelectedIndex)
                {
                    case 0:
                        dur = StopBits.None;
                        break;
                    case 1:
                        dur = StopBits.One;
                        break;
                    case 2:
                        dur =StopBits.Two;
                        break;
                    case 3:
                        dur = StopBits.OnePointFive;
                        break;
                    default:
                        dur = StopBits.One;
                        break;
                }     

                lstBxDurum.Items.Add("Stop Biti: "+dur);

                serialPort1 = new SerialPort(port, baud, eslik, databit, dur);
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                comboPortAdi.Text = port;
                comboBaudRate.Text = baud.ToString();
                comboDataBit.Text = databit.ToString();
                comboParity.Text = eslik.ToString();
                comboStopBiti.Text = dur.ToString();

                this.Size = new System.Drawing.Size(741, 571);
                this.MaximumSize = new Size(741, 571);
                this.MinimumSize = new Size(741, 571);

                serialPort1.Open();
                comboPortAdi.Enabled = false;
                comboBaudRate.Enabled = false;
                comboDataBit.Enabled = false;
                comboParity.Enabled = false;
                comboStopBiti.Enabled = false;
                btnBaglan.Enabled = false;
                btnYenile.Enabled = false;
                btnBaglan.Size = new Size(155, 31);

                btnBaglan.BackColor = Color.LightGreen;
                btnBaglan.Text = "BAĞLI: "+port;
                btnGonder.Show();
                btnTemizle.Show();
                btnYeni.Show();
                label7.Show();
                lblAlinan.Show();
                txtGonderilen.Show();
                txtAlinan.Show();

                
            }
            catch
            {
                lstBxDurum.Items.Add("Hata! Bağlantı gerçekleştirilemedi.");
               
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnYeni.Hide();
            serialPort1.Close();
            comboPortAdi.Enabled = true;
            comboBaudRate.Enabled = true;
            comboDataBit.Enabled = true;
            comboParity.Enabled = true;
            comboStopBiti.Enabled = true;
            btnBaglan.Enabled = true;
            btnYenile.Enabled = true;
            btnBaglan.Size = new Size(297, 31);
            btnBaglan.BackColor = Color.WhiteSmoke;
            btnBaglan.Text = "BAĞLAN";
            label7.Hide();
            lblAlinan.Hide();
            txtGonderilen.Hide();
            txtAlinan.Hide();
            btnGonder.Hide();
            btnTemizle.Hide();
            btnYeni.Hide();
            this.Size = new Size(333, 571);
            this.MaximumSize = new Size(333, 571);
            this.MinimumSize = new Size(333, 571);
            lstBxDurum.Items.Clear();
            lstBxDurum.Items.Add("Bağlantı Kapatıldı!");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            string[] portlar = SerialPort.GetPortNames();
            comboPortAdi.Items.Clear();
            foreach (string prt in portlar)
            {
                comboPortAdi.Items.Add(prt);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtGonderilen.Clear();
            txtAlinan.Clear();
            lstBxDurum.Items.Clear();

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1 == null)
                {
                    MessageBox.Show("Lütfen Port Seçiniz ve 'BAĞLAN' butonuna tıklayınız.");
                }
                else
                {
                    serialPort1.Write(txtGonderilen.Text + "\n");
                    txtGonderilen.Clear();
                    lstBxDurum.Items.Add("Veri Gönderildi");
                }

            }
            catch
            {
                lstBxDurum.Items.Add("Hata! Veri gönderilemedi.");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            txtAlinan.Text = txtAlinan.Text + serialPort1.ReadExisting() + "\r\n";
            txtAlinan.Select(txtAlinan.Text.Length, 0);
        }
    }
}
