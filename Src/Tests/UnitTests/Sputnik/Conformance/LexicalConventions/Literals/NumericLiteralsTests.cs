// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.LexicalConventions.Literals
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class NumericLiteralsTests : SputnikTestFixture
    {
        public NumericLiteralsTests()
            : base(@"Conformance\07_Lexical_Conventions\7.8_Literals\7.8.3_Numeric_Literals")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [TestCase("S7.8.3_A1.1_T1.js", Description = "DecimalLiteral :: DecimalIntegerLiteral")]
        [TestCase("S7.8.3_A1.1_T2.js", Description = "DecimalLiteral :: DecimalIntegerLiteral")]
        [TestCase("S7.8.3_A3.1_T1.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. ")]
        [TestCase("S7.8.3_A3.1_T2.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. ")]
        public void DecimalLiteralDecimalIntegerLiteral(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [TestCase("S7.8.3_A1.2_T1.js", Description = "DecimalLiteral :: DecimalIntegerLiteral ExponentPart")]
        [TestCase("S7.8.3_A1.2_T2.js", Description = "DecimalLiteral :: DecimalIntegerLiteral ExponentPart")]
        [TestCase("S7.8.3_A1.2_T3.js", Description = "DecimalLiteral :: DecimalIntegerLiteral ExponentPart")]
        [TestCase("S7.8.3_A1.2_T4.js", Description = "DecimalLiteral :: DecimalIntegerLiteral ExponentPart")]
        [TestCase("S7.8.3_A1.2_T5.js", Description = "DecimalLiteral :: DecimalIntegerLiteral ExponentPart")]
        [TestCase("S7.8.3_A1.2_T6.js", Description = "DecimalLiteral :: DecimalIntegerLiteral ExponentPart")]
        [TestCase("S7.8.3_A1.2_T7.js", Description = "DecimalLiteral :: DecimalIntegerLiteral ExponentPart")]
        [TestCase("S7.8.3_A1.2_T8.js", Description = "DecimalLiteral :: DecimalIntegerLiteral ExponentPart")]
        [TestCase("S7.8.3_A3.3_T1.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. ExponentPart")]
        [TestCase("S7.8.3_A3.3_T2.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. ExponentPart")]
        [TestCase("S7.8.3_A3.3_T3.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. ExponentPart")]
        [TestCase("S7.8.3_A3.3_T4.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. ExponentPart")]
        [TestCase("S7.8.3_A3.3_T5.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. ExponentPart")]
        [TestCase("S7.8.3_A3.3_T6.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. ExponentPart")]
        [TestCase("S7.8.3_A3.3_T7.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. ExponentPart")]
        [TestCase("S7.8.3_A3.3_T8.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. ExponentPart")]
        public void DecimalLiteralDecimalIntegerLiteralExponentPart(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [TestCase("S7.8.3_A2.1_T1.js", Description = "DecimalLiteral :: .DecimalDigits")]
        [TestCase("S7.8.3_A2.1_T2.js", Description = "DecimalLiteral :: .DecimalDigits")]
        [TestCase("S7.8.3_A2.1_T3.js", Description = "DecimalLiteral :: .DecimalDigits")]
        public void DecimalLiteralDecimalDigits(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [TestCase("S7.8.3_A2.2_T1.js", Description = "DecimalLiteral :: .DecimalDigits ExponentPart")]
        [TestCase("S7.8.3_A2.2_T2.js", Description = "DecimalLiteral :: .DecimalDigits ExponentPart")]
        [TestCase("S7.8.3_A2.2_T3.js", Description = "DecimalLiteral :: .DecimalDigits ExponentPart")]
        [TestCase("S7.8.3_A2.2_T4.js", Description = "DecimalLiteral :: .DecimalDigits ExponentPart")]
        [TestCase("S7.8.3_A2.2_T5.js", Description = "DecimalLiteral :: .DecimalDigits ExponentPart")]
        [TestCase("S7.8.3_A2.2_T6.js", Description = "DecimalLiteral :: .DecimalDigits ExponentPart")]
        [TestCase("S7.8.3_A2.2_T7.js", Description = "DecimalLiteral :: .DecimalDigits ExponentPart")]
        [TestCase("S7.8.3_A2.2_T8.js", Description = "DecimalLiteral :: .DecimalDigits ExponentPart")]
        public void DecimalLiteralDecimalDigitsExponentPart(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [TestCase("S7.8.3_A3.2_T1.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. DecimalDigits")]
        [TestCase("S7.8.3_A3.2_T2.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. DecimalDigits")]
        [TestCase("S7.8.3_A3.2_T3.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. DecimalDigits")]
        public void DecimalLiteralDecimalIntegerLiteralDecimalDigits(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [TestCase("S7.8.3_A3.4_T1.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. DecimalDigigts ExponentPart")]
        [TestCase("S7.8.3_A3.4_T2.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. DecimalDigigts ExponentPart")]
        [TestCase("S7.8.3_A3.4_T3.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. DecimalDigigts ExponentPart")]
        [TestCase("S7.8.3_A3.4_T4.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. DecimalDigigts ExponentPart")]
        [TestCase("S7.8.3_A3.4_T5.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. DecimalDigigts ExponentPart")]
        [TestCase("S7.8.3_A3.4_T6.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. DecimalDigigts ExponentPart")]
        [TestCase("S7.8.3_A3.4_T7.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. DecimalDigigts ExponentPart")]
        [TestCase("S7.8.3_A3.4_T8.js", Description = "DecimalLiteral :: DecimalIntegerLiteral. DecimalDigigts ExponentPart")]
        public void DecimalLiteralDecimalIntegerLiteralDecimalDigigtsExponentPart(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [TestCase("S7.8.3_A4.1_T1.js", Description = "DecimalLiteral :: ExponentPart is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.3_A4.1_T2.js", Description = "DecimalLiteral :: ExponentPart is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.3_A4.1_T3.js", Description = "DecimalLiteral :: ExponentPart is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.3_A4.1_T4.js", Description = "DecimalLiteral :: ExponentPart is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.3_A4.1_T5.js", Description = "DecimalLiteral :: ExponentPart is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.3_A4.1_T6.js", Description = "DecimalLiteral :: ExponentPart is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.3_A4.1_T7.js", Description = "DecimalLiteral :: ExponentPart is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.3_A4.1_T8.js", Description = "DecimalLiteral :: ExponentPart is incorrect", ExpectedException = typeof(Exception))]
        public void DecimalLiteralExponentPartIsIncorrect(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [TestCase("S7.8.3_A4.2_T1.js", Description = "ExponentPart :: ExponentIndicator ( /+/-) 0 DecimalDigits is allowed")]
        [TestCase("S7.8.3_A4.2_T2.js", Description = "ExponentPart :: ExponentIndicator ( /+/-) 0 DecimalDigits is allowed")]
        [TestCase("S7.8.3_A4.2_T3.js", Description = "ExponentPart :: ExponentIndicator ( /+/-) 0 DecimalDigits is allowed")]
        [TestCase("S7.8.3_A4.2_T4.js", Description = "ExponentPart :: ExponentIndicator ( /+/-) 0 DecimalDigits is allowed")]
        [TestCase("S7.8.3_A4.2_T5.js", Description = "ExponentPart :: ExponentIndicator ( /+/-) 0 DecimalDigits is allowed")]
        [TestCase("S7.8.3_A4.2_T6.js", Description = "ExponentPart :: ExponentIndicator ( /+/-) 0 DecimalDigits is allowed")]
        [TestCase("S7.8.3_A4.2_T7.js", Description = "ExponentPart :: ExponentIndicator ( /+/-) 0 DecimalDigits is allowed")]
        [TestCase("S7.8.3_A4.2_T8.js", Description = "ExponentPart :: ExponentIndicator ( /+/-) 0 DecimalDigits is allowed")]
        public void ExponentPartExponentIndicator0DecimalDigitsIsAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [TestCase("S7.8.3_A5.1_T1.js", Description = "DecimalLiteral :: HexIntegerLiteral")]
        [TestCase("S7.8.3_A5.1_T2.js", Description = "DecimalLiteral :: HexIntegerLiteral")]
        [TestCase("S7.8.3_A5.1_T3.js", Description = "DecimalLiteral :: HexIntegerLiteral")]
        [TestCase("S7.8.3_A5.1_T4.js", Description = "DecimalLiteral :: HexIntegerLiteral")]
        [TestCase("S7.8.3_A5.1_T5.js", Description = "DecimalLiteral :: HexIntegerLiteral")]
        [TestCase("S7.8.3_A5.1_T6.js", Description = "DecimalLiteral :: HexIntegerLiteral")]
        [TestCase("S7.8.3_A5.1_T7.js", Description = "DecimalLiteral :: HexIntegerLiteral")]
        [TestCase("S7.8.3_A5.1_T8.js", Description = "DecimalLiteral :: HexIntegerLiteral")]
        public void DecimalLiteralHexIntegerLiteral(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [TestCase("S7.8.3_A6.1_T1.js", Description = "HexIntegerLiteral :: 0(x/X) is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.3_A6.1_T2.js", Description = "HexIntegerLiteral :: 0(x/X) is incorrect", ExpectedException = typeof(Exception))]
        public void HexIntegerLiteral0XXIsIncorrect(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 7.8.3")]
        [TestCase("S7.8.3_A6.2_T1.js", Description = "0xG is incorrect", ExpectedException = typeof(Exception))]
        [TestCase("S7.8.3_A6.2_T2.js", Description = "0xG is incorrect", ExpectedException = typeof(Exception))]
        public void _0xGIsIncorrect(string file)
        {
            RunFile(file);
        }
    }
}