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
using System.Net.WebSockets;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.Win32.SafeHandles;

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

// IF ELSE PROJECT
// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your Subscription expires within a day");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your Subscription expires in {daysUntilExpiration} days");
//     discountPercentage = 10;
// }
// else if ((daysUntilExpiration <= 10 ))
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%");
// }

// ARRAY BASICS
// Arrays can be used to store multiple values of the same type in a single variable.
// An array is a special type of variable that can hold multiple values of the same data type

/*
// declare new array
string[] fraudulentOrderIDs = new string[3];
int[] myarray = new int[3]; myarray[0] = 1; myarray[1] = 2; myarray[2] = 3;


fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

// string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ]; //collection expression

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// //size of an array
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process");

// FOREACH STATEMENT
// string [] names = {"Rowena", "Robin", "Bao"};
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// int [] inventory = [200, 450, 700, 175, 250];
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin ++;
//     Console.WriteLine($"Bin {bin} = {items} (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");

//NESTED ITERATION
// string [] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
// foreach (string orderID in orderIDs)
// {
//    if (orderID.StartsWith("B"))
//    {
//     Console.WriteLine(orderID);
//    } 
// }

//NAMING CONVENTIONS(COMMENTING)
//A local variable is a variable that is scoped within the body of a method

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");

//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

// WHITESPACES
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
// {
//     if ((roll1 == roll2) && (roll2 == roll3)) 
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6; 
//     } 
//     else 
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }


// // CHALLENGE
// string str = "The quick brown fox jumps over the lazy dog.";
// // convert the message into a char array
// char[] charMessage = str.ToCharArray();
// // Reverse the chars
// Array.Reverse(charMessage);
// int x = 0;
// // count the o's
// foreach (char i in charMessage) { if (i == 'o') { x++; } }
// // convert it back to a string
// string new_message = new String(charMessage);
// // print it out
// Console.WriteLine(new_message);
// Console.WriteLine($"'o' appears {x} times.");


// //RESULT
// /*
//    This code reverses a message, counts the number of times 
//    a particular character appears, then prints the results
//    to the console window.
//  */

// string originalMessage = "The quick brown fox jumps over the lazy dog.";

// char[] message = originalMessage.ToCharArray();
// Array.Reverse(message);

// int letterCount = 0;

// foreach (char letter in message)
// {
//     if (letter == 'o')
//     {
//         letterCount++;
//     }
// }

// string newMessage = new String(message);

// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {letterCount} times.");

// STUDENT GRADING SYSTEM

using System;
using System.Reflection.Metadata;
// initialize variables - graded assignments
// int examAssignments = 5;

// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
// int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
// int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
// int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
// int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// // Student names
// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

// int[] studentScores = new int[10];

// string currentStudentLetterGrade = "";

// // Write the Report Header to the console
// Console.WriteLine("Student\t\tGrade\n");

// foreach (string name in studentNames)
// {
//     string currentStudent = name;

//     if (currentStudent == "Sophia")
//        studentScores = sophiaScores;

//     else if (currentStudent == "Andrew")
//         studentScores = andrewScores;

//     else if (currentStudent == "Emma")
//         studentScores = emmaScores;

//     else if (currentStudent == "Logan")
//         studentScores = loganScores;

//     else if (currentStudent == "Becky")
//     studentScores = beckyScores;

//     else if (currentStudent == "Chris")
//         studentScores = chrisScores;

//     else if (currentStudent == "Eric")
//         studentScores = ericScores;

//     else if (currentStudent == "Gregor")
//         studentScores = gregorScores;

//     else
//         continue;

//     // initialize/reset the sum of scored assignments
//     int sumAssignmentScores = 0;

//     // initialize/reset the calculated average of exam + extra credit scores
//     decimal currentStudentGrade = 0;

//     // initialize/reset a counter for the number of assignment 
//     int gradedAssignments = 0;

//     // loop through the scores array and complete calculations for currentStudent
//     foreach (int score in studentScores)
//     {
//         // increment the assignment counter
//         gradedAssignments += 1;

//         if (gradedAssignments <= examAssignments)
//             // add the exam score to the sum
//             sumAssignmentScores += score;

//         else
//             // add the extra credit points to the sum - bonus points equal to 10% of an exam score
//             sumAssignmentScores += score / 10;
//     }

//     currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

//     if (currentStudentGrade >= 97)
//         currentStudentLetterGrade = "A+";

//     else if (currentStudentGrade >= 93)
//         currentStudentLetterGrade = "A";

//     else if (currentStudentGrade >= 90)
//         currentStudentLetterGrade = "A-";

//     else if (currentStudentGrade >= 87)
//         currentStudentLetterGrade = "B+";

//     else if (currentStudentGrade >= 83)
//         currentStudentLetterGrade = "B";

//     else if (currentStudentGrade >= 80)
//         currentStudentLetterGrade = "B-";

//     else if (currentStudentGrade >= 77)
//         currentStudentLetterGrade = "C+";

//     else if (currentStudentGrade >= 73)
//         currentStudentLetterGrade = "C";

//     else if (currentStudentGrade >= 70)
//         currentStudentLetterGrade = "C-";

//     else if (currentStudentGrade >= 67)
//         currentStudentLetterGrade = "D+";

//     else if (currentStudentGrade >= 63)
//         currentStudentLetterGrade = "D";

//     else if (currentStudentGrade >= 60)
//         currentStudentLetterGrade = "D-";

//     else
//         currentStudentLetterGrade = "F";

//     //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
//     Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
// }

// // required for running in VS Code (keeps the Output windows open to view results)
// Console.WriteLine("\n\rPress the Enter key to continue");
// Console.ReadLine();


// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// // Console.WriteLine(pangram.Contains("fox"));
// // Console.WriteLine(pangram.Contains("cow"));

// // These two lines of code will create the same output

// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));

// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50; conditional operator
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// string permission = "Admin|Manager";
// int level = 56;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// VARIABLE SCOPE & LOGIC IN CODE BLOCK
// Creating variable in a code block

// bool flag = true;
// int value = 0;

// if (flag)
// {
//   Console.WriteLine($"Inside the code block: {value}");
// }

// value = 10;
// Console.WriteLine($"Outside the code block: {value}");


//Incorrect format
/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
       bool found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
*/

//Correct Format
/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
*/

//SWITCH CASE CONSTRUCT
/*
int employeeLevel = 100;
string employeeName = "Evans Torddey";

string title = "";

switch (employeeLevel)
{
  case 100:
  case 200:
      title = "Senior Associate";
      break;
  case 300:
      title = "Manager";
      break;
  case 400:
      title = "Senior Manager";
      break;
  default: 
      title = "Associate";
      break;    
}

Console.WriteLine($"{employeeName}, {title}");

*/

/*
// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
*/

//FOR STATEMENTS
// for (int i = 0; i < 10; i++) //initializer, condition, iterator
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; 1 < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

string [] names = {"Evans", "Eddie", "Cath", "Trevor"};
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "Eddie")
    {
        names[i] = "Gershom";
    }
}

foreach (var name in names) 
{
    Console.WriteLine(name);
}