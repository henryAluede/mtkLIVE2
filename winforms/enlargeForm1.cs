﻿using MetroFramework.Forms;
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
    public partial class enlargeForm1 : Form
    {
        public enlargeForm1(Image pix)
        {
            InitializeComponent();
            pictureBox1.Image = pix;
        }
    }
}
