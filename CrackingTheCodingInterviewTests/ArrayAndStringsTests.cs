using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackingTheCodingInterview;

namespace CrackingTheCodingInterviewTests
{
    [TestClass]
    public class ArrayAndStringsTests
    {
        [TestMethod]
        public void AllUniqueCharactersASCIITest()
        {
            Assert.AreEqual(true, ArrayAndStrings.AllUniqueCharactersASCII("abcd"));
            Assert.AreEqual(false, ArrayAndStrings.AllUniqueCharactersASCII("abcdc"));
            Assert.AreEqual(false, ArrayAndStrings.AllUniqueCharactersASCII("aa"));
            Assert.AreEqual(true, ArrayAndStrings.AllUniqueCharactersASCII("a"));
            Assert.AreEqual(true, ArrayAndStrings.AllUniqueCharactersASCII(""));
            Assert.AreEqual(false, ArrayAndStrings.AllUniqueCharactersASCII("kjsadasjdaaaa"));
            Assert.AreEqual(false, ArrayAndStrings.AllUniqueCharactersASCII("anbhyrioplkkkkxxxx"));
            Assert.AreEqual(false, ArrayAndStrings.AllUniqueCharactersASCII("aqwertyuio00"));
        }

        [TestMethod]
        public void AllUniqueCharactersUnicodeTest()
        {
            Assert.AreEqual(true, ArrayAndStrings.AllUniqueCharactersUnicode("абцд"));
            Assert.AreEqual(false, ArrayAndStrings.AllUniqueCharactersUnicode("абцдц"));
            Assert.AreEqual(false, ArrayAndStrings.AllUniqueCharactersUnicode("аа"));
            Assert.AreEqual(true, ArrayAndStrings.AllUniqueCharactersUnicode("а"));
            Assert.AreEqual(true, ArrayAndStrings.AllUniqueCharactersUnicode(""));
            Assert.AreEqual(false, ArrayAndStrings.AllUniqueCharactersUnicode("касдяветрзз"));
            Assert.AreEqual(false, ArrayAndStrings.AllUniqueCharactersUnicode("асдфгхйкльь"));
            Assert.AreEqual(false, ArrayAndStrings.AllUniqueCharactersUnicode("асдфгхйкл00"));
        }
    }
}
