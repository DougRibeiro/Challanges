using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityChalanges
{
    public class OddOccurrencesInArray
    {
        public long solution(long[] array)
        {

            List<long> excluded = new List<long>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && !excluded.Contains(j) && !excluded.Contains(i))
                    {
                        if (array[i] == array[j])
                        {
                            excluded.Add(i);
                            excluded.Add(j);
                            break;
                        }
                    }
                }
            }

             for (long h = 0; h < array.Length; h++)
            {
                if (!excluded.Contains(h))
                {
                    return array[h];
                }
            }
            return 0;
        }
    }
}