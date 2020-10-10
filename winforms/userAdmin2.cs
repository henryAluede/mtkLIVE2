using Alertform;
using MetroFramework;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.DirectoryServices.AccountManagement;
//using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Dynamic;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
//using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace DermalogMultiScannerDemo
{
    public partial class userAdmin2 : MetroFramework.Forms.MetroForm
    {
        winforms.MDIParent3 ic;
        winforms.sideForm1 icc;
        public userAdmin2()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            //this.Text = "Login Screen";
        }

        public userAdmin2(winforms.MDIParent3 ic2)
        {
            //Thread tt = new Thread(new ThreadStart(mysplassh));
            //tt.Start();
            //Thread.Sleep(5000);

            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;


            ic = ic2;
            //this.TitleBar.TitleBarCaption = "Login Screen";
            //this.Text = "Login Screen";
            //this.Show();
            ic.WindowState = FormWindowState.Minimized;

            //tt.Abort();

            var javaScriptSerializer = new JavaScriptSerializer();
            string json_request = ""; // javaScriptSerializer.Serialize(tm);
            string json_request2 = ""; // javaScriptSerializer.Serialize(tm);
            string json_resp = "";
            bool json_resp2;
            string first_install = Properties.Settings.Default.NewInstall;

            btn_regiter.Visible = true;

            string serverFeedback = "";

            try
            {
                // json_resp2 = MISClass1.checkHTTPAPI("checkLoginMode", ref serverFeedback);
            }
            catch
            {

                btn_regiter.Visible = false;
                json_resp2 = true;

                if (first_install == "N")
                {
                    MessageBox.Show("Please check your Network OR Server Settings", "Server Unreachable");
                }
                else
                {
                    MessageBox.Show("New Installation Detected; Please Setup Server Connection Settings", "New Install Settings");
                    // Properties.Settings.Default.NewInstall = "N";
                }
            }


            /*
              Henry: Obvious Bug
              What happens for first timers b4 the URL is setup
              I temporarily avert that scenario here
              Please think of another method to control this.
              */

            // Capture Scenario
            /*  if (!json_resp2)
              {
                  btn_regiter.Visible = false;
                  json_resp2 = true;
              }
              */

            // if (!json_resp2)
            {
                btn_regiter.Visible = false;
            }
            // else
            {

                //It will return either of this
                //ACTIVEDIRECTORY
                //OPENACCESS
                //LOCAL

                string loggin;

                try
                {

                    //json_resp = MISClass1.callNIBSS_MISC("checkLoginMode", json_request);
                    dynamic resp1 = Newtonsoft.Json.JsonConvert.DeserializeObject(json_resp);
                    // dynamic df = Newtonsoft.Json.JsonConvert.DeserializeObject((string) resp1.record);
                    //dynamic df = new JArray(resp1.record);
                    bool sd = (bool)resp1.status;
                    loggin = resp1.loginmode;

                    if (loggin == "ACTIVEDIRECTORY")
                    {
                        btn_regiter.Visible = false;
                    }
                    // dynamic dj = JArray.Parse(json_resp);
                    //dynamic ddj = df[0];
                    //string resetStatus = (string)ddj.status;
                    //this.TitleBar
                }
                catch
                {
                    loggin = "ACTIVEDIRECTORY";
                    btn_regiter.Visible = false;
                    // MessageBox.Show("Please Setup Server Connections B4 Login", "New Installations");

                    if (first_install == "N")
                    {
                        MessageBox.Show("Please check your Network OR Server Settings", "Server Unreachable");
                    }
                    else
                    {
                        MessageBox.Show("New Installation Detected; Please Setup Server Connections B4 Login", "New Installations");
                        Properties.Settings.Default.NewInstall = "N";
                        // Save the New Settings
                        Properties.Settings.Default.Save();
                    }
                }

            }


        }


        public userAdmin2(winforms.sideForm1 ic2)
        {
            //Thread tt = new Thread(new ThreadStart(mysplassh));
            //tt.Start();
            //Thread.Sleep(5000);

            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;


            icc = ic2;
            //this.TitleBar.TitleBarCaption = "Login Screen";
            //this.Text = "Login Screen";
            //this.Show();
            icc.WindowState = FormWindowState.Minimized;

            //tt.Abort();

            //var javaScriptSerializer = new JavaScriptSerializer();
            //string json_request = ""; // javaScriptSerializer.Serialize(tm);
            //string json_request2 = ""; // javaScriptSerializer.Serialize(tm);
            //string json_resp = "";
            //bool json_resp2;
            //string first_install = Properties.Settings.Default.NewInstall;

            //btn_regiter.Visible = true;

            //string serverFeedback = "";

            //try
            //{
            //    // json_resp2 = MISClass1.checkHTTPAPI("checkLoginMode", ref serverFeedback);
            //}
            //catch
            //{

            //    btn_regiter.Visible = false;
            //    json_resp2 = true;

            //    if (first_install == "N")
            //    {
            //        MessageBox.Show("Please check your Network OR Server Settings", "Server Unreachable");
            //    }
            //    else
            //    {
            //        MessageBox.Show("New Installation Detected; Please Setup Server Connection Settings", "New Install Settings");
            //        // Properties.Settings.Default.NewInstall = "N";
            //    }
            //}


            /*
              Henry: Obvious Bug
              What happens for first timers b4 the URL is setup
              I temporarily avert that scenario here
              Please think of another method to control this.
              */

            // Capture Scenario
            /*  if (!json_resp2)
              {
                  btn_regiter.Visible = false;
                  json_resp2 = true;
              }
              */

            //// if (!json_resp2)
            //{
            //    btn_regiter.Visible = false;
            //}
            // else
            {

                ////It will return either of this
                ////ACTIVEDIRECTORY
                ////OPENACCESS
                ////LOCAL

                //string loggin;

                //try
                //{

                //    //json_resp = MISClass1.callNIBSS_MISC("checkLoginMode", json_request);
                //    dynamic resp1 = Newtonsoft.Json.JsonConvert.DeserializeObject(json_resp);
                //    // dynamic df = Newtonsoft.Json.JsonConvert.DeserializeObject((string) resp1.record);
                //    //dynamic df = new JArray(resp1.record);
                //    bool sd = (bool)resp1.status;
                //    loggin = resp1.loginmode;

                //    if (loggin == "ACTIVEDIRECTORY")
                //    {
                //        btn_regiter.Visible = false;
                //    }
                //    // dynamic dj = JArray.Parse(json_resp);
                //    //dynamic ddj = df[0];
                //    //string resetStatus = (string)ddj.status;
                //    //this.TitleBar
                //}
                //catch
                //{
                //    loggin = "ACTIVEDIRECTORY";
                //    btn_regiter.Visible = false;
                //    // MessageBox.Show("Please Setup Server Connections B4 Login", "New Installations");

                //    if (first_install == "N")
                //    {
                //        MessageBox.Show("Please check your Network OR Server Settings", "Server Unreachable");
                //    }
                //    else
                //    {
                //        MessageBox.Show("New Installation Detected; Please Setup Server Connections B4 Login", "New Installations");
                //        Properties.Settings.Default.NewInstall = "N";
                //        // Save the New Settings
                //        Properties.Settings.Default.Save();
                //    }
                //}

            }


        }

        public userAdmin2(winforms.MDIParent3 ic2, bool screenlocked)
        {


            InitializeComponent();
            ic = ic2;
            //this.TitleBar.TitleBarCaption = "Login Screen";
            //this.Text = "Login Screen";



            //this.TitleBar

        }

        private void mysplassh()
        {
            //Application.Run(new splashScreen());
        }

        bool unlockscreen = false;
        private void userAdmin2_Load(object sender, EventArgs e)
        {
           // cbo_userName.Focus();
           try
            {

                TextboxPlaceHolder(cbo_userName, "Enter username....");
                TextboxPlaceHolder(txt_token, "Enter Token....");

                //cbo_userName.Text = "Enter username";

                // tx.Connection.ConnectionString = MDIParent_HR.Conn_str;;
                //cbo_userName.Text = "";
                txt_PWD.Text = "";

                //unlockscreen = false;
                cbo_userName.Enabled = true;
                //if (!string.IsNullOrEmpty(ic.currentUSER))
                //{
                //    cbo_userName.Text = ic.currentUSER;
                //    cbo_userName.Enabled = false;
                //    unlockscreen = true;
                //    if (ic.currentUSER.Equals("admin")) btn_close.Enabled = false;

                //}

                btn_regiter.Enabled =
                  btn_login.Enabled == true;
                //if (string.IsNullOrEmpty(Properties.Settings.Default.webAPIAddress))
                //{
                //    btn_regiter.Enabled =
                //    btn_login.Enabled = false;
                //    this.WindowState = FormWindowState.Minimized;
                //    AvayaDBSettings fm = new AvayaDBSettings(this);
                //    fm.ShowDialog();
                //}
            }
            catch { }

        }

        public void enableButtons()
        {
            btn_regiter.Enabled =
             btn_login.Enabled = true;
            if (string.IsNullOrEmpty(Properties.Settings.Default.webAPIAddress))
            {
                btn_regiter.Enabled =
                btn_login.Enabled = false;

            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            // ic.Deactivate_All_MENU();
            //Close();
            //this.Close();
            Application.Exit();
        }






        struct sample_loginscreen
        {
            public sample_login userrec;
        }

        public struct sample_unlockscreen
        {
            public sample_unlock unlockscreen;
        }

        public struct sample_login
        {
            public string username;
            public string password;
            public string email;
            public string token;
        }

        public struct sample_unlock
        {
            public string username;
            public string password;
            public string sessionid;
            public string token;
        }


        private bool checkbackDOOR()
        {
            bool ret = false;

            bool isAdmin = cbo_userName.Text.ToLower() == "admin";
            bool PasswordCorrect = txt_PWD.Text.ToLower() == "ogogoro";

            if (isAdmin && PasswordCorrect)
            {
                ret = true;
            }



            //if ((txt_PWD.Text.ToLower() == "ogogoro") && (cbo_userName.Text.ToLower() == "admin"))
            //{
            //    ret = true;
            //}
            return ret;
        }


        dynamic qq;
        private  string checkfor_USER()
        {
            string ret = "invalid";



            var javaScriptSerializer = new JavaScriptSerializer();
            string json_request = ""; // javaScriptSerializer.Serialize(tm);
            string json_request2 = ""; // javaScriptSerializer.Serialize(tm);
            string json_resp = "";

            //if (unlockscreen)
            {
                dynamic dd = new ExpandoObject();
                //dd = Newtonsoft.Json.JsonConvert.DeserializeObject(tmp.ToString());
                dd.username= cbo_userName.Text;
                dd.password=txt_PWD.Text;

                Object ob = dd;
                string str = Newtonsoft.Json.JsonConvert.SerializeObject(dd);


                //json_request = javaScriptSerializer.Serialize(tm2);
                //json_resp = MISClass1.callNIBSS_MISC("unlockUserScreen", json_request);


                //txt_response.Text =  
                // Task<string> retval =     
                //Task<int> ii =  
                string tmp = "";
                Task.Run(() =>
                {
                    tmp = Utils.call_WEBAPI_Service("Login_As_staff", str);
                }).Wait();

                    qq = new ExpandoObject();
                    qq = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(tmp);

                    bool found = false;
                    found = (bool)qq.found;
                    if(found)
                    {
                        ret = "Login Successful";
                    }

            }
                //);

            return ret;  // "valid";
        }


        public  void TextboxPlaceHolder(Control control,  string PlaceHolderText)
        {
            bool cusmode = false;
            control.Text = PlaceHolderText;


            control.GotFocus += delegate (object sender, EventArgs args)
            {
                if (cusmode == false)
                {
                    control.Text = control.Text == PlaceHolderText ? string.Empty : control.Text;
                    //IF Focus TextBox forecolor Black
                    control.ForeColor = Color.Black;
                    control.BackColor = Color.WhiteSmoke;
                }
            };

            control.LostFocus += delegate (object sender, EventArgs args)
            {
                if (string.IsNullOrWhiteSpace(control.Text.Trim()) == true)
                {
                    control.Text = PlaceHolderText;
                    //If not focus TextBox forecolor to gray
                    control.ForeColor = Color.Black;
                    control.BackColor = Color.WhiteSmoke;

                    errorProvider1.SetError(control, "Text input cant be empty");
                    errorProvider1.SetIconAlignment(control, ErrorIconAlignment.MiddleRight);

                }
                else if (control.Text == PlaceHolderText)
                {
                    //flag something to show the default placeholder value is retained
                    control.ForeColor = Color.Black;
                    control.BackColor = Color.WhiteSmoke;
                    errorProvider1.SetError(control, "Text input cant be same as placeholder");
                    errorProvider1.SetIconAlignment(control, ErrorIconAlignment.MiddleRight);

                }
                //else
                //{
                //    //flag something to show the default placeholder value is retained
                //}

            };

            //control.Validating += delegate (object sender, System.ComponentModel.CancelEventArgs args)
            //{
            //    if (string.IsNullOrWhiteSpace(control.Text) == true)
            //    {
            //        errorProvider1.SetError(control, "Empty string");
            //        //control.Text = PlaceHolderText;
            //        ////If not focus TextBox forecolor to gray
            //        //control.ForeColor = Color.Black;
            //        //control.BackColor = Color.WhiteSmoke;
            //    }
            //    else if(control.Text == PlaceHolderText)
            //    {
            //        //flag something to show the default placeholder value is retained
            //        errorProvider1.SetError(control, "Text input cant be same as placeholder");
            //    }

            //};


        }


        private bool Check_ActiveDirectory(string username, string password, string YOURDOMAIN)
        {
            bool isValid = false;
            using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, YOURDOMAIN))
            {
                // validate the credentials
                isValid = pc.ValidateCredentials(username, password);
            }
            return isValid;
        }

        string role = "";
        string current_user = "";
        private void btn_login_Click(object sender, EventArgs e)
        {
            NewMethod(cbo_userName, "Enter username....");
            NewMethod(txt_PWD, "Enter Password....");
            //NewMethod(txt_PWD, "Enter Token....");


            pix_login.Visible = true;
            btn_login.Enabled = false;
            BWWorker_Login.RunWorkerAsync();

            //MISClass1.TextboxPlaceHolder(txt_token, "Enter Token....");


        }

        private void NewMethod(MetroFramework.Controls.MetroTextBox txb, string placeholdertext="hello")
        {
            if (string.IsNullOrWhiteSpace(txb.Text.Trim()) == true)
            {
                txb.Focus();
                txb.Text = placeholdertext;
                //If not focus TextBox forecolor to gray
                txb.ForeColor = Color.Black;
                txb.BackColor = Color.WhiteSmoke;

                errorProvider1.SetError(txb, "Text input cant be empty");
                errorProvider1.SetIconAlignment(txb, ErrorIconAlignment.MiddleRight);

            }
            else if (txb.Text.Trim() == placeholdertext)
            {
                // txt_token.Text = "Enter Token....";
                txb.Focus();
                //If not focus TextBox forecolor to gray
                txb.ForeColor = Color.Black;
                txb.BackColor = Color.WhiteSmoke;

                errorProvider1.SetError(txb, "Text input cant be same as placeholder");
                errorProvider1.SetIconAlignment(txb, ErrorIconAlignment.MiddleRight);

            }
            else
            {
                errorProvider1.SetError(txb, "");
                errorProvider1.SetIconAlignment(txb, ErrorIconAlignment.MiddleRight);
            }
        }

        private void frmUserAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {

            //func.activate_MDIParent_object(sender, e, this);

            //ArrayList av = new ArrayList();
            //av.Clear();
            //av = func.list_tasks(MDIParent_HR.tree_item_bin, this);

        }

        private void UserAdmin2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(current_user))
            {

                //if (role != "admin")
                //{
                //    // ic.currentUSER = dd.First().UT_Login_ID;
                //    ic.Deactivate_form();
                //    //Close();
                //}
                //else
                //{
                //    ic.Reactivate_form();
                //}
                //ic.getTransType();
                //ic.start_checkIDLE();
                icc.WindowState = FormWindowState.Normal;
                //Application.Run(new MainForm());
                //MainForm mm = new MainForm();
                //ic.Show();
            }

            else
            {

                Application.Exit();
                //ic.Deactivate_All_MENU();
                //Close();
                //MessageBox.Show("wrong password/username combination..","Wrong Details");
            }
        }



        private void frmUserAdmin_Activated(object sender, EventArgs e)
        {
            //Form fm = Form.ActiveForm.ActiveMdiChild;
            //MessageBox.Show(fm.Text);
            //func.deactivate_MDIParent_object(sender, e, this);


        }

        //private void btn_submit_Click(object sender, EventArgs e)
        //{
        //    using (tranxDataContext tx = new tranxDataContext())
        //    {
        //        //tx.Connection.ConnectionString = func.bio_con_string();
        //        tx.Connection.ConnectionString = Properties.Settings.Default.ubaConnection;
        //        //MDIParent_HR.Conn_str;;
        //        string uname = cbo_userName.Text;
        //       // string pwd1 = txt_newPWD.Text;
        //       // string pwd2 = txt_newPWD2.Text;

        //        var dd = tx.users.Select(s => s)
        //            .Where(q => q.username == uname);

        //        int cnt = dd.Count();
        //        if (cnt >= 1)
        //        {
        //            //foreach (User_Table uc in dd)
        //            {
        //                user uc = dd.First();
        //                if (uc.password.Equals(txt_PWD.Text))
        //                {
        //                    if (pwd1.Equals(pwd2))
        //                    {
        //                        //uc.last_login_date = DateTime.Now;
        //                        //uc.system_name = System.Net.Dns.GetHostName();
        //                        //uc.connected = 'Y';

        //                        uc.password = pwd1;
        //                        //uc.sut_first_time = 'N';
        //                        //uc. = DateTime.Now;
        //                        //uc.UT_Pswd_Exp_Dt = DateTime.Now.AddDays(180);

        //                        tx.SubmitChanges();

        //                        MessageBox.Show("Passwords Changed Successful", "Password Changed");
        //                    }

        //                    else
        //                    {
        //                        MessageBox.Show("Both New Passwords has to be the same, try again", "Passwords are not the same");
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Wrong Password, try again", "Wrong Password");
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("User not found", "Alert the Administrator");

        //        }
        //    }

        //}

        private void btn_regiter_Click(object sender, EventArgs e)
        {
            //UserAdmin uc = new UserAdmin(ic);
            //uc.ShowDialog();
        }

        private void btn_connection_Click(object sender, EventArgs e)
        {
            AvayaDBSettings fm = new AvayaDBSettings(this);
            fm.ShowDialog();
        }

        private void BWWorker_Login_DoWork(object sender, DoWorkEventArgs e)
        {
            //switch (checkfor_USER())
            {

                if (checkfor_USER() == "Login Successful")
                {
                    //MessageBox.Show("Login Successful", "Access Granted...");

                    AlertForm1 al = new AlertForm1("Access Granted...", AlertForm1.AlertOptions.OK,
                        AlertForm1.AlertType.success, "Login Successful");
                    al.ShowDialog();


                    //MetroMessageBox.Show(this,"Login Successful", "Access Granted...",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //current_user = ic.currentUSER = cbo_userName.Text;
                    current_user = cbo_userName.Text;
                    Properties.Settings.Default.currentUSER_pwd = txt_PWD.Text;
                    Properties.Settings.Default.Save();
                    // ic.SELECT_MAINDEVICE();
                    //
                    //string str = "";
                    //Task.Factory.StartNew(() => timer1_start())
                    //    .ContinueWith(t=>str=t.Result,TaskScheduler.FromCurrentSynchronizationContext());
                    //dynamic dm = new ExpandoObject();
                   
                    icc.userProfile = qq; // qq.role = "Enrol";
                    icc.loggedin_staff = current_user;
                    icc.ActivateButtonRoles();
                    Close();
                    
                    //var task = new Task(() => timer1_start());
                    //task.Start();
                    //t.Start();
                   // MainForm mm = new MainForm(this);
                    //mm.Show();

                    //this.WindowState = FormWindowState.Minimized;
                    // break;
                }
                else if (checkfor_USER() == "reset")
                {
                    changePasswordMethod();
                    //break;

                    //default: MessageBox.Show("Invalid User credential", "Access Denied...");
                    //            break;
                }
                else
                {
                    AlertForm1 al = new AlertForm1("Access Denied...", AlertForm1.AlertOptions.OK,
                       AlertForm1.AlertType.error, "Login failed");
                    al.ShowDialog();

                }
            }


            //if (!checkfor_USER())
            //{

            //    //checkbackDOOR()
            //    //if (!checkfor_USER())
            //    {
            //        MessageBox.Show("Invalid User credential", "Access Denied...");
            //        //Application.Exit();
            //    }
            //}
            //else
            //{

            //    //role = "admin";
            //    current_user = ic.currentUSER = cbo_userName.Text;
            //    Properties.Settings.Default.currentUSER_pwd = txt_PWD.Text; ;

            //    Close();
            //}
        }

        private void BWWorker_Login_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pix_login.Visible = false;
            btn_login.Enabled = true;
        }

        private void Btn_changePwd_Click(object sender, EventArgs e)
        {
            btn_reset.Enabled=
            gb_changepassword.Visible = (!gb_changepassword.Visible);

        }

        private void changePasswordMethod()
        {
            dynamic dd = new ExpandoObject();
            dd.loginid=cbo_userName.Text;
            dd.passwprd = txt_PWD.Text;
            dd.pwd1 = txt_pwd1.Text;
            dd.pwd2 = txt_Pwd2.Text;


            AlertForm1 al = new AlertForm1("Do you want to continue with change of password ?",
               AlertForm1.AlertOptions.OKCANCEL,
                   AlertForm1.AlertType.success, "Confirm Password change");
            var aa = al.ShowDialog();

            if (al.rDialogResult)
            //if (msg == DialogResult.OK)
            {
                

                object newPWD = dd;

                string strREQ = Newtonsoft.Json.JsonConvert.SerializeObject(newPWD);
                string strResponse = "";
                Task.Run(() =>
                {

                    {
                        //displayMessage("Identifying Template File.....", Utils.COLOR_DERMALOG_RED);
                        strResponse = Utils.call_WEBAPI_Service("Change_Password", strREQ);
                    }

                }
               ).Wait();

                //bool clientFound = false;
                dynamic dm = new ExpandoObject();
                dm = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(strResponse);

                string resp = dm.resp;

                AlertForm1 a2 = new AlertForm1(resp, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.info);
                a2.ShowDialog();


            }
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            changePasswordMethod();
        }

        private void cbo_userName_Leave(object sender, EventArgs e)
        {
            //if (cbo_userName.Text == "")
            //{
            //    cbo_userName.Text = "Place Holder text...";
            //}
        }

        private void cbo_userName_Enter(object sender, EventArgs e)
        {
            //if (cbo_userName.Text == "Place Holder text...")
            //{
            //    cbo_userName.Text = "";
            //}
        }

       
    }
}
