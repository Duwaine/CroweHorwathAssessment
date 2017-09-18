using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CroweHorwathAssessment
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void HelloWorldNullArgumentTestMethod()
        {
            HelloWorld hWorld = new HelloWorld();

            Console.WriteLine(hWorld.GetHelloWorld() + Environment.NewLine);
        }
    }
}
