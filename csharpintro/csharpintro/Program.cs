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
//Console.WriteLine();
//Console.WriteLine("Give me your name:");
//string name = Console.ReadLine();
//Console.WriteLine("Hello, " + name + "!");

//Console.WriteLine("Give me your age:");
//string inputtedAge = Console.ReadLine();
//int age = Convert.ToInt32(inputtedAge);
//Console.WriteLine("age: " + age);

//Console.WriteLine("Give me your age:");
//age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("age: " + age);

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

Console.WriteLine("------------------------IF------------------------");
//if (conditie)
//{
//	// execute this code
//}
// else
//{
// //execute this code
//}

int varsta = 80;
int maxAge = 65;
if (varsta < maxAge)
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

//Console.WriteLine("first number:");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("second number:");
//int number2 = Convert.ToInt32(Console.ReadLine());
//if (number1 > number2) // <=
//{
//    Console.WriteLine("first number is greater than the second number");
//    Console.WriteLine(number1 - number2);
//}
//else
//{
//    Console.WriteLine("first number is lover than the second number");
//    Console.WriteLine(number1 + number2);
//}

// 3. Cititi doua nume de la utilizator. Afisati "Same" daca cele doua nume sunt identice si "Not the same" in caz contrar.
// Asigurati-va ca utilizatorul are o experienta placuta.

//Console.WriteLine("first name:");
//string firstName = Console.ReadLine();
//Console.WriteLine("second name:");
//string secondName = Console.ReadLine();
//if (firstName == secondName)
//{
//    Console.WriteLine("Same");
//}
//else
//{
//    Console.WriteLine("Not the same");
//}

// 4. Cititi doua cuvinte de la utilizator. Afisati "alphabetically ordered" daca cele doua sunt date in ordine alfabetica
// si "not alphabetically ordered" daca cele doua cuvinte nu sunt date in ordine alfabetica.
// Asigurati-va ca utilizatorul are o experienta placuta.

Console.WriteLine("first word:");
string firstWord = "ana";//Console.ReadLine();
Console.WriteLine("second word:");
string secondWord = "maria";// Console.ReadLine();
if (string.Compare(firstWord, secondWord) <= 0)
{
    Console.WriteLine("alphabetically ordered");
}
else
{
    Console.WriteLine("not alphabetically ordered");
}

Console.WriteLine("------------------------SWITCH------------------------");
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
int month = 2;//Convert.ToInt32(Console.ReadLine());
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

Console.WriteLine("------------------------ARRAY------------------------");
int[] numbers = new int[5] { 5, 2, 6, 8, 1 }; 
string[] words = new string[5] { "5", "2, 6, 8, 1", "ana", "pisica", "condition" };

int[] numbers1 = new int[6];
numbers1[0] = 25;
Console.WriteLine(numbers1[0]);

int sumaArray = numbers[0] + numbers[3] + numbers[2];
Console.WriteLine(sumaArray);

// 1 2 3
// 4 5 6
int[,] matrix = new int[2, 3];
matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;
matrix[1, 0] = 4;
matrix[1, 1] = 5;
matrix[1, 2] = 6;
Console.WriteLine(matrix[1, 1]);
matrix[1, 1] = 12344567;
Console.WriteLine(matrix[1, 1]);

//1
//Declare an array that will have 5 integer elements (12, 14, 34, 567, 34).
//Add those 5 elements into the array one by one. Print the value of the second element in the array.
Console.WriteLine();
Console.WriteLine("Ex1");
int[] n1 = new int[5];
n1[0] = 12;
n1[1] = 14;
n1[2] = 34;
n1[3] = 567;
n1[4] = 34;
Console.WriteLine(n1[1]);

//2
//Store and print the sum of the first three elements of the array and the product the last two elements in the array.
//Print the sum of the two results above (sum + product).
// sum = 60, prod = 19278
// sum2 = 19338
Console.WriteLine();
Console.WriteLine("Ex2");
int suma = n1[0] + n1[1] + n1[2];
int prod = n1[3] * n1[4];
Console.WriteLine("sum=" + suma + " prod=" + prod);
int suma2 = sum + prod;
Console.WriteLine("sum=" + suma2);


