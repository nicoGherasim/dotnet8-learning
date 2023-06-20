// See https://aka.ms/new-console-template for more information

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

Console.WriteLine("Give me your age:");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("age: " + age);

// operatori
// aritmetici 
// + - * / %
int s = 3 + 5;
int x = 10 % 3; // modulo - a % b -> restul impartirii lui a la b
Console.WriteLine(x);
Console.WriteLine("impartire");
Console.WriteLine(10 / 3);
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

// 1. Definiti cate o varibila pentru fiecare din valorile urmatoare
// folosind cel mai potrivit tip de date:
// 1, 123, x, csharp, 123.5, true, 12345678901234567890

byte one = 1;
byte two = 123;
char three = 'x';
string four = "csharp";
double five = 123.5;
bool six = true;
ulong seven = 12345678901234567890;

Console.WriteLine("------------------------IF----------------------------------");
//if (conditie)
//{
//	// execute this code
//}
// else
//{
// //execute this code
//}

int varsta = 80;
if (varsta < 65)
{
    Console.WriteLine("get to work!");
}
else
{
    Console.WriteLine("happy retirement!");
}

varsta = 80;
int varstaCopil = 25;
if (varsta < 65 && varstaCopil > 20)
{
    Console.WriteLine("get to work!");
}
else
{
    Console.WriteLine("happy retirement!");
}

varsta = 97;
if (varsta < 90)
{
    Console.WriteLine("lower than 90");
    //if 
}
else if (varsta < 95)
{
    Console.WriteLine("lower than 95");
}
else
{
    Console.WriteLine("greater or equal to 95");
}

// 2. Cititi doua numere de la utilizator si afisati suma lor daca primul nr e mai mic sau egal decat al doilea
// si diferenta lor daca primul numar e mai mare decat al doilea.
// Asigurati-va ca utilizatorul are o experienta placuta.'

Console.WriteLine("first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("second number:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("first number is greater than the second number");
    Console.WriteLine(number1 - number2);
}
else
{
    Console.WriteLine("first number is lover than the second number");
    Console.WriteLine(number1 + number2);
}

// 3. Cititi doua nume de la utilizator. Afisati "Same" daca cele doua nume sunt identice si "Not the same" in caz contrar.
// Asigurati-va ca utilizatorul are o experienta placuta.

Console.WriteLine("first name:");
string firstName = Console.ReadLine();
Console.WriteLine("second name:");
string secondName = Console.ReadLine();
if (firstName == secondName)
{
    Console.WriteLine("Same");
}
else
{
    Console.WriteLine("Not the same");
}

// 4. Cititi doua cuvinte de la utilizator. Afisati "alphabetically ordered" daca cele doua sunt date in ordine alfabetica
// si "not alphabetically ordered" daca cele doua cuvinte nu sunt date in ordine alfabetica.
// Asigurati-va ca utilizatorul are o experienta placuta.

Console.WriteLine("first word:");
string firstWord = Console.ReadLine();
Console.WriteLine("second word:");
string secondWord = Console.ReadLine();
if (string.Compare(firstWord, secondWord) <= 0)
{
    Console.WriteLine("alphabetically ordered");
}
else
{
    Console.WriteLine("not alphabetically ordered");
}

Console.WriteLine("------------------------SWITCH----------------------------------");
//switch (conditie)
//{
//    case x:
//        {
//            //execute code
//            //break;
//        }
//    case y:
//        {
//            //execute code
//            //break;
//        }
//    default:
//        {
//            //execute code
//            //break;
//        }
//}

int day = 3;

if(day == 1)
{
    Console.WriteLine("mon");
} 
else if (day == 2)
{
    Console.WriteLine("tue");
} 
else if (day == 3)
{
    Console.WriteLine("wed");
}
else if (day == 4)
{
    Console.WriteLine("thu");
}
else if (day == 5)
{
    Console.WriteLine("fri");
}
else if (day == 6)
{
    Console.WriteLine("sat");
}
else if (day == 7)
{
    Console.WriteLine("sun");
}
else
{
    Console.WriteLine("unknown!");
}

// the IF above and the SWITCH below are equivalent - they do the same thing
switch (day)
{
    case 1:
        {
            Console.WriteLine("mon");
            break;
        }
    case 2:
        {
            Console.WriteLine("tue");
            break;
        }
    case 3:
        {
            Console.WriteLine("wed");
            break;
        }
    case 4:
        {
            Console.WriteLine("thu");
            break;
        }
    case 5:
        {
            Console.WriteLine("fri");
            break;
        }
    case 6:
        {
            Console.WriteLine("sat");
            break;
        }
    case 7:
        {
            Console.WriteLine("sun");
            break;
        }
    default:
        {
            Console.WriteLine("unknown!");
            break;
        }
}

// 5. Cititi un numar de la utilizator.
// Folositi switch ca sa afisati lunile anului sau "unknown" in functie de numarul citit.

Console.WriteLine("number:");
int month = Convert.ToInt32(Console.ReadLine());
switch (month)
{
    case 1:
        {
            Console.WriteLine("jan");
            break;
        }
    case 2:
        {
            Console.WriteLine("feb");
            break;
        }
    case 3:
        {
            Console.WriteLine("mar");
            break;
        }
    case 4:
        {
            Console.WriteLine("apr");
            break;
        }
    case 5:
        {
            Console.WriteLine("may");
            break;
        }
    case 6:
        {
            Console.WriteLine("jun");
            break;
        }
    case 7:
        {
            Console.WriteLine("jul");
            break;
        }
    case 8:
        {
            Console.WriteLine("aug");
            break;
        }
    case 9:
        {
            Console.WriteLine("sep");
            break;
        }
    case 10:
        {
            Console.WriteLine("oct");
            break;
        }
    case 11:
        {
            Console.WriteLine("nov");
            break;
        }
    case 12:
        {
            Console.WriteLine("dec");
            break;
        }
    default:
        {
            Console.WriteLine("unknown!");
            break;
        }
}