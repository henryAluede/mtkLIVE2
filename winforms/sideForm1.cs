using Dermalog.Imaging.Capturing;
using Alertform;
using MetroFramework;
using Newtonsoft.Json.Linq;
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
//using Emgu.CV;

namespace DermalogMultiScannerDemo.winforms
{
    public partial class sideForm1 : MetroFramework.Forms.MetroForm   // Form
    {

        public  string loggedin_staff = "";
        //MDIParent3 ic;
        public FPScanner _fpScanner;
        public LocalAFIS _afis;

        public  VerifyWindow _VerifyWindow = null;
        //VerifyZF10_template VerifyWindow = null;
        public bool VerifyForm_hidden = false;


        public EnrollmentWindow_new enrollmentWindow = null;
        public bool enrollForm_hidden = false;

        EnterUsernameWindow_new enterUsernameWindow = null;
        public bool EnterUsernameForm_hidden = false;

        public  IdentificationWindow IdentifyWindow = null;
        public bool identifyForm_hidden = false;

        public dynamic userProfile;
        //public bool runNextPhase = true;

        public sideForm1()
        {
            InitializeComponent();

            Hide();
            userAdmin2 fm = new userAdmin2(this);
            fm.ShowDialog();


        }


        public  void ActivateButtonRoles()
        {
            btn_creatUser.Enabled=
            btn_resetData.Enabled = false;
            string rrole = userProfile.role;
            switch (rrole)
            {
                case "Enroll":
                    btn_verifyTemplate.Enabled = btn_Identification.Enabled = false;
                    btn_enroll.Enabled = true;
                    break;
                case "Verify":
                   btn_enroll.Enabled  = btn_Identification.Enabled = false;
                   btn_verifyTemplate.Enabled  = true;
                    break;
                case "Identify":
                    btn_verifyTemplate.Enabled = btn_enroll.Enabled = false;
                    btn_Identification.Enabled = true;
                    break;
                case "None":
                case "Suspended":
                    btn_verifyTemplate.Enabled = btn_enroll.Enabled =
                    btn_Identification.Enabled = false;
                    break;
                case "Administrator":
                    btn_verifyTemplate.Enabled = btn_enroll.Enabled = false;
                    btn_creatUser.Enabled =
                    btn_Identification.Enabled =  true;

                    break;
                case "Super":
                    btn_verifyTemplate.Enabled = btn_enroll.Enabled =
                    btn_creatUser.Enabled =
                    btn_Identification.Enabled = btn_resetData.Enabled = true;

                    break;
                default:
                    btn_verifyTemplate.Enabled = btn_enroll.Enabled = false;
                    btn_creatUser.Enabled=
                    btn_Identification.Enabled = btn_resetData.Enabled = false;

                    break;
            }
        }

        public sideForm1(MDIParent3 md)
        {
            InitializeComponent();
            //ic = md;
            connect_Device();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //winforms.testForm1 fm = new testForm1();
            //fm.ShowDialog();
        }

