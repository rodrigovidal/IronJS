// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
* @name: S15.3.4.2_A6;
* @section: 15.3.4.2, 13.2;
* @assertion: Function.prototype.toString has not prototype property;
* @description: Checking if obtaining the prototype property of Function.prototype.toString fails;
*/


// Converted for Test262 from original Sputnik source

ES5Harness.registerTest( {
id: "S15.3.4.2_A6",

path: "TestCases/15_Native/15.3_Function_Objects/15.3.4_Properties_of_the_Function_Prototype_Object/15.3.4.2_Function.prototype.toString/S15.3.4.2_A6.js",

assertion: "Function.prototype.toString has not prototype property",

description: "Checking if obtaining the prototype property of Function.prototype.toString fails",

test: function testcase() {
   //CHECK#1
if (Function.prototype.toString.prototype !== undefined) {
  $ERROR('#1: Function.prototype.toString has not prototype property'+Function.prototype.toString.prototype);
}

 }
});
