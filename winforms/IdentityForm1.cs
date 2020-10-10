using Dermalog.Afis.FingerCode3;
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
    public partial class IdentityForm1 : Form
    {
        public IdentityForm1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        LocalAFIS _afis ;
        private  void  btn_start_Click(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss"); 
            //var t = new Task(() => NewMethod());
            //NewMethod();
            //Task.Factory.StartNew(() => startTime(label1))
            //    .ContinueWith((_) => NewMethod())
            //    .ContinueWith((_) => startTime(label2))
            //    .ContinueWith((_) => startTime(label3))
            //    .ContinueWith((_) => NewMethod_verify())
            //    .ContinueWith((_) => endTime(label4))
            //    ;
            //t.Start();


            //Task.Factory.StartNew(() => startTime(label1))
            //   .ContinueWith((_) => NewMethod())
            //   .ContinueWith((_) => endTime(label2))
            //   ; 
            
            Task.Run(() => startTime(label1))
               .ContinueWith((_) => NewMethod())
               .ContinueWith((_) => endTime(label2))
               ;


        }


        private dynamic gen_FingerPrints(string refNO, Fingerprint fp)
        {
            dynamic verify_Result = new ExpandoObject(); 
            AFISVerificationResult result = new AFISVerificationResult();
            int threshold = Properties.Settings.Default.VerificationThreshold;
            //List<Fingerprint> fg = new List<Fingerprint>();
            using (tranxDataContext tx = new tranxDataContext())
            {
                tx.Connection.ConnectionString = Utils.getConnection();
                var fng = tx.fingerprint_Tables.Select(s => s).Where(w=>w.refNO==refNO);
                //lst_feedback.Items.Clear();
                //foreach (fingerprint_Table_verify templateFile in fng)
                Parallel.ForEach(fng, (templateFile, loopState) =>
                {

                    //lst_feedback.Items.Insert(0, templateFile.refNO);

                    byte[] data = Utils.convert_string2byteArray(templateFile.finger_data);

                    //String templateFileString = Path.GetFileNameWithoutExtension(templateFile);
                    String fingerPos = templateFile.position;

                    Fingerprint fingerprint = new Fingerprint();
                    fingerprint.Template = new Template();
                    fingerprint.Template.SetData(data, Dermalog.Afis.FingerCode3.Enums.TemplateFormat.Dermalog);
                    //fingerprint.Position = UInt32.Parse(fingerPos);
                    //fg.Add(fingerprint);

                    double dScore = new Matcher().Match(fingerprint.Template, fp.Template);
                    //double dScore = new Matcher().Match(userFingerprints[i].Template, fingerprints[j].Template);

                    if (dScore > threshold)
                    {
                        //dMaxScore = dScore;
                        result.Score = dScore; ;
                        result.Hit = true;
                        //return result;
                        verify_Result.found = true;
                        verify_Result.result = result;
                        verify_Result.fingerPos = fingerPos;
                        //tx.SubmitChanges();
                        //str.Append(user.Value.Name);
                        loopState.Stop();

                    }

                });
            }
            return verify_Result;
        }

        private void startTime(Label lb)
        {
            lb.Text = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss");
           // MessageBox.Show("completed............");
        }

        private void endTime(Label lb)
        {
            lb.Text = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss");
            MessageBox.Show("completed............");
        }
        private void NewMethod()
        {
            AFISVerificationResult result = new AFISVerificationResult();
            LocalUser user_found = new LocalUser();
            _afis = new LocalAFIS();
            Dictionary<long, LocalUser> userList = _afis.GetUserList();
            int threshold = Properties.Settings.Default.VerificationThreshold;
            //xamlListBoxUsers.Items.Clear();
            bool found = false; ;
            double matchValue = 0;


            List<Fingerprint> fg = new List<Fingerprint>();
            using (tranxDataContext tx = new tranxDataContext())
            {
                tx.Connection.ConnectionString = Utils.getConnection();
                var fng = tx.fingerprint_Table_verifies.Select(s => s);
                lst_feedback.Items.Clear();
                //foreach (fingerprint_Table_verify templateFile in fng)
                Parallel.ForEach(fng, templateFile =>
                {

                    lst_feedback.Items.Insert(0, templateFile.refNO);

                    byte[] data = Utils.convert_string2byteArray(templateFile.finger_data);

                    //String templateFileString = Path.GetFileNameWithoutExtension(templateFile);
                    String fingerPos = templateFile.position;

                    Fingerprint fingerprint = new Fingerprint();
                    fingerprint.Template = new Template();
                    fingerprint.Template.SetData(data, Dermalog.Afis.FingerCode3.Enums.TemplateFormat.Dermalog);
                    fingerprint.Position = UInt32.Parse(fingerPos);
                    fg.Add(fingerprint);

                    StringBuilder str = new StringBuilder();
                    Parallel.ForEach(userList, (user, loopState) =>
                    //Parallel.ForEach(userList, options, (user, loopState) =>
                    {

                        foreach (Fingerprint fd in user.Value.Fingerprints)
                        {
                            //str.Clear();
                            //xamlListBoxUsers.Items.Add(user);
                            double dScore = new Matcher().Match(fingerprint.Template, fd.Template);
                            //double dScore = new Matcher().Match(userFingerprints[i].Template, fingerprints[j].Template);

                            if (dScore > threshold)
                            {
                                //dMaxScore = dScore;
                                result.Score = dScore; ;
                                result.Hit = true;
                                //return result;
                                templateFile.identifiedAS = user.Value.Name;
                                //tx.SubmitChanges();
                                //str.Append(user.Value.Name);
                                loopState.Stop();

                            }
                        }
                        //result = _afis.IdentifyUser_New(user.Key, fg, Properties.Settings.Default.VerificationThreshold);
                        //result = _afis.IdentifyUser(user.Key, fingerprints_all, Properties.Settings.Default.VerificationThreshold);
                        //if (result.Hit)
                        {
                            //templateFile.identifiedAS = str.ToString();
                            //found = true;
                            //matchValue = result.Score;
                            //loopState.Stop();
                        }
                    });






                });
                tx.SubmitChanges();
            }
            //return "";
        }

        private void NewMethod_verify()
        {
            AFISVerificationResult result = new AFISVerificationResult();
            LocalUser user_found = new LocalUser();
            //_afis = new LocalAFIS();
            //Dictionary<long, LocalUser> userList = _afis.GetUserList();
            int threshold = Properties.Settings.Default.VerificationThreshold;
            //xamlListBoxUsers.Items.Clear();
            //bool found = false; ;
            //double matchValue = 0;


            //List<Fingerprint> fg = new List<Fingerprint>();
            using (tranxDataContext tx = new tranxDataContext())
            {
                tx.Connection.ConnectionString = Utils.getConnection();
                var fng = tx.fingerprint_Table_verifies.Select(s => s);
                lst_feedback2.Items.Clear();
                //foreach (fingerprint_Table_verify templateFile in fng)
                Parallel.ForEach(fng, templateFile =>
                {

                    lst_feedback2.Items.Insert(0, templateFile.refNO);

                    byte[] data = Utils.convert_string2byteArray(templateFile.finger_data);

                    //String templateFileString = Path.GetFileNameWithoutExtension(templateFile);
                    String fingerPos = templateFile.position;

                    Fingerprint fingerprint = new Fingerprint();
                    fingerprint.Template = new Template();
                    fingerprint.Template.SetData(data, Dermalog.Afis.FingerCode3.Enums.TemplateFormat.Dermalog);
                    fingerprint.Position = UInt32.Parse(fingerPos);
                    //fg.Add(fingerprint);

                    dynamic verifyme = gen_FingerPrints(templateFile.refNO, fingerprint);

                    templateFile.VerifiedAS = "NOT_Verified_OK";
                    if (verifyme.found)
                    {
                        templateFile.VerifiedAS = "VerifiedOK";
                    }
                  

                }
                
                );

                 tx.SubmitChanges();
            }
            //return "";
        }

        private void IdentityForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _afis = null;
            this.Dispose(true);

        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss"); 
            //var t = new Task(() => NewMethod());
            //NewMethod();
            //Task.Factory.StartNew(() => startTime(label3))
            //    .ContinueWith((_) => NewMethod_verify())
            //    .ContinueWith((_) => endTime(label4))
            //    ;

            Task.Run(() => startTime(label3))
                .ContinueWith((_) => NewMethod_verify())
                .ContinueWith((_) => endTime(label4))
                ;
            //t.Start();
        }

        private void IdentityForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
