using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.FoodDataParser;
using Newtonsoft.Json;


namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = DataDownloader.DownloadItemData("01009");


            Console.WriteLine("done");

            Console.ReadKey();
        }
    }
}
