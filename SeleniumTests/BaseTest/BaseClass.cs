using BaigiamasisDarbas_JusteMiciunaite;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

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
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot();
            }
            Driver.QuitDriver();
        }
    }
}
