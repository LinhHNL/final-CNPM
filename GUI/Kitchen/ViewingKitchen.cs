﻿using GUI.Components;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Components;

namespace GUI.Kitchen
{
    public partial class ViewingKitchen : MetroForm
    {
        public ViewingKitchen()
        {
            InitializeComponent();
        }

        private void ViewingKitchen_Load(object sender, EventArgs e)
        {
            flp_ShowBillTemp.Controls.Clear();
            BUS.TempBill TempBill = new BUS.TempBill();
            List<Dictionary<string, string>> TempBilList = TempBill.getTempBillNotDone();
            foreach (Dictionary<string, string> item in TempBilList)
            {
                    flp_ShowBillTemp.Controls.Add(new KitchenView(item["TempBillID"], this));
            }
        }
    }
}
