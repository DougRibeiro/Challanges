using CodilityChalanges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodilityChalangesTest
{
    public class VerizonTask3Test
    {
        [Fact]
        public void test1()
        {

            VerizonTask3 v3 = new VerizonTask3();

            int[] a = { 1, 1, 3, 3, 3, 4, 5, 5, 5, 5 };

            var result = v3.solution(a, 2);

            Assert.Equal(5, result);
        }


        [Fact]
        public void test2()
        {

            VerizonTask3 v3 = new VerizonTask3();

            int[] a = { 1, 1, 3, 3, 3, 4, 5, 5, 5, 5, 5, 5, 5 };

            var result = v3.solution(a, 2);

            Assert.Equal(7, result);
        }

        [Fact]
        public void test3()
        {

            VerizonTask3 v3 = new VerizonTask3();

            int[] a = { 1, 1, 3, 3, 3, 4, 5, 5, 5, 5, 5, 5, 5, 8 };

            var result = v3.solution(a, 2);

            Assert.Equal(8, result);
        }


        [Fact]
        public void test4()
        {

            VerizonTask3 v3 = new VerizonTask3();

            int[] a = { 1, 1, 3, 3, 3, 4, 4, 4, 5, 5 };

            var result = v3.solution(a, 2);

            Assert.Equal(5, result);
        }

        [Fact]
        public void test5()
        {

            VerizonTask3 v3 = new VerizonTask3();

            int[] a = { 1, 1, 1, 1, 1, 3, 3, 4, 4, 5,5,5 };

            var result = v3.solution(a, 2);

            Assert.Equal( 7, result);
        }

        [Fact]
        public void test6()
        {

            VerizonTask3 v3 = new VerizonTask3();

            int[] a = { 1, 1, 1, 1, 1, 3 };

            var result = v3.solution(a, 2);

            Assert.Equal( 6, result);
        }


    }
}
