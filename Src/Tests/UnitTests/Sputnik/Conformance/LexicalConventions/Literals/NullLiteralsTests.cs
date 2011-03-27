// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.LexicalConventions.Literals
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NullLiteralsTests : SputnikTestFixture
    {
        public NullLiteralsTests()
            : base(@"Conformance\07_Lexical_Conventions\7.8_Literals\7.8.1_Null_Literals")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.8.1")]
        [Description("Literal :: NullLiteral")]
        public void S7_8_1_A1_T1()
        {
            RunFile(@"S7.8.1_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.8.1")]
        [Description("Literal :: NullLiteral")]
        public void S7_8_1_A1_T2()
        {
            RunFile(@"S7.8.1_A1_T2.js");
        }
    }
}