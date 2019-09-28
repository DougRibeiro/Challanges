using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CodilityChalanges
{
    public class BinaryGap
    {

        public long getBinaryGap(long v)
        {
            List<long> bitArray = getBiteArray(v);
            List<long> gaps = getGapsFromBinary(bitArray);
            long result = getBiggerGap(gaps);

            return result;
        }

        private static long getBiggerGap(List<long> gaps)
        {
            long result = 0;
            foreach (long gapsize in gaps)
            {
                if (result < gapsize)
                {
                    result = gapsize;
                }
            }

            return result;
        }

        private static List<long> getGapsFromBinary(List<long> bitArray)
        {
            Boolean first = true;
            long countGap = 0;
            List<long> gaps = new List<long>();

            foreach (var value in bitArray)
            {
                if (value == 1)
                {
                    if (first)
                    {
                        if (countGap != 0)
                        {
                            gaps.Add(countGap);
                        }
                        countGap = 0;
                        first = false;
                    }
                    else
                    {
                        gaps.Add(countGap);
                        countGap = 0;
                    }
                }
                else
                {
                    if (!first)
                    {
                        countGap++;
                    }
                }
            }

            return gaps;
        }

        private static List<long> getBiteArray(long v)
        {
            List<long> bitArray = new List<long>();
            while (v > 0)
            {
                if (v % 2 == 0)
                {
                    bitArray.Add(0);
                }
                else
                {
                    bitArray.Add(1);
                }
                v = v / 2;
            }
            return bitArray;
        }
    }
}