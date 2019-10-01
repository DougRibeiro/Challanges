using CodilityChalanges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodilityChalangesTest
{
    public class VerizonTask2Test
    {

        [Fact]
        public void test1()
        {
            VerizonTask2 v2 = new VerizonTask2();

            int result = v2.solution("13 DUP 4 POP 5 DUP + DUP + -");

            Assert.Equal(7, result);
        }
        [Fact]
        public void test2()
        {
            VerizonTask2 v2 = new VerizonTask2();

            int result = v2.solution("5 6 + -");

            Assert.Equal(-1, result);
        }
        [Fact]
        public void test3()
        {
            VerizonTask2 v2 = new VerizonTask2();

            int result = v2.solution("5 - -");

            Assert.Equal(-1, result);
        }

    }
}
