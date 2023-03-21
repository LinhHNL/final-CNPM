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

namespace WinFormsApp2
{
    public partial class ShoppingCartForm : MetroFramework.Forms.MetroForm
    {
        public ShoppingCartForm()
        {
            InitializeComponent();
        }

        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {
            List <MonAnComponent> listdachon= StoringMonAnComponentShoppingCart.StoringMonAnComponentShoppingCartList;
            MessageBox.Show(listdachon.Count().ToString());
            // MessageBox.Show(listdachon.Count().ToString());
            foreach (MonAnComponent i in listdachon)
            {
                MessageBox.Show(i.getTenMon());
                pnl_hienthimonan.Controls.Add(new MonAnComponenInShoppingCart(i.getTenMon(),i.getSoLuong(),i.getGiaMon(),listdachon));
            }
        }
    }
}
