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

        [TestMethod]
        public void ReverseStringTest()
        {
            Assert.AreEqual("dcba", ArrayAndStrings.ReverseString("abcd"));
            Assert.AreEqual("", ArrayAndStrings.ReverseString(""));
            Assert.AreEqual("edcba", ArrayAndStrings.ReverseString("abcde"));
        }

        [TestMethod]
        public void IsPermutationTests()
        {
            Assert.AreEqual(true, ArrayAndStrings.IsPermutation("abcd", "dcba"));
            Assert.AreEqual(true, ArrayAndStrings.IsPermutation("apple", "papel"));
            Assert.AreEqual(true, ArrayAndStrings.IsPermutation("carrot", "tarroc"));
            Assert.AreEqual(false, ArrayAndStrings.IsPermutation("hello", "llloh"));
            Assert.AreEqual(true, ArrayAndStrings.IsPermutation("", ""));
        }

        [TestMethod]
        public void ReplaceSpacesTest()
        {
            Assert.AreEqual("Mr%20John%20Smith", ArrayAndStrings.ReplaceSpaces("Mr John Smith"));
        }

        [TestMethod]
        public void CompressStringTests()
        {
            Assert.AreEqual("a2b1c5a3", ArrayAndStrings.CompressString("aabcccccaaa"));
            Assert.AreEqual("", ArrayAndStrings.CompressString(""));
            Assert.AreEqual("abc", ArrayAndStrings.CompressString("abc"));
            Assert.AreEqual("44332211", ArrayAndStrings.CompressString("4444333221"));
        }

        [TestMethod]
        public void RotateMatrixTests()
        {
            var matrix =  new int[][]
            {
                new []{1, 2, 3, 4},
                new []{5, 6, 7, 8},
                new []{9, 10, 11, 12},
                new []{13, 14, 15, 16}
            };

            ArrayAndStrings.RotateMatrix(matrix);

            var expected = new int[][]
            {
                new []{13, 9, 5, 1},
                new []{14, 10, 6, 2},
                new []{15, 11, 7, 3},
                new []{16, 12, 8, 4}
            };
            for (var row = 0; row < matrix.Length; row++)
            {
                CollectionAssert.AreEqual(expected[row], matrix[row]);
            }
        }
    }
}
