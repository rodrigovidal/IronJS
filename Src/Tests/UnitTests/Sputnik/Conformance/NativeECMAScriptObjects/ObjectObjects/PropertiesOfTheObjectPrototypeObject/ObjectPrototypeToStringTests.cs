// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ObjectObjects.PropertiesOfTheObjectPrototypeObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ObjectPrototypeToStringTests : SputnikTestFixture
    {
        public ObjectPrototypeToStringTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.2_Object_Objects\15.2.4_Properties_of_the_Object_Prototype_Object\15.2.4.2_Object.prototype.toString")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.2.4.2")]
        [Description("When the toString method is called, the following steps are taken: i) Get the [[Class]] property of this object ii) Compute a string value by concatenating the three strings \"[object \", Result(1), and \"]\" iii) Return Result(2)")]
        public void S15_2_4_2_A1()
        {
            RunFile(@"S15.2.4.2_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.2.4.2")]
        [Description("The Object.prototype.toString.length property has the attribute ReadOnly")]
        public void S15_2_4_2_A10()
        {
            RunFile(@"S15.2.4.2_A10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.2.4.2")]
        [Description("The length property of the toString method is 0")]
        public void S15_2_4_2_A11()
        {
            RunFile(@"S15.2.4.2_A11.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.2.4.2")]
        [TestCategory("ECMA 13.2")]
        [Description("Object.prototype.toString has not prototype property")]
        public void S15_2_4_2_A6()
        {
            RunFile(@"S15.2.4.2_A6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.2.4.2")]
        [TestCategory("ECMA 13.2")]
        [Description("Object.prototype.toString can\'t be used as a constructor")]
        public void S15_2_4_2_A7()
        {
            RunFile(@"S15.2.4.2_A7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.2.4.2")]
        [Description("The Object.prototype.toString.length property has the attribute DontEnum")]
        public void S15_2_4_2_A8()
        {
            RunFile(@"S15.2.4.2_A8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.2.4.2")]
        [Description("The Object.prototype.toString.length property has the attribute DontDelete")]
        public void S15_2_4_2_A9()
        {
            RunFile(@"S15.2.4.2_A9.js");
        }
    }
}