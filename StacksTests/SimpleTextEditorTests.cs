using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks;

namespace StacksTests
{
    [TestClass]
    public class SimpleTextEditorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var textEditor = new SimpleTextEditor();

            textEditor.Append("abc");
            Assert.AreEqual('c', textEditor.Print(3));
            textEditor.Delete(3);
            textEditor.Append("xy");
            Assert.AreEqual('y', textEditor.Print(2));
            textEditor.Undo();
            textEditor.Undo();
            Assert.AreEqual('a', textEditor.Print(1));
        }
    }
}
