using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alertform;
using Dermalog.Imaging.Capturing;
//using DermalogMultiScannerDemo.Alertform;

namespace DermalogMultiScannerDemo
{
    public partial class SelectDeviceWindow_new :MetroFramework.Forms.MetroForm   // Form  //
    {
        public bool rDialogResult;
        public SelectDeviceWindow_new()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private DeviceIdentity _selectedDeviceIdentity;

        /// <summary>
        /// Selected Fingerprint Scanner
        /// </summary>
        public FPScanner FingerPrintScanner { get; internal set; }

        private Thread _thread;
       // private Task _thread2;

        public SelectDeviceWindow_new(DeviceIdentity selectedDeviceIdentity, MainForm owner)
        {
            _selectedDeviceIdentity = selectedDeviceIdentity;
            //this.pa = owner;

            InitializeComponent();

            this.Closing += SelectDeviceWindow_Closing;

            displayMessage("Loading Devices");
            xamlButtonOK.Enabled = false;

           _thread = new Thread(() =>
           //_thread = new Task(() =>
           {
               try
                {
                    DeviceInformations[] dinfos = FPScanner.GetAttachedDevices(_selectedDeviceIdentity); //Get all Fingerprint Scanners

                    //Display all Fingerprint-Scanners in GUI
                    // Application.Current.Dispatcher.BeginInvoke((Action)(() =>
                    {
                        xamlProgressBar.Visible = false;
                        displayMessage("Select Fingerprint-Scanner");
                        foreach (DeviceInformations dinfo in dinfos)
                        {
                            DeviceInfos di = new DeviceInfos(dinfo.index, dinfo.name);
                            xamlListBoxDevices.Items.Add(di);
                        }
                        if (xamlListBoxDevices.Items.Count > 0)
                        {
                            xamlListBoxDevices.SelectedIndex = 0;
                            
                        }

                        //Close();
                    }

                    //));
                    //NewMethodcaptureDevice_();

                }
                catch (Exception ex)
                {
                    //Application.Current.Dispatcher.BeginInvoke((Action)(() =>
                    {
                        rDialogResult = false;
                        MessageBox.Show(ex.Message, "ERROR");
                    }

                    //));
                }
            });
            _thread.Start();
            //Close();
        }
        public SelectDeviceWindow_new(DeviceIdentity selectedDeviceIdentity, VerifyZF10 owner)
        {
            _selectedDeviceIdentity = selectedDeviceIdentity;
            //this.pa = owner;
            NewMethod_selectDevice();
            //InitializeComponent();

            //this.Closing += SelectDeviceWindow_Closing;

            //displayMessage("Loading Devices");
            //xamlButtonOK.Enabled = false;

            //_thread = new Thread(() =>
            //{
            //    try
            //    {
            //        DeviceInformations[] dinfos = FPScanner.GetAttachedDevices(_selectedDeviceIdentity); //Get all Fingerprint Scanners

            //        //Display all Fingerprint-Scanners in GUI
            //        // Application.Current.Dispatcher.BeginInvoke((Action)(() =>
            //        {
            //            xamlProgressBar.Visible = false;
            //            displayMessage("Select Fingerprint-Scanner");
            //            foreach (DeviceInformations dinfo in dinfos)
            //            {
            //                DeviceInfos di = new DeviceInfos(dinfo.index, dinfo.name);
            //                xamlListBoxDevices.Items.Add(di);
            //            }
            //            if (xamlListBoxDevices.Items.Count > 0)
            //            {
            //                xamlListBoxDevices.SelectedIndex = 0;

            //            }

            //            //Close();
            //        }

            //        //));
            //        //NewMethodcaptureDevice_();

            //    }
            //    catch (Exception ex)
            //    {
            //        //Application.Current.Dispatcher.BeginInvoke((Action)(() =>
            //        {
            //            rDialogResult = false;
            //            MessageBox.Show(ex.Message, "ERROR");
            //        }

            //        //));
            //    }
            //});
            //_thread.Start();
            ////Close();
        }
        public SelectDeviceWindow_new(DeviceIdentity selectedDeviceIdentity, VerifyZF10_template owner)
        {
            _selectedDeviceIdentity = selectedDeviceIdentity;
            //this.pa = owner;
            NewMethod_selectDevice();

        }


        
        public SelectDeviceWindow_new(DeviceIdentity selectedDeviceIdentity, winforms.MDIParent3  owner)
        {
            _selectedDeviceIdentity = selectedDeviceIdentity;
            //this.pa = owner;

            InitializeComponent();

            this.Closing += SelectDeviceWindow_Closing;

            displayMessage("Loading Devices");
            xamlButtonOK.Enabled = false;

            _thread = new Thread(() =>
            {
                try
                {
                    DeviceInformations[] dinfos = FPScanner.GetAttachedDevices(_selectedDeviceIdentity); //Get all Fingerprint Scanners

                    //Display all Fingerprint-Scanners in GUI
                    // Application.Current.Dispatcher.BeginInvoke((Action)(() =>
                    {
                        xamlProgressBar.Visible = false;
                        displayMessage("Select Fingerprint-Scanner");
                        foreach (DeviceInformations dinfo in dinfos)
                        {
                            DeviceInfos di = new DeviceInfos(dinfo.index, dinfo.name);
                            xamlListBoxDevices.Items.Add(di);
                        }
                        if (xamlListBoxDevices.Items.Count > 0)
                        {
                            xamlListBoxDevices.SelectedIndex = 0;

                        }

                        //Close();
                    }

                    //));
                    //NewMethodcaptureDevice_();

                }
                catch (Exception ex)
                {
                    //Application.Current.Dispatcher.BeginInvoke((Action)(() =>
                    {
                        rDialogResult = false;
                        MessageBox.Show(ex.Message, "ERROR");
                    }

                    //));
                }
            });
            _thread.Start();
            //Close();
        }

