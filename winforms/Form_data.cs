using Alertform;
using Microsoft.SqlServer.Management.SqlParser.Common;
using Newtonsoft.Json.Linq;
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

namespace DermalogMultiScannerDemo.winforms
{
    public partial class Form_data :  MetroFramework.Forms.MetroForm //Form  //  
    {
        public Form_data()
        {
            InitializeComponent();
           

        }

        private void NewMethod_callService(string strResponse)
        {
            
            try
            {

                dynamic dm = new ExpandoObject();
                //dm = JObject.Parse((string)Newtonsoft.Json.JsonConvert.DeserializeObject(strResponse));
                dm = Newtonsoft.Json.JsonConvert.DeserializeObject(strResponse);

                string id = dm.data.individual.id;
                lb_firstname.Text = dm.data.individual.first_name;
                lb_lastname.Text = dm.data.individual.last_name;
                //txt_username.Text = 
                lb_username.Text = dm.data.individual.username;
                lb_email.Text = dm.data.individual.email;
                lb_DOB.Text = DateTime.Parse((string)dm.data.individual.dob).ToString("MMMM dd yyyy");
                //txt_state.Text = dm.data.individual.state;
                lb_country.Text = dm.data.individual.country;
                //txt_profession.Text = dm.data.individual.profession;
                lb_profession.Text = dm.data.profession_name;
                //string about = dm.data.individual.about;
                lb_phone.Text = dm.data.individual.phone;
                //string website = dm.data.individual.website;
                lb_gender.Text = dm.data.individual.gender;
                string confirmation_code = dm.data.individual.confirmation_code;
                lb_confirmationCode.Text = dm.data.individual.confirmation_code;
                //string social_facebook = dm.data.individual.social_facebook;
                //string social_twitter = dm.data.individual.social_twitter;
                //string social_instagram = dm.data.individual.social_instagram;
                //string social_linkedin = dm.data.individual.social_linkedin;
                //string social_youtube = dm.data.individual.social_youtube;
                //string politics = dm.data.individual.politics;
                // string recognition = dm.data.individual.recognition;
                //string hide_dob = dm.data.individual.hide_dob;
                lb_accountType.Text = dm.data.individual.account_type;
                lb_status.Text = dm.data.individual.status;
                lb_verifiedStatus.Text = dm.data.individual.verified_status;
                lb_createDT.Text = DateTime.Parse((string)dm.data.individual.created_on).ToString("MMMM dd yyyy");
                //string last_updated_on = dm.data.individual.last_updated_on;
                //string state_name = dm.data.individual.state_name;
                lb_state.Text = dm.data.individual.state_name;
                Pix_client.Image = Utils.Base64TOImage((string)dm.data.picture);
                Pix_client.Refresh();
                genBarcode(confirmation_code);

                //Utils.showAnimation(Pix_client, bunifuTransition1);

            }
            catch (Exception ex) { }
        }
       
        
        //private void NewMethod_callService_local(individual_data individual)
       private void NewMethod_callService_local(individual_data individual)
        {

            try
            {

                dynamic dm = new ExpandoObject();
                ////dm = JObject.Parse((string)Newtonsoft.Json.JsonConvert.DeserializeObject(strResponse));
                dm = Newtonsoft.Json.JsonConvert.DeserializeObject(individual.strResponse);

                string id = individual.id;
                lb_firstname.Text = individual.first_name;
                lb_lastname.Text = individual.last_name;
                //txt_username.Text = 
                lb_username.Text = individual.username;
                lb_email.Text = individual.email;
                lb_DOB.Text = DateTime.Parse((string)individual.dob).ToString("MMMM dd yyyy");
                //txt_state.Text = dm.data.individual.state;
                lb_country.Text = individual.country;
                //txt_profession.Text = dm.data.individual.profession;
                lb_profession.Text = individual.profession_name;
                //string about = dm.data.individual.about;
                lb_phone.Text = individual.phone;
                //string website = dm.data.individual.website;
                lb_gender.Text = individual.gender;
                string confirmation_code = individual.confirmation_code;
                lb_confirmationCode.Text = individual.confirmation_code;
                //string social_facebook = dm.data.individual.social_facebook;
                //string social_twitter = dm.data.individual.social_twitter;
                //string social_instagram = dm.data.individual.social_instagram;
                //string social_linkedin = dm.data.individual.social_linkedin;
                //string social_youtube = dm.data.individual.social_youtube;
                //string politics = dm.data.individual.politics;
                // string recognition = dm.data.individual.recognition;
                //string hide_dob = dm.data.individual.hide_dob;
                lb_accountType.Text = individual.account_type;
                lb_status.Text = individual.status;
                lb_verifiedStatus.Text = individual.verified_status;
                lb_createDT.Text = DateTime.Parse((string)individual.created_on).ToString("MMMM dd yyyy");
                //string last_updated_on = dm.data.individual.last_updated_on;
                //string state_name = dm.data.individual.state_name;
                lb_state.Text = individual.state_name;
                Pix_client.Image = Utils.Base64TOImage((string)dm.data.picture);
                Pix_client.Refresh();
                genBarcode(confirmation_code);

                //Utils.showAnimation(Pix_client, bunifuTransition1);

            }
            catch (Exception ex) { }
        }

