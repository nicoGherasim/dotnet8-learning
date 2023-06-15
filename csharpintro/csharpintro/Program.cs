// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");
Console.WriteLine();
Console.WriteLine("un alt text");

// variablia
// tip nume = expresie
int number = 10;
int anotherNumber = 20 + 5;
Console.WriteLine(number);
Console.WriteLine(anotherNumber);

// numere intregi https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
// numere cu virgula https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
Console.WriteLine("afisare tipuri de date:");
// tipuri de date
// byte 0 - 255
byte byteSample = 3;
Console.WriteLine(byteSample);
// int - numere intregi 
int intSample = 678;
// long - numere intregi foarte mari
long longSample = 1234567890987656;
// float - numere cu virgula
float floatSample = 100.5f;
// double - numere cu virgula foarte mari
double doubleSample = 123456765432134.456;
Console.WriteLine(doubleSample);

Console.WriteLine();
Console.WriteLine($"byte stores numbers between {byte.MinValue} and {byte.MaxValue}");
Console.WriteLine($"int stores numbers between {int.MinValue} and {int.MaxValue}");
Console.WriteLine($"long stores numbers between {long.MinValue} and {long.MaxValue}");
Console.WriteLine($"float stores numbers between {float.MinValue} and {float.MaxValue}");
Console.WriteLine($"double stores numbers between {double.MinValue} and {double.MaxValue}");
Console.WriteLine();

// bool - True (1) / False (0)
bool boolSample = true;
Console.WriteLine("boolean value: " + boolSample);

// caractere
char charSample = 'a';
string stringSample = "apa" + " rece";
Console.WriteLine(charSample);
Console.WriteLine(stringSample);

// date
DateTime dateTimeSample = DateTime.Now;
Console.WriteLine(dateTimeSample);

// conversie / cast
int firstNumber = 123;
long secondNumber = firstNumber;

int thirdNumber = 765;
byte fourthNumber = (byte) thirdNumber;
Console.WriteLine(fourthNumber);

// var 
var anotherNumber1 = 100.5f;
var isTrue = true;
var myName = "Nico";

// ASA DA - cod usor de citit si inteles
int first = 5;
int second = 6;
int sum = first + second;
Console.WriteLine(sum);

// ASA NU - cod greu de citit si inteles
int u = 5;
int z = 6;
int e = u + z;
Console.WriteLine(e);

// citit input de la utilizator (tastatura)
Console.WriteLine();
Console.WriteLine("Give me your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name + "!");

Console.WriteLine("Give me your age:");
string inputtedAge = Console.ReadLine();
int age = Convert.ToInt32(inputtedAge);
Console.WriteLine("age: " + age);

// operatori
// aritmetici 
// + - * / %
int s = 3 + 5;
int x = 10 % 3; // modulo - a % b -> restul impartirii lui a la b
Console.WriteLine(x);
Console.WriteLine(10.0 / 3.0);

// ++ --
Console.WriteLine("++");
int c = 5;
Console.WriteLine(c);
Console.WriteLine(c++);
Console.WriteLine(++c);

// operatori de asignare
int nr = 5;
nr = nr + 10;
Console.WriteLine(nr);
// += -=
nr += 15; // nr = nr +15;
Console.WriteLine(nr);

// operatori de comparare
// == equals     != not equals
Console.WriteLine(5 == 6);
Console.WriteLine(5 != 6);
// >=, >, <=, <
Console.WriteLine(5 <= 6);

// operatori logici
// && logical and
// || logical or
// ! logical not
// https://www.codecademy.com/learn/learn-c-sharp/modules/learn-csharp-logic-conditionals/cheatsheet
Console.WriteLine(6 == 6 && 7 == 9);
Console.WriteLine(6 == 6 || 7 == 9);
Console.WriteLine(!(6 == 6));