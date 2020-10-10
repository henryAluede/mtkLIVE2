using Dermalog.Imaging.Capturing;
using DermalogMultiScannerDemo.winforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermalogMultiScannerDemo
{
    public partial class SelectFGWindow_new : MetroFramework.Forms.MetroForm  // Form   //
    {
        public SelectFGWindow_new()
        {
            //this.Owner = owner;

            NewMethod_InitializeComponent();


            //InitializeComponent();

            //displayMessage("Select Frame-Grabber");
            //xamlButtonOK.Enabled = false;

            //DeviceIdentity[] dis = FPScanner.GetDevices();
            //xamlListBoxFG.DataSource = dis;

        }

        /// <summary>
        /// DeviceIdentity of the selected Frame-Grabber
        /// </summary>
        public DeviceIdentity SelectedDeviceIdentity { get; set; }

        public SelectFGWindow_new(MainForm owner)
        {
            this.Owner = owner;

            NewMethod_InitializeComponent();


            //InitializeComponent();

            //displayMessage("Select Frame-Grabber");
            //xamlButtonOK.Enabled = false;

            //DeviceIdentity[] dis = FPScanner.GetDevices();
            //xamlListBoxFG.DataSource = dis;
        }


        public SelectFGWindow_new(VerifyZF10 owner)
        {
            //this.Owner = owner;

            NewMethod_InitializeComponent();


            //InitializeComponent();

            //displayMessage("Select Frame-Grabber");
            //xamlButtonOK.Enabled = false;

            //DeviceIdentity[] dis = FPScanner.GetDevices();
            //xamlListBoxFG.DataSource = dis;
        }

        public SelectFGWindow_new(VerifyZF10_template owner)
        {
            //this.Owner = owner;

            NewMethod_InitializeComponent();


            //InitializeComponent();

            //displayMessage("Select Frame-Grabber");
            //xamlButtonOK.Enabled = false;

            //DeviceIdentity[] dis = FPScanner.GetDevices();
            //xamlListBoxFG.DataSource = dis;
        }

        public SelectFGWindow_new(winforms.MDIParent3 owner)
        {
            this.Owner = owner;
            NewMethod_InitializeComponent();


            //InitializeComponent();

            //displayMessage("Select Frame-Grabber");
            //xamlButtonOK.Enabled = false;

            //DeviceIdentity[] dis = FPScanner.GetDevices();
            //xamlListBoxFG.DataSource = dis;
        }

        public SelectFGWindow_new(winforms.sideForm1 owner)
        {

            //this.Owner = owner;
            //this.Parent = owner;

            NewMethod_InitializeComponent();
        }

        private async  void NewMethod_InitializeComponent()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;




            displayMessage("Select Frame-Grabber");
            xamlButtonOK.Enabled = false;

            DeviceIdentity[] dis = FPScanner.GetDevices();
            xamlListBoxFG.DataSource = dis;
            xamlListBoxFG.SelectedIndex = 0;

            if (xamlListBoxFG.Items.Count > 1)
            {
                //Show();
                DeviceIdentity selectedDI = (DeviceIdentity)xamlListBoxFG.SelectedItem; //Get selected Frame-Grabber
                this.SelectedDeviceIdentity = selectedDI;
                xamlButtonOK.Enabled = true;
                rDialogResult = true;
            }
            else if (xamlListBoxFG.Items.Count == 1)
            {
               Hide();
               //////////////////////////////////////////////////////////////
               //Dont alter this codes below, it will lead toerror
               int rr = await Task.Run(() =>
               {

                   DeviceIdentity selectedDI = (DeviceIdentity)xamlListBoxFG.SelectedItem; //Get selected Frame-Grabber
                    this.SelectedDeviceIdentity = selectedDI;
                    xamlButtonOK.Visible = false;
                    rDialogResult = true;
                    return 1;
                });
                this.Close();

                //////////////////////////////////////////////////////////////
            }
        }



        private void displayMessage(String message)
        {
            //Application.Current.Dispatcher.BeginInvoke((Action)(() =>
            {
                xamlLabelMessage.Text = message.ToUpper();
            }
            
            //));
        }

        public bool rDialogResult;
        private void xamlButtonOK_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.useExternalCamera = 0;
            //if (camToggle1.Checked)
            //{
            //    Properties.Settings.Default.useExternalCamera = 1;
            //}
            //Properties.Settings.Default.Save();



            rDialogResult = true;
            this.Close();
        }

        private void xamlListBoxFG_SelectionChanged(object sender, EventArgs e)
        {
            DeviceIdentity selectedDI = (DeviceIdentity)xamlListBoxFG.SelectedItem; //Get selected Frame-Grabber
            this.SelectedDeviceIdentity = selectedDI;

            xamlButtonOK.Enabled = true;
        }

        private void camToggle1_CheckedChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.useExternalCamera = 0;
            //if(camToggle1.Checked)
            //{
            //    Properties.Settings.Default.useExternalCamera = 1;
            //}
            //Properties.Settings.Default.Save();
        }

        private void xamlListBoxFG_Leave(object sender, EventArgs e)
        {
            DeviceIdentity selectedDI = (DeviceIdentity)xamlListBoxFG.SelectedItem; //Get selected Frame-Grabber
            this.SelectedDeviceIdentity = selectedDI;

            xamlButtonOK.Enabled = true;
        }
    }
}
