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