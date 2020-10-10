using MetroFramework.Forms;
using Microsoft.SqlServer.Management.Smo.Agent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.ServiceProcess.Design;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alertform
{
    public partial class AlertForm1 : MetroForm
    {
        public bool rDialogResult { get; set; }

        public AlertForm1(string message,AlertOptions alertbtn=AlertOptions.OK, AlertType alerttype=AlertType.success
            , string msgHeader = "Alert Message Box")
        {
            InitializeComponent();

            btn_ok.BackColor = Color.DarkSlateBlue;

            switch (alertbtn)
            {
               

                case AlertOptions.OK:
                    btn_cancel.Visible = false;
                    break;
                case AlertOptions.RETRYCANCEL:
                    btn_cancel.Text = "CANCEL";
                    btn_ok.Text = "RETRY";
                    break;
                case AlertOptions.YESNO:
                    btn_cancel.Text = "NO";
                    btn_ok.Text = "YES";
                    break;
                case AlertOptions.OKCANCEL:
                default:
                    break;
            }




            switch (alerttype)
            {
                case AlertType.success:
                    //this.Text = "Success " + "Alert Message Box";
                    panel1.BackColor = Color.Green;
                    lb_alert.ForeColor = Color.White;
                    btn_ok.BackColor = Color.DarkSlateBlue;
                    //SystemSounds.Exclamation.Play();
                    break;
                //case AlertType.info:
                //    this.Text = "Info " + "Alert Message Box";
                //    break;
                //case AlertType.warning:
                //    this.Text = "Warning " + "Alert Message Box";
                //    break;
                case AlertType.error:
                    panel1.BackColor = Color.DarkRed;
                    lb_alert.ForeColor = Color.White;
                    //SystemSounds.Asterisk.Play();
                    break;
                default:
                    panel1.BackColor = Color.SteelBlue;
                    lb_alert.ForeColor = Color.White;
                    //SystemSounds.Beep.Play();
                    break;
            }
            //if (ButtonNO == 1) btn_cancel.Visible = false;

          


            //btn_ok.Text = btntext;
            this.Text = msgHeader;
            lb_alert.Text = message;
        }

        private void showAnimation(Control cs)
        {
            bunifuTransition1.HideSync(cs, true);
            //bunifuTransition1.HideSync(cs, false, BunifuAnimatorNS.Animation.HorizBlind);
            //Thread.Sleep(2000);
            bunifuTransition1.ShowSync(cs, true);

        }


        public enum AlertType
        {
            success,info,warning,error
        }

        public enum AlertOptions
        {
            OKCANCEL,OK,RETRYCANCEL,YESNO
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            rDialogResult = false;
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            rDialogResult = true;
            Close();
        }

        private void AlertForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            showAnimation(panel1);
        }

        private void AlertForm1_Load(object sender, EventArgs e)
        {
            this.Top = -1*(this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
            ShowAlert.Start();
        }

        int interval = 0;
        private void ShowAlert_Tick(object sender, EventArgs e)
        {
            if(this.Top<60)
            {
                this.Top +=interval;
                interval += 2;

            }
            else
            {
                ShowAlert.Stop();
            }
        }
    }
}
