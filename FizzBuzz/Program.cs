// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Please input a number");
int givenNumber = Convert.ToInt32(Console.ReadLine());

for (int x=1; x<= givenNumber; x++)

if (x % 5 == 0 && x % 3 == 0)
{
    Console.WriteLine("FizzBuzz");
}
else if (x %5== 0)
{
    Console.WriteLine("Buzz");
}
else if (x % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else
{
    Console.WriteLine(x);
}

//-----------------------Alternate way-----------------------

Console.WriteLine("Enter a number");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);


for (int i=1; i<= number; i++)
{
    string output;
    if (i%3 == 0)    {
        output = "Fizz";
        
        if(i%5== 0)
        {
            output = "FIzzBuzz";
        }
    }
    else if(i%5 == 0)
    {
        output = "Buzz";
    }
    else
    {
        output = i.ToString();
    }
    Console.WriteLine(output);
}