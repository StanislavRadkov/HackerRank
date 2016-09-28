using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks;

namespace StacksTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(BalancedBrackets.ValiedateBrackets("{[()]}"), true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(BalancedBrackets.ValiedateBrackets("{[(])}"), false);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(BalancedBrackets.ValiedateBrackets("{{[[(())]]}}"), true);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(BalancedBrackets.ValiedateBrackets("}][}}(}][))]"), false);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(BalancedBrackets.ValiedateBrackets("[](){()}"), true);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(BalancedBrackets.ValiedateBrackets("()"), true);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(BalancedBrackets.ValiedateBrackets("({}([][]))[]()"), true);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(BalancedBrackets.ValiedateBrackets("{)[](}]}]}))}(())("), false);
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual(BalancedBrackets.ValiedateBrackets("((("), false);
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual(BalancedBrackets.ValiedateBrackets(""), true);
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(BalancedBrackets.ValiedateBrackets(")))"), false);
        }
    }
}