using CodilityChalanges;
using System;
using Xunit;

namespace CodilityChalangesTest
{
    public class BinaryGapTest
    {
        [Fact]
        public void Test1()
        {
            BinaryGap bg = new BinaryGap();
            long result = bg.getBinaryGap(20);

            Assert.Equal(1,result);
        }

        [Fact]
        public void Test2()
        {
            BinaryGap bg = new BinaryGap();
            long result = bg.getBinaryGap(529);

            Assert.Equal(4, result);
        }

        [Fact]
        public void Test3()
        {
            BinaryGap bg = new BinaryGap();
            long result = bg.getBinaryGap(887966);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Test4()
        {
            BinaryGap bg = new BinaryGap();
            long result = bg.getBinaryGap(9999999999);

            Assert.Equal(6, result);
        }
    }
}
