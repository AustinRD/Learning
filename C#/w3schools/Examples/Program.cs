// See https://aka.ms/new-console-template for more information

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
Console.WriteLine("Enter a username:");
string username = Convert.ToString(Console.ReadLine());
Console.WriteLine("Username: " + username);


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