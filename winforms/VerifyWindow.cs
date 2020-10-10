using Alertform;
using DermalogMultiScannerDemo.winforms;
//using Emgu.CV;
//using Emgu.CV.Structure;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermalogMultiScannerDemo
{
    public partial class VerifyWindow : MetroFramework.Forms.MetroForm // Form
    {

        public string loggedin_staff = "";
        #region Fields
        private FPScanner _fpScanner;
        private LocalAFIS _afis;
        public int _camera = 0;
        private LocalUser _enrolledUser;
        public LocalUser EnrolledUser
        {
            get { return _enrolledUser; }
            set { _enrolledUser = value; }
        }

        public String _username;
        private List<Fingerprint> _userFingerprints;

        private bool _displayOnImage = true;
        #endregion
        bool _streaming;
        //Capture _capture;
        public  bool nDialogResult = false;
        public VerifyWindow(FPScanner fpScanner, LocalAFIS afis)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            //xamlButtonEnroll.Enabled = false;

            pic_Webcam.Image = null;

            _fpScanner = fpScanner;
            _afis = afis;
        }

        sideForm1 fm2;
        public VerifyWindow(FPScanner fpScanner, LocalAFIS afis, string loggedinuser, string enteredUsername, sideForm1 fm)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //loggedin_staff = loggedinuser;
            //xamlButtonEnroll.Enabled = false;
            _username = enteredUsername;
            lb_loginuser.Text = "Hello, " + loggedinuser;
            //lb_loginuser.Text = "Logged in As " + loggedinuser;
            loggedin_staff = loggedinuser;
            pic_Webcam.Image = null;

            lb_clientName.Text = enteredUsername;
            genBarcode(enteredUsername);

            _fpScanner = fpScanner;
            _afis = afis;

            fm2 = fm;
        }


        public VerifyWindow(FPScanner fpScanner,  sideForm1 fm)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //loggedin_staff = loggedinuser;
            //xamlButtonEnroll.Enabled = false;
            //_username = enteredUsername;
            //lb_loginuser.Text = "Hello, " + loggedinuser;
            //lb_loginuser.Text = "Logged in As " + loggedinuser;
            //loggedin_staff = loggedinuser;
            pic_Webcam.Image = null;

            //lb_clientName.Text = enteredUsername;
           // genBarcode(enteredUsername);

            _fpScanner = fpScanner;
            //_afis = afis;

            fm2 = fm;
        }

        public void reloadForm(string enteredUsername)
        {
            _clearScreen();
            _username = enteredUsername;
            lb_clientName.Text = enteredUsername;
            genBarcode(enteredUsername);
        }


        public void returnPicture(byte[] pic)
        {
            pic_Webcam.Image = Utils.convertBinarytoImage(pic);
        }

        public void returnPicture(Image pic)
        {
            pic_Webcam.Image = pic;
            pic_Webcam.Refresh();
        }

        public VerifyWindow(LocalAFIS afis)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            //xamlButtonEnroll.Enabled = false;

            // _fpScanner = fpScanner;
            _afis = afis;
        }

        public VerifyWindow()
        {
            InitializeComponent();

            // xamlButtonEnroll.Enabled = false;

            //_fpScanner = fpScanner;
            //_afis = afis;
        }


        public void OpenEnterUsernameWindow()
        {
            //displayMessage("Enter Name.");

           //// Task.Run(() =>
           // {
           //     //EnterUsernameWindow_new
           //     EnterUsernameWindow_new enterUsernameWindow = new EnterUsernameWindow_new(this);
           //     //enterUsernameWindow.Owner = this;
           //     enterUsernameWindow.ShowDialog();

           //     if (!enterUsernameWindow.nDialogResult) this.Close();
           // }
            
            //).Wait();
            ////if (enterUsernameWindow.DialogResult.HasValue && enterUsernameWindow.DialogResult.Value)
            //{
            //    _username = enterUsernameWindow.Username;
            //    xamlLabelUsername.Text = _username;

            //    //displayMessage("Please place finger(s) onto scanner.");
            //    //Thread.Sleep(1000);
            //    //StartCapturing();
            //}
            //else
            //{
            //    //try
            //    {
            //        //this.Close();
            //    }
            //    //catch { }
            //}
        }

        public void enterUsernameWindow_return(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                _username = str;
                xamlLabelUsername.Text = _username;
                displayMessage("Client Name. " + _username);

                //lst_msg.Items.Insert(0, "-------------------------------------------");
                //lst_msg.Items.Insert(0, "Client Name. "+ _username);
                //lst_msg.Items.Insert(0, "-------------------------------------------");



                //_streaming = false;
                //_capture = new Capture();
            }
            else
            {
                Close();
            }
        }

        #region IFPScanner Events
        private void BindFPScannerEvents()
        {
            UnbindFPScannerEvents();

            _fpScanner.OnScannerImage += _fpScanner_OnScannerImage;
            _fpScanner.OnScannerDetect += _fpScanner_OnScannerDetect;
            _fpScanner.OnScannerError += _fpScanner_OnScannerError;
            //_fpScanner.OnFingerprintsDetected += _fpScanner_OnFingerprintsDetected;
            _fpScanner.OnFingerprintsDetected += _fpScanner_OnFingerprintsDetected_v;
        }

        private void UnbindFPScannerEvents()
        {

            _fpScanner.OnScannerImage -= _fpScanner_OnScannerImage;
            _fpScanner.OnScannerDetect -= _fpScanner_OnScannerDetect;
            _fpScanner.OnScannerError -= _fpScanner_OnScannerError;
            //_fpScanner.OnFingerprintsDetected -= _fpScanner_OnFingerprintsDetected;
            _fpScanner.OnFingerprintsDetected -= _fpScanner_OnFingerprintsDetected_v;

        }

        void _fpScanner_OnScannerError(object sender, FPScanner.ScannerErrorEventArgs e)
        {
            string msg = "Function call failed, because assigned device was disconnected.";
            if (e.Error == msg)
            {
                //MessageBox.Show(e.Error+Environment.NewLine+"You need to retsart the application, make sure the device is connected"
                //    , "Fatal Errror",MessageBoxButtons.OK,MessageBoxIcon.Error);

                AlertForm1 al = new AlertForm1(e.Error + Environment.NewLine +
                    "You need to retsart the application, make sure the device is connected", 
                    AlertForm1.AlertOptions.OK,
                    AlertForm1.AlertType.success, "Fatal Errror");
                al.ShowDialog();

                _fpScanner.StopCapturing();
                Application.Exit();
            }
            else
            {
                displayMessage(e.Error);
                _fpScanner.StopCapturing();
            }
        }

        void _fpScanner_OnScannerImage(System.Drawing.Image image)
        {
            if (!_displayOnImage)
                return;

            Bitmap bmp = new Bitmap(image);
            imageOnScannerDetect.Image = Utils.BitmapFromSource(Utils.BitmapToBitmapSource(bmp));
        }

        void _fpScanner_OnScannerDetect(System.Drawing.Image image)
        {
            displayMessage("Extracting Templates");

            var ff = _fpScanner;

            _displayOnImage = false;

            Bitmap bmp = new Bitmap(image);
            imageOnScannerDetect.Image = Utils.BitmapFromSource(Utils.BitmapToBitmapSource(bmp));
        }

        List<Fingerprint> fingerprints_all = new List<Fingerprint>();
        List<Fingerprint> fingerprints_new = new List<Fingerprint>();
        List<Fingerprint> fingerprints_left = new List<Fingerprint>();
        List<Fingerprint> fingerprints_right = new List<Fingerprint>();
        List<Fingerprint> fingerprints_mid = new List<Fingerprint>();
        void _fpScanner_OnFingerprintsDetected_v(List<Fingerprint> fingerprints)
        {
            _fpScanner.StopCapturing();

            _userFingerprints = fingerprints;
            //fingerprints_new = fingerprints;

            fingerprints_all.AddRange(fingerprints);

            //stackPanelFingerprints.Controls.Clear();
            //int imageWidth = (int)stackPanelFingerprints.Width / fingerprints.Count;
            //foreach (Fingerprint fingerprint in fingerprints)
            //{
            //    System.Windows.Controls.Image img = new System.Windows.Controls.Image();
            //    //Bitmap bmp = new Bitmap(fingerprint.Image);
            //    //img.Source = Utils.BitmapToBitmapSource(bmp);
            //    //img.Width = imageWidth;
            //    //img.Height = stackPanelFingerprints.Height;
            //    PictureBox p1 = new PictureBox();
            //    p1.Width = imageWidth;
            //    p1.Height = stackPanelFingerprints.Height;
            //    p1.Image = fingerprint.Image; // Utils.BitmapFromSource( img);
            //    stackPanelFingerprints.Controls.Add(p1);
            //}

            switch (selected_fingers)
            {
                case "left":

                    {
                        IAsyncResult result = fm2._VerifyWindow.BeginInvoke((MethodInvoker)delegate ()
                        //IAsyncResult result = this.BeginInvoke((MethodInvoker)delegate ()
                        //this.BeginInvoke((MethodInvoker)delegate ()
                        //this.Invoke((MethodInvoker)delegate ()
                        //fm2._VerifyWindow.BeginInvoke((MethodInvoker)delegate ()
                        //NewMethod(fp_left, fingerprints);
                        //Task.Run(()=>
                        {
                            fingerprints_left = fingerprints;
                            NewMethod(fp_left, fingerprints);
                            //Identify_AfterCapture(fingerprints_left);

                            BGWorker_LeftSearch.RunWorkerAsync(fingerprints);

                            //Label l = new Label(); l.Location = new Point(12, 10);
                            //l.Text = "Some Text";
                            //this.Controls.Add(l);
                        }
                        );
                        var anything = this.EndInvoke(result);
                        break;
                    }

                case "right":

                    {
                        this.BeginInvoke((MethodInvoker)delegate ()
                        {
                            fingerprints_right = fingerprints;
                            NewMethod(fp_right, fingerprints);

                            BGWorker_rightSearch.RunWorkerAsync(fingerprints);


                            //Label l = new Label(); l.Location = new Point(12, 10);
                            //l.Text = "Some Text";
                            //this.Controls.Add(l);
                        }
                        );
                        break;
                    }

                case "middle":

                    {
                        this.BeginInvoke((MethodInvoker)delegate ()
                        {
                            fingerprints_mid = fingerprints;
                            NewMethod(fp_thumb, fingerprints);

                            BGWorker_thumbSearch.RunWorkerAsync(fingerprints);


                            //Label l = new Label(); l.Location = new Point(12, 10);
                            //l.Text = "Some Text";
                            //this.Controls.Add(l);
                        }
                        );
                        break;
                    }
            }


            //xamlButtonEnroll.Enabled = true;
            //displayMessage("Press Identify to Start Enrollment");
        }
        #endregion

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _streaming = false;
            //_capture = null;
            StopCapturing();
            //this.Dispose(true);
        }

        public void StartCapturing()
        {
            BindFPScannerEvents();
            _fpScanner.StartCapturing();
        }

        public void StopCapturing()
        {
            UnbindFPScannerEvents();
            _fpScanner.StopCapturing();
        }

        private void displayMessage(String message)
        {
            //Application.Current.Dispatcher.BeginInvoke((Action)(() =>
            {
                //Function call failed, because assigned device was disconnected.

                xamlLabelMessage.Text = message;  // ..ToUpper();
                lst_msg.Items.Insert(0, message);   //.ToUpper());
            }
            //));
        }

        private void xamlButtonEnroll_Click(object sender, EventArgs e)
        {


            //DialogResult msg = MessageBox.Show("Are you sure you want to save this Enrollment ?", "Confirm Enrollment"
            //    , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            AlertForm1 al = new AlertForm1("Do you want to continue with Enrollment ?",
                AlertForm1.AlertOptions.OKCANCEL,
                    AlertForm1.AlertType.success, "Confirm Enrollment");
            var aa=al.ShowDialog();

            if(al.rDialogResult)
            //if (msg == DialogResult.OK)
            {
                xamlButtonEnroll.Enabled = false;
                //fingerprints_all = new List<Fingerprint>();
                //fingerprints_all.AddRange(fingerprints_left);
                //fingerprints_all.AddRange(fingerprints_right);
                //fingerprints_all.AddRange(fingerprints_mid);

                fingerprints_all = Utils.combine_fingers(
                fingerprints_left, fingerprints_right, fingerprints_mid);

                dynamic dd = new ExpandoObject();
                dd.remark = txt_remark.Text;
                dd.loggedin_staff = loggedin_staff;
                dd.username = _username;


                //object ob = dd;

                if (!Utils.check_usernames_exist(_username))
                {
                    Task.Run(() =>
                    {
                        _enrolledUser = _afis.RegisterUser(_username, fingerprints_all,dd, pic_Webcam.Image);

                        //pic_Webcam.Image.Save(@"c:\zf10\qwerty.jpg");
                        //call External API for postback
                        
                        call_ExternalAPI(dd);


                    //dispose allocated fingerprint templates
                        NewMethod_disposeFingerprint(fingerprints_all);
                        NewMethod_disposeFingerprint(fingerprints_left);
                        NewMethod_disposeFingerprint(fingerprints_right);
                        NewMethod_disposeFingerprint(fingerprints_mid);
                    //fingerprints_left.AsEnumerable<Fingerprint>().d;
                    //{

                    //});

                    //,fingerprints_right,fingerprints_mid
                    // _fpScanner.Freeze(false);

                        //fp_left.Controls.Clear();
                        //fp_right.Controls.Clear();
                        //fp_thumb.Controls.Clear();

                        CircleProgressbar1.Value = 0;
                        
                        //btn_capturefoto.Enabled=
                        btn_thump.Enabled = btn_right.Enabled = btn_left.Enabled =
                        chk_left.Checked = chk_right.Checked = chk_thumb.Checked = false;
                        //pic_Webcam.Image = null;
                        


                    }).Wait();

                    displayMessage("Enrollment Successful........");



                }
                else
                {
                    AlertForm1 a2 = new AlertForm1("User already exist.....", AlertForm1.AlertOptions.OK);
                     a2.ShowDialog();

                   // MessageBox.Show("User already exist.....");
                }
                // _enrolledUser = _afis.RegisterUser(_username, fingerprints_all);
                //_enrolledUser = _afis.RegisterUser(_username, _userFingerprints);
                nDialogResult = true;
                //Close();
            }
        }



        private void  call_ExternalAPI(dynamic dd)
        {
  
            //dynamic dd = new ExpandoObject(); 
            
            //dd.remark = txt_remark.Text;
            //dd.loggedin_staff = loggedin_staff;
            //dd.username = _username;
            
            dd.status = "Captured";
            Dictionary<string, string> getID = Utils.get_RefCode((string)dd.username);
            dd.rref = getID.First().Key;
            //dd.username = "jimba";
            dd.others = "Anything";
            pic_Webcam.Refresh();
            dd.capture_picture = Utils.ImageToBase64(pic_Webcam, true);
            dd.date = DateTime.Now.ToString("MMMM dd, yyyy"); ;
            
            string clientName = (string)dd.username;
            //dd.picture = Utils.ImageToBase64(pic_Webcam.Image);
            //dd.captureDate = DateTime.Now.ToString("MMMM dd, yyyy"); ;
            object ob = dd;
            string ss = Newtonsoft.Json.JsonConvert.SerializeObject(ob);
            //string APIHandle = @"infometriq-partner-api/capture/feedback";
            string APIHandle = @"submit_Online_Request";
            
            string resp = "";
            Task.Run(() =>
            {
              
                //resp = Utils.call_External_WEBAPI_Service(APIHandle, ss);
                resp = Utils.call_WEBAPI_Service(APIHandle, ss);

            }).Wait();
            //else
            {
                string msg = "Feedback submitted to online portal....";
                AlertForm1 a2 = new AlertForm1(msg, AlertForm1.AlertOptions.OK);
                a2.ShowDialog();

            }
        }



        private void NewMethod_disposeFingerprint(List<Fingerprint> fingerprints_all)
        {
            try
            {
                if (fingerprints_all.Count > 0)
                {
                    //foreach (Fingerprint fingerprint in fingerprints_all)
                    //{
                    //    fingerprint.Dispose();
                    //}
                    fingerprints_all.Clear();
                }
            }
            catch { }
        }

        private void showAnimation(Control cs)
        {
            bunifuTransition1.HideSync(cs, true);
            //bunifuTransition1.HideSync(cs, false, BunifuAnimatorNS.Animation.HorizBlind);
            //Thread.Sleep(2000);
            bunifuTransition1.ShowSync(cs, true);

        }



        private void Window_Loaded(object sender, EventArgs e)
        {
        //    Task.Run(() =>
        //    {
        //        // BGWorker1.RunWorkerAsync();
        //        // StartCapturing();
        //        try
        //        {
        //            BindFPScannerEvents();
                   

        //        }
        //        catch { }

               
        //        //_fpScanner = 
        //    }
        //    ).Wait(); 

                pic_Webcam.Image = null;
                lbVersion.Text = Properties.Settings.Default.VersionPlatform;

                //_camera = Properties.Settings.Default.useExternalCamera;
                //_streaming = false;
                ////_camera = null;
                //try
                
                //{

                //    _capture.Dispose();
                //    _capture = new Capture(_camera);
                //}
                //catch { }

               

               // OpenEnterUsernameWindow();
        
            
           // 

            //lb_loginuser.Text = "Logged in As "+loggedin_staff;

        }

        private void NewMethod( FlowLayoutPanel fPanel2, List<Fingerprint> finger_new)
        {
            fPanel2.Controls.Clear();
            //fingerprints_new = fingerprints;
            // xamlStackPanelFingerprints.Controls.Clear();
            // int imageWidth = (int)xamlStackPanelFingerprints.Width / fingerprints.Count;
            FlowLayoutPanel fl = new FlowLayoutPanel();
            // file2ToolStripMenuItem.Width = xamlStackPanelFingerprints.Width;
            // file2ToolStripMenuItem.Height = xamlStackPanelFingerprints.Height;

            foreach (Fingerprint fingerprint in finger_new)
            {
                // System.Windows.Controls.Image img = new System.Windows.Controls.Image();

                //Bitmap bmp = new Bitmap(fingerprint.Image);
                //img.Source = Utils.BitmapToBitmapSource(bmp);
                //PictureBox pi = new PictureBox();
                //pi.Image = (Image)Utils.BitmapFromSource(Utils.BitmapToBitmapSource(bmp));
                //System.Drawing.Image pi = (System.Drawing.Image)Utils.BitmapToBitmapSource2(bmp);
                string str = string.Format("NFIQ: {0}", fingerprint.NFIQ);
                // fPanel1.Controls.Add(addFinger(pi, str ));

                PictureBox p = new PictureBox();
                p.Image = fingerprint.Image;
                p.Refresh();
                //p.Image = global::DermalogMultiScannerDemo.Properties.Resources.fingers1;
                //p.Location = new System.Drawing.Point(615, 22);
                //p.Name = "pictureBox1";
                p.Dock = DockStyle.Fill;
                //p.Size = new System.Drawing.Size(100, 71);
                p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;


                Label lb = new Label();
                lb.Text = str;

                TableLayoutPanel tb = new TableLayoutPanel();
                tb.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;

                tb.ColumnCount = 1;
                tb.RowCount = 2;
                tb.Size = new System.Drawing.Size(95, 126);
                //tb.

                tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
                tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));



                //Button b = new Button();
                tb.Controls.Add(p, 0, 0);
                tb.Controls.Add(lb, 0, 1);
                fPanel2.Controls.Add(tb);


            }
        }
        private void NewMethod_new(FlowLayoutPanel fPanel2, List<Fingerprint> finger_new)
        {
            fPanel2.Controls.Clear();
            //fingerprints_new = fingerprints;
            // xamlStackPanelFingerprints.Controls.Clear();
            // int imageWidth = (int)xamlStackPanelFingerprints.Width / fingerprints.Count;
            FlowLayoutPanel fl = new FlowLayoutPanel();
            // file2ToolStripMenuItem.Width = xamlStackPanelFingerprints.Width;
            // file2ToolStripMenuItem.Height = xamlStackPanelFingerprints.Height;

            foreach (Fingerprint fingerprint in finger_new)
            {
                // System.Windows.Controls.Image img = new System.Windows.Controls.Image();

                Bitmap bmp = new Bitmap(fingerprint.Image);
                //img.Source = Utils.BitmapToBitmapSource(bmp);
                //PictureBox pi = new PictureBox();
                //pi.Image = (Image)Utils.BitmapFromSource(Utils.BitmapToBitmapSource(bmp));
                System.Drawing.Image pi = (System.Drawing.Image)Utils.BitmapToBitmapSource2(bmp);
                string str = string.Format("NFIQ: {0}", fingerprint.NFIQ);
                // fPanel1.Controls.Add(addFinger(pi, str ));

                PictureBox p = new PictureBox();
                p.Image = pi;
                //p.Image = global::DermalogMultiScannerDemo.Properties.Resources.fingers1;
                //p.Location = new System.Drawing.Point(615, 22);
                //p.Name = "pictureBox1";
                p.Dock = DockStyle.Fill;
                //p.Size = new System.Drawing.Size(100, 71);
                p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;


                Label lb = new Label();
                lb.Text = str;

                TableLayoutPanel tb = new TableLayoutPanel();
                tb.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;

                tb.ColumnCount = 1;
                tb.RowCount = 2;
                tb.Size = new System.Drawing.Size(95, 126);
                //tb.

                tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
                tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));



                //Button b = new Button();
                tb.Controls.Add(p, 0, 0);
                tb.Controls.Add(lb, 0, 1);

                // bunifuTileButton1
                // 
                Bunifu.Framework.UI.BunifuTileButton bButton1 = new Bunifu.Framework.UI.BunifuTileButton();
                bButton1.BackColor = System.Drawing.Color.Crimson;
                bButton1.color = System.Drawing.Color.Crimson;
                bButton1.colorActive = System.Drawing.Color.Crimson;
                bButton1.Cursor = System.Windows.Forms.Cursors.Hand;
                bButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
                bButton1.ForeColor = System.Drawing.Color.White;
                bButton1.Image = pi;
                bButton1.ImagePosition = 5;
                bButton1.ImageZoom = 95;
                bButton1.LabelPosition = 25;
                bButton1.LabelText = str;
                bButton1.Location = new System.Drawing.Point(947, 74);
                bButton1.Margin = new System.Windows.Forms.Padding(6);
                //this.bunifuTileButton1.Name = "bunifuTileButton1";
                bButton1.Size = new System.Drawing.Size(96, 126);
                bButton1.TabIndex = 27;



                fPanel2.Controls.Add(bButton1);


            }
        }

        string selected_fingers;

        private void chk_thumb_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_thumb.Checked)
            {
                selected_fingers = "middle";
                imageOnScannerDetect.Image = null;
                xamlImageOnScannerImage.Image = Properties.Resources.fingers3;
                displayMessage("Please place THUMB finger(s) onto scanner.");
                Thread.Sleep(1000);
                StartCapturing();
            }
            else
            {
                StopCapturing();
            }
        }

        private void chk_right_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_right.Checked)
            {
                selected_fingers = "right";
                imageOnScannerDetect.Image = null;
                xamlImageOnScannerImage.Image = Properties.Resources.fingers2;
                displayMessage("Please place RIGHT finger(s) onto scanner.");
                Thread.Sleep(1000);
                StartCapturing();
            }
            else
            {
                StopCapturing();
            }
        }

        private  void chk_left_CheckedChanged(object sender, EventArgs e)
        {
            bool noProblem = true;
            try
            {
                if (chk_left.Checked)
                {
                    selected_fingers = "left";
                    imageOnScannerDetect.Image = null;
                    xamlImageOnScannerImage.Image = Properties.Resources.fingers1;
                    displayMessage("Please place LEFT finger(s) onto scanner.");
                    Thread.Sleep(100);

                    
                    Task.Run(() =>
                    {
                        StartCapturing();
                        //BGWorker_LeftSearch.RunWorkerAsync();
                        //Identify_AfterCapture(fingerprints_left);
                        //return 10;
                    }
                    ).Wait();
                    //.ContinueWith(tt=>
                    //{
                    //    //Identify_AfterCapture(fingerprints_left);
                    //   // BGWorker_LeftSearch.RunWorkerAsync();
                    //});
                    
                   
                }
                else
                {
                    lb_clientName.Text = lb_match.Text ="";
                    CircleProgressbar1.Value = 0;
                   // StopCapturing();
                }



            }
            catch {
                noProblem = false;
            
            }
            //finally
            //{
            //    if (noProblem)
            //        BGWorker_LeftSearch.RunWorkerAsync();
            //}

        }

        public  byte[] mypic = null;
        private void btnCapture_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    captureForm1 cp = new captureForm1();
            //    DialogResult dd = new DialogResult();
            //     cp.Show(this);
            //    //returnPicture(mypic);
            //}
            //catch (Exception ex){
            //    string ss = ex.Message;
            //}

            //if (!_streaming)
            //{
            //    Application.Idle += streaming_device;
            //    btnCapture.Text = "Stop Webcam Streaming...";

            //}
            //else
            //{
            //    Application.Idle -= streaming_device;
            //    btnCapture.Text = "Start Webcam Streaming...";
            //}

            //_streaming = !_streaming;
        }

        private  void streaming_device(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ///_capture = new Capture();
            //Task.Run(() =>
            //try
            {
                //capture_image();
                //Task.Run(() => capture_image()); ;
                // var task = Task.Factory.StartNew(() => capture_image()); ;
            }
            //).Wait();
            //catch { }
        }

        private void capture_image()
        {
            //try
            //{
               
            //    var img = _capture.QueryFrame().ToImage<Bgr, byte>();
            //    var bmp = img.Bitmap;
            //    pic_Webcam.Image = bmp;
            //    pic_Webcam.Refresh();


            //}
            //catch { }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            pix_login.Visible = true;
            string enteredUsername = _username;

            dynamic found = Utils.check_InternetID_exist(enteredUsername);

            //found.status = true;
            //found.idstring = ds2.idString;
            //found.username = ds2.username;
            //found.remark = "Enrolled Already";
            if (enteredUsername.Length == 0)
            {
                AlertForm1 al = new AlertForm1(found.remark, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error);
                al.ShowDialog();
                //MessageBox.Show("Username must not be empty.");
            }
            else
            {
                if ((bool)found.status)
                {
                    if ((bool)found.enrolled)
                    {
                        AlertForm1 al = new AlertForm1(found.remark, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.info);
                        al.ShowDialog();
                        Utils.show_ClientExist(enteredUsername);
                    }
                    else
                    {
                        string values = found.username;
                        string keyvalues = found.idstring;

                        AlertForm1 al = new AlertForm1(found.remark + Environment.NewLine + "Username => " + values +
                            Environment.NewLine + "Internat ID Number => " + keyvalues, AlertForm1.AlertOptions.OK,
                            AlertForm1.AlertType.info);
                        al.ShowDialog();

                        Utils.show_ClientExist(enteredUsername);
                        //Utils.show_ClientExist_Online(enteredUsername);
                    }

                }
                else
                {

                    AlertForm1 al = new AlertForm1(found.remark, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.info);
                    al.ShowDialog();

                    Utils.show_ClientExist_Online(enteredUsername);
                }

                // string strResponse = "";
                // Task.Run(() =>
                // {

                //     {
                //         // displayMessage("Verifying Template File.....", Utils.COLOR_DERMALOG_RED);
                //         //string externalAPI = Properties.Settings.Default.ExternalAPIAddress;
                //         string servNAME = string.Format("infometriq-partner-api/individuals/{0}/username",_username);
                //         strResponse = Utils.call_External_WEBAPI_GETService(servNAME);
                //         //strResponse = Utils.call_WEBAPI_GETService("infometriq-partner-api/individuals");
                //     }
                // }
                //).Wait();
            }

            pix_login.Visible = false;

            //winforms.Form_data fm = new winforms.Form_data(strResponse);
            //fm.ShowDialog();
        }

        private void btn_left_Click(object sender, EventArgs e)
        {

            //StopCapturing();

            //btn_right.Enabled =  true;
            chk_left.Checked = !chk_left.Checked;
            if (!chk_left.Checked)
            {
                fp_left.Controls.Clear();
                fp_thumb.Controls.Clear();
                fp_right.Controls.Clear();

                NewMethod_disposeFingerprint(fingerprints_left);
                NewMethod_disposeFingerprint(fingerprints_right);
                NewMethod_disposeFingerprint(fingerprints_mid);

                btn_right.Enabled = btn_thump.Enabled = false;
                pic_Webcam.Image = null;
            }
            
            //fp_right.Controls.Clear();
            //fp_thumb.Controls.Clear();
            showAnimation(bunifuCards3);
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            btn_thump.Enabled = true;
            //showAnimation(bunifuCards3);
            chk_right.Checked = !chk_right.Checked;
            if (!chk_right.Checked)
            {
                fp_right.Controls.Clear();
                fp_thumb.Controls.Clear();

                btn_thump.Enabled = false;

                //NewMethod_disposeFingerprint(fingerprints_left);
                NewMethod_disposeFingerprint(fingerprints_right);
                NewMethod_disposeFingerprint(fingerprints_mid);
            }

            //
            //fp_thumb.Controls.Clear();
        }

        private void btn_thump_Click(object sender, EventArgs e)
        {
            //showAnimation(bunifuCards3);
            chk_thumb.Checked = !chk_thumb.Checked;
            if (!chk_thumb.Checked)
            {
                fp_thumb.Controls.Clear();
                //NewMethod_disposeFingerprint(fingerprints_left);
                //NewMethod_disposeFingerprint(fingerprints_right);
                NewMethod_disposeFingerprint(fingerprints_mid);
            }

            //
            //
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //this.Close();

            fp_left.Controls.Clear();
            fp_thumb.Controls.Clear();
            fp_right.Controls.Clear();


            //release binded events for fpscanner re-entry
            UnbindFPScannerEvents();

            NewMethod_disposeFingerprint(fingerprints_left);
            NewMethod_disposeFingerprint(fingerprints_right);
            NewMethod_disposeFingerprint(fingerprints_mid);

            btn_right.Enabled = btn_thump.Enabled = false;
            pic_Webcam.Image = null;
            lb_match.Text = "Best User verified 0%)";
            lst_msg.Items.Clear();
            CircleProgressbar1.Value = 0;

            fm2.VerifyForm_hidden = true;

            Hide();

        }

        public  void genBarcode(string enteredUsername)
        {
            Utils.gen_barcode(pixBarcode, enteredUsername);
        }

        private void BGWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }

       
        private  bool Identify_AfterCapture_old(List<Fingerprint> capturedfingerprints)
        {

            if(capturedfingerprints.Count==0)
            {
                AlertForm1 al = new AlertForm1("FingerPrint Error:No fingerprints Captures", AlertForm1.AlertOptions.OK,
                   AlertForm1.AlertType.error);
                 al.ShowDialog();

                //MetroMessageBox.Show(this,"No fingerprints Captures","FingerPrint Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }

            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 2
            };

            string username_identified = "";
            //fingerprints_all = new List<Fingerprint>();
            //if(fingerprints_left.Count()>0) fingerprints_all.AddRange(fingerprints_left);
            //if (fingerprints_right.Count() > 0) fingerprints_all.AddRange(fingerprints_right);
            //if (fingerprints_mid.Count() > 0) fingerprints_all.AddRange(fingerprints_mid);

            List<Fingerprint> fingerprints_all = capturedfingerprints;


            AFISVerificationResult result = new AFISVerificationResult();
            LocalUser user_found = new LocalUser();
            //_afis = new LocalAFIS();
            //Dictionary<long, LocalUser> userList = _afis.GetUserList();
            Dictionary<long, LocalUser> userList = _afis.GetUserList_New();

            //xamlListBoxUsers.Items.Clear();
            bool found = false; ;
            double matchValue = 0;
            string Hand="";
            string HandPosition="";
            Parallel.ForEach(userList, (user, loopState) =>
            //Parallel.ForEach(userList, options, (user, loopState) =>
            {
                //xamlListBoxUsers.Items.Add(user);

                result = _afis.IdentifyUser_New(user.Key, fingerprints_all, Properties.Settings.Default.VerificationThreshold);
                //result = _afis.IdentifyUser(user.Key, fingerprints_all, Properties.Settings.Default.VerificationThreshold);
                if (result.Hit)
                {
                    user_found = (LocalUser)user.Value;
                    found = true;
                    Hand = result.Hand;
                    HandPosition = result.HandPosition;
                    matchValue = result.Score;
                    loopState.Stop();
                }
            });


            //xamlButtonEnroll.Enabled = !found;
            if (found)
            {

               // string str = string.Format("user={0} , match value={1} ", user_found.Name, matchValue.ToString("N2"));
                username_identified = user_found.Name;

                string str = String.Format("User verified ({0}%), Name={1}, Hand : {2}, Hand Position : {3}",
                                 matchValue.ToString("N2"), username_identified, Hand,
                                 HandPosition);

                displayMessage(str);

                //MessageBox.Show(str, "User Already Enrolled......", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //DialogResult dg =  
                //   MetroMessageBox.Show(this,str, "User Already Enrolled......", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                AlertForm1 al = new AlertForm1(str, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error, "User Already Enrolled......");
                al.ShowDialog();


                lb_match.Text = string.Format("Best User verified {0} %", matchValue.ToString("N0"));
                showAnimation(CircleProgressbar1);
                CircleProgressbar1.Value = Convert.ToInt16(matchValue.ToString("N0"));

                Task.Run(() =>
                 //var tt = new Task(() =>
                 {
                     using (tranxDataContext tx = new tranxDataContext())
                     {
                         tx.Connection.ConnectionString = Utils.getConnection();
                         var ds = tx.userTable_1s.Where(w => w.username == user_found.Name)
                              .Select(s => s);

                         if (ds.Any())
                         {

                             byte[] bb = Utils.convert_string2byteArray(ds.First().live_image);
                             pic_Webcam.Image = null;
                             pic_Webcam.Image = Utils.convertBinarytoImage(bb);
                             showAnimation(pic_Webcam);
                            //tx.SubmitChanges();
                        }
                         else
                         {
                             pic_Webcam.Image = null;
                         }
                     }
                     //return 1;
                 }).Wait();

                //tt.Start();

            }
            else
            {
                //MessageBox.Show("record not found.........");
                pic_Webcam.Image = null;
            }

            //_enrolledUser = _afis.IdentifyUser(_username, fingerprints_all,Properties.Settings.Default.VerificationThreshold);
            // _enrolledUser = _afis.RegisterUser(_username, fingerprints_all);
            //_enrolledUser = _afis.RegisterUser(_username, _userFingerprints);
            //DialogResult = true;
            //Close();

            return found;
        }

        private bool Identify_AfterCapture(List<Fingerprint> capturedfingerprints)
        {

            if (capturedfingerprints.Count == 0)
            {
                AlertForm1 al = new AlertForm1("FingerPrint Error:No fingerprints Captures", AlertForm1.AlertOptions.OK,
                   AlertForm1.AlertType.error);
                al.ShowDialog();

                //MetroMessageBox.Show(this,"No fingerprints Captures","FingerPrint Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }

            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 2
            };

            string username_identified = "";
            //fingerprints_all = new List<Fingerprint>();
            //if(fingerprints_left.Count()>0) fingerprints_all.AddRange(fingerprints_left);
            //if (fingerprints_right.Count() > 0) fingerprints_all.AddRange(fingerprints_right);
            //if (fingerprints_mid.Count() > 0) fingerprints_all.AddRange(fingerprints_mid);

            dynamic dd = new ExpandoObject();
            dd.selectedFormat = Properties.Settings.Default.TemplateFORMAT;
            dd.refNO = txt_selectedUser.Text;// refNO;
            //dd.selectedFormat = Properties.Settings.Default.TemplateFORMAT;
            List<Fingerprint> fingerprints_all = capturedfingerprints;
            List<string> fingerData = new List<string>();
            foreach (Fingerprint tempFile in fingerprints_all)
            {

                //string fpath = tempFile;
                //string fpath = openTemplateFile.FileName;
                //FileInfo fs = new FileInfo(fpath);
                byte[] array = tempFile.Template.Data;
                //dd.finger_data = Utils.convert_byteArray2string(array);
                fingerData.Add(Utils.convert_byteArray2string(array));
            }
            dd.finger_data = fingerData;
            Object ob = dd;
            string strBody = Newtonsoft.Json.JsonConvert.SerializeObject(dd);

            string strResponse = "";
            Task.Run(() =>
            {
                
                {
                    //displayMessage("Identifying Template File.....", Utils.COLOR_DERMALOG_RED);
                    strResponse = Utils.call_WEBAPI_Service("VERIFY_List_templateFormat", strBody);
                }
               
            }
            ).Wait();

            bool clientFound = false;
            dynamic dm = new ExpandoObject();
            dm = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(strResponse);


            String scoreString = "0.00";
            double maxMatch = 0;

            if ((bool)dm.found)
            {
                if ((bool)dm.Hit)

                {
                    scoreString = String.Format("{0:0.00}", (double)dm.result.Score);
                    clientFound = true;
                    //string resp = String.Format("User verified ({0}%), Name={1}, Hand : {2}, Hand Position : {3}",
                    //   scoreString, dm.ClientName, dm.Hand, dm.HandPosition);

                    //AlertForm1 al = new AlertForm1(resp,
                    //   AlertForm1.AlertOptions.OK, AlertForm1.AlertType.success);
                    //al.ShowDialog();
                    foreach (string resp in dm.respResults)
                    {
                        displayMessage(resp);
                        //displayMessage(resp, Utils.COLOR_DERMALOG_GREEN);
                    }

                    //label2.Text = String.Format("User verified ({0}%)", scoreString);
                    //aGauge1.Value = (float)result.Score;
                    if ((double)dm.maxMatch > maxMatch)
                    {
                        maxMatch = (double)dm.maxMatch;
                        pic_Webcam.Image = Utils.Base64TOImage((string)dm.Photo);
                        pic_Webcam.Refresh();


                        String bestscoreString = String.Format("{0:0.00}", maxMatch);
                        lb_match.Text = String.Format("User verified ({0}%)", bestscoreString);
                        //aGauge1.Value = (float)maxMatch;
                        CircleProgressbar1.Value = (int)maxMatch;

                        lb_clientName.Text = "User Detail => " + (string)dm.ClientName;
                        _username = (string)dm.ClientName;
                        genBarcode((string)dm.ClientName);


                        //showAnimation(bunifuCards1);
                        //showAnimation(bunifuCards2);
                        //showAnimation(aGauge1);
                        
                        //showAnimation(CircleProgressbar1);
                        //showAnimation(pixBarcode);

                        //StopCapturing();
                        //scanBegin = false;
                    }


                }
            }
            else
            {

                //AlertForm1 al = new AlertForm1(String.Format("User not verified ({0}%)", scoreString),
                //    AlertForm1.AlertOptions.OK, AlertForm1.AlertType.info);
                //al.ShowDialog();

                displayMessage(String.Format("User not verified ({0}%)", scoreString));
                if (!clientFound)
                {

                    pic_Webcam.Image = null;
                    pic_Webcam.Refresh();
                    lb_clientName.Text = "User not Verified";
                    String bestscoreString = scoreString;
                    lb_match.Text = String.Format("User verified ({0}%)", bestscoreString);
                    //aGauge1.Value = 0;
                    CircleProgressbar1.Value = 0;
                    //showAnimation(CircleProgressbar1);
                }
            }


            //_enrolledUser = _afis.IdentifyUser(_username, fingerprints_all,Properties.Settings.Default.VerificationThreshold);
            // _enrolledUser = _afis.RegisterUser(_username, fingerprints_all);
            //_enrolledUser = _afis.RegisterUser(_username, _userFingerprints);
            //DialogResult = true;
            //Close();

            return clientFound;
        }


        string username_identified = "";
        private void bn_identify_Click(object sender, EventArgs e)
        {
            fingerprints_all = Utils.combine_fingers(fingerprints_left,
                                fingerprints_right, fingerprints_mid);

            Task.Run(() =>
            {
                bool found = Identify_AfterCapture(fingerprints_all);
            }).Wait(1000);


            // var options = new ParallelOptions()
            // {
            //     MaxDegreeOfParallelism = 2
            // };


            // //fingerprints_all = new List<Fingerprint>();
            // //if(fingerprints_left.Count()>0) fingerprints_all.AddRange(fingerprints_left);
            // //if (fingerprints_right.Count() > 0) fingerprints_all.AddRange(fingerprints_right);
            // //if (fingerprints_mid.Count() > 0) fingerprints_all.AddRange(fingerprints_mid);

            // fingerprints_all = Utils.combine_fingers(fingerprints_left,
            //                     fingerprints_right, fingerprints_mid);


            // AFISVerificationResult result = new AFISVerificationResult();
            // LocalUser user_found = new LocalUser();
            // //_afis = new LocalAFIS();
            // Dictionary<long, LocalUser> userList = _afis.GetUserList_New();
            // //Dictionary<long, LocalUser> userList = _afis.GetUserList();

            // //xamlListBoxUsers.Items.Clear();
            // bool found = false; ;
            // double matchValue = 0;
            // Parallel.ForEach(userList, (user, loopState) =>
            // //Parallel.ForEach(userList, options, (user, loopState) =>
            //{
            //    //xamlListBoxUsers.Items.Add(user);

            //    result = _afis.IdentifyUser_New(user.Key, fingerprints_all, Properties.Settings.Default.VerificationThreshold);
            //    //result = _afis.IdentifyUser(user.Key, fingerprints_all, Properties.Settings.Default.VerificationThreshold);
            //    if (result.Hit)
            //     {
            //         user_found = (LocalUser) user.Value;
            //         found = true;
            //         matchValue = result.Score;
            //         loopState.Stop();
            //     }
            // });


            // xamlButtonEnroll.Enabled = !found;
            // if (found)
            // {

            //     string str = string.Format("user={0} , match value={1} ", user_found.Name, matchValue.ToString("N2"));
            //     username_identified = user_found.Name;
            //     MessageBox.Show(str, "User Already Enrolled......", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //     lb_match.Text = string.Format("Best User verified {0} %", matchValue.ToString("N0"));
            //     showAnimation(CircleProgressbar1);
            //     CircleProgressbar1.Value = Convert.ToInt16(matchValue.ToString("N0"));

            //    Task.Run(() =>
            //    //var tt = new Task(() =>
            //    {
            //        using (tranxDataContext tx = new tranxDataContext())
            //         {
            //            tx.Connection.ConnectionString = Utils.getConnection();
            //            var ds = tx.userTable_1s.Where(w => w.username == user_found.Name)
            //                  .Select(s => s);

            //             if (ds.Any())
            //             {


            //                 byte[] bb = Utils.convert_string2byteArray(ds.First().live_image);
            //                pic_Webcam.Image = null;
            //               pic_Webcam.Image = Utils.convertBinarytoImage(bb);
            //                 showAnimation(pic_Webcam);
            //                 //tx.SubmitChanges();
            //             }
            //             else
            //             {
            //                 pic_Webcam.Image = null;
            //             }
            //         }
            //     }).Wait();

            //     //tt.Start();



            // }
            // else
            // {
            //     MessageBox.Show("record not found.........");
            //     pic_Webcam.Image = null;
            // }

            // //_enrolledUser = _afis.IdentifyUser(_username, fingerprints_all,Properties.Settings.Default.VerificationThreshold);
            // // _enrolledUser = _afis.RegisterUser(_username, fingerprints_all);
            // //_enrolledUser = _afis.RegisterUser(_username, _userFingerprints);
            // //DialogResult = true;
            // //Close();
        }

        private void btn_newEnroll_Click(object sender, EventArgs e)
        {
            //dispose allocated fingerprint templates
            //foreach (Fingerprint fingerprint in fingerprints_all)
            //{
            //    fingerprint.Dispose();
            //}

            _clearScreen();

            showAnimation(CircleProgressbar1);
            showAnimation(bunifuCards1);

            ////_afis = new LocalAFIS();
            ////EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis);
            //EnterUsernameWindow_new enterUsernameWindow = new EnterUsernameWindow_new(this);
            //enterUsernameWindow.StartPosition = FormStartPosition.CenterScreen;
            //enterUsernameWindow.ShowDialog();
            fm2.enrollForm_hidden = true;
            Hide();
           
            fm2.NewUserRegistraion_popup();

        }

        private void _clearScreen()
        {
            NewMethod_disposeFingerprint(fingerprints_all);
            NewMethod_disposeFingerprint(fingerprints_left);
            NewMethod_disposeFingerprint(fingerprints_right);
            NewMethod_disposeFingerprint(fingerprints_mid);

            // _fpScanner.Freeze(false);


            fp_left.Controls.Clear();
            fp_right.Controls.Clear();
            fp_thumb.Controls.Clear();
            CircleProgressbar1.Value = 0;
            xamlButtonEnroll.Enabled = true;

            btn_left.Enabled = true;
            chk_left.Checked = chk_right.Checked = chk_thumb.Checked = false;
            pic_Webcam.Image = null;
        }

        private void EnrollmentWindow_new_FormClosing(object sender, FormClosingEventArgs e)
        {

            _clearScreen();


            //_streaming = false;
            //_capture = null;
            //this.Dispose(true);
            //fm2.identifyForm_hidden = true;
        }

        private void btn_log_Click(object sender, EventArgs e)
        {

        }

        private void btn_updatePIC_Click(object sender, EventArgs e)
        {
            //using (tranxDataContext tx = new tranxDataContext())
            //{
            //    tx.Connection.ConnectionString = Utils.getConnection();
            //    var ds = tx.userTable_1s.Where(w => w.username == username_identified)
            //         .Select(s => s);

            //    if (ds.Any())
            //    {
            //        byte[] bb = Utils.convertImagetoBinary(pic_Webcam.Image);
            //        ds.First().live_image = Utils.convert_byteArray2string(bb);
            //        tx.SubmitChanges();
            //        //showAnimation(bunifuCards1);

            //        AlertForm1 al = new AlertForm1("Photo Updated successfully...", AlertForm1.AlertOptions.OK);
            //         al.ShowDialog();
            //        //MessageBox.Show("Photo Updated successfully...");
            //    }
            //    else
            //    {
            //        pic_Webcam.Image = null;
            //    }
            //}

   
            dynamic dd = new ExpandoObject();
            dd.status = "captured";
            dd.rref = "C0000000001";
            dd.username = "jimba";
            dd.others = "Anything";
            pic_Webcam.Refresh();
            dd.capture_picture = Utils.ImageToBase64(pic_Webcam,true);
            dd.date = DateTime.Now.ToString("MMMM dd, yyyy"); ;
            object ob = dd;
            string ss = Newtonsoft.Json.JsonConvert.SerializeObject(ob);
            string APIHandle = @"infometriq-partner-api/capture/feedback";
            string resp = Utils.call_External_WEBAPI_Service(APIHandle, ss);

            //dynamic dresp = Newtonsoft.Json.JsonConvert.SerializeObject(resp);
            //string webResp = ((string)dresp.status).ToUpper();
            //if (dresp.status == "OK")
            //{

            //    using (tranxDataContext tx = new tranxDataContext())
            //    {
            //        tx.Connection.ConnectionString = Utils.getConnection();
            //        var ds = tx.individual_datas.FirstOrDefault(s => s.username == clientName);

            //    }
            //}


        }

        private void BGWorker_LeftSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Fingerprint> fp = (List<Fingerprint>)e.Argument;

            if (Identify_AfterCapture(fp))
            {
                //btn_right.Enabled =
                xamlButtonEnroll.Enabled = false;
            }
            else
            {
                //xamlButtonEnroll.Enabled =
                //btn_right.Enabled = true;
                AlertForm1 al = new AlertForm1("User not Found.......", AlertForm1.AlertOptions.OK,
                   AlertForm1.AlertType.error);
                al.ShowDialog();

            }
            //Identify_AfterCapture(fingerprints_left);
        }

        private void BGWorker_rightSearch_DoWork(object sender, DoWorkEventArgs e)
        {

            List<Fingerprint> fp = (List<Fingerprint>)e.Argument;
            if (Identify_AfterCapture(fp)) xamlButtonEnroll.Enabled = false;
            //Identify_AfterCapture(fingerprints_left);

            if (Identify_AfterCapture(fp))
            {
                btn_thump.Enabled =
                xamlButtonEnroll.Enabled = false;
            }
            else
            {
                //xamlButtonEnroll.Enabled =
                btn_thump.Enabled = true;

                AlertForm1 al = new AlertForm1("User not Found.......", AlertForm1.AlertOptions.OK,
                   AlertForm1.AlertType.error);
                al.ShowDialog();
            }
        }

        private void BGWorker_thumbSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Fingerprint> fp = (List<Fingerprint>)e.Argument;
            if (Identify_AfterCapture(fp))
            {
                xamlButtonEnroll.Enabled = false;
            }
            else
            {
                //xamlButtonEnroll.Enabled = true;
                AlertForm1 al = new AlertForm1("User not Found.......", AlertForm1.AlertOptions.OK,
                   AlertForm1.AlertType.error);
                al.ShowDialog();
            }
            //Identify_AfterCapture(fingerprints_left);
        }

        private void btn_capturefoto_Click(object sender, EventArgs e)
        {

            string base64str = Utils.GetImageFromCamera(pic_Webcam);
            pic_Webcam.Refresh();
            //captureForm1 fm = new captureForm1(this);
            //fm.ShowDialog();
        }
    }
}
