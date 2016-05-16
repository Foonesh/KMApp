using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Windows;
using Application.DataLogicLayer;
using HtmlAgilityPack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Applicaiton.Logic.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {   
            DatabaseNutrients model = new DatabaseNutrients();

            var z = model.ABBREV.Select(it => it.Energ_Kcal).FirstOrDefault();

            MessageBox.Show(z.ToString());
            var test = model.ABBREV.Take(5);

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

        }
    }
}
