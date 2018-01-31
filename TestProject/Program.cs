using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TradeSatoshiAPI.GlobalSettings.API_Key = ""; //For testing purpose
            TradeSatoshiAPI.GlobalSettings.Secret = "";

            Console.WriteLine(TradeSatoshiAPI.APICall.GetBalances().Result.result[0].Total.ToString());
            Console.ReadKey();
        }
    }
}
