using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//including references libraries 
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CameraApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice videoSource;

        

        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevices)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

       

      

       
        private void buttonStart_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(CaptureDevices[comboBox1.SelectedIndex].MonikerString);
            videoSource.NewFrame += VideoSource_NewFrame1;
            videoSource.Start();

        }

        private void VideoSource_NewFrame1(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        
        private void buttonCapture_Click(object sender, EventArgs e)
        {
            if(videoSource.IsRunning == false)
            {
                
                MessageBox.Show("Camera is off!!!");
            }
            else
            {
                pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            videoSource.Stop();
            Application.Exit();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPG(*.JPG|*.jpg";
            if (save.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(pictureBox2.Width);
                int height = Convert.ToInt32(pictureBox2.Height);
                Bitmap bit = new Bitmap(width, height);
                pictureBox2.DrawToBitmap(bit, new Rectangle(0, 0, Width, Height));
                bit.Save(save.FileName, ImageFormat.Jpeg);

            }
        }
    }
}
