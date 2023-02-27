using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class MyTextbox : TextBox
    {
        public MyTextbox()
        {
            BorderStyle = System.Windows.Forms.BorderStyle.None;
            AutoSize = false;
         
            Controls.Add(new Label()
            {
                Height = 1,
                Dock = DockStyle.Bottom,
                BackColor = Color.SteelBlue,
                
            }); ;
        }
    }
}
