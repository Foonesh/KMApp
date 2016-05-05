using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.FoodDataParser;


namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataDownloader.DownloadItemData("01009"));
            Console.ReadKey();
        }
    }
}
