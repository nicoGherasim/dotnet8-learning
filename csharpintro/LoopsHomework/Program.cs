//[Exercise 1]
//Given an array of integer numbers, print the total of all the values that are even numbers.
//[1, 2, 3, 4, 5] -> total = 6

Console.WriteLine("--- Ex 1 ---");

int[] numbers = new int[] { 123, 222, 335, 468, 580 };
int sum = 0;
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sum += number;
    }
}
Console.WriteLine($"The total of the even numbers is {sum}");

//[Exercise 2]
//Find if an array of integer numbers contains duplicates and display them if so.
//[1, 2, 3, 3, 4] -> 3

Console.WriteLine();
Console.WriteLine("--- Ex 2 ---");

numbers = new int[] { 1, 2, 3, 3, 4, 4, 5, 6, 6 };
List<int> duplicates = new List<int>();
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] == numbers[j])
        {
            duplicates.Add(numbers[i]);
        }
    }
}
Console.Write("The numbers that have duplicates are: ");
foreach (int duplicate in duplicates)
{
    Console.Write($"{duplicate} ");
}
Console.WriteLine();

//[Exercise 3]
//Check if there are duplicates in a list of strings. If yes, remove the them.
//{"a", "b", "b", "c", "c", "d"} -> { "a", "b", "c", "d"}

Console.WriteLine();
Console.WriteLine("--- Ex 3 ---");

List<string> strings = new List<string> { "a", "bbb", "b", "bbb", "cc", "cc", "c", "d", "c", "bb", "bbb" };
for (int i = 0; i < strings.Count; i++)
{
    for (int j = i + 1; j < strings.Count; j++)
    {
        if (strings[i] == strings[j])
        {
            strings.RemoveAt(j);
        }
    }
}
Console.Write("The array without duplicates is: ");
foreach (string elem in strings)
{
    Console.Write($"{elem} ");
}
Console.WriteLine();

//[Exercise 4]
//Write a program to count the frequency of each element in an array.
//[1, 4, 5, 2, 1, 4, 3, 1, 2] -> 1 - 3 times, 4 - 2 times, 5 - one time, 2 - 2 times, 3 - one time

Console.WriteLine();
Console.WriteLine("--- Ex 4 ---");

numbers = new int[] { 1, 2, 3, 3, 4, 4, 5, 6, 6, 7, 7, 7 };
Dictionary<int, int> numbersFrequency = new Dictionary<int, int>();

foreach (int number in numbers)
{
    if (numbersFrequency.ContainsKey(number))
    {
        numbersFrequency[number] += 1;
    }
    else
    {
        numbersFrequency.Add(number, 1);
    }
}

foreach (var numberFrequency in numbersFrequency)
{
    if (numberFrequency.Value > 1)
    {
        Console.WriteLine($"Number {numberFrequency.Key} - {numberFrequency.Value} times");
    }
    else
    {
        Console.WriteLine($"Number {numberFrequency.Key} - {numberFrequency.Value} time");
    }
}

//[Exercise 5]
//Read an array from the console and separate odd and even values into 2 arrays. 
//[3, 4, 5, 6, 7, 8] -> Odd array: [3, 5, 7], Even array: [4, 6, 8]

Console.WriteLine();
Console.WriteLine("--- Ex 5 ---");

Console.WriteLine("Provide the number of elements in the array: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());

numbers = new int[numberOfElements];
// using two lists instead of two array as the lists can have dynamic size
// if we were using arrays from the start the size of them should be specified and we don't know the size in advance
List<int> evenNumbers = new List<int>();
List<int> oddNumbers = new List<int>();

Console.WriteLine("Provide, one by one, the elements of your array: ");
for (int i = 0; i < numberOfElements; i++)
{
    Console.WriteLine($"Provide the element on index {i}:");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < numberOfElements; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenNumbers.Add(numbers[i]);
    }
    else
    {
        oddNumbers.Add(numbers[i]);
    }
}

// converting the lists into array as the requirement is to have two arrays in the end
int[] evenNumbersArray = evenNumbers.ToArray();
int[] oddNumbersArray = oddNumbers.ToArray();

