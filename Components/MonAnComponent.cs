﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.Components
{
    public partial class MonAnComponent : UserControl
    {
        public MonAnComponent()
        {
            InitializeComponent();
        }

        public MonAnComponent(String ten, String gia)
        {
            InitializeComponent();
            lbl_ten.Text = ten;
            lbl_gia.Text = gia;
        }
    }
}
