using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityChalanges
{
    public class VerizonTask3
    {

        public int solution(int[] A, int K)
        {
            int n = A.Length;
            int best = 0;
            int count = 0;
            for (int i = 0; i < n - K - 1; i++)
            {
                if (A[i] == A[i + 1])
                    count = count + 1;
                else
                    count = 0;
                if (count > best)
                    best = count;
            }
            int result = best + 1 + K;

            return result;
        }
    }
}