// using the arrays above just as any array
Console.WriteLine("The even numbers array: ");
for (int i = 0; i < evenNumbersArray.Length; i++)
{
    Console.Write($"{evenNumbersArray[i]} ");

}

Console.WriteLine();
Console.WriteLine("The odd numbers array: ");
for (int i = 0; i < oddNumbersArray.Length; i++)
{
    Console.Write($"{oddNumbersArray[i]} ");
}
Console.WriteLine();

//[Exercise 6]
//Read two numbers, a and b, from the user and create a collection with all the numbers between a and b.
//Be sure to have the collection in ascending order (a to b if a < b, b to a if b < a).
//Print the collection elements. Print all numbers that divide by 3 starting from a to b. Use both for and foreach loops.
//a = 3, b = 15 => collection = 3, 4, 5, ..., 14, 15 & output => 3, 6, 9, 12, 15

Console.WriteLine();
Console.WriteLine("--- Ex 6 ---");

Console.WriteLine("Provide the start of the interval: ");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("Provide the end of the interval: ");
int end = int.Parse(Console.ReadLine());

List<int> startToEnd = new List<int>();

if (start < end)
{
    for (int i = start; i <= end; i++)
    {
        startToEnd.Add(i);
    }
}
else
{
    for (int i = end; i <= start; i++)
    {
        startToEnd.Add(i);
    }
}

Console.WriteLine("Elements that divide by 3");
foreach (int element in startToEnd)
{
    if (element % 3 == 0)
    {
        Console.WriteLine(element);
    }
}

//[Exercise 7]
//Add all numbers from 123 to 234 to a list (use FOR). For each element of the list print the following (use FOREACH):
//If number is divisible by 3, print the number and Fizz 
//If number is divisible by 5, print the number and Buzz
//If number is divisible by 3 and 5, print the number and FizzBuzz
//Otherwise, print the number

Console.WriteLine();
Console.WriteLine("--- Ex 7 ---");

List<int> fizzBuzzList = new List<int>();
for (int i = 123; i <= 234; i++)
{
    fizzBuzzList.Add(i);
}

foreach (int i in fizzBuzzList)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i + " FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i + " Fizz");
    }
    else if (i % 5 == 0)
    {

        Console.WriteLine(i + " Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

//[Exercise 8]
//Create a list that contains 10 names read from the user.
//Using while print the first 6 names of the list. {a, b, c, d, e, f, g, h, i, j} -> { a, b, c, d, e, f}

Console.WriteLine();
Console.WriteLine("--- Ex 8 ---");

List<string> names = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

int n8 = 0;
while (n8 <= 5)
{
    Console.WriteLine(names[n8]);
    n8++;
}

//[Exercise 9]
//Read numbers from the user until the input is 0. Use a do while loop.

Console.WriteLine();
Console.WriteLine("--- Ex 9 ---");

int n9;
do
{
    Console.WriteLine("Provide number (will stop when input is 0): ");
    n9 = int.Parse(Console.ReadLine());
} while (n9 != 0);


//[Exercise 10]
//Iterate from -1 to -123 and print all the numbers. Break the iteration when you find the first number that divides to 21. Use do while and break.

Console.WriteLine();
Console.WriteLine("--- Ex 10 ---");

int n10 = -1;
do
{
    if (n10 % 21 == 0)
    {
        Console.WriteLine("Teh first number that divides to 21 was found. It is " + n10);
        break;
    }
    Console.WriteLine(n10);
    n10--;
} while (n10 >= -100);

//[Exercise 11]
//Read 10 names from the user (use a while loop) and store them in a list.
//Display all the names from the list except for the ones that start with "a", "A", "b" or "B".
//Use continue.

Console.WriteLine();
Console.WriteLine("--- Ex 11 ---");

names = new List<string>();

int index = 0;
while (index < 10)
{
    Console.WriteLine("Provide the name on position " + index);
    names.Add(Console.ReadLine());
    index++;
}

Console.WriteLine("The names that don't start with a, A, b or B:");
foreach (string name in names)
{
    if (name.StartsWith("a") || name.StartsWith("A") || name.StartsWith("b") || name.StartsWith("B"))
    {
        continue;
    }
    Console.WriteLine(name);
}
