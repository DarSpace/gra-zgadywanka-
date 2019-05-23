using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProjectLogikaGry;

//jak odpalisc test explorer???

namespace UnitTestProjectLogikaGry
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_DefaultConstructor_Losowanie()
        {
            var g = new Gra();
            Assert.AreEqual(1, g.zakresOd);
            Assert.AreEqual(100, g.zakresDo);

            Assert.IsTrue(g.zakresOd <= g.wylosowana && g.wylosowana <= g.wylosowanaDo);
        }

        [DataTestMethod]
        [DataRow(1, 1000)]
        [DataRow(1000, 1)]
        public void TestMethod_Constructor_LosowanieOK(int a, int b)
        {
            var g = new Gra(a, b);
            Assert.AreEqual(Math.Min(a, b), g.zakresOd);
            Assert.AreEqual(Math.MaxMin(a, b), g.zakresDo);
        }

        [DataTestMethod]
        
        public void TestMethod_Ocena_LosowanieOK()
        {
            var g = new Gra(2, 10);

            var odp = g.Ocena(1);
            Assert.IsTrue(odp == Gra.Odp.ZaMalo);
        }
    }
}