        private void NewMethod_callService2()
        {

            Task.Run(() =>
            {

                {
                    // displayMessage("Verifying Template File.....", Utils.COLOR_DERMALOG_RED);
                    strResponse = Utils.call_WEBAPI_GETService("infometriq-partner-api/individuals");
                   /// strResponse = Utils.call_WEBAPI_GETService("infometriq-partner-api/individuals");
                }
            }
            ).Wait();


            AlertForm1 fm = new AlertForm1("Client Data Received Successfully.....");
            fm.ShowDialog();

            pix_login.Visible = false;

            try
            {

                dynamic dm = new ExpandoObject();
                dm = JObject.Parse((string)Newtonsoft.Json.JsonConvert.DeserializeObject(strResponse));

                string id = dm.data.individual.id;
                lb_firstname.Text = dm.data.individual.first_name;
                lb_lastname.Text = dm.data.individual.last_name;
                //txt_username.Text = 
                lb_username.Text = dm.data.individual.username;
                lb_email.Text = dm.data.individual.email;
                lb_DOB.Text = DateTime.Parse((string)dm.data.individual.dob).ToString("MMMM dd yyyy");
                //txt_state.Text = dm.data.individual.state;
                lb_country.Text = dm.data.individual.country;
                //txt_profession.Text = dm.data.individual.profession;
                lb_profession.Text = dm.data.profession_name;
                //string about = dm.data.individual.about;
                lb_phone.Text = dm.data.individual.phone;
                //string website = dm.data.individual.website;
                lb_gender.Text = dm.data.individual.gender;
                string confirmation_code = dm.data.individual.confirmation_code;
                lb_confirmationCode.Text = dm.data.individual.confirmation_code;
                //string social_facebook = dm.data.individual.social_facebook;
                //string social_twitter = dm.data.individual.social_twitter;
                //string social_instagram = dm.data.individual.social_instagram;
                //string social_linkedin = dm.data.individual.social_linkedin;
                //string social_youtube = dm.data.individual.social_youtube;
                //string politics = dm.data.individual.politics;
                // string recognition = dm.data.individual.recognition;
                //string hide_dob = dm.data.individual.hide_dob;
                lb_accountType.Text = dm.data.individual.account_type;
                lb_status.Text = dm.data.individual.status;
                lb_verifiedStatus.Text = dm.data.individual.verified_status;
                lb_createDT.Text = DateTime.Parse((string)dm.data.individual.created_on).ToString("MMMM dd yyyy");
                //string last_updated_on = dm.data.individual.last_updated_on;
                //string state_name = dm.data.individual.state_name;
                lb_state.Text = dm.data.individual.state_name;
                Pix_client.Image = Utils.Base64TOImage((string)dm.data.picture);
                Pix_client.Refresh();
                genBarcode(confirmation_code);

                Utils.showAnimation(Pix_client, bunifuTransition1);

            }
            catch (Exception ex) { }
        }




        dynamic dmd = new ExpandoObject();
        public Form_data(dynamic data)
        {
            InitializeComponent();
            dmd = data;

            //dynamic dd = new ExpandoObject();
             //txt_fname.Text= dmd.firstname ;
            //txt_username.Text= dmd.username ;
             //txt_lastname.Text= dmd.lastname ;
            //dd.dob = DateTime.Now;

        }


        string _strResponse = "";
        public Form_data(string data)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            strResponse = data;

            NewMethod_callService(data);
            //dd.dob = DateTime.Now;

        }

        //public Form_data(string data,bool disableSave)
        //{
        //    Control.CheckForIllegalCrossThreadCalls = false;
        //    InitializeComponent();
        //    strResponse = data;

        //    if (disableSave) btn_save.Visible = false;

        //    NewMethod_callService(data);
        //    //dd.dob = DateTime.Now;

        //}

        public Form_data(individual_data data, bool disableSave)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //strResponse = data;

            if (disableSave) btn_save.Visible = false;

