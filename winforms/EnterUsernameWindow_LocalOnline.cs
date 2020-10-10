using Alertform;
using DermalogMultiScannerDemo.winforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermalogMultiScannerDemo
{
    public partial class EnterUsernameWindow_LocalOnline :  MetroFramework.Forms.MetroForm // Form //
    {
        public  bool nDialogResult = false;
        public  dynamic DialogResponse = new  ExpandoObject();
        bool Feedback = true;
        EnrollmentWindow_new ic;
        sideForm1 sidebar_form;
        public string HintMsg="";

        public EnterUsernameWindow_LocalOnline()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            xamlButtonOK.Visible = false;
            Feedback = false;
            // xamlTextBoxUsername.Focus();
        }

        public EnterUsernameWindow_LocalOnline(string message)
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            HintMsg=xamlTextBoxUsername.HintText = message;
            xamlButtonOK.Visible = false;
            Feedback = false;
            // xamlTextBoxUsername.Focus();
        }

        public EnterUsernameWindow_LocalOnline(bool enroll)
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            //xamlButtonOK.Visible = false;
            //Feedback = false;
            // xamlTextBoxUsername.Focus();
        }

        public EnterUsernameWindow_LocalOnline(bool enroll, sideForm1 fm)
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            //xamlButtonOK.Visible = false;
            //Feedback = false;
            // xamlTextBoxUsername.Focus();
            sidebar_form = fm;
        }

        public EnterUsernameWindow_LocalOnline(EnrollmentWindow_new fm)
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            // xamlTextBoxUsername.Focus();
            ic = fm;
        }

       

        private String _username;
        public String Username
        {
            get { return _username; }
            set { _username = value; }
        }

       

        private void xamlButtonOK_Click(object sender, EventArgs e)
        {
            nDialogResult = false;
            //if (!Utils.check_usernames_exist(_username))
            String enteredUsername = xamlTextBoxUsername.Text.Trim();
            dynamic found = Utils.check_InternetID_exist(enteredUsername);

            //found.status = true;
            //found.idstring = ds2.idString;
            //found.username = ds2.username;
            //found.remark = "Enrolled Already";


            if (enteredUsername.Length == 0)
            {
                AlertForm1 al = new AlertForm1(found.remark, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error);
                al.ShowDialog();

                DialogResponse.result = false;
                //MessageBox.Show("Username must not be empty.");
            }
            else
            {
                if ((bool)found.status)
                {
                    if ((bool)found.enrolled)
                    {
                        string values = found.username;
                        string keyvalues = found.idstring;

                        //DialogResult rsp =  MessageBox.Show("Client already Enrolled......"+Environment.NewLine+"Username => "+values +
                        //     Environment.NewLine + "Internat ID Number => " + keyvalues,
                        //     "Duplicate Check",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);

                        nDialogResult = false;

                        AlertForm1 al = new AlertForm1(found.remark + Environment.NewLine + "Username => " + values +
                            Environment.NewLine + "Internat ID Number => " + keyvalues,
                            AlertForm1.AlertOptions.RETRYCANCEL, AlertForm1.AlertType.error, "Duplicate Check");
                        var aa = al.ShowDialog();

                        //Utils.show_ClientExist(enteredUsername);
                        DialogResponse.result = false;
                        if (!al.rDialogResult)
                        //if (rsp == DialogResult.Cancel)
                        {

                           this.Close();
                           // Hide();
                           // this.WindowState = FormWindowState.Minimized;
                           // sidebar_form.EnterUsernameForm_hidden = true;
                        }
                    }
                    else
                    {
                        //Clien data downloaded but yet to enroll
                        DialogResponse.result = true;
                        DialogResponse.enteredUsername = enteredUsername;
                        _username = enteredUsername;
                        //ic._username = enteredUsername;
                        //ic.enterUsernameWindow_return(enteredUsername);
                        //ic.loggedin_staff = lo;
                        nDialogResult = true;

                        AlertForm1 al = new AlertForm1(found.remark, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.info);
                        al.ShowDialog();

                        // Utils.show_ClientExist(enteredUsername);

                        this.Close();
                        // Hide();
                        // this.WindowState = FormWindowState.Minimized;
                        // sidebar_form.EnterUsernameForm_hidden = true;
                        //Utils.gen_barcode(pixBarcode, enteredUsername);
                    }
                }

                else
                {
                    DialogResponse.result = false;
                    DialogResponse.enteredUsername = enteredUsername;
                    _username = enteredUsername;
                    //ic._username = enteredUsername;
                    //ic.enterUsernameWindow_return(enteredUsername);
                    //ic.loggedin_staff = lo;
                    nDialogResult = true;


                    string msg = found.remark + Environment.NewLine + "Make sure you Download Online Data before you start Finger Capture..";



                    AlertForm1 al = new AlertForm1(msg, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.info);
                    al.ShowDialog();

                    // Utils.show_ClientExist(enteredUsername);

                    this.Close();
                    // Hide();
                    // this.WindowState = FormWindowState.Minimized;
                    // sidebar_form.EnterUsernameForm_hidden = true;
                    //Utils.gen_barcode(pixBarcode, enteredUsername);

                }

            }
        }

        private void EnterUsernameWindow_new_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ic.enterUsernameWindow_return(_username);
            DialogResponse.result = true;
            try
            {
               //if(Feedback) ic.genBarcode(_username);
               //if(sidebar_form!=null)
               // {
               //     sidebar_form.EnterUsernameForm_hidden = true;
               // }
            }
            catch { }

        }

        private void show_ClientExist()
        {
            //pix_login.Visible = true;
            String enteredUsername = xamlTextBoxUsername.Text.Trim();
            individual_data  strResponse = null;
            //Task.Run(() =>
            {

                {
                    // displayMessage("Verifying Template File.....", Utils.COLOR_DERMALOG_RED);
                    //string externalAPI = Properties.Settings.Default.ExternalAPIAddress;
                    //string servNAME = string.Format("infometriq-partner-api/individuals/{0}/username", enteredUsername);
                    //strResponse = Utils.call_External_WEBAPI_GETService(servNAME);
                    using (tranxDataContext tx = new tranxDataContext())
                    {
                        tx.Connection.ConnectionString = Utils.getConnection();
                        var ds = tx.individual_datas.FirstOrDefault(s => s.username == enteredUsername);
                        strResponse = ds;
                        //strResponse = Newtonsoft.Json.JsonConvert.SerializeObject(ds);
                    }
                    //strResponse = Utils.call_WEBAPI_GETService("infometriq-partner-api/individuals");
                }
            }
           //).Wait();


            //AlertForm1 fmm = new AlertForm1("Client Data Received Successfully.....");
            //fmm.ShowDialog();

            //pix_login.Visible = false;


            winforms.Form_data fm = new winforms.Form_data(strResponse,true);
            fm.ShowDialog();
        }


        public void reloadForm()
        {

            xamlTextBoxUsername.Text="";
            pixBarcode.Image = null;
            pixBarcode.Refresh() ;
            DialogResponse.result = true;
            Show();
            //lb_clientName.Text = enteredUsername;
            //genBarcode(enteredUsername);
        }

        private void btn_exist_Click(object sender, EventArgs e)
        {
            pix_busy.Visible = true;
            //if (!Utils.check_usernames_exist(_username))
            String enteredUsername = xamlTextBoxUsername.Text.Trim();
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

                    string values = found.username;
                    string keyvalues = found.idstring;

                    AlertForm1 al = new AlertForm1(found.remark + Environment.NewLine + "Username => " + values +
                        Environment.NewLine + "Internat ID Number => " + keyvalues, AlertForm1.AlertOptions.OK,
                        AlertForm1.AlertType.info, "Duplicate Check");
                    al.ShowDialog();

                   //Utils.show_ClientExist(enteredUsername);
                    Utils.show_ClientExist_Online(enteredUsername);
                    //MessageBox.Show("Client already Enrolled......" + Environment.NewLine + "Username => " + values +
                    //    Environment.NewLine + "Internat ID Number => " + keyvalues,
                    //    "Duplicate Check", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Utils.gen_barcode(pixBarcode, enteredUsername);
                    pix_busy.Visible = false;
                }
                else
                {

                    AlertForm1 al = new AlertForm1(found.remark, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.info);
                    al.ShowDialog();
                    Utils.show_ClientExist_Online(enteredUsername);

                    ///Utils.show_ClientExist(enteredUsername);
                    // MessageBox.Show("Username does not exist....");

                }


            }
          
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResponse.result = false;
            this.Close();
            // Hide();
            // this.WindowState = FormWindowState.Minimized;
            // sidebar_form.EnterUsernameForm_hidden = true;
        }

        private void EnterUsernameWindow_new_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(HintMsg))
            {
                xamlTextBoxUsername.HintText = HintMsg;
            }
        }

        private void btn_checkExistLocal_Click(object sender, EventArgs e)
        {
            pix_busy.Visible = true;
            //if (!Utils.check_usernames_exist(_username))
            String enteredUsername = xamlTextBoxUsername.Text.Trim();
            //dynamic found = Utils.check_InternetID_exist(enteredUsername);
           
            //found.status = true;
            //found.idstring = ds2.idString;
            //found.username = ds2.username;
            //found.remark = "Enrolled Already";

            if (string.IsNullOrEmpty(enteredUsername))
            {
                AlertForm1 al = new AlertForm1("Username must not be empty.", AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error);
                al.ShowDialog();
                //MessageBox.Show("Username must not be empty.");
            }
            else
            {
                Utils.show_ClientExist(enteredUsername);
                Utils.gen_barcode(pixBarcode, enteredUsername);

                pix_busy.Visible = false;
            }
        }
    }
}
