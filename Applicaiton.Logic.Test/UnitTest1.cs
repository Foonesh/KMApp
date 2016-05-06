using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
            DatabaseModel model = new DatabaseModel();

            var z = model.ABBREV.Select(it => it.Energ_Kcal).FirstOrDefault();

        }
    }
}
