//[Exercise 1]
//Read two numbers from the user and display the mathematical operations result for division, multiplication,
//addition, subtraction and modulo. (Read C# Numbers)

// store the numbers in double data type so that not only the integer operations work
Console.WriteLine("Exercise 1:");
Console.WriteLine("Give me the first number:");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Give me the second number:");
double secondNumber = Convert.ToDouble(Console.ReadLine());

var sum = firstNumber + secondNumber;
Console.WriteLine("Addition = " + sum);

var diff = firstNumber - secondNumber;
Console.WriteLine("Substraction = " + diff);

var prod = firstNumber * secondNumber;
Console.WriteLine("Multiplication = " + prod);

var div = firstNumber / secondNumber;
Console.WriteLine("Division = " + div);

var mod = firstNumber % secondNumber;
Console.WriteLine("Modulo = " + mod);

//[Exercise 2]
//Write some examples when you use the following operators:
//+  -  *  /  %  ++  --  +=  -=

Console.WriteLine();
Console.WriteLine("Exercise 2:");
Console.WriteLine(123456+ 987654);
Console.WriteLine(6789 - 1234);
Console.WriteLine(567 * 4332);
Console.WriteLine(34565432345 % 2);
var number = 123;
Console.WriteLine(number++);
Console.WriteLine(number--);
Console.WriteLine(number);
number += 234;
Console.WriteLine(number);
number -= 765;
Console.WriteLine(number);

//[Exercise 3]
//Write some examples when you use the following operators:
// ==  !=  &&  ||  !

Console.WriteLine();
Console.WriteLine("Exercise 3:");
Console.WriteLine("ana" == "Ana" && "maria" != "Maria"); // false
Console.WriteLine("ana" != "Ana"); // true
Console.WriteLine(123 == 123 && (345 != 345 || 23 == 23)); // true 
Console.WriteLine((56 == 56 || 345 == 567) && (34 != 45) && (23 >= 34 || 34 >= 56)); // false
Console.WriteLine(!true || !false || !("ana" == "Ana")); // true