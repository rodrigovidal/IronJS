// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
* @name: S13.2.2_A3_T2;
* @section: 13.2.2, 15.2.3.1;
* @assertion: When the [[Construct]] property for a Function object F is called: 
* A new native ECMAScript object is created. 
* It gets the value of the [[Prototype]] property of the F(Denote it PROTO_VAL). 
* If PROTO_VAL is not an object, sets the [[Prototype]] property of native ECMAScript object just created
*  to the original Object prototype object as described in 15.2.3.1;
* @description: Declaring a function with "var __FACTORY = function()";
*/


// Converted for Test262 from original Sputnik source

ES5Harness.registerTest( {
id: "S13.2.2_A3_T2",

path: "TestCases/13_Function_Definition/13.2_Creating_Function_Objects/S13.2.2_A3_T2.js",

assertion: "When the [[Construct]] property for a Function object F is called:",

description: "Declaring a function with \"var __FACTORY = function()\"",

test: function testcase() {
   var __FACTORY = function(){};
__FACTORY.prototype=1;

//////////////////////////////////////////////////////////////////////////////
//CHECK#1
if (typeof __FACTORY.prototype !== 'number') {
	$ERROR('#1: typeof __FACTORY.prototype === \'number\'. Actual: typeof __FACTORY.prototype ==='+(typeof __FACTORY.prototype));
}
//
//////////////////////////////////////////////////////////////////////////////

var __device = new __FACTORY();

//////////////////////////////////////////////////////////////////////////////
//CHECK#2
if (!(Object.prototype.isPrototypeOf(__device))) {
	$ERROR('#2: Object.prototype.isPrototypeOf(__device) === true');
}
//
//////////////////////////////////////////////////////////////////////////////

 }
});
