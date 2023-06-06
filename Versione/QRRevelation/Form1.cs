using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Presentation;
using BarcodeReader = ZXing.BarcodeReader;

namespace QRRevelation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;
        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtQRCode.Text = "";
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            if (captureDevice.IsRunning)
                captureDevice.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox.Image);
                    if (result !=null)
                {
                  
                    txtQRCode.Text = result.ToString();
                    timer1.Stop();
                
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();

                 

                }
                
            }

        }

        private void txtQRCode_TextChanged(object sender, EventArgs e)
        {
            if (txtQRCode.Text== "Solitudine") {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Solitudione.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Sorpresa")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Sorpresa.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Appagamento")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Appagamento.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Soddisfazione")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Soddisfazione.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Sensazione di colpa")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Sensazione di colpa.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Rimorso")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Rimorso.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Rabbia")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Rabbia.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Paura")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Paura.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Orgoglio")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Orgoglio.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Nostalgia")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Nostalgia.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Invidia")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Invidia.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Inquietudine")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Inquietudine.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Felicità")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Felicità.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Euforia")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Euforia.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Disgusto")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Disgusto.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Ansia")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Ansia.wav");
                player.Play();
            }
            if (txtQRCode.Text == "Delusione")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Delusione.wav");
           
                player.Play();
            }
            if (txtQRCode.Text == "Tristezza")
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Tristezza.wav");
                player.Play();
            }
            

        }
    }
}
