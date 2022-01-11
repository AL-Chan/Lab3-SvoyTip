using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab03_SvoyTip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_SvoyTip.Tests
{
    [TestClass()]
    public class DegreeTests
    {
        [TestMethod()]
        public void SortTest() //вывод величин
        {
            var degree = new Degree(36.6, DegreeTip.C);
            Assert.AreEqual("36,6 C", degree.Sort());

            degree = new Degree(36.6, DegreeTip.F);
            Assert.AreEqual("36,6 F", degree.Sort());

            degree = new Degree(36.6, DegreeTip.Ra);
            Assert.AreEqual("36,6 Ra", degree.Sort());

            degree = new Degree(36.6, DegreeTip.K);
            Assert.AreEqual("36,6 K", degree.Sort());
        }

        [TestMethod()]
        public void SlozhenieTest() //сложение
        {
            var degree = new Degree(36.6, DegreeTip.C);
            degree = degree + 10.5;
            Assert.AreEqual("47,1 C", degree.Sort());
        }

        [TestMethod()]
        public void VychitanieTest() //вычитание
        {
            var degree = new Degree(28.0, DegreeTip.Ra);
            degree = degree - 16.8;
            Assert.AreEqual("11,2 Ra", degree.Sort());
        }
        
        [TestMethod()] //сложение и вычитание двух величин
        public void DveRaznieVelichiny_Slozh_Vychet()
        {
            var c = new Degree(36, DegreeTip.C); //96.8 F
            var f = new Degree(59, DegreeTip.F); //15.0 C

            Assert.AreEqual("51 C", (c + f).Sort());
            Assert.AreEqual("155,8 F", (f + c).Sort());

            Assert.AreEqual("-37,8 F", (f - c).Sort());
            Assert.AreEqual("21 C", (c - f).Sort());
        }

        [TestMethod()]
        public void UmnojenieNaChicloTest() //умножение на число
        {
        var degree = new Degree(18.0, DegreeTip.F);
        degree = degree * 3;
        Assert.AreEqual("54 F", degree.Sort());
        }

        [TestMethod()]
        public void CelcVDrugoe() //вывод значения цельсия в любом типе
        {
        Degree degree;

        degree = new Degree(10, DegreeTip.C);
        Assert.AreEqual("50 F", degree.Vyvod(DegreeTip.F).Sort());

        degree = new Degree(20, DegreeTip.C);
        Assert.AreEqual("527,67 Ra", degree.Vyvod(DegreeTip.Ra).Sort());

        degree = new Degree(30, DegreeTip.C);
        Assert.AreEqual("303,15 K", degree.Vyvod(DegreeTip.K).Sort());
        }
        
        [TestMethod()]
        public void DrugoeVCelc() //вывод любого другого типа в значения цельсия
        {
            Degree degree;

            degree = new Degree(50, DegreeTip.F);
            Assert.AreEqual("10 C", degree.Vyvod(DegreeTip.C).Sort());

            degree = new Degree(671.67, DegreeTip.Ra);
            Assert.AreEqual("100 C", degree.Vyvod(DegreeTip.C).Sort());

            degree = new Degree(1, DegreeTip.K);
            Assert.AreEqual("-272,15 C", degree.Vyvod(DegreeTip.C).Sort());
        }

    }
}