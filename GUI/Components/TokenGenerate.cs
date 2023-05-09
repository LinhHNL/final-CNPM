using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Components
{
    public class TokenGenerate
    {
        private String TokenID;
        public TokenGenerate() {
        }
        private void setTokenID()
        {
            Random rnd = new Random();
            TokenID= rnd.Next().ToString()+ "-" + "M001";
        }
        private String getTokenID()
        {
            return TokenID;
        }
    }
}
