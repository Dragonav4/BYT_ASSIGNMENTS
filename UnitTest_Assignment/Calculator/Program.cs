// See https://aka.ms/new-console-template for more information

using Calculator;

var a = 8;
var b = 2;

var add = new Calculator.Calculator(a, b, "+").Calculate();
var sub = new Calculator.Calculator(a, b, "-").Calculate();
var mul = new Calculator.Calculator(a, b, "*").Calculate();
var div = new Calculator.Calculator(a, b, "/").Calculate();

Console.WriteLine($"{a} + {b} = {add}");
Console.WriteLine($"{a} - {b} = {sub}");
Console.WriteLine($"{a} * {b} = {mul}");
Console.WriteLine($"{a} / {b} = {div}");