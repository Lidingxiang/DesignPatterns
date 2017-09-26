using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PatternApp.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var ret=new string('-',7);

            //var dd = ret;


            var str = "201709211340BBBBAAAA";
            //var ret = str.Remove(str.Length-4);
            var ret = str.Substring(str.Length-4, 4);
            var dd = ret;
        }
    }
}
