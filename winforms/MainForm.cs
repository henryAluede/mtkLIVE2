using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dermalog.Imaging.Capturing;
using System.Reflection;
using System.Windows.Interop;
using IWin32Window = System.Windows.Interop.IWin32Window;
//using Emgu.CV.Structure;
//using Emgu.CV;
using System.Threading;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
//using System.Windows;
//using System.Windows;

namespace DermalogMultiScannerDemo
{
    public partial class MainForm :MetroFramework.Forms.MetroForm // Form
    {
        public FPScanner _fpScanner;
        private LocalUser _selectedUser;
        private LocalAFIS _afis;
        public string currentUSER;
        bool _streaming;
        //Capture _capture;
        bool scanBegin = false;

        public MainForm()
        {
            // InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;


           


            try
            {
                InitializeComponent();

                this.Text += " v" + Assembly.GetExecutingAssembly().GetName().Version;

                //use any assembly versions
                RedirectAssembly("Dermalog.Imaging.Capturing");
                RedirectAssembly("Dermalog.AFIS.FourprintSegmentation");
                RedirectAssembly("Dermalog.AFIS.TwoPprintSegmentation");

                RedirectAssembly("Dermalog.Afis.NistQualityCheck");
                RedirectAssembly("Dermalog.AFIS.FingerCode3");


                DisplayMessage("Loading user database");
                _afis = new LocalAFIS();
                lbStorage.Text = "Storage: " + _afis.StoragePath;
                toolTip1.SetToolTip(lbStorage, _afis.StoragePath);
                //lbStorage.ToolTip = _afis.StoragePath;

                UpdateUserList();
                EnableGUI(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "ERROR");
                //Close();
            }


        }

        public DeviceIdentity SelectedDeviceIdentity { get; set; }
        public FPScanner FingerPrintScanner { get; internal set; }
        public void connect_Device()
        {

           // CloseScanner();
            Thread.Sleep(1000);
            //string deviceName = "FG_ZF10";
            DeviceIdentity selectedDI = DeviceIdentity.FG_ZF10; //Get selected Frame-Grabber
            //DeviceIdentity selectedDI = (DeviceIdentity)xamlListBoxFG.SelectedItem; //Get selected Frame-Grabber
            //this.SelectedDeviceIdentity = selectedDI;

            DeviceInformations[] dinfos = FPScanner.GetAttachedDevices(selectedDI); //Get all Fingerprint Scanners
            DeviceInformations dinfo = dinfos.First();
            DeviceInfos di = new DeviceInfos(dinfo.index, dinfo.name);
            FingerPrintScanner = FPScanner.GetFPScanner(selectedDI, di.Index);

            _fpScanner = FingerPrintScanner;
            //use any assembly versions

            RedirectAssembly("Dermalog.Imaging.Capturing");
            RedirectAssembly("Dermalog.AFIS.FourprintSegmentation");
            RedirectAssembly("Dermalog.AFIS.TwoPprintSegmentation");

            RedirectAssembly("Dermalog.Afis.NistQualityCheck");
            RedirectAssembly("Dermalog.AFIS.FingerCode3");



            _afis = new LocalAFIS();
            //// DisplayMessage("Loading user database");
            // // lbStorage.Text = "Storage: " + _afis.StoragePath;
            // //toolTip1.SetToolTip(lbStorage, _afis.StoragePath);


            // //lbStorage.ToolTip = _afis.StoragePath;

            UpdateUserList();
            EnableGUI(false);
            Thread.Sleep(500);

        }

