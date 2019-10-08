using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MOD.BAL;
namespace MOD.Test
{
    [TestFixture]
    public class TestCalculate
    {
        [Test]
        public void TestAdd()
        {
            Calculate obj = new Calculate();
            int actual = obj.Add(3, 5);
            int expected = 15;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void TestGetNames()
        {
            Calculate obj = new Calculate();
            //List<string> list = obj.GetNames();
            //int count = list.Count;
            //Assert.Greater(count, 0);
            List<string> list1= new List<string>()
            {
                "Rohan",
                "Sachin",
                "Karan",
                "Jeson"
            };
            List<string> list2 = obj.GetNames();
            for(int i=0;i<=list1.Count;i++)
            {
                Assert.AreEqual(list1[i], list2[i]);
            }
        }
    }
}
