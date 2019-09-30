using CodilityChalanges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodilityChalangesTest
{
    public class OddOccurrencesInArrayTest
    {
        [Fact]
        public void OddOccurrencesInArrayTest1()
        {
            OddOccurrencesInArray ooia = new OddOccurrencesInArray();

            long[] array = { 9, 3, 9, 3, 9, 7, 9 };
            long result = ooia.solution(array);
            Assert.Equal(7, result);
        }
    }
}