//1.
Console.WriteLine("What is your name and surname? ");
string nameAndSurname = Console.ReadLine();
Console.WriteLine($"Hello, {nameAndSurname}");

/*
//2.
Console.WriteLine("Enter first number: ");
string n1 = Console.ReadLine();
Console.WriteLine("Enter Second number: ");
string n2 = Console.ReadLine();

bool IsNumber1 = int.TryParse(n1,out int num1);
bool IsNumber2 = int.TryParse(n2, out int num2);

if (IsNumber1 && IsNumber2)
{
    Console.WriteLine($"sum of the two numbers is: {num1 + num2}");
    Console.WriteLine($"substraction of the two numbers is: {num1 - num2}");
    Console.WriteLine($"multiplication of the two numbers is: {num1 * num2}");
    Console.WriteLine($"division of the two numbers is: {num1 % num2}");
}else if (IsNumber1)
{
    Console.WriteLine($"{n2} is not a number!");
}else if (IsNumber2)
{
    Console.WriteLine($"{n1} is not a number!");
}else
{
    Console.WriteLine($"{n1} and {n2} are not numbers!");   
}


//3.
Console.WriteLine("Enter first number: ");
string n1=Console.ReadLine();
Console.WriteLine("Enter Second number: ");
string n2=Console.ReadLine();   

bool IsNumber1 = int.TryParse(n1,out int num1);
bool IsNumber2 = int.TryParse(n2, out int num2);

int num3;

if (IsNumber1 && IsNumber2)
{
    num3 = num1;
    num1 = num2;
    num2 = num3;
    Console.WriteLine($"First number equals to: {num1}");
    Console.WriteLine($"Second number equals to: {num2}");
}
else if (IsNumber1)
{
    Console.WriteLine($"{n2} is not a number!");
}
else if (IsNumber2)
{
    Console.WriteLine($"{n1} is not a number!");
}
else
{
    Console.WriteLine($"{n1} and {n2} are not numbers!");
}


//4.
Console.WriteLine("Enter a first number: ");
string n1=Console.ReadLine();
Console.WriteLine("Enter a second number: ");
string n2 = Console.ReadLine();
Console.WriteLine("Enter a third number: ");
string n3 = Console.ReadLine();
Console.WriteLine("Enter a fourth number: ");
string n4 = Console.ReadLine();

bool IsNumber1 = double.TryParse(n1,out double num1);
bool IsNumber2 = double.TryParse(n2, out double num2);
bool IsNumber3 = double.TryParse(n3, out double num3);
bool IsNumber4 = double.TryParse(n4, out double num4);

if(IsNumber1 && IsNumber2 && IsNumber3 && IsNumber4)
{
    double average = (num1 + num2 + num3 + num4) / 4;
    Console.WriteLine(average);
}else
{
    Console.WriteLine("You inputted the numbers wrong! Try again!");
}



//5.
Console.WriteLine("Enter a number in kelvin: ");
string input = Console.ReadLine();
bool isDouble = double.TryParse(input,out double k);

double c;

if (isDouble)
{
    c = k - 273.15;
    Console.WriteLine($"{k} in celcius is: {c}");
}
else
{
    Console.WriteLine($"{input} is not a number!");  
}


//6.]
Console.WriteLine("Enter a number: ");
string input = Console.ReadLine();
bool isNumber = int.TryParse(input,out int num);
if (isNumber)
{
    if (num > 0)
    {
        Console.WriteLine($"{num} is positive");
    }
    else
    {
        Console.WriteLine($"{num} is negative");
    }
}
else
{
    Console.WriteLine($"{input} is not a number!");
}



//7.
Console.WriteLine("Enter a first number: ");
string n1 = Console.ReadLine();
Console.WriteLine("Enter a second number: ");
string n2 = Console.ReadLine();
Console.WriteLine("Enter a third number: ");
string n3 = Console.ReadLine();

bool isNumber1 = int.TryParse(n1, out int num1);
bool isNumber2 = int.TryParse(n2, out int num2);
bool isNumber3 = int.TryParse(n3, out int num3);

int max;
if (isNumber1 && isNumber2 && isNumber3)
{
    if (num1 >= num2) max = num1;
    else max = num2;
    if (num3 > max) max = num3;
    Console.WriteLine($"{max} is max number.");
}
else
{
    Console.WriteLine("You inputted the numbers wrong!");
}  



//8.
Console.WriteLine("Enter first number: ");
string n1 = Console.ReadLine();
Console.WriteLine("Enter Second number: ");
string n2 = Console.ReadLine();

bool IsNumber1 = int.TryParse(n1, out int num1);
bool IsNumber2 = int.TryParse(n2, out int num2);

if(IsNumber1 && IsNumber2)
{
    if (num1 == num2)
    {
        num1 *= 3;
        num2 *= 3;
        Console.WriteLine($"First and second number now equal to {num1}");
    }
    else
    {
        Console.WriteLine($"First and second number now equal to {num1} and {num2}");
    }
}
else
{
    Console.WriteLine("You inputted the numbers wrong!");
}



//9.
Console.WriteLine("Enter a number: ");
string input = Console.ReadLine();
bool isNumber = int.TryParse(input,out int num);
if (isNumber)
{
    if (num % 7 == 0) Console.WriteLine($"{num} can be divided by 7");
    else
    {
        Console.WriteLine($"{num} can't be divided by 7 without a remainder");
    }

}
else
{
    Console.WriteLine($"{input} is not a number!");
}



//10.
Console.WriteLine("Enter a number: ");
string input = Console.ReadLine();
bool isNumber = int.TryParse(input, out int num);

int ans;
bool containsFive = false;
int numUnchanged = num;

if (isNumber)
{
    while (num > 0)
    {
        if (num % 10 == 5)
        {
            Console.WriteLine($"There is 5 in {numUnchanged}");
            containsFive = true;
            break;
        }
        num /= 10;
    }
    if (!containsFive) Console.WriteLine($"There is not 5 in {numUnchanged}");
}
else
{
    Console.WriteLine($"{input} is not a number!");
}


//11.
Console.WriteLine("Enter a number: ");
string input = Console.ReadLine();
bool isNumber = int.TryParse(input, out int num);

string s="";
if (isNumber) 
{
    while (num > 0)
    {
        s = num % 10 + " " + s;
        num /= 10;
    }
    Console.WriteLine(s);
}
else
{
    Console.WriteLine($"{input} is not a number!");
}
*/
