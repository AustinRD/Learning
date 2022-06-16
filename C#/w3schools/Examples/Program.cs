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
Console.Write("line sample.");

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