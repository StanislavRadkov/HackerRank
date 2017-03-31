using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotBuilding;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BotBuildingTests
{
    [TestClass]
    public class BotCleanPartiallyObservableTests
    {
        [TestInitialize]
        public void Init()
        {
            string fileName = "myfile.txt";
            using (FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                file.SetLength(0);
            }
        }       

        [TestMethod]
        public void TestMethod1()
        {
           var input = new String[]
           {
                "bdooo",
                "-dooo",
                "ooooo",
                "ooooo",
                "ooooo"
           };

            Assert.AreEqual("RIGHT", BotCleanPartiallyObservable.NextMove(0, 0, input));

            var input1 = new String[]
           {
                "-d-oo",
                "-d-oo",
                "ooooo",
                "ooooo",
                "ooooo"
           };

            Assert.AreEqual("CLEAN", BotCleanPartiallyObservable.NextMove(0, 1, input1));

            var input2 = new String[]
            {
                "-b-oo",
                "-d-oo",
                "ooooo",
                "ooooo",
                "ooooo"
            };

            Assert.AreEqual("DOWN", BotCleanPartiallyObservable.NextMove(0, 1, input2));

            var input3 = new String[]
            {
                "---oo",
                "-d-oo",
                "ooooo",
                "ooooo",
                "ooooo"
            };

            Assert.AreEqual("CLEAN", BotCleanPartiallyObservable.NextMove(1, 1, input3));

            var input4 = new String[]
            {
                "---oo",
                "-b-oo",
                "ooooo",
                "ooooo",
                "ooooo"
            };

            Assert.AreEqual("LEFT", BotCleanPartiallyObservable.NextMove(1, 1, input4));

            var input5 = new String[]
            {
                "---oo",
                "b--oo",
                "ooooo",
                "ooooo",
                "ooooo"
            };

            Assert.AreEqual("DOWN", BotCleanPartiallyObservable.NextMove(1, 0, input5));
        }
    }
}
