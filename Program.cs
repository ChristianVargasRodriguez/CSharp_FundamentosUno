// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Create a Loop that prints all values from 1-255
for (int i = 1; i <= 255; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine(" 2 -----------------------------");
// Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
for (int x = 1; x <= 100; x++)
{
    if ((x % 3 == 0 || x % 5 == 0) && !(x % 3 == 0 && x % 5 == 0))
    {
        Console.WriteLine(x);
    }
}

Console.WriteLine(" 3 -----------------------------");
// Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5

for (int y = 1; y <= 100; y++)
{
    if (y % 3 == 0 && y % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (y % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (y % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(y);
    }
}

Console.WriteLine(" 4 -----------------------------");
//  If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!

Console.WriteLine(" 4.1 *********************");
int q = 1;
while (q <= 255)
{
    Console.WriteLine(q);
    q++;
}

Console.WriteLine(" 4.2 *********************");
int h = 1;
while (h <= 100)
{
    if ((h % 3 == 0 || h % 5 == 0) && !(h % 3 == 0 && h % 5 == 0))
    {
        Console.WriteLine(h);
    }
    h++;
}


Console.WriteLine(" 4.3 *********************");
int r = 1;
while (r <= 100)
{
    if (r % 3 == 0 && r % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (r % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (r % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(r);
    }
    
    r++;
}