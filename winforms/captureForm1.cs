//using Emgu.CV;
//using Emgu.CV.Structure;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermalogMultiScannerDemo.winforms
{
    public partial class captureForm1 : MetroForm //Form
    {

        public bool _streaming;
        //public Capture _capture;
        public int _camera = 0;


        EnrollmentWindow_new ic;
        public captureForm1()
        {
            InitializeComponent();
        }
        public captureForm1(EnrollmentWindow_new ff)
        {
            InitializeComponent();

            ic = ff;
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {

            //_camera = Properties.Settings.Default.useExternalCamera;
            //_streaming = false;
            //_capture = new Capture(_camera);

            //if (!_streaming)
            //{
            //    Application.Idle += streaming_device;
            //    btnCapture.Text = "Stop Webcam Streaming...";

            //}
            //else
            //{
            //    Application.Idle -= streaming_device;
            //    btnCapture.Text = "Start Webcam Streaming...";

            //    if (pic_Webcam.Image!=null) {
            //        //byte[] bb = Utils.convertImagetoBinary(pic_Webcam.Image);
            //        //ic.returnPicture(bb);
            //        ic.returnPicture(pic_Webcam.Image);
            //    }
            //}

            //_streaming = !_streaming;


            // _camera = Properties.Settings.Default.useExternalCamera;
            // //_streaming = false;
            // _capture = new Capture(_camera);

            //// if (!_streaming)
            // {
            //     Application.Idle += streaming_device;
            //     //btnCapture.Text = "Stop Webcam Streaming...";

            // }


            //_streaming = !_streaming;
            string base64str = Utils.GetImageFromCamera(pic_Webcam);
        }


        private static object _lock = new object();
        private void streaming_device(object sender, EventArgs e)
        {
            //throw new NotImplementedException(();
            ///_capture = new Capture();

            //try
            {
                //var task = Task.Factory.StartNew(() => capture_image()); ;

                //lock (_lock)
                //{
                //    Task.Run(() => capture_image()); ;
                //}

               // capture_image();
            }
            //catch { }
        }

        private void capture_image()
        {
            try
            {
                //if (camToggle1.Checked)
                //{
                //    _capture = new Capture(1);
                //}
                //else
                //{
                //    _capture = new Capture(0);
                //}

               
                   // //your code

                   // var img = _capture.QueryFrame().ToImage<Bgr, byte>();
                   // var bmp = img.Bitmap;
                   // pic_Webcam.Image = bmp;
                   //// ic.returnPicture(bmp);
                   // //ic.mypic = bmp;
                //}

                //using (tranxDataContext tx = new tranxDataContext())
                //{
                //    var ds = tx.userTable_1s.Where(w => w.username == _username)
                //         .Select(s => s);

                //if (ds.Any())
                //    {
                //        byte[] bb = Utils.convertImagetoBinary(pic_Webcam.Image);
                //        ds.First().live_image = Utils.convert_byteArray2string(bb);
                //        tx.SubmitChanges();
                //    }
                //    else
                //    {
                //        pic_Webcam.Image = null;
                //    }
                //}



            }
            catch { }
        }

        private void captureForm1_Load(object sender, EventArgs e)
        {
            pic_Webcam.Image = null;


           // _camera = Properties.Settings.Default.useExternalCamera;
           // _streaming = false;
           // _capture = new Capture(_camera);
           //// _capture.
        }

        private void captureForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ic.returnPicture(pic_Webcam.Image);
            //_streaming = false;
            //_capture = null;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            //else
            {
                //Application.Idle -= streaming_device;
                //btnCapture.Text = "Start Webcam Streaming...";

                if (pic_Webcam.Image != null)
                {
                    //byte[] bb = Utils.convertImagetoBinary(pic_Webcam.Image);
                    //ic.returnPicture(bb);
                    ic.returnPicture(pic_Webcam.Image);
                }
            }
        }
    }
}
