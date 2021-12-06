using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TPFinal.ClassLibrary;
using System.IO;
using System;

namespace Test_TP3
{
    [TestClass]
    public class TestTP3
    {
        [TestMethod]
        public void testExportAll_positives()
        {
            string name = "Complete list of " + typeof(Lol).Name + " games.xml";
            string fileName = AppDomain.CurrentDomain.BaseDirectory + name;

            List<Lol> imported = new List<Lol>();
            List<Lol> list = new List<Lol>();
            list.Add(new Lol("Akali", "MID", "Platinum", "Asia", 1));
            list.Add(new Lol("Alistar", "TOP", "Platinum", "Asia", 2));

            ImportExport<Lol> exportTest = new ImportExport<Lol>(list);

            exportTest.exportAll();
            imported = exportTest.Import();
            Assert.IsNotNull(list);
            Assert.IsTrue(File.Exists(fileName));
            Assert.AreEqual(imported[0].champion.ToString(),"Akali");
            Assert.AreEqual(imported[1].champion.ToString(), "Alistar");

        }

        [TestMethod]
        public void testExportAll_negatives()
        {
            string name = "Complete list of " + typeof(Lol).Name + " games.xml";
            string fileName = AppDomain.CurrentDomain.BaseDirectory + name;

            List<Lol> list = null;
            
            ImportExport<Lol> exportTest = new ImportExport<Lol>(list);

            exportTest.exportAll();

            Assert.IsNull(list);
            Assert.IsTrue(File.Exists(fileName));

        }

        [TestMethod]
        public void testImport_positives()
        {
            string name = "Complete list of " + typeof(Lol).Name + " games.xml";
            string fileName = AppDomain.CurrentDomain.BaseDirectory + name;

            List<Lol> list = new List<Lol>();
            List<Lol> imported;
            list.Add(new Lol("Akali", "MID", "Platinum", "Asia", 1));
            list.Add(new Lol("Alistar", "TOP", "Platinum", "Asia", 2));

            ImportExport<Lol> exportTest = new ImportExport<Lol>(list);

            exportTest.exportAll();

            imported = exportTest.Import();

            Assert.IsNotNull(imported);
            Assert.AreEqual(imported[0].champion.ToString(), "Akali");
            Assert.AreEqual(imported[1].champion.ToString(), "Alistar");

        }

        [TestMethod]
        public void testImport_negatives()
        {
            string name = "Complete list of " + typeof(Lol).Name + " games.xml";
            string fileName = AppDomain.CurrentDomain.BaseDirectory + name;

            List<Lol> list = new List<Lol>();
            List<Lol> imported;

            ImportExport<Lol> exportTest = new ImportExport<Lol>(list);

            File.Delete(fileName);

            imported = exportTest.Import();

            Assert.IsNull(imported);
            Assert.IsFalse(File.Exists(fileName));

        }
    }
}
