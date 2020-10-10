using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DermalogMultiScannerDemo.winforms
{
    public partial class CreateRoleForm1 :Form //MetroFramework.Forms.MetroForm // 
    {
        Form sd;

        public CreateRoleForm1()
        {
            InitializeComponent();
        }


        public CreateRoleForm1(sideForm1 ssd)
        {
            InitializeComponent();
            sd = ssd;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_generateBtnList_Click(object sender, EventArgs e)
        {
            //Form sd =new Form() ;
            Dictionary<string, string> btnDict = new Dictionary<string, string>();
            foreach (Control item in sd.Controls)
            {
                if (item is Bunifu.Framework.UI.BunifuFlatButton)
                {
                    try
                    {
                        btnDict.Add(item.Name, item.Text);
                        //ListItem ll = new ListItem();
                        //ll.Text = item.Text;
                        //ll.Value = item.Name;
                        string ll = item.Text;
                        listBox1.Items.Add(ll);
                        //checkedListBox1.Items.Remove(item);
                        //checkedListBox1.Items.Add(item.Text, false);
                    }
                    catch { }
                }
                else if (item is Bunifu.Framework.UI.BunifuTileButton)
                {
                    try
                    {
                        btnDict.Add(item.Name, item.Text);
                        //ListItem ll = new ListItem();
                        string ll = ((Bunifu.Framework.UI.BunifuTileButton)item).LabelText;
                        ///ll.Text = ((Bunifu.Framework.UI.BunifuTileButton)item).LabelText;
                        //ll.Text = ((Bunifu.Framework.UI.BunifuTileButton)item).LabelText;
                        //ll.Value = item.Name;
                        listBox1.Items.Add(ll);



                        //btnDict.Add(item.Name, ((Bunifu.Framework.UI.BunifuTileButton)item).LabelText);
                        //checkedListBox1.Items.Add(((Bunifu.Framework.UI.BunifuTileButton)item).LabelText, false);
                    }
                    catch { }
                }
                else { }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in listBox1.SelectedItems)
            {
                //if( item.Selected)
                {
                    //ListItem ll = new ListItem();
                    //ll.Text = item.Text;
                    //ll.Value = item.Value;
                    listBox2.Items.Add(item.Text);
                    listBox1.Items.Remove(item.Text);
                    listBox1.Refresh();
                    listBox2.Refresh();
                }
            }    
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in listBox2.SelectedItems)
            {
                //if (item.Selected)
                {
                    listBox1.Items.Add(item.Text);
                    listBox2.Items.Remove(item.Text);
                    listBox1.Refresh();
                    listBox2.Refresh();
                }
            }
        }
    }
}
