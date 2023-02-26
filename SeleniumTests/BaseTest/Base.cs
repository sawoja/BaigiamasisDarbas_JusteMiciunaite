using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.BaseClass
{
    internal class Base
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
    }
}
