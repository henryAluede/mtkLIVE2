using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ServiceProcess;
//using WindowsFormsApplication1.LINQSources;
using MetroFramework.Forms;
using System.Web.Script.Serialization;
using Microsoft.SqlServer.Management.Smo;
using System.Threading.Tasks;
using System.Dynamic;
using Newtonsoft.Json.Linq;
using Alertform;
using Microsoft.SqlServer.Management.Common;
using System.Configuration;
//using System.Configuration;


namespace DermalogMultiScannerDemo
{
    public partial class AvayaDBSettings : MetroForm // Form //
    {
      //  SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
        userAdmin2 fmm;
        public AvayaDBSettings()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public AvayaDBSettings(userAdmin2 fm)
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            fmm = fm;
        }

        public struct branch_Struct
        {
            public string M_CODTYPE { get; set; }
            public string M_CODKEY { get; set; }
            public string M_CODENAME { get; set; }
            public string MISC { get; set; }
            public string M_CREATEDATE { get; set; }
            public string M_CREATEPOINT { get; set; }
            public string M_CREATEUSER { get; set; }
            public string M_LASTUSERID { get; set; }
        }


        private void btn_refreshServer_Click(object sender, EventArgs e)
        {

            //SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;

            //List<string> dt = instance.GetDataSources();
            //getServerInstances();
            pictureBox1.Visible = true;
            backgroundWorker1.RunWorkerAsync();
 
           
        }

   

        private void getServerInstances()
        {
  
            try
            {
                ServiceController serv2 = new ServiceController("SQLBrowser");
                if (serv2.Status != ServiceControllerStatus.Running)
                {
                    serv2.Start();
                  
                }
            }
            catch { }

            //DataTable dataTable = SmoApplication.EnumAvailableSqlServers(false);
            DataTable dataTable = SmoApplication.EnumAvailableSqlServers();
            //DataTable dataTable2 = Microsoft.SqlServer.Management.Smo.;
            
            cb_datasource.ValueMember = "Name";
            cb_datasource.DataSource = dataTable;


        }