Console.WriteLine("------------------------LIST------------------------");
List<int> numere = new List<int> { 3, 5, 2, 13, 7, 10 };
numere[0] = 456;
numere.Add(123);
Console.WriteLine(numere[0]);
Console.WriteLine(numere[6]);

Console.WriteLine(numere.Contains(987));
Console.WriteLine(numere.Last());

//1
//Declare a list that will have 5 integer elements (12, 14, 34, 567, 34).
//Add those 5 elements into the list one by one. Print the value of the second element in the list.
Console.WriteLine();
Console.WriteLine("Ex1");
List<int> l4 = new List<int>();
l4.Add(12);
l4.Add(14);
l4.Add(34);
l4.Add(567);
l4.Add(34);
Console.WriteLine(l4[1]);

//2
//Declare a list that will contain 3 names (Ana, Victor, Luca).
//Print all the three names comma separated on the same line.
// Ana, Victor, Luca
Console.WriteLine();
Console.WriteLine("Ex2"); List<string> l5 = new List<string> { "Ana", "Victor", "Luca" };
Console.WriteLine(l5[0] + ", " + l5[1] + ", " + l5[2]);
//the line below is equivalent to the line above - it does the same thing using string interpolation (that $ and {})
Console.WriteLine($"{l5[0]}, {l5[1]}, {l5[2]}");

Console.WriteLine("------------------------QUEUE------------------------");
Queue<int> coada = new Queue<int>();
coada.Enqueue(12);
coada.Enqueue(45);
coada.Enqueue(34);
Console.WriteLine(coada.Peek());
coada.Dequeue();
Console.WriteLine(coada.Peek());
Console.WriteLine(coada.Last());

//1
//Declare a queue that will have 5 integer elements (12, 14, 34, 567, 34).
//Add those 5 elements into the queue one by one. Print the value of the second element in the queue.
Console.WriteLine();
Console.WriteLine("Ex1");
Queue<int> q1 = new Queue<int>();
q1.Enqueue(12);
q1.Enqueue(14);
q1.Enqueue(34);
q1.Enqueue(567);
q1.Enqueue(34);
Console.WriteLine(q1.ElementAt(1));

Console.WriteLine("------------------------STACK------------------------");
Stack<int> stiva = new Stack<int>(5);stiva.Push(65);stiva.Push(12);stiva.Push(89);Console.WriteLine(stiva.Peek());Console.WriteLine(stiva.Pop());Console.WriteLine(stiva.Peek());Console.WriteLine(stiva.Count);
//1
//Declare a stack that will have 5 integer elements (12, 14, 34, 567, 34).
//Add those 5 elements into the stack one by one.Print the value of the second element in the stack.
Console.WriteLine();
Console.WriteLine("Ex1");
Stack<int> s1 = new Stack<int>();
s1.Push(12);
s1.Push(14);
s1.Push(34);
s1.Push(567);
s1.Push(34);
Console.WriteLine(s1.ElementAt(1));

Console.WriteLine("------------------------DICTIONARY------------------------");

List<int> l = new List<int> { 3, 5, 2, 13, 7, 10 };
Dictionary<int, string> elements = new Dictionary<int, string>{ { 123, "ana" }, { 234, "maria" }, { 345, "ioana" } };
Console.WriteLine(elements[123]);

Dictionary<string, string> d = new Dictionary<string, string>();
d.Add("a", "ana");
d.Add("b", "banana");
d.Add("e", "ene");

Console.WriteLine(d["e"]);
Console.WriteLine(d.ElementAt(0).Key);
Console.WriteLine(d.ContainsKey("j"));
Console.WriteLine(d.ContainsValue("banana"));

Dictionary<int, List<string>> d2 = new Dictionary<int, List<string>>();
List<string> letters = new List<string> { "a", "b", "c" };

d2.Add(45, letters);
d2.Add(89, new List<string> { "x", "y" });

Console.WriteLine(d2[45][0]);

Dictionary<string, List<string>> d3 = new Dictionary<string, List<string>>();
d3.Add("nico", new List<string> { "x", "y" });
Console.WriteLine(d3["nico"][1]);

