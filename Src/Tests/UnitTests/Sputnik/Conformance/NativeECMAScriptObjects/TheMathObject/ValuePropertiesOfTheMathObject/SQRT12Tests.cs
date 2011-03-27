// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheMathObject.ValuePropertiesOfTheMathObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SQRT12Tests : SputnikTestFixture
    {
        public SQRT12Tests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.8_The_Math_Object\15.8.1_Value_Properties_of_the_Math_Object\15.8.1.7_SQRT1_2")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.1.7")]
        [Description("Math.SQRT1_2 is approximately 0.7071067811865476")]
        public void S15_8_1_7_A1()
        {
            RunFile(@"S15.8.1.7_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.1.7")]
        [Description("Value Property SQRT1_2 of the Math Object has the attribute DontEnum")]
        public void S15_8_1_7_A2()
        {
            RunFile(@"S15.8.1.7_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.1.7")]
        [Description("Value Property SQRT1_2 of the Math Object has the attribute DontDelete")]
        public void S15_8_1_7_A3()
        {
            RunFile(@"S15.8.1.7_A3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.1.7")]
        [Description("Value Property SQRT1_2 of the Math Object has the attribute ReadOnly")]
        public void S15_8_1_7_A4()
        {
            RunFile(@"S15.8.1.7_A4.js");
        }
    }
}