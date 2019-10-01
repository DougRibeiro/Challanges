using System;
using System.Collections.Generic;
using System.Text;
using CodilityChalanges;
using Xunit;

namespace CodilityChalangesTest
{
    public class VerizonTask1Test
    {

        [Fact]
        public void test1() {

            VerizonTask1 v1 = new VerizonTask1();
            int result = v1.Solution(553);
            Assert.Equal(553, result);
        }

        [Fact]
        public void test2()
        {

            VerizonTask1 v1 = new VerizonTask1();
            int result = v1.Solution(213);
            Assert.Equal(321, result);
        }

       
    }
}
