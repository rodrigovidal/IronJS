// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.StringObjects.PropertiesOfTheStringPrototypeObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StringPrototypeConcatTests : SputnikTestFixture
    {
        public StringPrototypeConcatTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.5_String_Objects\15.5.4_Properties_of_the_String_Prototype_Object\15.5.4.6_String.prototype.concat")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("String.prototype.concat([,[...]])")]
        public void S15_5_4_6_A1_T1()
        {
            RunFile(@"S15.5.4.6_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("String.prototype.concat([,[...]])")]
        public void S15_5_4_6_A1_T10()
        {
            RunFile(@"S15.5.4.6_A1_T10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("String.prototype.concat([,[...]])")]
        public void S15_5_4_6_A1_T2()
        {
            RunFile(@"S15.5.4.6_A1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("String.prototype.concat([,[...]])")]
        public void S15_5_4_6_A1_T3()
        {
            RunFile(@"S15.5.4.6_A1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("String.prototype.concat([,[...]])")]
        public void S15_5_4_6_A1_T4()
        {
            RunFile(@"S15.5.4.6_A1_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("String.prototype.concat([,[...]])")]
        public void S15_5_4_6_A1_T5()
        {
            RunFile(@"S15.5.4.6_A1_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("String.prototype.concat([,[...]])")]
        public void S15_5_4_6_A1_T6()
        {
            RunFile(@"S15.5.4.6_A1_T6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("String.prototype.concat([,[...]])")]
        public void S15_5_4_6_A1_T7()
        {
            RunFile(@"S15.5.4.6_A1_T7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("String.prototype.concat([,[...]])")]
        public void S15_5_4_6_A1_T8()
        {
            RunFile(@"S15.5.4.6_A1_T8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("String.prototype.concat([,[...]])")]
        public void S15_5_4_6_A1_T9()
        {
            RunFile(@"S15.5.4.6_A1_T9.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("The String.prototype.concat.length property has the attribute ReadOnly")]
        public void S15_5_4_6_A10()
        {
            RunFile(@"S15.5.4.6_A10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("The length property of the concat method is 1")]
        public void S15_5_4_6_A11()
        {
            RunFile(@"S15.5.4.6_A11.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("String.prototype.concat([,[...]]) can accept at least 128")]
        public void S15_5_4_6_A2()
        {
            RunFile(@"S15.5.4.6_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("String.prototype.concat([,[...]]) can\'t change the instance to be applied")]
        public void S15_5_4_6_A3()
        {
            RunFile(@"S15.5.4.6_A3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("when String.prototype.concat([,[...]]) is called first Call ToString, giving it the this value as its argument")]
        public void S15_5_4_6_A4_T1()
        {
            RunFile(@"S15.5.4.6_A4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("when String.prototype.concat([,[...]]) is called first Call ToString, giving it the this value as its argument")]
        public void S15_5_4_6_A4_T2()
        {
            RunFile(@"S15.5.4.6_A4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [TestCategory("ECMA 13.2")]
        [Description("String.prototype.concat has not prototype property")]
        public void S15_5_4_6_A6()
        {
            RunFile(@"S15.5.4.6_A6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [TestCategory("ECMA 13.2")]
        [Description("String.prototype.concat can\'t be used as constructor")]
        public void S15_5_4_6_A7()
        {
            RunFile(@"S15.5.4.6_A7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("The String.prototype.concat.length property has the attribute DontEnum")]
        public void S15_5_4_6_A8()
        {
            RunFile(@"S15.5.4.6_A8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.5.4.6")]
        [Description("The String.prototype.concat.length property has the attribute DontDelete")]
        public void S15_5_4_6_A9()
        {
            RunFile(@"S15.5.4.6_A9.js");
        }
    }
}