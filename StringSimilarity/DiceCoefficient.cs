using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSimilarity
{
    public static class DiceCoefficient
    {
        public static double DiceCoefficientCount(string strA, string strB)
        {
            HashSet<string> setA = new HashSet<string>();
            HashSet<string> setB = new HashSet<string>();

            for (int i = 0; i < strA.Length - 1; ++i)
                setA.Add(strA.Substring(i, 2));

            for (int i = 0; i < strB.Length - 1; ++i)
                setB.Add(strB.Substring(i, 2));

            HashSet<string> intersection = new HashSet<string>(setA);
            intersection.IntersectWith(setB);

            return (2.0 * intersection.Count) / (setA.Count + setB.Count);
        }
    }
}
