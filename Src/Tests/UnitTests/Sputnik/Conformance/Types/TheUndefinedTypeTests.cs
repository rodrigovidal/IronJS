// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Types
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TheUndefinedTypeTests : SputnikTestFixture
    {
        public TheUndefinedTypeTests()
            : base(@"Conformance\08_Types\8.1_The_Undefined_Type")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.1")]
        [Description("The Undefined type has one value, called undefined")]
        public void S8_1_A1_T1()
        {
            RunFile(@"S8.1_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.1")]
        [Description("The Undefined type has one value, called undefined")]
        public void S8_1_A1_T2()
        {
            RunFile(@"S8.1_A1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.1")]
        [Description("Any variable that has not been assigned a value has the value undefined")]
        public void S8_1_A2_T1()
        {
            RunFile(@"S8.1_A2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.1")]
        [Description("Any variable that has not been assigned a value has the value undefined")]
        public void S8_1_A2_T2()
        {
            RunFile(@"S8.1_A2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.1")]
        [Description("undefined is not a keyword or reserved word")]
        public void S8_1_A3()
        {
            RunFile(@"S8.1_A3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.1")]
        [Description("If property of object not exist, return undefined")]
        public void S8_1_A4()
        {
            RunFile(@"S8.1_A4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.1")]
        [Description("Function argument that isn\'t provided has a value of undefined")]
        public void S8_1_A5()
        {
            RunFile(@"S8.1_A5.js");
        }
    }
}