        private void OpenSelectDeviceDialog(DeviceIdentity selectedDeviceIdentity)
        {

            bool runNextPhase = true;
            //ResetGUI();
            //DisplayMessage("Device configuration");
            //EnableGUI(false);

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
                    // DisplayMessage("Opening device");

                    _fpScanner = selectDevice.FingerPrintScanner;
                    //ic._fpScanner = _fpScanner;
                    if (_fpScanner != null)
                    {
                        //ResetGUI();
                        //EnableGUI(true);
                    }
                    // runNextPhase = true;

                    NewUserRegistraion_popup();
                    ////EnterUsernameWindow_new
                    //EnterUsernameWindow_new enterUsernameWindow = new EnterUsernameWindow_new(true);
                    ////enterUsernameWindow.Owner = this;
                    //enterUsernameWindow.ShowDialog();

                    //if ((bool)enterUsernameWindow.DialogResponse.result) //this.Close();

                    //{
                    //    try
                    //    {
                    //        _afis = new LocalAFIS();
                    //        if (!enrollForm_hidden)
                    //        {
                    //            //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis);
                    //            //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis,
                    //            enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis,
                    //               loggedin_staff, enterUsernameWindow.DialogResponse.enteredUsername, this);
                    //            //enrollmentWindow.MdiParent = this;
                    //            //enrollmentWindow.StartPosition = FormStartPosition.CenterScreen;
                    //            // EnrollmentWindow enrollmentWindow = new EnrollmentWindow(_fpScanner, _afis);
                    //            //enrollmentWindow.Owner = this;
                    //            //enrollmentWindow.Show();
                    //            var ddg = enrollmentWindow.ShowDialog();
                    //        }
                    //        else
                    //        {
                    //            enrollmentWindow.reloadForm(enterUsernameWindow.DialogResponse.enteredUsername);
                    //            var ddg = enrollmentWindow.ShowDialog();
                    //        }
                    //    }
                    //    catch { }

                    //}
                }
                else
                {
                    //DisplayError("No device selected");


                    //DialogResult msg = MessageBox.Show("Kindly connect your fingerprint Device and Retry", "No device selected"
                    //    , MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);


                    AlertForm1 al = new AlertForm1("Kindly connect your fingerprint Device and Retry",
                        AlertForm1.AlertOptions.RETRYCANCEL
                        , AlertForm1.AlertType.error, "No device selected");
                    var aa = al.ShowDialog();

                    if (!al.rDialogResult)
                    //if (msg == DialogResult.Cancel)
                    {
                        if (selectDevice.FingerPrintScanner != null)
                        {
                            selectDevice.FingerPrintScanner.Dispose();
                        }
                        runNextPhase = false;
                    }
                    else
                    {
                        OpenSelectDeviceDialog(selectedDeviceIdentity);
                        //connect_Device();
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }
        private void OpenSelectDeviceDialog_setup(DeviceIdentity selectedDeviceIdentity)
        {

            bool runNextPhase = true;
            //ResetGUI();
            //DisplayMessage("Device configuration");
            //EnableGUI(false);

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
                    // DisplayMessage("Opening device");

                    _fpScanner = selectDevice.FingerPrintScanner;
                    //ic._fpScanner = _fpScanner;
                    if (_fpScanner != null)
                    {
                        //ResetGUI();
                        //EnableGUI(true);
                    }
                    // runNextPhase = true;

                   // NewUserRegistraion_popup();
                    ////EnterUsernameWindow_new
                    //EnterUsernameWindow_new enterUsernameWindow = new EnterUsernameWindow_new(true);
                    ////enterUsernameWindow.Owner = this;
                    //enterUsernameWindow.ShowDialog();

                    //if ((bool)enterUsernameWindow.DialogResponse.result) //this.Close();

                    //{
                    //    try
                    //    {
                    //        _afis = new LocalAFIS();
                    //        if (!enrollForm_hidden)
                    //        {
                    //            //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis);
                    //            //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis,
                    //            enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis,
                    //               loggedin_staff, enterUsernameWindow.DialogResponse.enteredUsername, this);
                    //            //enrollmentWindow.MdiParent = this;
                    //            //enrollmentWindow.StartPosition = FormStartPosition.CenterScreen;
                    //            // EnrollmentWindow enrollmentWindow = new EnrollmentWindow(_fpScanner, _afis);
                    //            //enrollmentWindow.Owner = this;
                    //            //enrollmentWindow.Show();
                    //            var ddg = enrollmentWindow.ShowDialog();
                    //        }
                    //        else
                    //        {
                    //            enrollmentWindow.reloadForm(enterUsernameWindow.DialogResponse.enteredUsername);
                    //            var ddg = enrollmentWindow.ShowDialog();
                    //        }
                    //    }
                    //    catch { }

                    //}
                }
                else
                {
                    //DisplayError("No device selected");


                    //DialogResult msg = MessageBox.Show("Kindly connect your fingerprint Device and Retry", "No device selected"
                    //    , MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);


                    AlertForm1 al = new AlertForm1("Kindly connect your fingerprint Device and Retry",
                        AlertForm1.AlertOptions.RETRYCANCEL
                        , AlertForm1.AlertType.error, "No device selected");
                    var aa = al.ShowDialog();

                    if (!al.rDialogResult)
                    //if (msg == DialogResult.Cancel)
                    {
                        if (selectDevice.FingerPrintScanner != null)
                        {
                            selectDevice.FingerPrintScanner.Dispose();
                        }
                        runNextPhase = false;
                    }
                    else
                    {
                        OpenSelectDeviceDialog_setup(selectedDeviceIdentity);
                        
                        //connect_Device();
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
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
                //xamlLabelMessage.Text = message.ToUpper();
                //lst_msg.Items.Insert(0, message.ToUpper());
                AlertForm1 al = new AlertForm1(message, AlertForm1.AlertOptions.OK);
                al.ShowDialog();
                // MessageBox.Show(message);
            }
            //));
        }

        private void CloseScanner()
        {
            if (_fpScanner == null)
                return;

            // StopCapturing();

            _fpScanner.Dispose();
            _fpScanner = null;
        }
        private void OpenSelectFGDialog(bool setupPARAM=false)
        {
            //CloseScanner();

            //ResetGUI();
            //DisplayMessage("Device configuration");

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


                    if (setupPARAM)
                    {
                        OpenSelectDeviceDialog_setup(selectedDeviceIdentity);
                    }
                    else
                    {
                        OpenSelectDeviceDialog(selectedDeviceIdentity);
                    }
                }
                else
                {
                    if (_fpScanner == null)
                        DisplayError("No Frame-Grabber selected.");
                    //EnableGUI(false);
                }
            }
            catch (Exception ex)
            {

                AlertForm1 al = new AlertForm1(ex.Message, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error);
                al.ShowDialog();
                // DisplayError(ex.Message);
            }
        }
        private void OpenSelectFGDialog_setup()
        {
            //CloseScanner();

            //ResetGUI();
            //DisplayMessage("Device configuration");

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

                    OpenSelectDeviceDialog_setup(selectedDeviceIdentity);
                }
                else
                {
                    if (_fpScanner == null)
                        DisplayError("No Frame-Grabber selected.");
                    //EnableGUI(false);
                }
            }
            catch (Exception ex)
            {

                AlertForm1 al = new AlertForm1(ex.Message, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error);
                al.ShowDialog();
                // DisplayError(ex.Message);
            }
        }

        private void btn_CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public FPScanner FingerPrintScanner { get; internal set; }
        public void connect_Device()
        {

            // CloseScanner();
            //Thread.Sleep(1000);
            //string deviceName = "FG_ZF10";
            DeviceIdentity selectedDI = new DeviceIdentity();//Get selected Frame-Grabber
            selectedDI = DeviceIdentity.FG_ZF10; //Get selected Frame-Grabber
            //DeviceIdentity selectedDI = (DeviceIdentity)xamlListBoxFG.SelectedItem; //Get selected Frame-Grabber
            //this.SelectedDeviceIdentity = selectedDI;

            DeviceInformations[] dinfos = FPScanner.GetAttachedDevices(selectedDI); //Get all Fingerprint Scanners
            DeviceInformations dinfo = dinfos.First();
            DeviceInfos di = new DeviceInfos(dinfo.index, dinfo.name);
            FingerPrintScanner = FPScanner.GetFPScanner(selectedDI, di.Index);

            //_fpScanner = FingerPrintScanner;
            ////use any assembly versions

            //RedirectAssembly("Dermalog.Imaging.Capturing");
            //RedirectAssembly("Dermalog.AFIS.FourprintSegmentation");
            //RedirectAssembly("Dermalog.AFIS.TwoPprintSegmentation");

            //RedirectAssembly("Dermalog.Afis.NistQualityCheck");
            //RedirectAssembly("Dermalog.AFIS.FingerCode3");



            //_afis = new LocalAFIS();
            //// DisplayMessage("Loading user database");
            // // lbStorage.Text = "Storage: " + _afis.StoragePath;
            // //toolTip1.SetToolTip(lbStorage, _afis.StoragePath);


            // //lbStorage.ToolTip = _afis.StoragePath;

            // UpdateUserList();
            //EnableGUI(false);
            //Thread.Sleep(500);

        }


        private void btn_verify_Click(object sender, EventArgs e)
        {
            {
                //EnterUsernameWindow_new
                EnterUsernameWindow_new enterUsernameWindow = 
                    new EnterUsernameWindow_new();
                //enterUsernameWindow.Owner = this;
                enterUsernameWindow.ShowDialog();

                //if (!enterUsernameWindow.nDialogResult) this.Close();
            }

        }



        private void btn_enroll_Click(object sender, EventArgs e)
        {
            bool runNextPhase = false;
            // Task.Factory.StartNew(() =>
            Thread.Sleep(1000);
            try
            {
                //_streaming = false;
                //_capture = new Capture();

                {
                    //Task.Run(() =>
                    //{
                    if (_fpScanner == null)
                    {
                       // OpenSelectFGDialog();
                       // runNextPhase = true;

                        throw new Exception("Device not connected..");
                    }
                    //}).Wait();
                    else
                    {
                        //CloseScanner();
                        //connect_Device();
                        //_fpScanner = FingerPrintScanner;
                        //Task.Run(() =>
                        //{
                        if (!EnterUsernameForm_hidden)
                        {
                            //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis);
                            //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis,
                            enterUsernameWindow = new EnterUsernameWindow_new(true, this);
                            //enterUsernameWindow.Owner = this;
                            enterUsernameWindow.Activate();
                            var dg = enterUsernameWindow.ShowDialog();

                        }
                        else
                        {
                            enterUsernameWindow.Activate();
                            enterUsernameWindow.reloadForm();
                            var ddg = enrollmentWindow.ShowDialog();
                        }
                        // var dg = enterUsernameWindow.ShowDialog();
                        //}).Wait();
                        //EnterUsernameWindow_new enterUsernameWindow = new EnterUsernameWindow_new(true);
                        ////enterUsernameWindow.Owner = this;
                        //var dg = enterUsernameWindow.ShowDialog();

                        if ((bool)enterUsernameWindow.DialogResponse.result) //this.Close();

                        {
                            try
                            {
                               _afis = new LocalAFIS();

                                if (!enrollForm_hidden)
                                {
                                    //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis);
                                    //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis,
                                    enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis,
                                       loggedin_staff, enterUsernameWindow.DialogResponse.enteredUsername, this);

                                    var ddg = enrollmentWindow.ShowDialog();
                                }
                                else
                                {
                                    enrollmentWindow.reloadForm(enterUsernameWindow.DialogResponse.enteredUsername);
                                    //var ddg = 
                                    enrollmentWindow.Show();
                                }
                            }
                            catch(Exception ex) {
                                AlertForm1 al = new AlertForm1(ex.Message, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error);
                                al.ShowDialog();

                            }

                        }


                    }
                    //testForm1 tf = new testForm1();
                    //tf.Show();
                }

                //).Wait();
            }
            catch (Exception ex)
            {
                //MetroMessageBox.Show(this,ex.ToString(), "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                AlertForm1 al = new AlertForm1(ex.Message, AlertForm1.AlertOptions.OK);
                al.ShowDialog();

                //MessageBox.Show(ex.ToString(), "Error");
                runNextPhase = false;
            }
            //return 1;

            // .ContinueWith((_)=>

            //if (runNextPhase)
            {
                // Task.Run(() =>
                //await Task.Run(() =>
                //StopCapturing();
                //ResetGUI();

                //DisplayMessage("User enrollment");
                //xamlListBoxUsers.SelectedIndex = -1; //Deselect User
                //Task.Factory.StartNew(() =>
                {
                    //try
                    //{
                    //    _afis = new LocalAFIS();
                    //    //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis);
                    //    EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis, loggedin_staff);
                    //    //enrollmentWindow.MdiParent = this;
                    //    enrollmentWindow.StartPosition = FormStartPosition.CenterScreen;
                    //    // EnrollmentWindow enrollmentWindow = new EnrollmentWindow(_fpScanner, _afis);
                    //    //enrollmentWindow.Owner = this;
                    //    //enrollmentWindow.Show();
                    //    enrollmentWindow.Show();
                    //}
                    //catch { }
                }
                //return 2;
                //).Wait();
            }

            //if (enrollmentWindow.DialogResult)
            ////if (enrollmentWindow.DialogResult.HasValue && enrollmentWindow.DialogResult.Value)
            //{
            //    UpdateUserList();
            //}

            //DisplayMessage("Select User to verify");
        }


        public void NewUserRegistraion_popup()
        {
            //if (!EnterUsernameForm_hidden)
            {
                //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis);
                //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis,
                enterUsernameWindow = new EnterUsernameWindow_new(true, this);
                //enterUsernameWindow.Owner = this;
                //var dg = enterUsernameWindow.ShowDialog();

            }
            //else
            //{
            //    enterUsernameWindow.reloadForm();
            //    //var ddg = enrollmentWindow.ShowDialog();
            //}
            var dg = enterUsernameWindow.ShowDialog();

            //EnterUsernameWindow_new enterUsernameWindow = new EnterUsernameWindow_new(true);
            ////enterUsernameWindow.Owner = this;
            //var dg = enterUsernameWindow.ShowDialog();

            if ((bool)enterUsernameWindow.DialogResponse.result) //this.Close();

            {
                try
                {
                   // _afis = new LocalAFIS();

                    if (!enrollForm_hidden)
                    {

                        //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis);
                        //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis,
                        enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis,
                           loggedin_staff, enterUsernameWindow.DialogResponse.enteredUsername, this);

                        var ddg = enrollmentWindow.ShowDialog();
                    }
                    else
                    {
                        enrollmentWindow.Activate();
                        enrollmentWindow.reloadForm(enterUsernameWindow.DialogResponse.enteredUsername);
                        var ddg = enrollmentWindow.ShowDialog();
                    }
                }
                catch { }

            }
        }





        private void btn_setupDevice_Click(object sender, EventArgs e)
        {
            // ic.setupDevices_new();
            // winforms.testForm1 fm = new testForm1();
            //fm.ShowDialog();

            try
            {
                //_streaming = false;
                //_capture = new Capture();
                OpenSelectFGDialog(true);
                //testForm1 tf = new testForm1();
                //tf.Show();
            }
            catch (Exception ex)
            {
                //AlertForm1 al = new AlertForm1("Kindly connect your fingerprint Device and Retry"
                //      , AlertForm1.AlertType.success, "No device selected", "RETRY");
                AlertForm1 al = new AlertForm1(ex.ToString(), AlertForm1.AlertOptions.OK);
                al.ShowDialog();

                //if (!al.rDialogResult)


                //MessageBox.Show(ex.ToString(), "Error");
            }


        }

        private void sideForm1_Load(object sender, EventArgs e)
        {
            // connect_Device();
        }

        private void sideForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CloseScanner();
                Dispose();
            }
            catch { }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {

            //DialogResult msg = MessageBox.Show("Are you sure you want to Delete All Records....",
            //                  "Reset Database Records...",
            //                  MessageBoxButtons.OKCancel,
            //                  MessageBoxIcon.Warning);

            AlertForm1 al = new AlertForm1("Are you sure you want to Delete All Records....",
                AlertForm1.AlertOptions.YESNO,
                AlertForm1.AlertType.success,
                                "Reset Database Records...");
            var aa = al.ShowDialog();

            if (al.rDialogResult)

            //if (msg == DialogResult.OK)
            {

                try
                {
                    //StopCapturing();
                    _afis = new LocalAFIS();
                    System.IO.Directory.Delete(_afis.StoragePath, true);

                    //Added to mimick same behavior in database table
                    Utils.truncate_tables();
                    //UpdateUserList();
                    //ResetGUI();
                    DisplayError("Reset Completed............");

                }
                catch (Exception ex)
                {
                    DisplayError(ex.Message);
                }
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            winforms.IdentityForm1 fm = new IdentityForm1();
            fm.ShowDialog();
        }

        private async void btn_checkConnection_Click(object sender, EventArgs e)
        {
            //string addr = @"http://192.168.8.109/sam/ptmfb/testubasvccc/";

            //Properties.Settings.Default.webAPIAddress = txt_address.Text;
            //Properties.Settings.Default.Save();


            JToken str = await Task<JToken>.Run(() => Utils.call_WEBAPI_GETService("Establish_Serverconnection"));
            dynamic dd = new ExpandoObject();
            //dd = Newtonsoft.Json.JsonConvert.DeserializeObject(tmp.ToString());

            dd = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(str.ToString());


            bool ConnectionOK = (bool)dd.ConnectionOK;
            if (ConnectionOK)
            {
                AlertForm1 al = new AlertForm1("Connection established, WebAPI Address Saved Successfully...",
                    AlertForm1.AlertOptions.OK);
                al.ShowDialog();

                //MessageBox.Show("Connection established, WebAPI Address Saved Successfully...");
            }
            else
            {
                AlertForm1 al = new AlertForm1("Failed to establish connection...", AlertForm1.AlertOptions.OK);
                al.ShowDialog();

                //MessageBox.Show("Failed to establish connection...");
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void btn_verifyZF10_Click(object sender, EventArgs e)
        {
            bool runNextPhase = true;
            Task.Run(() =>
            {
                try
                {
                    //_streaming = false;
                    //_capture = new Capture();
                    if (_fpScanner == null)
                    {
                        OpenSelectFGDialog();
                    }
                    else
                    {
                        //CloseScanner();
                        connect_Device();
                        _fpScanner = FingerPrintScanner;
                    }
                    //testForm1 tf = new testForm1();
                    //tf.Show();
                }
                catch (Exception ex)
                {
                    runNextPhase = false;
                    AlertForm1 al = new AlertForm1(ex.ToString(), AlertForm1.AlertOptions.OK);
                    al.ShowDialog();



                    //MessageBox.Show(ex.ToString(), "Error");
                }
            }).Wait();


            if (runNextPhase)
            {
                VerifyZF10 fm = new VerifyZF10(_fpScanner);

                fm.Show();
            }
        }



       
        private void btn_verifyTemplate_Click(object sender, EventArgs e)
        {
            bool runNextPhase = true;
            //Task.Run(() =>
            Thread.Sleep(1000);
            {
                //try
                {
                    //_streaming = false;
                    //_capture = new Capture();
                    if (_fpScanner == null)
                    {
                        //OpenSelectFGDialog();
                        AlertForm1 al = new AlertForm1("Device is not connected", AlertForm1.AlertOptions.OK);
                        al.ShowDialog();
                        return;
                    }
                    try
                    {
                        //_afis = new LocalAFIS();

                        if (!VerifyForm_hidden)
                        {
                            //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis);
                            //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis,
                           // _VerifyWindow = new VerifyWindow(_fpScanner,this);
                            _VerifyWindow = new VerifyWindow(_fpScanner, this);
                            _VerifyWindow.Activate();
                            var ddg = _VerifyWindow.ShowDialog();
                        }
                        else
                        {
                            // VerifyWindow.reloadForm("Identification Request");
                            //var ddg = 
                            // _VerifyWindow.Show();
                            _VerifyWindow.Activate();
                            var ddg = _VerifyWindow.ShowDialog();
                        }
                    }
                    catch(Exception ex) {
                        AlertForm1 al = new AlertForm1(ex.ToString(), AlertForm1.AlertOptions.OK);
                        al.ShowDialog();


                    }
                }
                //catch (Exception ex)
                //{

                //    runNextPhase = false;
                //    AlertForm1 al = new AlertForm1(ex.ToString(), AlertForm1.AlertOptions.OK);
                //    al.ShowDialog();


                //    // MessageBox.Show(ex.ToString(), "Error");
                //}
            }
            //).Wait();

            //if (runNextPhase)
            //{
            //    VerifyZF10_template fm = new VerifyZF10_template(_fpScanner);

            //    fm.ShowDialog();
            //}
        }

        private void btn_CheckUser_Click(object sender, EventArgs e)
        {
            {
                //EnterUsernameWindow_new
                EnterUsernameWindow_new enterUsernameWindow =
                    new EnterUsernameWindow_new("Check using UserName");
                //enterUsernameWindow.Owner = this;
                enterUsernameWindow.ShowDialog();

            }

        }

        private void btn_resetData_Click(object sender, EventArgs e)
        {
            //DialogResult msg = MessageBox.Show("Are you sure you want to Delete All Records....",
            //                  "Reset Database Records...",
            //                  MessageBoxButtons.OKCancel,
            //                  MessageBoxIcon.Warning);

            AlertForm1 al = new AlertForm1("Are you sure you want to Delete All Records....",
                AlertForm1.AlertOptions.YESNO,
                AlertForm1.AlertType.success,
                                "Reset Database Records...");
            var aa = al.ShowDialog();

            if (al.rDialogResult)

            //if (msg == DialogResult.OK)
            {

                try
                {
                    //StopCapturing();
                    _afis = new LocalAFIS();
                    System.IO.Directory.Delete(_afis.StoragePath, true);

                    //Added to mimick same behavior in database table
                    Utils.truncate_tables();
                    //UpdateUserList();
                    //ResetGUI();
                    DisplayError("Reset Completed............");

                }
                catch (Exception ex)
                {
                    DisplayError(ex.Message);
                }
            }
        }

     
        private void btn_searchByIIN_Click(object sender, EventArgs e)
        {
            {
                //EnterUsernameWindow_new
                EnterUsernameWindow_IIN enterUsernameWindow =
                    new EnterUsernameWindow_IIN("Check using Internet ID number");
                //enterUsernameWindow.Owner = this;
                enterUsernameWindow.ShowDialog();

                //if (!enterUsernameWindow.nDialogResult) this.Close();
            }
        }



        private void btn_Identification_Click(object sender, EventArgs e)
        {
        
            bool runNextPhase = false;
            // Task.Factory.StartNew(() =>
            Thread.Sleep(1000);
            try
            {
                //_streaming = false;
                //_capture = new Capture();

                {
                    //Task.Run(() =>
                    //{
                    if (_fpScanner == null)
                    {

                        //MetroMessageBox.Show(this,ex.ToString(), "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        //AlertForm1 al = new AlertForm1("Device is not connected", AlertForm1.AlertOptions.OK);
                        //al.ShowDialog();
                        throw new Exception("Device is not connected");
                        //OpenSelectFGDialog();
                        //runNextPhase = true;
                        
                        //return;
                    }
                    //}).Wait();
                    else
                    {
                       

                        //if ((bool)enterUsernameWindow.DialogResponse.result) //this.Close();

                        {
                            try
                            {
                                _afis = new LocalAFIS();

                                if (!identifyForm_hidden)
                                {
                                    //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis);
                                    //EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis,
                                    IdentifyWindow = new IdentificationWindow(_fpScanner, _afis,
                                       loggedin_staff, "Identification Request", this);

                                    //IdentifyWindow.Show();
                                    IdentifyWindow.Activate();
                                    var ddg = IdentifyWindow.ShowDialog();
                                }
                                else
                                {
                                    //IdentifyWindow.reloadForm("Identification Request");
                                    //var ddg = 

                                    //IdentifyWindow.Show();
                                    IdentifyWindow.Activate();
                                    var ddg = IdentifyWindow.ShowDialog();
                                }
                            }
                            catch (Exception ex)
                            {
                                AlertForm1 al = new AlertForm1(ex.ToString(), AlertForm1.AlertOptions.OK);
                                al.ShowDialog();


                            }
                        }


                    }
                    //testForm1 tf = new testForm1();
                    //tf.Show();
                }

                //).Wait();
            }
            catch (Exception ex)
            {
                //MetroMessageBox.Show(this,ex.ToString(), "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                AlertForm1 al = new AlertForm1(ex.Message, AlertForm1.AlertOptions.OK);
                al.ShowDialog();

                //MessageBox.Show(ex.ToString(), "Error");
                runNextPhase = false;
            }
 

     
        }

        private void btn_assignRoleBtns_Click(object sender, EventArgs e)
        {
            
        }


        private void btn_creatUser_Click(object sender, EventArgs e)
        {
            frm_createUSERS fm = new frm_createUSERS(this);
            var ar = fm.ShowDialog();
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            AvayaDBSettings fm = new AvayaDBSettings();
            fm.ShowDialog();
        }
    }
}
