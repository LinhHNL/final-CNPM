using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TokenGenerate
    {
            public String getTokenID()
            {
                // Get current date and time
                DateTime now = DateTime.Now;

                // Format the date and time as a string
                string formattedDateTime = now.ToString("dd:MM:yy-HH:mm:ss");

                String IDDevice = "M001";
                String TokenID = formattedDateTime + "-" + IDDevice;
                return TokenID;
            }
        }
    }
