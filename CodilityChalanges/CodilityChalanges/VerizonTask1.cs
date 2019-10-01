using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityChalanges
{
    public class VerizonTask1
    {
        public int Solution(int N)
        {
            string numberString = N.ToString();
            List<int> finalNumber = new List<int>();

            for (int i = 0; i < numberString.Length; i++) {

                int x = Int32.Parse(numberString[i].ToString());
                finalNumber.Add(x);
            }

            finalNumber.Sort();
            finalNumber.Reverse();
            string auxString = "";

            foreach (var value in finalNumber) {
                auxString = auxString + value;
            }

            int y = Int32.Parse(auxString);

            if (y > 100000000) {

                return -1;
            }
            return y;
        }
    }
}