        public  SelectDeviceWindow_new(DeviceIdentity selectedDeviceIdentity, winforms.sideForm1 owner)
        {
            _selectedDeviceIdentity = selectedDeviceIdentity;
            //this.pa = owner;

            NewMethod_selectDevice();
        }

        private  void NewMethod_selectDevice()
        {
            InitializeComponent();

            this.Closing += SelectDeviceWindow_Closing;

            displayMessage("Loading Devices");
            xamlButtonOK.Enabled = true;

            //_thread = new Thread(() =>
             Task.Run(() =>
            {
                try
                {
                    DeviceInformations[] dinfos = FPScanner.GetAttachedDevices(_selectedDeviceIdentity); //Get all Fingerprint Scanners

                    //Display all Fingerprint-Scanners in GUI
                    // Application.Current.Dispatcher.BeginInvoke((Action)(() =>
                    {
                        xamlProgressBar.Visible = false;
                        displayMessage("Select Fingerprint-Scanner");
                        foreach (DeviceInformations dinfo in dinfos)
                        {
                            DeviceInfos di = new DeviceInfos(dinfo.index, dinfo.name);
                            xamlListBoxDevices.Items.Add(di);
                        }
                        if (xamlListBoxDevices.Items.Count > 1)
                        {
                            xamlListBoxDevices.SelectedIndex = 0;
                            //NewMethodcaptureDevice_();
                            //xamlButtonOK.Enabled = true;
                        }
                        else if (xamlListBoxDevices.Items.Count == 1)
                        {
                            this.Hide();
                            xamlListBoxDevices.SelectedIndex = 0;
                            //xamlButtonOK.Enabled = false;
                            NewMethodcaptureDevice_();


                        }
                        else if (xamlListBoxDevices.Items.Count == 0)
                        {
                            this.Hide();
                            //xamlListBoxDevices.SelectedIndex = 0;
                            //xamlButtonOK.Enabled = false;
                            //NewMethodcaptureDevice_();
                            throw new Exception("No device Detected, make sure Scanner is attached and retry");
                            //rDialogResult = false;
                        }


                        //Close();
                    }

                    //));
                    //NewMethodcaptureDevice_();

                }
                catch (Exception ex)
                {
                    //Application.Current.Dispatcher.BeginInvoke((Action)(() =>
                    {
                        rDialogResult = false;

                        AlertForm1 al = new AlertForm1(ex.Message,
                        AlertForm1.AlertOptions.OK
                        , AlertForm1.AlertType.error, "ERROR Encountered");
                         al.ShowDialog();

                        //MessageBox.Show(ex.Message, "ERROR Encountered",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Close();
                    }

                    //));
                }
            }).Wait(500);
            //_thread.Start();
            //Close();
        }

        void SelectDeviceWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_thread != null)
            {
                _thread.Abort();
                //_thread.Join();
            }

            //Close();
        }

        private void displayMessage(String message)
        {
            // Application.Current.Dispatcher.BeginInvoke((Action)(() =>
            {
                xamlLabelMessage.Text = message.ToUpper();
            }
            //));
        }

        private void xamlButtonOK_Click(object sender, EventArgs e)
        {
            NewMethodcaptureDevice_();
        }

        private void NewMethodcaptureDevice_()
        {
           
                Task.Run(() =>
                {
                    if (xamlListBoxDevices.SelectedIndex >= 0)
                    {
                        DeviceInfos selectedDInfos = xamlListBoxDevices.SelectedItem as DeviceInfos; //Get selected Fingerprint Scanner
                                                                                                     // DeviceInfos selectedDInfos = xamlListBoxDevices.SelectedValue as DeviceInfos; //Get selected Fingerprint Scanner
                        if (selectedDInfos != null)
                        {
                            var _preCursor = this.Cursor;
                            try
                            {
                                this.Cursor = Cursors.WaitCursor; //.Wait;
                                FingerPrintScanner = FPScanner.GetFPScanner(_selectedDeviceIdentity, selectedDInfos.Index);
                                rDialogResult = true;
                            }
                            catch (Exception ex)
                            {

                                AlertForm1 al = new AlertForm1(ex.Message, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error);
                                al.ShowDialog();

                                //MessageBox.Show(ex.Message, "ERROR");
                            }
                            finally
                            {
                                this.Cursor = _preCursor;
                                this.Close();
                            }
                        }
                    }
                });
           
            
        }

        private void xamlListBoxDevices_SelectionChanged(object sender, EventArgs e)
        {
            xamlButtonOK.Enabled = true;
        }

        private void btn_retry_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    public class DeviceInfos
    {
        private int mIndex;
        public int Index
        {
            get { return mIndex; }
            set { mIndex = value; }
        }

        private String mName;
        public String Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public DeviceInfos(int index, string name)
        {
            this.Index = index;
            this.Name = name;
        }

        public override string ToString()
        {
            return mName;
        }
    }