//1
//Declare a dictionary that will have 5 elements (key value pair of int and string, grade and child name).
//Add those 5 elements into the dictionary one by one. Print the value of one of the elements in the dictionary.
Console.WriteLine();
Dictionary<int, string> dict6 = new Dictionary<int, string>();
dict6.Add(5, "Ana");
dict6.Add(6, "Ioan");
dict6.Add(10, "Maria");
dict6.Add(8, "Teodora");
dict6.Add(9, "Mihaela");
Console.WriteLine(dict6[8]);

//2
//Declare a dictionary that will contain 5 elements (key value pair of int and a list of strings, grade and children names).
//Print the name of the first child in the dictionary that got a 10 and the second child that got an 8.
Console.WriteLine();
Dictionary<int, List<string>> dict1 = new Dictionary<int, List<string>>
            {
                { 5, new List<string>() { "Ana" }  },
                { 6, new List<string>() { "Ioana", "Ioan" }  },
                { 8, new List<string>() { "Diana", "Andrei", "Laura" }  },
                { 10, new List<string>() { "Mihaela" }  },
            };
Console.WriteLine(dict1[10][0]);
Console.WriteLine(dict1[8][1]);


Console.WriteLine("------------------------FOR------------------------");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine();
int j1 = 1;
for(; j1 <= 5; j1++)
{
    Console.WriteLine(j1);
}

Console.WriteLine();
for (int k = 1; ; k++)
{
    if(k > 5)
    {
        break;
    }
    Console.WriteLine(k);
}

Console.WriteLine();
for (int q = 1; q <= 5;)
{
    Console.WriteLine(q);
    q++;
}

Console.WriteLine();
int m = 1;
for(; ; )
{
    if (m > 5)
    {
        break;
    }
    Console.WriteLine(m);
    m++;
}

Console.WriteLine();
List<int> numbersList = new List<int>();
//instead of doing this a lot of times:
//numbers.Add(123);
//numbers.Add(124);
//we can do this:
for (int i = 123; i <= 456; i++)
{
    numbersList.Add(i);
}

for (int i = 0; i < numbersList.Count; i++)
{
    Console.WriteLine(numbersList[i]);
}

//1
//Print all even numbers from 1 to 15
Console.WriteLine();
for (int i = 1; i <= 15; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
//the above for is equivalent with the one below
Console.WriteLine();
for (int i = 2; i <= 14; i += 2) // -> i = i + 2
{
    Console.WriteLine(i);
}

//2
//Print all even numbers from 15 to 1
Console.WriteLine();
for (int i = 15; i >= 1; i--)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
//the above for is equivalent with the one below
Console.WriteLine();
for (int i = 14; i >= 2; i -= 2) // -> i = i - 2
{
    Console.WriteLine(i);
}

//3
//Create a list of numbers that contains all the numbers that divide by 7 starting -100 to 100.
//Display the elements of the list.
Console.WriteLine();
List<int> list2 = new List<int>();
for (int i = -100; i <= 100; i++)
{
    if (i % 7 == 0)
    {
        list2.Add(i);
        Console.WriteLine(i);
    }
}

Console.WriteLine("------------------------FOREACH------------------------");
int[] arrayName = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
foreach (int element in arrayName)
{
    Console.WriteLine(element);
}

Console.WriteLine();
int[] arrayName1 = new int[] { 23, 45, 657, 12, 129 };
foreach (int element in arrayName1)
{
    Console.WriteLine(element * element);
}

Console.WriteLine();
List<string> names = new List<string> { "ana", "maria", "ioan" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

// 1
//Read 5 numbers from the user using a for loop and store them in a collection.
//Display the elements of the collection multiplied by 12.75 using a foreach loop.
Console.WriteLine();
List<int> list = new List<int>();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Number: ");
    int inputtedNumber = int.Parse(Console.ReadLine());
    list.Add(inputtedNumber);
}
double numberToMultiplyWith = 12.75;
Console.WriteLine($"Each element multiplied by {numberToMultiplyWith}");
foreach (int element in list)
{
    Console.WriteLine(element * numberToMultiplyWith);
}

Console.WriteLine("------------------------WHILE------------------------");
int n = 1;
while (n < 6)
{
    Console.WriteLine("Current value of n is " + n);
    //Console.WriteLine($"Current value of n is {n}");
    //Console.WriteLine("Current value of n is {0}", n);
    n++;
}

Console.WriteLine();
int o = 789;
while (o >= 678)
{
    Console.WriteLine(o);
    o -= 34;
}

//1 
//Create a list of numbers that contains all the numbers that divide by 7 starting -100 to 100.
//Display the elements of the list. Use while loop.
Console.WriteLine();
int n2 = -100;
List<int> l10 = new List<int>();
while (n2 <= 100) // n < 101
{
    if (n2 % 7 == 0)
    {
        l10.Add(n2);
        Console.WriteLine(n2);
    }
    n2++;
}
// the while above is equivalent with the for below
Console.WriteLine();
List<int> list3 = new List<int>();
for (int i = -100; i <= 100; i++)
{
    if (i % 7 == 0)
    {
        list3.Add(i);
        Console.WriteLine(i);
    }
}

Console.WriteLine("------------------------DO WHILE------------------------");
x = 0;
do
{
    Console.WriteLine(x);
    x++;
} while (x < 5);

Console.WriteLine();
int y = 1234567890;
do
{
    Console.WriteLine(y);
    y--;
    Console.WriteLine(y);
} while (y < 5);

//1
//Print all the numbers between 56 and 987 that divide by 24. Use a do while loop.
Console.WriteLine();

int n7 = 56;
do
{
    if (n7 % 24 == 0)
    {
        Console.WriteLine(n7);
    }
    n7++;
} while (n7 <= 987);

Console.WriteLine("------------------------CONTINUE------------------------");
for (int i = 1; i <= 12; i++)
{
    Console.WriteLine("before continue");
    if (i == 2 || i == 5 || i == 7)
    {
        continue;
    }
    Console.WriteLine("after continue");
    Console.WriteLine(i);
}

Console.WriteLine("------------------------BREAK------------------------");
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine("before break");
    if (i == 5)
    {
        break;
    }
    Console.WriteLine("after break");
    Console.WriteLine(i);
}

