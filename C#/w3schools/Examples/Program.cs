// See https://aka.ms/new-console-template for more information

// The File class of the System.IO namespace is used to work with files.

using System.IO;

/*
    Useful File methods:
        AppendText()        Appends text to the end of an existing file
        Copy()              Copies a file
        Create()            Creates or overwrites a file
        Delete()            Deletes a file
        Exists()            Tests whether the file exists
        ReadAllText()       Reads the contents of a file
        Replace()           Replaces the contents of a file with the contents
                            of another file
        WriteAllText()      Creates a new file and writes the contents to it.
                            If the file already exists it will be overwritten.
*/

string writeText = "Hello World!";
File.WriteAllText("filename.txt", writeText);

string readText = File.ReadAllText("filename.txt");
Console.WriteLine(readText);

/* 
    C# Output
    System - 
    Console - 
    Write()
    WriteLine()

    Comments:
        Single-line - use the // syntax

        Multi-line - this section of notes is a multi-line comment
*/
Console.WriteLine("Hello, World!");
Console.WriteLine(DateTime.Now);
Console.WriteLine(10 + 10);

// WriteLine provides an automatic newline, while Write prints to a single line.
Console.Write("This is a single ");
Console.WriteLine("line sample.");

/*
    Variables - containers for storing data-values, in C# variables have types that describe the
        Syntax:     type variableName = value;
        Types:    
            int
            long
            float
            double
            char
            string
            bool
        C# variables can be declared with an initial value or without one.

    Constants - variables that should not be able to be overwritten.
        Keyword:    const

    Multi-Declaration - multiple variables of the same type can be declared at once using a comma to separate them.

    C# Naming Variables - 
        .   Identifiers can contain letters, digits, and underscores
        .   Identifiers must begin with a letter
        .   Identifiers should start with a lowercase letter
        .   Identifiers can not contain whitespace
        .   Identifiers are case sensitive
        .   Identifiers can not be reserved keywords such as int, double, etc.
*/

int age = 999;
double grade = 3.84D; 
char firstInitial = 'A';  // Character data values must be surrounded by single quotes
string firstName= "Austin"; // String data values must be surrounded by double quotes
bool isOld = true;  // Boolean data values can only be true or false

const double PI = 3.14159;

Console.WriteLine(age);
Console.WriteLine(grade);
Console.WriteLine(firstInitial);
Console.WriteLine(firstName);
Console.WriteLine(isOld);
Console.WriteLine(PI);

/*
    Floating-Point v.s. Integer Types

    int - can store whole numbers from -2147483648 to 2147483647
    long - can store whole numbers from -9223372036854775808 to 9223372036854775807
        longs should end with the character "L"
    
    float - can store decimal numbers, with precision up to 6-7 digits
        floats should end with the character "F"
    double - can store decimal numbers, with precision up to 15 digits
        doubles should end with the character "D"

    Floating point numbers can be used with scientific notation
*/

float floatNum = 5.75F;
double doubleNum = 9.99D;

float scientificFloatNum = 20e3F;
double scientificDoubleNum = 12E4D;

Console.WriteLine(floatNum);
Console.WriteLine(doubleNum);
Console.WriteLine(scientificFloatNum);
Console.WriteLine(scientificDoubleNum);


/*
    Type Casting
        Implicit (automatic) - converting a smaller type to a larger type size
            char > int > long > float > double
        Explicit (manual) - converting a larger type to a smaller type size
            double > float > long > int > char
*/

// Implicit Samples
int intNum = 10;
double castedDouble = intNum;

Console.WriteLine(intNum);
Console.WriteLine(castedDouble);

// Explicit Samples
doubleNum = 9.99;
int castedInt = (int) doubleNum;

Console.WriteLine(doubleNum);
Console.WriteLine(castedInt);

/*
    Built-In Type Conversion Methods
    Convert.ToBoolean
    Convert.ToDouble
    Convert.ToString
    Convert.ToInt32 - for conversion to int
    Convert.ToInt64 - for conversion to long
*/
intNum = 10;
Console.WriteLine(Convert.ToString(intNum));

