// See https://aka.ms/new-console-template for more information

using GenericClasses;

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("----------------Generic Classes----------------");

var mySample = new Sample<int>();
mySample.Field = 1;
Console.WriteLine(mySample.ShowInfo());

var charSample = new Sample<char>();
charSample.Field = 'A';
Console.WriteLine(charSample.ShowInfo());

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("----------------Using Calculator----------------");

var calculatorI = new Calculator<int>();
Console.WriteLine($"Addition result: {calculatorI.Add(1, 2)}");

var calculatorD = new Calculator<double>();
Console.WriteLine($"Addition result: {calculatorD.Add(1.5, 2.5)}");

ShowValueAndType<Calculator<double>>(calculatorD);

//Generic functions
void ShowValueAndType<T>(T input)
{
    Console.WriteLine($"The input is {input} and is of type {input.GetType()}");
}