        public MainForm(FPScanner __fpScanner)
        {
            // InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
           _fpScanner = __fpScanner;

            //connect_Device();


            try
            {
                InitializeComponent();

                this.Text += " v" + Assembly.GetExecutingAssembly().GetName().Version;

                //use any assembly versions
                RedirectAssembly("Dermalog.Imaging.Capturing");
                RedirectAssembly("Dermalog.AFIS.FourprintSegmentation");
                RedirectAssembly("Dermalog.AFIS.TwoPprintSegmentation");

                RedirectAssembly("Dermalog.Afis.NistQualityCheck");
                RedirectAssembly("Dermalog.AFIS.FingerCode3");


                
                _afis = new LocalAFIS();
                DisplayMessage("Loading user database");
                lbStorage.Text = "Storage: " + _afis.StoragePath;
                toolTip1.SetToolTip(lbStorage, _afis.StoragePath);
               

                //lbStorage.ToolTip = _afis.StoragePath;

                UpdateUserList();
                EnableGUI(false);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "ERROR");
                //Close();
                //DisplayError(ex.Message + "\n" + ex.StackTrace);
                lst_msg.Items.Insert(0, ex.Message );
            }


        }

        public static void RedirectAssembly(string shortName)
        {
            ResolveEventHandler handler = null;
            handler = (sender, args) =>
            {
                var requestedAssembly = new AssemblyName(args.Name);
                if (requestedAssembly.Name != shortName)
                    return null;

                AppDomain.CurrentDomain.AssemblyResolve -= handler;
                return Assembly.Load(shortName);
                //return Assembly.LoadWithPartialName(shortName);
            };
            AppDomain.CurrentDomain.AssemblyResolve += handler;
        }

        #region FPScanner Events
        private void BindFPScannerEvents()
        {
            UnbindFPScannerEvents();

            _fpScanner.OnScannerImage += _fpScanner_OnScannerImage;
            _fpScanner.OnScannerDetect += _fpScanner_OnScannerDetect;
            _fpScanner.OnScannerError += _fpScanner_OnScannerError;
            _fpScanner.OnFingerprintsDetected += _fpScanner_OnFingerprintsDetected;
        }

        private void BindFPScannerEvents_new()
        {
            UnbindFPScannerEvents();

            _fpScanner.OnScannerImage += _fpScanner_OnScannerImage;
            _fpScanner.OnScannerDetect += _fpScanner_OnScannerDetect;
            _fpScanner.OnScannerError += _fpScanner_OnScannerError;
            _fpScanner.OnFingerprintsDetected += _fpScanner_OnFingerprintsDetected_new;
        }

        private void UnbindFPScannerEvents()
        {
            if (_fpScanner == null)
                return;

            _fpScanner.OnScannerImage -= _fpScanner_OnScannerImage;
            _fpScanner.OnScannerDetect -= _fpScanner_OnScannerDetect;
            _fpScanner.OnScannerError -= _fpScanner_OnScannerError;
            _fpScanner.OnFingerprintsDetected -= _fpScanner_OnFingerprintsDetected;
        }

