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

namespace MainSystem
{
    public partial class frmScanQR : Form
    {
        public frmScanQR()
        {
            InitializeComponent();
        }

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        private string id;

        public string DecodeID
        {
            get { return id; }
            set { id = value; }
        }

        
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Image)eventArgs.Frame.Clone();
        }

        private void frmScanQR_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in CaptureDevice)
            {
                comboBox1.Items.Add(device.Name);
            }
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FinalFrame != null)
            {
                FinalFrame.Stop();


            }
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            timer1.Start();
        }

        private void frmScanQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();

            try
            {
                Result result = reader.Decode((Bitmap)pictureBox1.Image);
                timer1.Stop();
                string decoded = result.ToString().Trim();

                MessageBox.Show("Success");
                DecodeID=decoded;
                if (FinalFrame.IsRunning == true)
                {
                    FinalFrame.Stop();
                    this.Dispose();
                    pictureBox1.Image = null;
                    comboBox1.SelectedIndex = -1;
                    
                }
            }
            catch (Exception)
            {
                timer1.Start();
                //timer1.Stop();
                //MessageBox.Show("No code detected");
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
