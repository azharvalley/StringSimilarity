using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSimilarity
{
    public static class LettersSimilarity
    {
        private static int total;

        public static int ComputeSimilarity(string source, string target)
        {
            Dictionary<char, List<int>> LetterDistanceSource = new Dictionary<char, List<int>>();
            Dictionary<char, List<int>> LetterDistanceTarget = new Dictionary<char, List<int>>();
            List<char> frequentLetters = new List<char>{ 'e', 't', 'a', 'i', 'n', 's' };
            

            foreach (var letter in frequentLetters)
            {
                List<int> lettersPositions = new List<int>();

                if (source.Contains(letter))
                {
                    var count = source.Count(x => x.Equals(letter));
                    for (int i = 0; i < count; i++)
                    {
                        lettersPositions.Add(source.IndexOf(letter, i));
                    }

                    LetterDistanceSource.Add(letter, lettersPositions);
                }
            }

            foreach (var letter in frequentLetters)
            {
                List<int> lettersPositions = new List<int>();

                if (target.Contains(letter))
                {
                    var count = target.Count(x => x.Equals(letter));
                    for (int i = 0; i < count; i++)
                    {
                        lettersPositions.Add(source.IndexOf(letter, i));
                    }

                    LetterDistanceTarget.Add(letter, lettersPositions);
                }
            }

            foreach (var item in LetterDistanceTarget)
            {
                int totalDifference = LetterDistanceTarget.Where(x => x.Key == item.Key)
                                                .Sum(s => s.Value.Sum()) 
                                      - LetterDistanceTarget.Where(x => x.Key == item.Key)
                                                .Sum(s => s.Value.Sum());

                total += totalDifference;
            }

            return total;
        }
    }
}