/*
    User Input
*/
// Console.WriteLine("Enter a username:");
// string username = Convert.ToString(Console.ReadLine());
// Console.WriteLine("Username: " + username);


/*
    Operators
    +   Addition
    -   Subtraction
    *   Multiplication
    /   Division
    %   Modulus
    ++  Increment
    --  Decrement

    Assignment Operators
    =  
    += 
    -= 
    *= 
    /= 
    %= 
    &= 
    |= 
    ^= 
    >>=
    <<=

    Comparison Operators
    ==  Equal To
    !=  Not Equal
    >   Greater Than
    <   Less Than
    >=  Greater Than or Equal To
    <=  Less Than or Equal To

    Logical Operators
    &&  Logical AND
    ||  Logical OR
    !   Logical NOT

    Math - C# Class or Library containing methods related to common math functions
    Math.Max(x, y) - return the highest value of x and y
    Math.Min(x, y) - return the lowest value of x and y
    Math.Sqrt(x) - return the square root of x
    Math.Abs(x) - returns the absolute value of (x)
    Math.Round(x) - returns the nearest whole number, of a number x

    String Methods
    x.Length - returns the length of string x
    x.ToUpper() - returns the uppercase string conversion of x
    x.ToLower() - returns the lowercase string conversion of x
    string.Concat(y, z) - returns the result of combining two strings y and z
    x.IndexOf("key") - returns the string index of the term searched
    x.Substring(index) - returns the substring starting at the index position provided

    String Interpolation
    $"{variable}";

    String Access - strings can be accessed as arrays.
    string x = "something";
    x[index] = "value";

    Escape Strings
    \n - New line
    \t - Tab
    \b - Backspace
*/

firstName = "Austin";
string lastInitial = "D";
string fullName = $"{firstName} {lastInitial}.";
Console.WriteLine(fullName);

/*
    Conditional Statements
    if statements 
        if (condition) {

        } else if (condition) {

        } else {

        }
    
    ternary operator
        type variable = (condition) ? expressionTrue : expressionFalse;

    switch statements
        switch(expression) {
            case x:
                break; -- required to stop the execution of the following statements
            case y:
                break;
            default:   -- code that always runs
                break;
        }

    
    Loops
    while (condition) {

    }
    do {

    } while (condition);

    for (statement 1; statement 2; statement 3) {

    }

    foreach (type variableName in arrayName) {

    }

    Break and Continue
    break - can be used to stop or step out of a loop
    continue - can be used to break one iteration of a loop

    Arrays 
    type[] - declare an array by using square brackets after a type
    type[] arrayName = {value1, ..., valuex}
    type[] arrayName = new type[arraySize]
    type[] arrayName = new type[arraySize] {value1, ..., valuex}
    type[] arrayName = new type[] {value1, ..., valuex}

    Sorting Arrays
    Array.Sort(variableName)

    System.Linq - namespace within the System library containing array methods

    arrayName.Max() - returns the largest value
    arrayName.Min() - returns the smallest value
    arrayName.Sum() - returns the sum of the elements
*/

static void MyMethod(string fname) {
    Console.WriteLine("Hello " + fname);
}
static void MethodWithDefaultParam(string fname = "Austin") {
    Console.WriteLine("Hello " + fname);
}

MyMethod("Austin");
MethodWithDefaultParam();

static string MethodWithNamedArguments(string lname, string fname) {
    return "Hello, " + fname + " " + lname;
}
Console.WriteLine(MethodWithNamedArguments(fname: "Austin", lname: "Developer"));

/*
    Method Overloading - multiple methods can have the same name with different parameters.
    Either the number of parameters or the type of parameters or both must be different.    
*/

Car myCar = new Car();
Console.WriteLine(myCar.quantity);

// Using a property to change a value
myCar.Color = "Silver";
Console.WriteLine(myCar.Color);

/*
    Inheritance (Derived and Base Classes) - allows one class to "inherit" or access methods 
        from another class
        Derived Classes (child) - class that inherits from another class
        Base Classes (parent) - class that is inherited from

        Useful For:
            Code Reuseability

    Sealed - keyword indicating a class that should not be inherited from.
        
*/

