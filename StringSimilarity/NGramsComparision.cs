using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSimilarity
{
    public static class NGramsComparision
    {
        public static List<string> MakeTriGrams(string text)
        {
            StringBuilder nGram = new StringBuilder();
            List<string> result = new List<string>();

            //generate nGrams
            for (int i = 1; i < text.Length - 1; i++)
            {
                char before = text[i - 1];
                char after = text[i + 1];

                for (int k = 0; k < 3; k++)
                {
                    nGram.Append(text[-1 + i + k]);
                }

                if(nGram.Length >= 2)
                {
                    result.Add(nGram.ToString());
                }
                
                nGram.Clear();
            }

            return result;

        }

        public static double CompareStringsWithTriGram(string source, string target)
        {
            int nGramMatch = 0;
            int nGramCount = target.Count();            

            List<string> _source = MakeTriGrams(source);
            List<string> _target = MakeTriGrams(target);

            foreach (var item in _target)
            {
                if(_source.Any(x => x == item)) 
                    nGramMatch += 1;
            }

            return (double)nGramMatch/(double)nGramCount;
        }
    }
}
