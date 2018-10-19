using System;
using AutofacContrib.NSubstitute;
using FunkyCode.Entities.Basic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace AutoSubstituteTests
{
    [TestClass]
    public class UnitTest1
    {
        AutoSubstitute _autoSubstitute = new AutoSubstitute();

        [TestMethod]
        public void TestMethod1()
        {


            var interface_B_mock = Substitute.For<Interface_B>();
            interface_B_mock.Method_B().Returns(i => 1);

            // _autoSubstitute.Provide(interface_B_mock);

            var a = _autoSubstitute.Resolve<Class_A>();

            a.Method_A();

        }
    }
}
