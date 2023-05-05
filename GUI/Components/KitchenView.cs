using GUI.Kitchen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Components
{
    public partial class KitchenView : UserControl
    {
        String BillId = "";
        ViewingKitchen context;
        public KitchenView(String BillID, ViewingKitchen context)
        {
            this.BillId = BillID;
            InitializeComponent();
            this.context = context;
            this.lbl_idban.Text = BillID;
        }

        private void lbl_lookInfo_Click(object sender, EventArgs e)
        {
            context.Hide();
            DetailKitchen DetailKitchen = new DetailKitchen(BillId);
            DetailKitchen.ShowDialog();
            context.Close();
        }
    }
}
