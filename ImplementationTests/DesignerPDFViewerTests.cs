using Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementationTests
{
    [TestClass]
    public class DesignerPDFViewerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(9, DesignerPDFViewer.Solve(new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, "abc" ));
        }
    }
}
