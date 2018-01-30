using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeSatoshiAPI
{
    public class GlobalSettings
    {
        public static string API_Key;
        public static string Secret;
        public static byte[] Secret_Key
        {
            get
            {
                return Convert.FromBase64String(Secret);
            }
        }        
    }
}
