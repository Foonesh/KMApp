using System;
using System.Net;
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
            var z = new HtmlWeb().Load("http://zdrowezywienie.edu.pl/tabelekaloryczne.htm");
               HtmlDocument doc = new HtmlDocument();
            

            string x = z.DocumentNode.OuterHtml;

            var h = z.DocumentNode.SelectNodes("//td[contains(@class,'l')]");

            foreach (var p in h)
            {
                string a = p.InnerHtml;
            }

        }
    }
}
