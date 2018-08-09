﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lab17.Library.Tests
{
    [TestFixture]
    public class PrimesIndexMatcherTests
    {
        //[Test]
        //public void Index_Matcher_When1_Returns2()
        //{
        //    // Assemble
        //    int index = 1;
        //    // Act
        //    int output = PrimeIndexMatcher.GetValue(index);
        //    // Assert
        //    Assert.AreEqual(2, output);
        //}

        //[Test]
        //public void Index_Matcher_When2_Returns3()
        //{
        //    // Assemble
        //    int input = 2;
        //    // Act
        //    int output = PrimeIndexMatcher.GetValue(input);
        //    // Assert
        //    Assert.AreEqual(3, output);
        //}

        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(4, 7)]
        [TestCase(5, 11)]
        [TestCase(25, 97)]
        [TestCase(50, 229)]
        [TestCase(100, 541)]
        public void Index_Matcher_WhenIndex_ReturnsPrime(int input,int prime)
        {
            // Assemble
            // Act
            int output = PrimeIndexMatcher.GetValue(input);
            // Assert
            Assert.AreEqual(prime, output);
        }
    }
}
