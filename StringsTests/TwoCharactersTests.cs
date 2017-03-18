using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace StringsTests
{
    [TestClass]
    public class TwoCharactersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, TwoCharacters.CountMax("beabeefeab"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, TwoCharacters.CountMax("ab"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, TwoCharacters.CountMax("uyetuppelecblwipdsqabzsvyfaezeqhpnalahnpkdbhzjglcuqfjnzpmbwprelbayyzovkhacgrglrdpmvaexkgertilnfooeazvulykxypsxicofnbyivkthovpjzhpohdhuebazlukfhaavfsssuupbyjqdxwwqlicbjirirspqhxomjdzswtsogugmbnslcalcfaxqmionsxdgpkotffycphsewyqvhqcwlufekxwoiudxjixchfqlavjwhaennkmfsdhigyeifnoskjbzgzggsmshdhzagpznkbahixqgrdnmlzogprctjggsujmqzqknvcuvdinesbwpirfasnvfjqceyrkknyvdritcfyowsgfrevzon"));
        }
    }
}
