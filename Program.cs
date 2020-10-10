using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermalogMultiScannerDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AvayaDBSettings_FEP());
            //Application.Run(new AvayaDBSettings());
            //Application.Run(new Form1());
            //Application.Run(new moveCDRFiles());
            //Application.Run(new Form_AYO());
            //Application.Run(new Form_BCP_UPLOAD());
            try
            {
                //Application.Run(new EnrollmentWindow_new());
                Application.Run(new winforms.sideForm1());
                //Application.Run(new winforms.captureForm1());
                //Application.Run(new winforms.Form_data());
            }
            catch(Exception ex) {

                string str = ex.Message;
            }
           
            //Application.Run(new frm_FEP_BCP());
            //Application.Run(new COPY_JOURNAL_Files());


        }
    }
}