Console.WriteLine("------------------------DEBUG------------------------");
// debug - means removing bugs from your code

// bugs - refers to an error, fault, or flaw in any computer program or a hardware system

// most bugs occur due to errors and mistakes made by developers when constructing the source code

// debugging - run your code step by step in order to remove bugs

// debugger - means that there is one tool actively monitors everything that’s happening as the program runs.
// It also allows you to pause the app at any point to examine its state and then step through your code
// line by line to watch every detail as it happens.

// breakpoint 
// F9
// added on the line of code you want to examinate in detail
// indicates where Visual Studio should suspend your running code so you can take a closer look

// F11
// step into
// execute the next line of code and if the next line is a function call,
// Step Into will stop at the first line of the function

// F10
// step over
// execute the next line of code and if the next line is a function call,
// Step Over will execute the function, and will stop at the next line of code after the function

// F11 + shift
// step out
// this will return to the line where the current function was called

// F5 continue
// will continue executing the code, until the next breakpoint

Console.WriteLine();
Step1();

void Step1()
{
    Console.WriteLine("go to step2");
    Step2();
}
void Step2()
{
    Console.WriteLine("go to step3");
    Step3();
}

void Step3()
{
    Console.WriteLine("stop");
}

// the functions/methods above will run as the code below
Console.WriteLine("go to step2");
Console.WriteLine("go to step3");
Console.WriteLine("stop");

Console.WriteLine("------------------------ALGORITHMS------------------------");
// un set finit de pasi
// care se executa cu scopul de a rezolva o problema sau de indeplini o sarcina
// simpli sau complecsi in functie de problema pe care o rezolva
// input -> pasi (procesare/instructiuni) -> output

//Every time you bake or cook something, you follow a set of steps to put the ingredients together and produce a final product.
//If you were asked to write down instructions to make your recipe,you could create your own algorithm.
//You would only need to specify : 
//Inputs: Ingredients and quantities
//Process: recipe or method 
//Output: What the finished meal will be like 

// MATRIX
// 2 6
// 9 3
// 7 5

int[,] matrice = new int[3, 3]
{
                {2, 6, 3},
                {9, 3, 1},
                {7, 5, 8}
};

Console.WriteLine();
Console.WriteLine(matrice[0,0]);
Console.WriteLine(matrice[0,1]);
Console.WriteLine();

