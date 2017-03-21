﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreedyTests
{
    [TestClass]
    public class MarkAndToysTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, MarkAndToys.Max(new int[] { 1, 12, 5, 111, 200, 1000, 10 }, 50));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new int[] {
                2716485, 47574329, 54317443, 73887797, 4690442, 50158330, 36082844, 35504863, 10098449, 36757751, 51223808, 70905600, 2915719, 19449463, 15531534, 90627969, 10138256, 56422983, 94058705, 61663313, 49377065, 49952346, 67204721, 50973358, 35007152, 35561646, 21839119, 62717102, 25604425, 42393960, 26469586, 28320910, 89968289, 33303381, 54725059, 94658731, 83461711, 90807903, 82679946, 46076512, 80082006, 33903754, 69498465, 82997725, 5869569, 85029999, 73625694, 16007825, 41452983, 20200751, 77671138, 43346400, 70153097, 44875859, 46836111, 57676602, 32953858, 68675230, 20393704, 11074635, 63585542, 99379642, 91911897, 6070183, 85199375, 46636956, 53245266, 21177439, 37444859, 35925213, 19770303, 70043217, 69828967, 89268768, 53040943, 75698537, 74298768, 79182989, 44222714, 68268103, 51900093, 21893853, 64130855, 22053190, 19286064, 10966966, 32246144, 52239922, 32158548, 5156201, 15830909, 48260442, 57052195, 7742806, 54330625, 42251571, 54379762, 7575892, 15945362, 44340973, 96017457, 35715665, 14384191, 65846424, 77500786, 19941486, 94061313, 4315906, 51640827, 38284028, 72584009, 3540920, 12694233, 89231216, 78110463, 31980297, 52714535, 10356607, 36736572, 84873083, 68029160, 52567481, 85649878, 25081356, 60310288, 39980503, 19849279, 67206402, 72747, 88310993, 11547376, 96090204, 76543010, 78447919, 14452981, 54043796, 50905757, 8514294, 58359702, 2546584, 99314674, 83460063, 6087505, 12008907, 72691280, 84197968, 96505557, 25405815, 47070927, 85758481, 62795250, 67616440, 90842314, 961480, 92697796, 3668954, 40941984, 65063427, 70875357, 93531083, 53374420, 34939085, 89621288, 29917430, 65903356, 4074269, 36477579, 16809113, 65104915, 94837281, 19355697, 16935942, 78297345, 77959554, 81461201, 3504977, 14673874, 77966758, 81427144, 61744802, 16241591, 96738746, 81877594, 7083906, 97700227, 74575390, 10752860, 91158563, 92155169, 81628217, 84689646, 45529589, 69083654, 26827286, 27963371, 34987010, 83417907, 64440950, 51796123, 823
            };

            Assert.AreEqual(19, MarkAndToys.Max(input, 80000000));
        }
    }
}