        void _fpScanner_OnScannerError(object sender, FPScanner.ScannerErrorEventArgs e)
        {
            //DisplayError(e.Error);
            //DisplayError("Scanning stopped, select another user .....");
            //picBusy.Visible = false;
            //StartCapturing();
            //MessageBox.Show(e.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }

        void _fpScanner_OnScannerImage(System.Drawing.Image image)
        {
            //xamlImageOnScannerImage.Image = Utils.BitmapFromSource( Utils.BitmapToBitmapSource(image as Bitmap));
        }

        void _fpScanner_OnScannerDetect(System.Drawing.Image image)
        {
            if (scanBegin)
            {
                string templateFormat = Properties.Settings.Default.TemplateFORMAT;

                displayMessage(String.Format("Template FORMAT({0})", templateFormat), Utils.COLOR_DERMALOG_GREEN);
                DisplayMessage("Extracting Templates");
                xamlImageOnScannerDetect.Image = Utils.BitmapFromSource(Utils.BitmapToBitmapSource(image as Bitmap));
            }
        }
        List<Fingerprint> fingerprints_new = new List<Fingerprint>();

        double maxMatch = 0;
        void _fpScanner_OnFingerprintsDetected(List<Fingerprint> fingerprints)
        {
            #region GUI - Display Fingerprints
            fingerprints_new = fingerprints;

            // backgroundWorker1.RunWorkerAsync();

            // xamlStackPanelFingerprints.Controls.Clear();
            // int imageWidth = (int)xamlStackPanelFingerprints.Width / fingerprints.Count;
            // FlowLayoutPanel fl = new FlowLayoutPanel();
            // file2ToolStripMenuItem.Width = xamlStackPanelFingerprints.Width;
            // file2ToolStripMenuItem.Height = xamlStackPanelFingerprints.Height;

            //foreach (Fingerprint fingerprint in fingerprints)
            //{
            //   // System.Windows.Controls.Image img = new System.Windows.Controls.Image();

            //    Bitmap bmp = new Bitmap(fingerprint.Image);
            //    //img.Source = Utils.BitmapToBitmapSource(bmp);
            //    //PictureBox pi = new PictureBox();
            //    //pi.Image = (Image)Utils.BitmapFromSource(Utils.BitmapToBitmapSource(bmp));
            //    System.Drawing.Image pi =  (System.Drawing.Image) Utils.BitmapToBitmapSource2(bmp);
            //    string str = string.Format("NFIQ: {0}", fingerprint.NFIQ);
            //    // fPanel1.Controls.Add(addFinger(pi, str ));
            //    fingerprint.Dispose();
            //    PictureBox p = new PictureBox();
            //    p.Image = pi;
            //    //p.Image = global::DermalogMultiScannerDemo.Properties.Resources.fingers1;
            //    //p.Location = new System.Drawing.Point(615, 22);
            //    //p.Name = "pictureBox1";
            //    p.Dock = DockStyle.Fill;
            //    p.Size = new System.Drawing.Size(100, 71);
            //    p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;


            //    Label lb = new Label();
            //    lb.Text = str;

            //    TableLayoutPanel tb = new TableLayoutPanel();
            //    tb.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;

            //    tb.ColumnCount = 1;
            //    tb.RowCount = 2;
            //    tb.Size = new System.Drawing.Size(123, 135);
            //    //tb.

            //    tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //    tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            //    tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            //    tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));



            //    //Button b = new Button();
            //    tb.Controls.Add(p, 0, 0);
            //    tb.Controls.Add(lb, 0, 1);
            //    fPanel1.Controls.Add(tb);




            //    // pi.Height = xamlStackPanelFingerprints.Height;
            //    //pi.Width = imageWidth;
            //    //    Bitmap bmp = new Bitmap(fingerprint.Image);
            //    //    img.Source = Utils.BitmapToBitmapSource(bmp);

            //    //    TextBlock tbNFIQ = new TextBlock();
            //    //    tbNFIQ.Text = "NFIQ: " + fingerprint.NFIQ;
            //    //    tbNFIQ.FontSize = 80;
            //    //    tbNFIQ.TextAlignment = TextAlignment.Center;
            //    //    tbNFIQ.VerticalAlignment = System.Windows.VerticalAlignment.Bottom;
            //    //    tbNFIQ.Foreground = Utils.GetBrushFromNFIQ(fingerprint.NFIQ);

            //    //    Grid grid = new Grid();
            //    //    RowDefinition gridRow1 = new RowDefinition();
            //    //    gridRow1.Height = new GridLength(1, GridUnitType.Star);
            //    //    RowDefinition gridRow2 = new RowDefinition();
            //    //    gridRow2.Height = new GridLength(1, GridUnitType.Star);
            //    //    grid.RowDefinitions.Add(gridRow1);
            //    //    grid.RowDefinitions.Add(gridRow2);

            //    //    img.SetValue(Grid.RowProperty, 0);
            //    //    tbNFIQ.SetValue(Grid.RowProperty, 1);

            //    //    grid.Children.Add(img);
            //    //    grid.Children.Add(tbNFIQ);

            //    //    grid.Margin = new Thickness(30, 0, 30, 0);

            //    //fl.Controls.Add(pi);
            //}
            #endregion

            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    NewMethod();
                }
                );


            }



            // xamlStackPanelFingerprints.Controls.Add(fl);
            if (_selectedUser != null)
                {
                try
                {
                    //Verify User
                    DisplayMessage("Verifying Templates");
                    //Utils.bytetofile(@"C:\dermalog\Ayofutronics\futronic\dermalog2.dat", fingerprints.First().Template.Data);
                    AFISVerificationResult result = _afis.VerifyUser_New(_selectedUser.ID, fingerprints, Properties.Settings.Default.VerificationThreshold);
                    //AFISVerificationResult result = _afis.VerifyUser(_selectedUser.ID, fingerprints, Properties.Settings.Default.VerificationThreshold);
                    String scoreString = String.Format("{0:0.00}", result.Score);

                     

                    if (result.Hit)
                    {

                        displayMessage(String.Format("User verified ({0}%)", scoreString), Utils.COLOR_DERMALOG_GREEN);
                        //MessageBox.Show(String.Format("User verified ({0}%)", scoreString));
                        //label2.Text = String.Format("User verified ({0}%)", scoreString);
                        //aGauge1.Value = (float)result.Score;
                        if (result.Score > maxMatch)
                        {
                            maxMatch = result.Score;

                            String bestscoreString = String.Format("{0:0.00}", maxMatch);
                            label2.Text = String.Format("Best Finger verified ({0}%)", bestscoreString);
                            aGauge1.Value = (float)maxMatch;
                            CircleProgressbar1.Value = (int)maxMatch;

                            //showAnimation(bunifuCards1);
                            //showAnimation(bunifuCards2);
                            //showAnimation(aGauge1);
                            showAnimation(CircleProgressbar1);
                            //StopCapturing(); 
                            scanBegin = false;
                        }
                       
                    }
                    else
                    {
                        displayMessage(String.Format("User not verified ({0}%)", scoreString), Utils.COLOR_DERMALOG_RED);
                        //label2.Text = String.Format("User verified ({0}%)", scoreString);
                        //aGauge1.Value = (float)result.Score;
                    }
                    //String bestscoreString = String.Format("{0:0.00}", maxMatch);
                    //label2.Text = String.Format("Best User verified ({0}%)", bestscoreString);
                    //aGauge1.Value = (float)maxMatch;
                    //CircleProgressbar1.Value = (int)maxMatch;

                    ////showAnimation(bunifuCards1);
                    ////showAnimation(bunifuCards2);
                    ////showAnimation(aGauge1);
                    //showAnimation(CircleProgressbar1);
                    ////StopCapturing();

                    scanBegin = false;
                    DisplayError("Scanning Completed.....");
                    MessageBox.Show("Scanning Completed.....view result");
                    picBusy.Visible = false;
                    StopCapturing();


                }
                catch (Exception e)
                {
                    DisplayError(e.Message);
                    //StopCapturing();

                }
               
            }

            //dispose allocated fingerprint templates
            foreach (Fingerprint fingerprint in fingerprints)
            {
                fingerprint.Dispose();
            }

            _fpScanner.Freeze(false);

            
        }
        #endregion


        private void showAnimation(Control cs)
        {
            bunifuTransition1.HideSync(cs,true);
            //bunifuTransition1.HideSync(cs, false, BunifuAnimatorNS.Animation.HorizBlind);
            //Thread.Sleep(2000);
            bunifuTransition1.ShowSync(cs, true);

        }

        void _fpScanner_OnFingerprintsDetected_new(List<Fingerprint> fingerprints)
        {
            #region GUI - Display Fingerprints
            fingerprints_new = fingerprints;

           
            #endregion


            Dictionary<long, LocalUser> userList = _afis.GetUserList();
            xamlListBoxUsers.Items.Clear();
            foreach (LocalUser user in userList.Values)
            {
                //xamlListBoxUsers.Items.Add(user);
                // }

                _selectedUser = user;


                // xamlStackPanelFingerprints.Controls.Add(fl);
                if (_selectedUser != null)
                {
                    try
                    {
                        //Verify User
                        DisplayMessage("Verifying Templates");
                        AFISVerificationResult result = _afis.VerifyUser(_selectedUser.ID, fingerprints, Properties.Settings.Default.VerificationThreshold);
                        String scoreString = String.Format("{0:0.00}", result.Score);

                        if (result.Score > maxMatch)
                        {
                            maxMatch = result.Score;
                        }

                        if (result.Hit)
                        {
                            displayMessage(String.Format("User verified ({0})", scoreString), Utils.COLOR_DERMALOG_GREEN);
                            //label2.Text = String.Format("User verified ({0}%)", scoreString);
                            //aGauge1.Value = (float)result.Score;
                           
                            break;

                        }
                        else
                        {
                            displayMessage(String.Format("User not verified ({0})", scoreString), Utils.COLOR_DERMALOG_RED);
                            //label2.Text = String.Format("User verified ({0}%)", scoreString);
                            //aGauge1.Value = (float)result.Score;
                        }
                        String bestscoreString = String.Format("{0:0.00}", maxMatch);
                        label2.Text = String.Format("Best User verified ({0}%) username= {1}", bestscoreString,_selectedUser.Name);
                        aGauge1.Value = (float)maxMatch;

                        showAnimation(aGauge1);
                        //StopCapturing();
                        //NewMethod();
                    }
                    catch (Exception e)
                    {
                        DisplayError(e.Message);
                        //StopCapturing();
                    }
                }

                {
                    //this.BeginInvoke((MethodInvoker)delegate ()
                    //{
                    //    NewMethod();

                    //    Label l = new Label(); l.Location = new Point(12, 10);
                    //    l.Text = "Some Text";
                    //    this.Controls.Add(l);
                    //}
                    //);

                    //var resp;
                    //Task.Factory.StartNew(()=>NewMethod_new()).
                }
            }

            //dispose allocated fingerprint templates
            foreach (Fingerprint fingerprint in fingerprints)
            {
                fingerprint.Dispose();
            }

            _fpScanner.Freeze(false);


        }



        #region FPScanner capturing
        public void StartCapturing()
        {
            //if (!stop_scan)
            {
                BindFPScannerEvents();
                _fpScanner.StartCapturing();
            }
        }

        public void StartCapturing_new()
        {
            //if (!stop_scan)
            {
                BindFPScannerEvents();
                _fpScanner.StartCapturing();
            }
        }


        public void StopCapturing()
        {
            if (_fpScanner != null)
                _fpScanner.StopCapturing();

            UnbindFPScannerEvents();
            
        }
        #endregion

        #region GUI
        private void EnableGUI(bool enable)
        {
            //Application..Current.Dispatcher.BeginInvoke((Action)(() =>
            {
                xamlButtonEnroll.Enabled =  !enable;
                xamlListBoxUsers.Enabled = enable;
                xamlListBoxUsers.SelectedIndex = -1;
            }
            //));
        }

        private void ResetGUI()
        {
            try
            {
                lst_msg.Items.Clear();
                if (_afis.IsEmpty())
                {
                    DisplayMessage("Press 'Enroll User'");
                }
                else
                {
                    DisplayMessage("Select User to verify");
                }

                //Application.Current.Dispatcher.BeginInvoke((Action)(() =>
                {
                    //xamlImageOnScannerImage.Image = Properties.Resources.fingers1; // null;
                    xamlImageOnScannerDetect.Image = null; // Properties.Resources.fingers; //null;
                    // xamlStackPanelFingerprints.Children.Clear();
                }
            }
            catch(Exception ex)
            {
                DisplayMessage(ex.Message);
            }
            //));
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // CloseScanner();
            StopCapturing();
            this.Dispose(true);
        }

        private void CloseScanner()
        {
            if (_fpScanner == null)
                return;

            StopCapturing();

            _fpScanner.Dispose();
            _fpScanner = null;
        }

        private void bioForm1_Load(object sender, EventArgs e)
        {
            lb_format.Text = "Default Template Format -> " + Properties.Settings.Default.TemplateFORMAT;

            //this.WindowState = FormWindowState.Minimized;
            //userAdmin2 fm = new userAdmin2(this);
            //fm.ShowDialog();
            //_fpScanner = 
            try
            {
               // _streaming = false;
               // _capture = new Capture();

                EnableGUI(true);
                // OpenSelectFGDialog();
                //testForm1 tf = new testForm1();
                //tf.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void OpenSelectFGDialog()
        {
            CloseScanner();

            ResetGUI();
            DisplayMessage("Device configuration");

            try
            {
                SelectFGWindow_new selectFG = new SelectFGWindow_new(this);

                selectFG.ShowDialog();

                if (selectFG.rDialogResult)
               // if (selectFG.ShowDialog()==DialogResult.OK)
                    //if (selectFG.rDialogResult.HasValue && selectFG.rDialogResult.Value)
                    {
                        var selectedDeviceIdentity = selectFG.SelectedDeviceIdentity;

                    if (_fpScanner != null)
                    {
                        _fpScanner.Dispose();
                        _fpScanner = null;
                    }

                    OpenSelectDeviceDialog(selectedDeviceIdentity);
                }
                else
                {
                    if (_fpScanner == null)
                        DisplayError("No Frame-Grabber selected.");
                    EnableGUI(false);
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }


       


        private void OpenSelectDeviceDialog(DeviceIdentity selectedDeviceIdentity)
        {
            ResetGUI();
            DisplayMessage("Device configuration");
            EnableGUI(false);

            try
            {
                //IWin32Window win32Window = new WindowWrapper(this);
                SelectDeviceWindow_new selectDevice = new SelectDeviceWindow_new(selectedDeviceIdentity, this);
                if (_fpScanner != null)
                    selectDevice.FingerPrintScanner = _fpScanner;

                selectDevice.ShowDialog();

                if (selectDevice.rDialogResult)
                    //if (selectDevice.rDialogResult.HasValue && selectDevice.DialogResult.Value)
                {
                    DisplayMessage("Opening device");

                    _fpScanner = selectDevice.FingerPrintScanner;
                    if (_fpScanner != null)
                    {
                        ResetGUI();
                        EnableGUI(true);
                    }
                }
                else
                {
                    DisplayError("No device selected");
                    if (selectDevice.FingerPrintScanner != null)
                    {
                        selectDevice.FingerPrintScanner.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            StopCapturing();
            ResetGUI();

            DisplayMessage("User enrollment");
            xamlListBoxUsers.SelectedIndex = -1; //Deselect User

            EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis);
           // EnrollmentWindow enrollmentWindow = new EnrollmentWindow(_fpScanner, _afis);
            //enrollmentWindow.Owner = this;
            enrollmentWindow.ShowDialog();

            if (enrollmentWindow.nDialogResult)
                //if (enrollmentWindow.DialogResult.HasValue && enrollmentWindow.DialogResult.Value)
                {
                    UpdateUserList();
            }

            DisplayMessage("Select User to verify");
        }

        private void UpdateUserList()
        {
           // _afis = new LocalAFIS();
            Dictionary<long, LocalUser> userList = _afis.GetUserList();
            xamlListBoxUsers.Items.Clear();
            foreach (LocalUser user in userList.Values)
            {
                xamlListBoxUsers.Items.Add(user);
            }
        }

        private void DisplayMessage(String message)
        {
            displayMessage(message, Utils.COLOR_DERMALOG_BLUE);
        }

        private void DisplayError(String error)
        {
            displayMessage(error, Utils.COLOR_DERMALOG_RED);
        }

        private void displayMessage(String message, System.Windows.Media.Brush brush)
        {
           // Application.Current.Dispatcher.BeginInvoke((Action)(() =>
            {
                //xamlLabelMessage.BackColor = brush;
                xamlLabelMessage.Text = message;
                //xamlLabelMessage.Text = message.ToUpper();
                lst_msg.Items.Insert(0, message);
            }
            //));
        }


        public TableLayoutPanel addFinger(Image pp, string str)
        {

            PictureBox p = new PictureBox();
            p.Image = pp;
            //p.Image = global::DermalogMultiScannerDemo.Properties.Resources.fingers1;
            //p.Location = new System.Drawing.Point(615, 22);
            //p.Name = "pictureBox1";
            p.Dock = DockStyle.Fill;
            p.Size = new System.Drawing.Size(100, 71);
            p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;


            Label lb = new Label();
            lb.Text = str;

            TableLayoutPanel tb = new TableLayoutPanel();
            tb.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;

            tb.ColumnCount = 1;
            tb.RowCount = 2;
            tb.Size = new System.Drawing.Size(123, 135);
            //tb.

            tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));



            //Button b = new Button();
            tb.Controls.Add(p, 0, 0);
            tb.Controls.Add(lb, 0, 1);
            //fPanel1.Controls.Add(tb);
            return tb;
        }

        public void genBarcode(string enteredUsername)
        {
            Utils.gen_barcode(pixBarcode, enteredUsername);
        }
        // bool stop_scan = false;
        private void xamlListBoxUsers_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                //connect_Device();
                //txt_selectedUser.Text
                string user_found = xamlListBoxUsers.SelectedItem.ToString();
                txt_selectedUser.Text=user_found;
                if (!string.IsNullOrEmpty(user_found))
                {
                    // = txt_selectedUser.Text;
                    using (tranxDataContext tx = new tranxDataContext())
                    {
                        var ds = tx.userTable_1s.Where(w => w.username == user_found)
                             .Select(s => s);

                        if (ds.Any())
                        {


                            byte[] bb = Utils.convert_string2byteArray(ds.First().live_image);
                            pic_Webcam.Image = Utils.convertBinarytoImage(bb);

                            //tx.SubmitChanges();
                        }
                        else
                        {
                            pic_Webcam.Image = null;
                        }
                    }

                   // Start_Capture_selectedUser();
                }
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

          

            

            //backgroundWorker1.RunWorkerAsync();
        }

        private void Start_Capture_selectedUser()
        {
            //else

            picBusy.Visible = true;
            aGauge1.Value = 0;
            maxMatch = 0;
            CircleProgressbar1.Value = 0;
            fPanel1.Controls.Clear();

            //showAnimation(bunifuCards1);
            showAnimation(bunifuCards2);
            //showAnimation(aGauge1);
            //showAnimation(CircleProgressbar1);


            StopCapturing();
            //stop_scan = false;
            LocalUser selectedUser = (LocalUser)xamlListBoxUsers.SelectedItem;
            //LocalUser selectedUser = (LocalUser)txt_selectedUser.Text;

            if (selectedUser != null)
            {
                ResetGUI();

                _selectedUser = selectedUser;
                genBarcode(selectedUser.Name);

                DisplayMessage("Please place finger(s) onto scanner");
                if (_fpScanner == null)
                {
                    //var t = Task.Factory.StartNew(() => OpenSelectFGDialog());
                    //var t = new Task(() => OpenSelectFGDialog());
                    //.Start();
                    //connect_Device();
                    //OpenSelectFGDialog();

                }
                //else
                StartCapturing();


            }
            else
            {
                MessageBox.Show("Requested user not found, check if the input value is correct...",
                    "User not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xamlMenuItemSelectFG_Click(object sender, EventArgs e)
        {
            OpenSelectFGDialog();
        }

        private void xamlMenuItemReset_Click(object sender, EventArgs e)
        {
            try
            {
                StopCapturing();
                System.IO.Directory.Delete(_afis.StoragePath, true);
                _afis = new LocalAFIS();
                UpdateUserList();
                ResetGUI();

            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }



        private void btn_enrol_Click(object sender, EventArgs e)
        {
            EnrollmentWindow enrollmentWindow = new EnrollmentWindow();
            //enrollmentWindow.Owner = this;
            enrollmentWindow.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void xamlMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void NewMethod()
        {
            fPanel1.Controls.Clear();
            //fingerprints_new = fingerprints;
            // xamlStackPanelFingerprints.Controls.Clear();
            // int imageWidth = (int)xamlStackPanelFingerprints.Width / fingerprints.Count;
            //FlowLayoutPanel fl = new FlowLayoutPanel();
            // file2ToolStripMenuItem.Width = xamlStackPanelFingerprints.Width;
            // file2ToolStripMenuItem.Height = xamlStackPanelFingerprints.Height;

            foreach (Fingerprint fingerprint in fingerprints_new)
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
                tb.Size = new System.Drawing.Size(145, 199);
                //tb.

                tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
                tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));



                //Button b = new Button();
                tb.Controls.Add(p, 0, 0);
                tb.Controls.Add(lb, 0, 1);
                fPanel1.Controls.Add(tb);


            }
        }

        private void rb_left_CheckedChanged(object sender, EventArgs e)
        {
            show_fingerCapture();
        }

        private void rb_right_CheckedChanged(object sender, EventArgs e)
        {
            show_fingerCapture();
        }

        private void rb_thumb_CheckedChanged(object sender, EventArgs e)
        {
            show_fingerCapture();
        }

        void show_fingerCapture()
        {
            //if(rb_thumb.Checked)
            //{
            //    xamlImageOnScannerImage.Image = Properties.Resources.fingers3;
            //}
            //else if(rb_right.Checked)
            //{
            //    xamlImageOnScannerImage.Image = Properties.Resources.fingers2;
            //}
            //else if (rb_left.Checked)
            //{
            //    xamlImageOnScannerImage.Image = Properties.Resources.fingers1;
            //}
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (!_streaming)
            {
                Application.Idle += streaming_device;
                btnCapture.Text = "Stop Webcam Streaming...";

            }
            else
            {
                Application.Idle -= streaming_device;
                btnCapture.Text = "Start Webcam Streaming...";
            }

            _streaming = !_streaming;
        }

        private void streaming_device(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ///_capture = new Capture();
           // capture_image();
        }

        private void capture_image()
        {

            //var img = _capture.QueryFrame().ToImage<Bgr, byte>();
            //var bmp = img.Bitmap;
            //pic_Webcam.Image = bmp;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ResetGUI();

            //_selectedUser = selectedUser;

            DisplayMessage("Please place finger(s) onto scanner");
            StartCapturing_new();

        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            //StopCapturing();

            //_fpScanner.Dispose();
            //_fpScanner = null;
            CloseScanner();
            Close();
           // Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Dispose(true);
        }

        private void btn_startsWith_Click(object sender, EventArgs e)
        {
            //List<string> dd = new List<string> { "Not found" };

            ////xamlListBoxUsers.Items.Clear();
            //string str = txt_selectedUser.Text;
            ////xamlListBoxUsers.DataSource = Utils.get_usernames(str)??dd;
            ////xamlListBoxUsers.Refresh();
            //int ii =  xamlListBoxUsers.Items.IndexOf(str);
            //xamlListBoxUsers.SelectedIndex = ii;
            xamlListBoxUsers.Text= txt_selectedUser.Text;

        }

        private void btn_startScan_Click(object sender, EventArgs e)
        {
            Start_Capture_selectedUser();
        }
    }
}
#endregion