int numberOfRows = matrice.GetLength(0);
int numberOfColumns = matrice.GetLength(1);

for(int i = 0; i < numberOfRows; i++)
{
    for(int j = 0;  j < numberOfColumns; j++)
    {
        Console.Write(matrice[i,j] + " ");
    }
    Console.WriteLine();
}

// 1
// Write an algorithm that iterates two different lists
// (declared in advance with different number of elements)
// and print the sum of each element of the first list with each element of the second list.
// Use only foreach loops.

// l1: 4, 8, 5, 3
// l2: 40, 80, 50, 30, 100
// result: 44, 84, 54, 34, 104, 48, 88, 58, 38, 108, 45, 85, 55, 35, 105, 43, 83, 53, 33, 103 

Console.WriteLine();
List<int> l1 = new List<int> { 4, 8, 5, 3 };
List<int> l2 = new List<int> { 40, 80, 50, 30, 100, 70, 50 };

foreach(int i in l1)
{
    foreach (int j in l2)
    {
        Console.Write((i + j) + ", ");
    }
}

// 2 MIN MAX
// Print the minimum value and the maximum value of an array.
// Do not use array.Min() or array.Max().

Console.WriteLine();
int[] myArray1 = new int[] { -1, 2, 3, 8, -12, 56, 128, 7 };

Console.WriteLine(myArray1.Min());
Console.WriteLine(myArray1.Max());

int min = myArray1[0];
int max = myArray1[0];

foreach(int i in myArray1)
{
    if(i < min)
    {
        min = i;
    }
    if(i > max)
    {
        max = i;
    }
}
Console.WriteLine("min: " + min + ", max: " + max);

// 3 PRIME NUMBER
// Write an algorithm to check if a number is prime or not (it only divides by 1 and itself).
// Print "the number is prime" is so or "the number is not prime" otherwise.
// Prime numbers: 13, 23
// Not prime numbers: 12, 24, 15

Console.WriteLine();
int numberToBeChecked = 12;
bool isPrime = true;

for (int i = 2; i < numberToBeChecked; i++)
{
    if (numberToBeChecked % i == 0)
    {
        isPrime = false;
        break;
    }
}

if (isPrime)
{
    Console.WriteLine("the number is prime");
}
else
{
    Console.WriteLine("the number is not prime");
}

// 4 SWAP VARIABLES
// a = 12 b = 15
// a = 15 b = 13

int a = 12;
int b = 15;
int temp;

Console.WriteLine(a + " " + b);
temp = b;
Console.WriteLine(a + " " + b);
b = a;
Console.WriteLine(a + " " + b);
a = temp;
Console.WriteLine(a + " " + b);

// 5 PALINDROME
// Write an algorithm to check if a number is a palindrome or not (it is the same read from both ends).
// Print "the number is palindrome" if so or "the number is not palindrome" otherwise.
// 2002, 1991, 121, 909, 22
// not palindrome 1932 -> 2391

Console.WriteLine();
int numberToCheck = 2002;
int reverse = 0;
int rest, temporary = numberToCheck;

// 1932 
// 0
// 0* 10 + 2 -> 193
// 2 * 10 + 3 -> 19
// 23 * 10 + 9 -> 1
// 239 * 10 + 1 -> 0

while(temporary > 0)
{
    rest = temporary % 10;
    temporary = temporary / 10;
    reverse = (reverse * 10) + rest;
}

if(nr == reverse)
{
    Console.WriteLine("the number is palindrome");
}
else
{
    Console.WriteLine("the number is not palindrome");
}

// 6 SEARCH
// Given an unsorted array which might have a number in the majority
// (a number appears at least 50 % in the array),
// find and print the first majority number if it exists.

Console.WriteLine();
myArray1 = new int[] { 72, 23, 17, 17, 17, 23, 23, 23, 23, 23 };

for (int i = 0; i < myArray1.Length; i++)
{
    int count = 1;

    for (int j = i + 1; j < myArray1.Length; j++)
    {
        if (myArray1[i] == myArray1[j])
        {
            count++;
        }
    }

    if (count >= myArray1.Length / 2)
    {
        Console.WriteLine("number = " + myArray1[i] + " count = " + count);
        break;
    }
}