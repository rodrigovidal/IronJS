// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.UnaryOperators
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TheTypeofOperatorTests : SputnikTestFixture
    {
        public TheTypeofOperatorTests()
            : base(@"Conformance\11_Expressions\11.4_Unary_Operators\11.4.3_The_typeof_Operator")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.3")]
        [Description("White Space and Line Terminator between \"typeof\" and UnaryExpression are allowed")]
        public void S11_4_3_A1()
        {
            RunFile(@"S11.4.3_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.3")]
        [Description("Operator \"typeof\" uses GetValue")]
        public void S11_4_3_A2_T1()
        {
            RunFile(@"S11.4.3_A2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.3")]
        [Description("Operator \"typeof\" uses GetValue")]
        public void S11_4_3_A2_T2()
        {
            RunFile(@"S11.4.3_A2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.3")]
        [Description("Result of applying \"typeof\" operator to undefined is \"undefined\"")]
        public void S11_4_3_A3_1()
        {
            RunFile(@"S11.4.3_A3.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.3")]
        [Description("Result of applying \"typeof\" operator to null is \"object\"")]
        public void S11_4_3_A3_2()
        {
            RunFile(@"S11.4.3_A3.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.3")]
        [Description("Result of applying \"typeof\" operator to boolean is \"boolean\"")]
        public void S11_4_3_A3_3()
        {
            RunFile(@"S11.4.3_A3.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.3")]
        [Description("Result of appying \"typeof\" operator to number is \"number\"")]
        public void S11_4_3_A3_4()
        {
            RunFile(@"S11.4.3_A3.4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.3")]
        [Description("Result of appying \"typeof\" operator to string is \"string\"")]
        public void S11_4_3_A3_5()
        {
            RunFile(@"S11.4.3_A3.5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.3")]
        [Description("Result of applying \"typeof\" operator to the object that is native and doesn\'t implement [[Call]] is \"object\"")]
        public void S11_4_3_A3_6()
        {
            RunFile(@"S11.4.3_A3.6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.3")]
        [Description("Result of applying \"typeof\" operator to the object that is native and implements [[Call]] is \"function\"")]
        public void S11_4_3_A3_7()
        {
            RunFile(@"S11.4.3_A3.7.js");
        }
    }
}