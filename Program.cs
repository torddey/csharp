// string name = "Bob";
// int message = 3;
// decimal temp = 34.4m;

// Console.Write("Hello, ");
// Console.Write(name);
// Console.Write("! You have ");
// Console.Write(message);
// Console.Write(" messages in your inbox. The temperature is ");
// Console.Write(temp);
// Console.Write(" celsius.");

// Escape Character Sequence is an instruction to the runtime to insert a special character that will affect the output of your string
// Console.WriteLine("Hello\nWorld!");
// Console.WriteLine("Hello\tWorld!");

// // Basic Operations
// string firstName = "Bob";
// int widgetSold = 7;
// Console.WriteLine(firstName + " sold " + (widgetSold + 7) + " widgets.");

// string firstName = "Bob";
// string greeting = "Hello";
// // Console.WriteLine(greeting + " " + firstName + "!");

// String Interpolation 
// string message = $"{greeting} {firstName}!";

// string firstName = "Bob";
// string message = $"Hello {firstName}!";
// Console.WriteLine(message);

// int version = 11;
// string updateText = "Update to Windows";
// avoid this  // string message = $"{updateText} {version}";
// Console.WriteLine($"{updateText} {version}!");

// string projectName = "First-Project";
// Console.WriteLine($@"C:\Output\{projectName}\Data");

// string projectName = "ACME";
// string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
// Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

// string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
// string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
// Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

// int sum = 7 + 5;
// int difference = 7 - 5;
// int product = 7 * 5;
// int quotient = 7 / 5;

// Console.WriteLine("Sum: " + sum);
// Console.WriteLine("Differnece: " + difference);
// Console.WriteLine("Product: " + product);
// Console.WriteLine("Quotient: " + quotient);

// decimal decimalQuotient = 7.0m / 5;
// Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// decimal decimalQuotient = 7 / 5.0m;
// decimal decimalQuotient = 7.0m / 5.0m;
// Console.WriteLine(decimalQuotient);

// int first = 7;
// int second = 5;
// decimal quotient = (decimal)first / (decimal)second;
// Console.WriteLine(quotient);

// Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
// Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// int value1 = 3 + 4 * 5;
// int value2 = (3 + 4) * 5;
// Console.WriteLine(value1);
// Console.WriteLine(value2);

// Compound assignment operators +=, -=, *=, ++

// int value = 0;
// value = value + 5;
// value += 5; 
// Console.WriteLine(value);

// int value = 0;
// value = value + 1;
// value ++;
// Console.WriteLine(value);

// int value = 1;
// value = value + 1;
// Console.WriteLine("First increment: " + value);

// value += 1;
// Console.WriteLine("Second increment: " + value);

// value ++;
// Console.WriteLine("Third increment: " + value);

// value = value -1;
// Console.WriteLine("First decrement: " + value);

// value -= 1;
// Console.WriteLine("Second decrement: " + value);

// value --;
// Console.WriteLine("Second decrement: " + value);


// int value = 1;
// value ++;
// Console.WriteLine("First: " + value);
// Console.WriteLine($"Second: {value++}");
// Console.WriteLine("Third: " + value);
// Console.WriteLine("Fourth: " + (++value));

// int fahrenheit = 94;
// decimal celsius = (fahrenheit - 32m) * (5m / 9m);
// Console.WriteLine("The temperature is " + celsius + " celcius. ");

// int result = 3 + 1 * 5 / 2;
// Console.WriteLine(result);

// initialize variables - graded assignments 
// int currentAssignments = 5;

// int sophia1 = 93;
// int sophia2 = 87;
// int sophia3 = 98;
// int sophia4 = 95;
// int sophia5 = 100;

// int nicolas1 = 80;
// int nicolas2 = 83;
// int nicolas3 = 82;
// int nicolas4 = 88;
// int nicolas5 = 85;

// int zahirah1 = 84;
// int zahirah2 = 96;
// int zahirah3 = 73;
// int zahirah4 = 85;
// int zahirah5 = 79;

// int jeong1 = 90;
// int jeong2 = 92;
// int jeong3 = 98;
// int jeong4 = 100;
// int jeong5 = 97;

// int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
// int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
// int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
// decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
// decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
// decimal jeongScore = (decimal) jeongSum / currentAssignments;

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + " \tA");
// Console.WriteLine("Nicolas:\t" + nicolasScore + " \tB");
// Console.WriteLine("Zahirah:\t" + zahirahScore + " \tB");
// Console.WriteLine("Jeong:\t\t" + jeongScore + " \tA");

using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Numerics;

// string studentName = "Sophia Johnson";
// string course1Name = "English 101";
// string course2Name = "Algebra 101";
// string course3Name = "Biology 101";
// string course4Name = "Computer Science I";
// string course5Name = "Psychology 101";

// int course1Credit = 3;
// int course2Credit = 3;
// int course3Credit = 4;
// int course4Credit = 4;
// int course5Credit = 3;

// int gradeA = 4;
// int gradeB = 3;

// int course1Grade = gradeA;
// int course2Grade = gradeB;
// int course3Grade = gradeB;
// int course4Grade = gradeB;
// int course5Grade = gradeA;

// int totalCreditHours = 0;
// totalCreditHours += course1Credit;
// totalCreditHours += course2Credit;
// totalCreditHours += course3Credit;
// totalCreditHours += course4Credit;
// totalCreditHours += course5Credit;

// int totalGradePoints = 0;
// totalGradePoints += course1Credit * course1Grade;
// totalGradePoints += course2Credit * course2Grade;
// totalGradePoints += course3Credit * course3Grade;
// totalGradePoints += course4Credit * course4Grade;
// totalGradePoints += course5Credit * course5Grade;

// decimal gradePointAverage = (decimal) totalGradePoints / totalCreditHours;

// int leadingDigit = (int) gradePointAverage;
// int firstDigit = (int) (gradePointAverage * 10) % 10;
// int secondDigit = (int) (gradePointAverage * 100) % 10;

// Console.WriteLine($"Student: {studentName}\n");

// Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

// Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
// Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
// Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
// Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
// Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

// Console.WriteLine($"Final GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");

// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// dice.Next()

// int firstValue = 500;
// int secondValue = 600;
// int largerValue;

// largerValue = Math.Max(firstValue, secondValue); 

// Console.WriteLine(largerValue);



// decision logic with if statements

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }

// if ((roll1 == roll2) && (roll2 == roll3)) 
// {
//     Console.WriteLine("You rolled triples! +6 bonus to total!");
//     total += 6;
// }

// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
// }

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your Subscription expires within a day");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your Subscription expires in {daysUntilExpiration} days");
    discountPercentage = 10;
}
else if ((daysUntilExpiration <= 10 ))
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}