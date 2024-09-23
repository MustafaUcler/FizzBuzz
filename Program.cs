

Console.Write("Skriv in en siffra: ");

int sum = int.Parse(Console.ReadLine());

for (int i = 0; i <= sum; i++)
{
        if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
    
}
