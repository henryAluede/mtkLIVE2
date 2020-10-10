using Alertform;
using Newtonsoft.Json;
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
    public partial class frm_createUSERS : MetroFramework.Forms.MetroForm // Form
    {
        sideForm1 sf;
        public frm_createUSERS()
        {
            InitializeComponent();
        }

        public frm_createUSERS(sideForm1 ff)
        {
            InitializeComponent();
            sf = ff;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool check_if_Empty(string  str, string txtbox)
        {
            bool retval = false;
            if(!string.IsNullOrEmpty(str))
            {
                retval = true;
            }
            else
            {
                throw new Exception(txtbox + " cannot be empty...");
            }
            return retval;
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_if_Empty(txt_loginID.Text,"LoginID") && check_if_Empty(txt_staffname.Text,"Staff Name"))
                {
                    Save_AppUserData();
                }
            }
            catch(Exception ex)
            {
                AlertForm1 al = new AlertForm1(ex.Message, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.info);
                al.ShowDialog();

            }

        }

        private void Save_AppUserData()
        {
            dynamic NU = new ExpandoObject();
            NU.loginid = txt_loginID.Text;
            NU.staffname = txt_staffname.Text;
            NU.emailaddress = txt_emailaddress.Text;
            NU.state = cbo_state.Text;
            NU.location = cbo_location.Text;
            NU.role = cbo_role.Text;
            NU.status = chk_status.Checked ? "Activated" : "Pending";
            NU.createdBy = sf.loggedin_staff;

            object newUser = NU;

            string strREQ = Newtonsoft.Json.JsonConvert.SerializeObject(newUser);
            string strResponse = "";
            Task.Run(() =>
            {

                {
                    //displayMessage("Identifying Template File.....", Utils.COLOR_DERMALOG_RED);
                    strResponse = Utils.call_WEBAPI_Service("save_ApplicationUser", strREQ);
                }

            }
           ).Wait();

            //bool clientFound = false;
            dynamic dm = new ExpandoObject();
            dm = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(strResponse);

            string resp = dm.resp;

            AlertForm1 al = new AlertForm1(resp, AlertForm1.AlertOptions.OK, AlertForm1.AlertType.info);
            al.ShowDialog();

            // RefreshData();


            try
            {
                JObject ss = new JObject();
                ss = dm.dataset;
                DataSet dataSet = Newtonsoft.Json.JsonConvert.DeserializeObject<DataSet>(ss.ToString());

                //DataTable dataTable = 
                //object dd = dm.dataset;
                // dynamic cc = new ExpandoObject();
                // cc= JsonConvert.DeserializeObject<DataSet>((string)dm.dataset);

                // DataSet dss =  Newtonsoft.Json.JsonConvert.DeserializeObject<DataSet>(cc);
                // DataSet dss = (DataSet)((string)dm.dataset);
                //DGV_AppUsers.DataSource = ((DataSet)dm.dataset).Tables["Items"]; ;// dss.Tables["Items"]; ;
                DGV_AppUsers.DataSource = dataSet.Tables["Items"]; //dataTable;
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }

            ClearForm();
        }

        private void btn_save_Load(object sender, EventArgs e)
        {

        }

        private void frm_createUSERS_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            string strResponse = "";
            Task.Run(() =>
            {

                {
                    //displayMessage("Identifying Template File.....", Utils.COLOR_DERMALOG_RED);
                    strResponse = Utils.call_WEBAPI_GETService("Get_AppUsers");
                }

            }
           ).Wait();

            //bool clientFound = false;
            dynamic dm = new ExpandoObject();
            //dm = Newtonsoft.Json.JsonConvert.DeserializeObject<DataSet>(strResponse);
            DataSet dss = Newtonsoft.Json.JsonConvert.DeserializeObject<DataSet>(strResponse);

            DGV_AppUsers.DataSource = dss.Tables["Items"];

            //DataTable table2 = new DataTable("medications");
            //table2.Columns.Add("Login ID");
            //table2.Columns.Add("StaffName");
            //table2.Columns.Add("Email Address");
            //table2.Columns.Add("State");
            //table2.Columns.Add("Location");
            //table2.Columns.Add("Application Role");
            //table2.Columns.Add("Activation Status");
            //table2.Columns.Add("Created By");


            //table2 = dss.Tables["Items"];
            //DGV_AppUsers.DataSource = table2;

        }

        private void DGV_AppUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
      

        }

        public string check4Null(object ob)
        {
            string retval = "";
            if(!string.IsNullOrEmpty(ob.ToString()))
            {
                retval = ob.ToString();
            }

            return retval;
        }

        private void DGV_AppUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow NU = DGV_AppUsers.CurrentRow;
                //dynamic NU = new ExpandoObject();
                txt_loginID.Text = check4Null(NU.Cells[0].Value);
                txt_staffname.Text = check4Null(NU.Cells[1].Value);
                txt_emailaddress.Text = check4Null(NU.Cells[2].Value);
                cbo_state.Text = check4Null(NU.Cells[3].Value);
                cbo_location.Text = check4Null(NU.Cells[4].Value);
                cbo_role.Text = check4Null(NU.Cells[5].Value);
                chk_status.Checked = check4Null(NU.Cells[6].Value) == "Activated" ? true : false;
            }
            catch { }

        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txt_loginID.Text =
                        txt_staffname.Text =
                        txt_emailaddress.Text = "";
            cbo_state.SelectedIndex =
            cbo_location.SelectedIndex =
            cbo_role.SelectedIndex = 0;
            chk_status.Checked = false;
            txt_loginID.Focus();
        }
    }
}
