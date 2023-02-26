using BaigiamasisDarbas_JusteMiciunaite;
using NUnit.Framework;

namespace SeleniumTests.BaseClass
{
    public class Base
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
