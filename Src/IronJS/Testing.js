﻿var obj = {};

var foo = function (a1, a2, a3) {
    return function () {
        var x = "this is a string";
        x = a1; // will fail
    };
};


foo(1, 2, "lol")();