Truck myTruck = new Truck();
myTruck.honk();

Console.WriteLine(myTruck.color + " " + myTruck.model);

/* 
    Polymorphism - principle that a method can have many forms, usually relevant when there 
        is multiple classes inheriting from a single class
        Methods of the base class override the derived class.

*/

Animal myAnimal = new Animal();
myAnimal.makeSound();   // Animal Sound
Animal myDog = new Dog();
myDog.makeSound();      // Animal Sound
Animal myCat = new Cat();
myCat.makeSound();      // Animal Sound
myCat.move();           // Animal Move
Animal myDolphin = new Dolphin();
myDolphin.move();       // Swim

/*
    Abstraction - process of hiding certain details and showing only the important information 
        to the user

    Abstract - keyword used for classes and methods to indicate abstraction
    Abstract classes can not be used to creaqte objects directly, they must be inherited by 
        other classes.

    Used to provide a layer of security to data, in this way we can hide certain bits of 
        information and only show the relevant and important ones.
*/

/* 
    Interfaces - additional method of achieving abstraction, an interface is an entirely
        abstract class, containing only abstract methods and properties.

    Interfaces should begin with the letter I
    By default members of an interface are abstract and public

    Interfaces are "implemented" using the : symbol in the class definition.

    Interfaces may not be used to create objects, and may not contain a constructor
    Interface methods do not have a body
    All methods of an interface must be overridden

    Used to provide a layer of security, and as C#'s method of "multiple inheritance", 
    that is base classes that inherit from multiple parents.

*/

/* 
    Enumerations - special classes that represent a group of constants, by default
    enumerations are given values corresponding to the indexed order in which they 
    are defined starting with zero.
*/
Size sodaSize = Size.Small;
Console.WriteLine(sodaSize);
Console.WriteLine((int) sodaSize);

/*
    Error Handling
    Exceptions - errors found while a program is either compiling, or running that affect the program
        negatively.

    Try-Catch
        Try - defines a block of code to be tested for errors while executing
        Catch - defines a block of code to be executed if some error occurs
        Finally - defines a block of code that should run regardless of the try catch result

        Throw - keyword that enables the creation of custom errors
*/
try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
  Console.WriteLine("Something went wrong.");
}
finally
{
  Console.WriteLine("The 'try catch' is finished.");
}

// Enumeration
enum Size {
    Small,
    Medium = 2, // Sample enum with assigned value
    Large
}

// Inheritance

// Base Class
public class Vehicle {
    public string color = "Grey";

    public void honk() {
        Console.WriteLine("Beeep!");
    }
}

// Derived Class
public class Truck : Vehicle {
    public string model = "F-150";
}

// Sealed Class -- can not be inherited from
sealed class Manufacturer {
    // ...
}

// Polymorphism

// Base Class
class Animal {
    public void makeSound() {
        Console.WriteLine("Animal sound");
    }
    public virtual void move() {
        Console.WriteLine("Animal Move");
    }
}
// Derived Class
class Dog : Animal {
    public void makeSound() {
        Console.WriteLine("Dog sound");
    }
}
// Derived Class
class Cat : Animal {
    public void makeSound() {
        Console.WriteLine("Cat sound");
    }
    public void move() {
        Console.WriteLine("Walk");
    }
}
class Dolphin : Animal {
    public void makeSound() {
        Console.WriteLine("Dolphin sound");
    }
    public override void move() {
        Console.WriteLine("Swim");
    }
}

// Abstraction
abstract class Human {
    public abstract void makeSound();
    public void sleep() {
        Console.WriteLine("zZzZ");
    }
}


// Interface
interface IAnimal {
    void animalSound();  // Interface Method
}

// Multiple inheritance
interface IFirstInterface {
    void myMethod();
}
interface ISecondInterface {
    void myOtherMethod();
}
class MultipleInheritanceDemo : IFirstInterface, ISecondInterface {
    public void myMethod() {
        // ...
    }
    public void myOtherMethod() {
        // ...
    }
}