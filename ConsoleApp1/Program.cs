using ConsoleApp1;

var firstNumber = 1;
int secondNumber = 2;
var thirdNumber = 3;
int? fourthNumber = 2321;

fourthNumber ??= 0 switch
{
	0 => secondNumber,
	_ => firstNumber,
};

Console.WriteLine(fourthNumber + " " + firstNumber + " " + thirdNumber + " " + Class1.Number);