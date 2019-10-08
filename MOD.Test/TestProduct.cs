using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MOD.BAL;
using MOD.DAL;
namespace MOD.Test
{
    [TestFixture]
    class TestProduct
    {
        [Test]
        public void Get()
        {
            ProductBAL obj = new ProductBAL();
            Product p = obj.Get(2);
            Assert.IsNotNull(p);
        }
        [Test]
        public void TestAdd()
        {
            ProductBAL obj = new ProductBAL();
            Product p = new Product()
            {
                Pname = "Abv",
                Price = 100,
                Stock = 10
            };
            obj.Add(p);
            Product p1 = obj.Get(4);

            Assert.IsNotNull(p1);
        }

    }
}
