//[Exercise 1]
//Read three integer numbers from the user and display the minimum and maximum number.
//Input:
//33 11 25
//Output:
//Minimum number is 11
//Maximum number is 33

Console.WriteLine("Provide first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Provide second number: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Provide third number: ");
int thirdNumber = int.Parse(Console.ReadLine());

// assume that the first number is the minimum and the maximum
int min = firstNumber, max = firstNumber;

//try to see i there is another min
if (secondNumber <= min && secondNumber <= thirdNumber)
{
    min = secondNumber;
}
else
{
    min = thirdNumber;
}

// try to see if there is another max
if (secondNumber >= max && secondNumber >= thirdNumber)
{
    max = secondNumber;
}
else
{
    max = thirdNumber;
}

Console.WriteLine($"Minimum: {min}");
Console.WriteLine($"Maximum: {max}");



//[Exercise 2]
//Resolve exercise 1 using ternary operator. (Find information about the ternary operator in the useful resources and online.)
//Input:
//13 99 - 441
//Output:
//Minimum number is -441
//Maximum number is 99

// ternary operator
// condition ? code if condition is true : code if condition is false

int ternaryMin = (secondNumber <= min && secondNumber <= thirdNumber) ? secondNumber : thirdNumber;
Console.WriteLine($"Minimum: {ternaryMin}");

int ternaryMax = (secondNumber >= max && secondNumber >= thirdNumber) ? secondNumber : thirdNumber;
Console.WriteLine($"Maximum: {ternaryMax}");



//[Exercise 3]
//Read a number from the keyboard which represents a number of days and convert to years (1 year = 356days),
//months(1 month = 30 days), weeks and days as in example. 
//Be careful here because when we have just 1 year, we will display "1 year" and not "1 years". Same for months and days.
//Input:
//1239
//Output:
//3 years, 4 months, 24 days
//Input:
//409
//Output:
//1 year, 1 month, 14 days

Console.WriteLine("Enter the number of days you want to convert: ");
int numberOfDaysToConvert = Convert.ToInt32(Console.ReadLine());

int numberOfYears = numberOfDaysToConvert / 365;
// the rest of what has been already converted to years gets converted to months by dividing to 30
int numberOfMonths = (numberOfDaysToConvert % 365) / 30; 
// the rest of what has been already converted to years gets converted to days by doing modulo 30
int numberOfDays = (numberOfDaysToConvert % 365) % 30; 

if (numberOfYears > 1)
{
    Console.Write($"{numberOfYears} years ");
}
else
{
    Console.Write($"{numberOfYears} year ");
}

if (numberOfMonths > 1)
{
    Console.Write($"{numberOfMonths} months ");
}
else
{
    Console.Write($"{numberOfMonths} month ");
}

if (numberOfDays > 1)
{
    Console.Write($"{numberOfDays} days ");
}
else
{
    Console.Write($"{numberOfDays} day ");
}



//[Exercise 4]
//Write a program to input marks of five subjects Physics, Chemistry, Biology, Mathematics and Computer Science. Calculate percentage and grade according to following:  
//Percentage >= 90 % : Grade A  
//Percentage >= 80% : Grade B  
//Percentage >= 70% : Grade C  
//Percentage >= 60% : Grade D  
//Percentage >= 40% : Grade E  
//Percentage < 40% : Grade F  
//Input:
//Enter the Physics mark: 95
//Enter the Chemistry mark: 95
//Enter the Biology mark: 97
//Enter the Mathematics mark: 98
//Enter the Computer Science mark: 90
//Output:
//Percentage = 95.00 and grade is A.

Console.WriteLine();
Console.Write("Provide the Physics mark (0-100): ");
int physicsMark = Convert.ToInt32(Console.ReadLine());
Console.Write("Provide the Chemistry mark (0-100) :");
int chemistryMark = Convert.ToInt32(Console.ReadLine());
Console.Write("Provide the Biology mark (0-100): ");
int biologyMark = Convert.ToInt32(Console.ReadLine());
Console.Write("Provide the Mathematics mark (0-100): ");
int mathematicsMark = Convert.ToInt32(Console.ReadLine());
Console.Write("Provide the Computer Science mark (0-100): ");
int computerScienceMark = Convert.ToInt32(Console.ReadLine()); 

float averageMark = (physicsMark + chemistryMark + biologyMark + mathematicsMark + computerScienceMark) / 5.00f;

// option one: IF
if (averageMark >= 90)
{
    Console.WriteLine($"Average is {averageMark} and grade is A");
}
else if (averageMark >= 80)
{
    Console.WriteLine($"Average is {averageMark} and grade is B");
}
else if (averageMark >= 70)
{
    Console.WriteLine($"Average is {averageMark} and grade is C");
}
else if (averageMark >= 60)
{
    Console.WriteLine($"Average is {averageMark} and grade is D");
}
else if (averageMark >= 40)
{
    Console.WriteLine($"Average is {averageMark} and grade is E");
}
else
{
    Console.WriteLine($"Average is {averageMark} and grade is F");
}

// option two: SWITCH
switch (averageMark)
{
    case >= 90:
        {
            Console.WriteLine($"Average is {averageMark} and grade is A");
            break;
        }
    case >= 80:
        {
            Console.WriteLine($"Average is {averageMark} and grade is B");
            break;
        }
    case >= 70:
        {
            Console.WriteLine($"Average is {averageMark} and grade is C");
            break; }
    case >= 60:
        {
            Console.WriteLine($"Average is {averageMark} and grade is D");
            break;
        }
    case >= 40:
        {
            Console.WriteLine($"Average is {averageMark} and grade is E");
            break;
        }
    default:
        {
            Console.WriteLine($"Average is {averageMark} and grade is F");
            break;
        }
}



//[Exercise 5]
//Write a program to accept a grade and declare the equivalent description.  
//E -> Excellent  
//V -> Very Good  
//G -> Good  
//A -> Average  
//F -> Fail
//Input:
//V
//Output:
//Very Good

Console.WriteLine("Enter the grade: ");
string grade = Console.ReadLine();

// .ToUpper() makes sure the grader becomes a capital letter before comparing it
switch (grade.ToUpper())
{
    case "E":
        Console.WriteLine("Excellent");
        break;
    case "V":
        Console.WriteLine("Very Good");
        break;
    case "G":
        Console.WriteLine("Good");
        break;
    case "A":
        Console.WriteLine("Average");
        break;
    case "F":
        Console.WriteLine("Fail");
        break;
    default:
        Console.WriteLine("Unknown grade");
        break;
}
// of course the same results can be achieved by using IF


//[Exercise 6]  
//Write a program to read temperature in centigrade and display a suitable message according to temperature state below:  
//Temp < 0 then Freezing weather  
//Temp 0-10 then Very Cold weather  
//Temp 10-20 then Cold weather  
//Temp 20-30 then Normal in Temp  
//Temp 30-40 then Its Hot  
//Temp >=40 then Its Very Hot  
//Input:
//38
//Output:
//Normal in Temp

Console.WriteLine("Provide the temperature (centigrade): ");
int temperature = Convert.ToInt32(Console.ReadLine());

switch (temperature)
{
    case < 0:
        Console.WriteLine("Freezing weather");
        break;
    case < 10:
        Console.WriteLine("Very cold weather");
        break;
    case < 20:
        Console.WriteLine("Cold weather");
        break;
    case < 30:
        Console.WriteLine("Normal in temp");
        break;
    case < 40:
        Console.WriteLine("It's hot");
        break;
    case >= 40:
        Console.WriteLine("It's very hot");
        break;
}
// of course the same results can be achieved by using IF