        private void btn_connection_Click(object sender, EventArgs e)
        {
           
            save_WebAPI_Address();
        }

        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            getServerInstances();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //comboBox1.Refresh();
            pictureBox1.Visible = false;
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();


            


        }

 


        private void btn_DBRefresh_Click(object sender, EventArgs e)
        {
           
            {
                string serverName = cb_datasource.SelectedValue.ToString();
                Server server = new Server(serverName);

                server.ConnectionContext.LoginSecure = false;
                server.ConnectionContext.Login = string.IsNullOrEmpty(txt_userID.Text) ? "sa" : txt_userID.Text;
                server.ConnectionContext.Password = txt_pwd.Text;
                //server.ConnectionContext.Password = "iworkformtk.123";


                cb_initialcatalog.Items.Clear();

                try
                {
                    foreach (Database db in server.Databases)
                    {

                        //comboBox2.ValueMember = "Server";
                        cb_initialcatalog.Items.Add(db.Name);
                    }
                }
                catch { }
            }

        }

        private   void btn_NIBBSAddr_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                //save_WebAPI_Address();
                Utils.get_templateFORMAT(cb_templateFormat);
            }).Wait(500);
        }



        private async void save_WebAPI_Address()
        {
            //string addr = @"http://192.168.8.109/sam/ptmfb/testubasvccc/";

            Properties.Settings.Default.useExternalCamera = 0;
            if (camToggle1.Checked)
            {
                Properties.Settings.Default.useExternalCamera = 1;
            }
            //Properties.Settings.Default.Save();

            Properties.Settings.Default.webAPIAddress = txt_address.Text;
            Properties.Settings.Default.ExternalAPIAddress = txt_externalAPI.Text;
            //Properties.Settings.Default.ConfigFolder = txt_configFile.Text;
            Properties.Settings.Default.ImageFolder = txt_imagefolder.Text;

            Properties.Settings.Default.Save();


            // Generate app value for the appcontrol table
            dynamic ddvalue = new ExpandoObject();
            ddvalue.connectionString = Properties.Settings.Default.informetriQConnectionString;
            ddvalue.webAPIAddress=Properties.Settings.Default.webAPIAddress ;
            ddvalue.ExternalAPIAddress = Properties.Settings.Default.ExternalAPIAddress;
            ddvalue.TemplateFORMAT = Properties.Settings.Default.TemplateFORMAT;
            ddvalue.ImageFolder = Properties.Settings.Default.ImageFolder;
            //ddvalue.ConfigFolder = Properties.Settings.Default.ConfigFolder;

            object ob = ddvalue;
            string paramValue =    Newtonsoft.Json.JsonConvert.SerializeObject(ob);

            dynamic ddParam = new ExpandoObject();
            ddParam.paramName = "APPSETTINGS_"+Environment.MachineName;
            ddParam.paramValue = paramValue;

            ob = ddParam;
            string SaveParamValue = Newtonsoft.Json.JsonConvert.SerializeObject(ob);



            JToken strResp = await Task<JToken>.Run(() => Utils.call_WEBAPI_Service("Post_AppSettings_Value", SaveParamValue));
            dynamic ddResp = new ExpandoObject();
            //dd = Newtonsoft.Json.JsonConvert.DeserializeObject(tmp.ToString());

            ddResp = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(strResp.ToString());



            //JToken str = await Task<JToken>.Run(() => Utils.call_WEBAPI_GETService("Establish_Serverconnection"));
            //dynamic dd = new ExpandoObject();
            ////dd = Newtonsoft.Json.JsonConvert.DeserializeObject(tmp.ToString());

            //dd = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(str.ToString());


            //bool ConnectionOK = (bool) dd.ConnectionOK;
            //if (ConnectionOK)
            //{
            //    MessageBox.Show("Connection established, WebAPI Address Saved Successfully...");
            //}
            //else
            //{
            //    MessageBox.Show("Failed to establish connection...");
            //}


            //dynamic ddata = new ExpandoObject();
            //ddata.paramName = "connectionstring";
            //ddata.paramValue = Properties.Settings.Default.informetriQConnectionString;
            //object jt = ddata;
            //string strr = Newtonsoft.Json.JsonConvert.SerializeObject(jt);

            //JToken str = await Task<JToken>.Run(() => Utils.call_WEBAPI_Service("Save_ServerConfig", strr));
            //dynamic dd = new ExpandoObject();
            ////dd = Newtonsoft.Json.JsonConvert.DeserializeObject(tmp.ToString());

            //dd = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(str.ToString());


            bool ConnectionOK = (bool)ddResp.saved;
            if (ConnectionOK)
            {
                Properties.Settings.Default.VersionPlatform = (string)ddResp.platform;
                Properties.Settings.Default.Save();
                string msg = "Connection established, Configuration Saved Successfully...";
                //MessageBox.Show(msg);
                AlertForm1 al = new AlertForm1(msg);
                al.ShowDialog();
            }
            else
            {
                AlertForm1 al = new AlertForm1((string)ddResp.resp,AlertForm1.AlertOptions.OK,AlertForm1.AlertType.error);
                al.ShowDialog();
                //MessageBox.Show((string)dd.message);
            }

            pix_webSetting.Visible = false;

        }



        private void AvayaDBSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fmm != null)
            {
                fmm.enableButtons();
                fmm.WindowState = FormWindowState.Normal;
            }
        }

        private void AvayaDBSettings_Load(object sender, EventArgs e)
        {

            txt_address.Text = Properties.Settings.Default.webAPIAddress;
            lb_templateFormat.Text = Properties.Settings.Default.TemplateFORMAT;
            txt_externalAPI.Text = Properties.Settings.Default.ExternalAPIAddress;
            txt_imagefolder.Text = Properties.Settings.Default.ImageFolder;
            //getBranches();
        }

        private void getBranches()
        {
            try
            {
               // txt_address.Text = Properties.Settings.Default.NIBSSAddress;
                //groupBox1.Enabled = metroToggle_DB.Checked = Properties.Settings.Default.DB_Enabled;

                //string json_request = "";
                var javaScriptSerializer = new JavaScriptSerializer() { MaxJsonLength = 86753090 };
                //string json_resp = MISClass1.callNIBSS_MISC(@"getmiscodeparam/BRANCH", json_request);
                //List<branch_Struct> resp = javaScriptSerializer.Deserialize<List<branch_Struct>>(json_resp);
                //cb_branch.DataSource = resp.ToArray();


                cb_branch.ValueMember = "M_CODKEY";
                cb_branch.DisplayMember = "M_CODENAME";
                //cb_branch.Refresh();

               // if (!string.IsNullOrEmpty(Properties.Settings.Default.BranchName))
                {
                   // cb_branch.Text = Properties.Settings.Default.BranchName;
                }



            }
            catch (Exception ex)
            {
                string ss = ex.Message;
            }
        }

        private void MetroToggle_DB_CheckedChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.useExternalCamera = 0;
            if (camToggle1.Checked)
            {
                Properties.Settings.Default.useExternalCamera = 1;
            }
            Properties.Settings.Default.Save();
        }

        private void Cb_branch_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cb_branch.SelectedText))
            {
               // Properties.Settings.Default.BranchName = cb_branch.SelectedText;
               // Properties.Settings.Default.BranchValue = cb_branch.SelectedValue.ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void cb_templateFormat_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cb_templateFormat.Text))
            {
                // Properties.Settings.Default.BranchName = cb_branch.SelectedText;
                lb_templateFormat.Text=
                Properties.Settings.Default.TemplateFORMAT = cb_templateFormat.Text;
                Properties.Settings.Default.Save();
            }
        }

        private async void btn_downloadSettings_Click(object sender, EventArgs e)
        {
            pix_webSetting.Visible = true;
            dynamic ddParam = new ExpandoObject();
            ddParam.paramName = "APPSETTINGS";
           // ddParam.paramValue = paramValue;

            object ob = ddParam;
            string SaveParamValue = Newtonsoft.Json.JsonConvert.SerializeObject(ob);



            JToken strResp = await Task<JToken>.Run(() => Utils.call_WEBAPI_Service("Get_AppSettings_Value", SaveParamValue));
            dynamic ddResp = new ExpandoObject();
            //dd = Newtonsoft.Json.JsonConvert.DeserializeObject(tmp.ToString());

            ddResp = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(strResp.ToString());

            if ((bool)ddResp.found)
            {
                dynamic ddvalue = new ExpandoObject();
                ddvalue = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>((string)ddResp.paramValue);


                //string informetriQConnectionString = ddvalue.connectionString;
                //string webAPIAddress = ddvalue.webAPIAddress;
                //string ExternalAPIAddress = ddvalue.ExternalAPIAddress;
                //string TemplateFORMAT = ddvalue.TemplateFORMAT;


                Properties.Settings.Default.informetriQConnectionString = ddvalue.connectionString;
                Properties.Settings.Default.webAPIAddress = ddvalue.webAPIAddress;
                Properties.Settings.Default.ExternalAPIAddress = ddvalue.ExternalAPIAddress;
                Properties.Settings.Default.TemplateFORMAT = ddvalue.TemplateFORMAT;

                txt_address.Text = Properties.Settings.Default.webAPIAddress;
                lb_templateFormat.Text = Properties.Settings.Default.TemplateFORMAT;
                txt_externalAPI.Text = Properties.Settings.Default.ExternalAPIAddress;

                Properties.Settings.Default.Save();
                string msg = "App Setting retrieved from server Successfully...";
                //MessageBox.Show(msg);
                AlertForm1 al = new AlertForm1(msg);
                al.ShowDialog();

            }
            else
            {
                string msg = "App Setting not found, Configure application ...";
                AlertForm1 al = new AlertForm1(msg,AlertForm1.AlertOptions.OK,AlertForm1.AlertType.error);
                al.ShowDialog();
            }

            pix_webSetting.Visible = false;
        }

        private void ch_useDirect_CheckedChanged(object sender, EventArgs e)
        {
            txt_serverSource.Enabled = txt_serverAddress.Enabled =  btn_testConnection.Enabled =ch_useDirect.Checked;
            //
            Properties.Settings.Default.CONNECTIONMODE = ch_useDirect.Checked?"1":"0";
            Properties.Settings.Default.Save();
        }

        private SqlConnection getNewSqlConnection(String ipadd, String UserName, String Password)
        {
            // server=tcp:servername, portnumber
            String connetionString = "";
           connetionString += " Data Source = " + ipadd + ",1433; Network Library = DBMSSOCN;"; // Initial Catalog = myDataBase;
            connetionString += "  User ID=" + UserName + "; Password=" + Password + ";";
  
            SqlConnection connection = new SqlConnection(connetionString);
            return connection;
        }


        private void btn_testConnection_Click(object sender, EventArgs e)
        {
            NewServerConnetionMethod();

        }

        private void NewServerConnetionMethod(bool suppressMsg=false)
        {
            try
            {
                string serverName;       // = comboBox1.SelectedValue.ToString() ;
                Server server;
                Boolean cmanualflag = ch_useDirect.Checked;

                serverName = ((cb_datasource.Items.Count == 0) ? "" : cb_datasource.SelectedValue.ToString());

                if ((serverName.Trim() == "") || (cmanualflag))
                {
                    serverName = txt_serverAddress.Text.Trim();    //      ToString();
                    SqlConnection sqlj = getNewSqlConnection(serverName, txt_userID.Text, txt_pwd.Text);
                    ServerConnection scip = new ServerConnection(sqlj);


                    String dbname = txt_serverSource.Text.Trim();
                    String con_str = ConfigurationManager.ConnectionStrings["APPDIRECT"].ConnectionString;
                    String con_str1 = con_str.Replace("SERVERNAME", serverName);
                    con_str1 = con_str1.Replace("DBNAME", dbname);
                    con_str1 = con_str1.Replace("USERNAME", txt_userID.Text.Trim());
                    con_str1 = con_str1.Replace("PASSWORD", txt_pwd.Text.Trim());

                    Properties.Settings.Default.informetriQConnectionString = con_str1;
                    // MessageBox.Show(con_str1);
                    txt_connection.Text= con_str1;
                    Properties.Settings.Default.CONNECTIONMODE = "1";

                    Properties.Settings.Default.Save();

                    using (tranxDataContext tx = new tranxDataContext())
                    {
                        try
                        {
                            tx.Connection.ConnectionString = con_str1;
                            int ii = tx.ExecuteCommand(string.Format("Exec testtesttesttest '{0}'", txt_userID.Text));
                            tx.SubmitChanges();
                            if (!suppressMsg)
                            {
                                AlertForm1 al = new AlertForm1("Connection Successful...", AlertForm1.AlertOptions.OK, AlertForm1.AlertType.success);
                                al.ShowDialog();
                               //MessageBox.Show("Connection Successful");
                            }
                        }
                        catch (Exception ex)
                        {
                            if (!suppressMsg)
                            {
                                AlertForm1 al = new AlertForm1(ex.Message, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error);
                                al.ShowDialog();
                                //MessageBox.Show(ex.Message);
                            }
                        }
                    }


                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void NewServerConnetionMethod_NEW(bool suppressMsg = false)
        {
            try
            {
                string serverName;       // = comboBox1.SelectedValue.ToString() ;
                //Server server;
                Boolean cmanualflag = ch_useDirect.Checked;

                serverName = ((cb_datasource.Items.Count == 0) ? "" : cb_datasource.SelectedValue.ToString());

                if ((serverName.Trim() == "") || (cmanualflag))
                {
                    serverName = txt_serverAddress.Text.Trim();    //      ToString();
                    SqlConnection sqlj = getNewSqlConnection(serverName, txt_userID.Text, txt_pwd.Text);
                    ServerConnection scip = new ServerConnection(sqlj);


                    String dbname = txt_serverSource.Text.Trim();
                    String con_str = ConfigurationManager.ConnectionStrings["APPDIRECT"].ConnectionString;
                    String con_str1 = con_str.Replace("SERVERNAME", serverName);
                    con_str1 = con_str1.Replace("DBNAME", dbname);
                    con_str1 = con_str1.Replace("USERNAME", txt_userID.Text.Trim());
                    con_str1 = con_str1.Replace("PASSWORD", txt_pwd.Text.Trim());

                    Properties.Settings.Default.informetriQConnectionString = con_str1;
                    // MessageBox.Show(con_str1);
                    txt_connection.Text = con_str1;
                    Properties.Settings.Default.CONNECTIONMODE = "1";

                    Properties.Settings.Default.Save();


                    dynamic dd = new ExpandoObject();
                    dd.ConnectionString = con_str1;
                    dd.DB_userID = txt_userID.Text;
 
                    Object ob = dd;
                    string paramValue = Newtonsoft.Json.JsonConvert.SerializeObject(dd);


                    //txt_response.Text = Post(str);
                    //string txt_response = VERIFY_List_templateFormat(str);
                    //string txt_response = Utils.call_WEBAPI_Service("VERIFY_templateFormat", str);
                    string txt_response = await Task.Run(() => Utils.call_WEBAPI_Service("TEST_ServerConnectionSP", paramValue));
                    string sstr = txt_response;
                    dynamic dm = new ExpandoObject();
                    dm = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(sstr);

                    // MessageBox.Show((string)dm.msg);
                    if ((bool)dm.success)
                    {
                        AlertForm1 al = new AlertForm1((string)dm.msg, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.success);
                        al.ShowDialog();
                    }
                    else
                    {
                        throw new Exception((string)dm.msg);
                    }
                }

            }
            catch (Exception ex)
            {
                AlertForm1 al = new AlertForm1(ex.Message, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error);
                al.ShowDialog();
            }
        }




        private void btn_getImageFolder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                
                Properties.Settings.Default.ImageFolder=
                txt_imagefolder.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void btn_DBConnection_Click(object sender, EventArgs e)
        {
            pix_webSetting.Visible = true;
            Properties.Settings.Default.CONNECTIONMODE = ch_useDirect.Checked ? "1" : "0";
            if (ch_useDirect.Checked && string.IsNullOrEmpty(cb_datasource.Text))
            {
                NewServerConnetionMethod();
                //return;
            }
            else
            {
                string informetriQConnectionString = Properties.Settings.Default.informetriQConnectionString;
                //if (string.IsNullOrEmpty(informetriQConnectionString))
                {

                    SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
                    SqlConnectionStringBuilder cs2 = new SqlConnectionStringBuilder();

                    ////Properties.MDBSettings.Default.sys_password = txt_pwd.Text;
                    cs.InitialCatalog = cb_initialcatalog.Text;
                    ////cs.IntegratedSecurity = true;
                    //cs.InitialCatalog =  comboBox2.Text;

                    cs.UserID = "sa";
                    cs.Password = txt_pwd.Text;
                    ////cs.Password = "iworkformtk.123";
                    cs.DataSource = cb_datasource.Text;
                    //txt_connection.Text = cs.ConnectionString;
                    Properties.Settings.Default.informetriQConnectionString = cs.ConnectionString;
                    ////Properties.MDBSettings.Default.Save();
                    cs2 = cs;
                    cs2.Password = "xxxxxxxxxxxxx";
                    txt_connection.Text = cs2.ConnectionString;
                    ////cs.InitialCatalog = "iCONNECT3";
                    ////Properties.Settings.Default.NIBSSAddress = txt_address.Text;
                    ////Properties.Settings.Default.BranchName = cb_branch.Text;

                    Properties.Settings.Default.Save();

                    //getBranches();
                    ////Properties.MDBSettings.Default.iCONNECT3 = txt_connection2.Text = cs.ConnectionString;
                    //MessageBox.Show();
                    AlertForm1 al = new AlertForm1("Saved Successfully...", AlertForm1.AlertOptions.OK, AlertForm1.AlertType.success);
                    al.ShowDialog();
                }
            }
        }

        //private void btn_configFile_Click(object sender, EventArgs e)
        //{
        //    if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
        //    {

        //        Properties.Settings.Default.ConfigFolder =
        //        txt_configFile.Text = folderBrowserDialog2.SelectedPath;
        //        Properties.Settings.Default.Save();
        //    }
        //}

        private async void btn_Getsettings_Click(object sender, EventArgs e)
        {
            dynamic ddParam = new ExpandoObject();
            ddParam.paramName = "APPSETTINGS_" + Environment.MachineName;
            //ddParam.paramValue = paramValue;

            object  ob = ddParam;
            string SaveParamValue = Newtonsoft.Json.JsonConvert.SerializeObject(ob);
            Properties.Settings.Default.webAPIAddress = txt_address.Text;


            JToken strResp = await Task<JToken>.Run(() => Utils.call_WEBAPI_Service("Get_AppSettings_Value", SaveParamValue));
            dynamic ddvalue1 = new ExpandoObject();
            //dd = Newtonsoft.Json.JsonConvert.DeserializeObject(tmp.ToString());

            ddvalue1 = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(strResp.ToString());
            dynamic ddvalue = new ExpandoObject();
            ddvalue = JObject.Parse(ddvalue1.paramValue.ToString());
          
            bool ConnectionOK = (bool)ddvalue1.found;
            if (ConnectionOK)
            {
               

                // Generate app value for the appcontrol table
                //dynamic ddvalue = new ExpandoObject();
                Properties.Settings.Default.informetriQConnectionString = (string)ddvalue.connectionString;
                //txt_address.Text= Properties.Settings.Default.webAPIAddress = (string)ddvalue.webAPIAddress;
                Properties.Settings.Default.ExternalAPIAddress = (string)ddvalue.ExternalAPIAddress;
                Properties.Settings.Default.TemplateFORMAT = (string)ddvalue.TemplateFORMAT;
                 Properties.Settings.Default.ImageFolder = (string)ddvalue.ImageFolder;

                txt_externalAPI.Text = Properties.Settings.Default.ExternalAPIAddress ;
                lb_templateFormat.Text = Properties.Settings.Default.TemplateFORMAT ;
                txt_imagefolder.Text = Properties.Settings.Default.ImageFolder;

                //Properties.Settings.Default.ConfigFolder = (string)ddvalue.ConfigFolder;
                Properties.Settings.Default.VersionPlatform = (string)ddvalue.platform;
                Properties.Settings.Default.Save();
                string msg = "Connection established, Configuration Retrieved Successfully...";
                //MessageBox.Show(msg);
                AlertForm1 al = new AlertForm1(msg);
                al.ShowDialog();
            }
            else
            {
                string msg = "Connection failed......";
                AlertForm1 al = new AlertForm1(msg, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error);
                al.ShowDialog();
                //MessageBox.Show((string)dd.message);
            }

            pix_webSetting.Visible = false;
        }
    }
}