            //NewMethod_callService(data);
            NewMethod_callService_local(data);
            //dd.dob = DateTime.Now;

        }

        public void genBarcode(string str)
        {
            Utils.gen_barcode(pixBarcode, str);
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            Close();
        }


        string strResponse = "";
        private void Form_data_Load(object sender, EventArgs e)
        {
           

           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dynamic dm = new ExpandoObject();
            dm = Newtonsoft.Json.JsonConvert.DeserializeObject(strResponse);

            try
            {
                //individual_data ind =  Newtonsoft.Json.JsonConvert.DeserializeObject<individual_data>((string)dm.data.individual);
                //saveData(Newtonsoft.Json.JsonConvert.DeserializeObject(dm.data.individual));

                AlertForm1 fm = new AlertForm1("Do you want to save Client Data?",AlertForm1.AlertOptions.YESNO,AlertForm1.AlertType.info);
                var rst = fm.ShowDialog();

                if (fm.rDialogResult)
                {

                    dynamic ind = dm.data.individual;
                    //string profession_desc = dm.dataprofession_name;
                    //saveData(ind, profession_desc, strResponse);
                    if (ind != null)
                    {
                        dynamic newDM = new ExpandoObject();
                        JToken token = JToken.Parse(dm.data.individual.ToString());
                        newDM.Data = JObject.Parse(token.ToString());
                       
                        newDM.ProfessionDesc = dm.dataprofession_name;
                        token = JToken.Parse(strResponse);
                        newDM.strResponse =  JObject.Parse(token.ToString());
                        newDM.strResponse.data.individual.about =  newDM.Data.about = "Available Online";;

                        dynamic ind2 = new ExpandoObject();
                        ind2.mydata = newDM;
                        object rr = ind2;

                        string strBody = Newtonsoft.Json.JsonConvert.SerializeObject(rr);
                        string strResponse1 = "";
                        Task.Run(() =>
                        {
                            strResponse1 = Utils.call_WEBAPI_Service("submit_individualOnlineData", strBody);


                        }).Wait();

                        dynamic dmd = new ExpandoObject();
                        dmd = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(strResponse1);

                        if ((bool)dmd.ok)
                        {
                            AlertForm1 fm2 = new AlertForm1((string)dmd.Message, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.success);
                            var rst2 = fm2.ShowDialog();
                        }
                        else
                        {
                            throw new Exception((string)dmd.Message);
                        }
                    }
                    else
                    {
                        throw new Exception("Client Data cannot be empty");
                    }
                }
            }
            catch (Exception ex)
            {
                AlertForm1 fm = new AlertForm1(ex.Message, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error);
                var rst = fm.ShowDialog();
            }
        }

        private void saveData(dynamic dm,string Profession_desc, string strResponse)
        {
            //dynamic dm = new ExpandoObject();
            // individual_data ind = Newtonsoft.Json.JsonConvert.DeserializeObject<individual_data>(dd);
            //individual_data ind = dd;
            try
            {
                using (tranxDataContext tx = new tranxDataContext())
                {
                    tx.Connection.ConnectionString = Utils.getConnection();
                    string strUsername = dm.username;
                    var ds = tx.individual_datas.FirstOrDefault(s => s.username == strUsername);

                    if (ds == null)
                    {
                        individual_data ind = new individual_data();
                        ind.id = dm.id;
                        ind.first_name = dm.first_name;
                        ind.last_name = dm.last_name;
                        ind.username = dm.username;
                        ind.email = dm.email;
                        ind.dob = dm.dob;
                        ind.state = dm.state;
                        ind.country = dm.country;
                        ind.profession = dm.profession;
                        ind.about = dm.about;
                        ind.phone = dm.phone;
                        ind.website = dm.website;
                        ind.gender = dm.gender;
                        ind.confirmation_code = dm.confirmation_code;
                        ind.social_facebook = dm.social_facebook;
                        ind.social_twitter = dm.social_twitter;
                        ind.social_instagram = dm.social_instagram;
                        ind.social_linkedin = dm.social_linkedin;
                        ind.social_youtube = dm.social_youtube;
                        ind.politics = dm.politics;
                        ind.recognition = dm.recognition;
                        ind.hide_dob = dm.hide_dob;
                        ind.rating = dm.rating;
                        ind.status = dm.status;
                        ind.verified_status = dm.verified_status;
                        ind.created_on = dm.created_on;
                        ind.last_updated_on = dm.last_updated_on;
                        ind.state_name = dm.state_name;

                        ind.profession_name = Profession_desc;
                        ind.strResponse = strResponse;
                        ind.account_type = dm.account_type;
                        tx.individual_datas.InsertOnSubmit(ind);
                        tx.SubmitChanges();

                        AlertForm1 fm = new AlertForm1("Saved Successfully...", AlertForm1.AlertOptions.OK, AlertForm1.AlertType.success);
                        var rst = fm.ShowDialog();

                    }
                    else
                    {
                        AlertForm1 fm = new AlertForm1("User Details already saved...", AlertForm1.AlertOptions.OK, AlertForm1.AlertType.info);
                        var rst = fm.ShowDialog();
                        btn_save.Enabled = false;
                    }
                }
                
            }
            catch(Exception ex)
            {
                AlertForm1 fm = new AlertForm1(ex.Message, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.error);
                var rst = fm.ShowDialog();
            }

        }

        private void btn_getData_Click(object sender, EventArgs e)
        {
            pix_login.Visible = true;
            NewMethod_callService2();
        }
    }
}
