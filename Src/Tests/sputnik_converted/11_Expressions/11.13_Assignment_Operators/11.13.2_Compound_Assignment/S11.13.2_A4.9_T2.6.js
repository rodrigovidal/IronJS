// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
 * @name: S11.13.2_A4.9_T2.6;
 * @section: 11.13.2, 11.10.1;
 * @assertion: The production x &= y is the same as x = x & y; 
 * @description: Type(x) is different from Type(y) and both types vary between String (primitive or object) and Undefined;
 */


// Converted for Test262 from original Sputnik source

ES5Harness.registerTest( {
id: "S11.13.2_A4.9_T2.6",

path: "TestCases/11_Expressions/11.13_Assignment_Operators/11.13.2_Compound_Assignment/S11.13.2_A4.9_T2.6.js",

assertion: "The production x &= y is the same as x = x & y",

description: "Type(x) is different from Type(y) and both types vary between String (primitive or object) and Undefined",

test: function testcase() {
   //CHECK#1
x = "1";
x &= undefined;
if (x !== 0) {
  $ERROR('#1: x = "1"; x &= undefined; x === 0. Actual: ' + (x));
}

//CHECK#2
x = undefined;
x &= "1";
if (x !== 0) {
  $ERROR('#2: x = undefined; x &= "1"; x === 0. Actual: ' + (x));
}

//CHECK#3
x = new String("1");
x &= undefined;
if (x !== 0) {
  $ERROR('#3: x = new String("1"); x &= undefined; x === 0. Actual: ' + (x));
}

//CHECK#4
x = undefined;
x &= new String("1");
if (x !== 0) {
  $ERROR('#4: x = undefined; x &= new String("1"); x === 0. Actual: ' + (x));
}

 }
});
