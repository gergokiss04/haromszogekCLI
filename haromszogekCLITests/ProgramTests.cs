using Microsoft.VisualStudio.TestTools.UnitTesting;
using haromszogekCLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromszogekCLI.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void derekszoguTest()
        {
            //13.Feladat:
            //Függvény tesztelése megadott számokkal,működés vizsgálata
            Haromszog h = new Haromszog("3 4 5");
            Assert.AreEqual(true, Program.derekszogu(h));
        }
    }
}