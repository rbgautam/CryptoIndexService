﻿using System;
using CrytoIndex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrytoIndexTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Main driver = new Main();

            Assert.IsNotNull(driver);
        }


        [TestMethod]
        public void TestCreateDb()
        {
           CryptoIndexRepository.Main driver = new CryptoIndexRepository.Main();

            Assert.IsNotNull(driver);
        }

    }
}
