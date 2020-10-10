using Dermalog.Imaging.Capturing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermalogMultiScannerDemo.winforms
{
    public partial class MDIParent3 : Form
    {
        private int childFormNumber = 0;

        public FPScanner _fpScanner;
        public  LocalUser _selectedUser;
        public LocalAFIS _afis;
        public string currentUSER;
        public bool _streaming;
       // Capture _capture;

        public MDIParent3()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Hide();
            userAdmin2 fm = new userAdmin2(this);
            fm.ShowDialog();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void setupDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                //_streaming = false;
                //_capture = new Capture();
                OpenSelectFGDialog();
                //testForm1 tf = new testForm1();
                //tf.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        public void setupDevices_new()
        {
            try
            {
                //_streaming = false;
                //_capture = new Capture();
                OpenSelectFGDialog();
                //testForm1 tf = new testForm1();
                //tf.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void OpenSelectDeviceDialog(DeviceIdentity selectedDeviceIdentity)
        {
            //ResetGUI();
            //DisplayMessage("Device configuration");
            //EnableGUI(false);

            try
            {
                //IWin32Window win32Window = new WindowWrapper(this);
                SelectDeviceWindow_new selectDevice = new SelectDeviceWindow_new(selectedDeviceIdentity, this);
                if (_fpScanner != null)
                    selectDevice.FingerPrintScanner = _fpScanner;

                selectDevice.ShowDialog();

                if (selectDevice.rDialogResult)
                //if (selectDevice.rDialogResult.HasValue && selectDevice.DialogResult.Value)
                {
                   // DisplayMessage("Opening device");

                    _fpScanner = selectDevice.FingerPrintScanner;
                    if (_fpScanner != null)
                    {
                        //ResetGUI();
                        //EnableGUI(true);
                    }
                }
                else
                {
                    DisplayError("No device selected");
                    if (selectDevice.FingerPrintScanner != null)
                    {
                        selectDevice.FingerPrintScanner.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }

        private void OpenSelectFGDialog()
        {
            CloseScanner();

            //ResetGUI();
            //DisplayMessage("Device configuration");

            try
            {
                SelectFGWindow_new selectFG = new SelectFGWindow_new(this);

                selectFG.ShowDialog();

                if (selectFG.rDialogResult)
                // if (selectFG.ShowDialog()==DialogResult.OK)
                //if (selectFG.rDialogResult.HasValue && selectFG.rDialogResult.Value)
                {
                    var selectedDeviceIdentity = selectFG.SelectedDeviceIdentity;

                    if (_fpScanner != null)
                    {
                        _fpScanner.Dispose();
                        _fpScanner = null;
                    }

                    OpenSelectDeviceDialog(selectedDeviceIdentity);
                }
                else
                {
                    if (_fpScanner == null)
                        DisplayError("No Frame-Grabber selected.");
                    //EnableGUI(false);
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }

        private void DisplayMessage(String message)
        {
            displayMessage(message, Utils.COLOR_DERMALOG_BLUE);
        }

        private void DisplayError(String error)
        {
            displayMessage(error, Utils.COLOR_DERMALOG_RED);
        }

        private void displayMessage(String message, System.Windows.Media.Brush brush)
        {
            // Application.Current.Dispatcher.BeginInvoke((Action)(() =>
            {
                //xamlLabelMessage.BackColor = brush;
                //xamlLabelMessage.Text = message.ToUpper();
                //lst_msg.Items.Insert(0, message.ToUpper());
                MessageBox.Show(message);
            }
            //));
        }


        private void CloseScanner()
        {
            if (_fpScanner == null)
                return;

           // StopCapturing();

            _fpScanner.Dispose();
            _fpScanner = null;
        }

        private void verifyUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm fm = new MainForm();
            fm.MdiParent = this;
            fm._fpScanner = _fpScanner;
            //fm.StartPosition = FormStartPosition.CenterScreen;
            fm.Show();
        }

        private void resetApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //StopCapturing();
                _afis = new LocalAFIS();
                System.IO.Directory.Delete(_afis.StoragePath, true);
                
                //Added to mimick same behavior in database table
                Utils.truncate_tables();
                //UpdateUserList();
                //ResetGUI();

            }
            catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }

        private void enrollUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StopCapturing();
            //ResetGUI();

            //DisplayMessage("User enrollment");
            //xamlListBoxUsers.SelectedIndex = -1; //Deselect User
            
            //_afis = new LocalAFIS();
            EnrollmentWindow_new enrollmentWindow = new EnrollmentWindow_new(_fpScanner, _afis);
            enrollmentWindow.MdiParent = this;
            enrollmentWindow.StartPosition = FormStartPosition.CenterScreen;
            // EnrollmentWindow enrollmentWindow = new EnrollmentWindow(_fpScanner, _afis);
            //enrollmentWindow.Owner = this;
            enrollmentWindow.Show();

            //if (enrollmentWindow.DialogResult)
            ////if (enrollmentWindow.DialogResult.HasValue && enrollmentWindow.DialogResult.Value)
            //{
            //    UpdateUserList();
            //}

            //DisplayMessage("Select User to verify");
        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void menu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //winforms.sideForm2 sf1 = new sideForm2(this);
            //sf1.MdiParent = this;
            //sf1.Show();
        }

        private void launchSidebarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            winforms.sideForm1 sf1 = new sideForm1(this);
            sf1.MdiParent = this;
            sf1.Show();
        }

        private void MDIParent3_Load(object sender, EventArgs e)
        {
            winforms.sideForm1 sf1 = new sideForm1(this);
            sf1.MdiParent = this;
            sf1.Show();
        }

        private void MDIParent3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_fpScanner == null)
                return;

            //StopCapturing();

            _fpScanner.Dispose();
            _fpScanner = null;
        }
    }
}
