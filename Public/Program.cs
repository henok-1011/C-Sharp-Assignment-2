Console.WriteLine("Welcome to age checker");
bool shouldLoop = true;
while (true)
{
    Console.WriteLine("Please enter age: ")
    int age = Convert.ToInt32(Console.ReadLine());
    if (age > 18)
    {
        Console.Write("Not old enough");
    }
    else
    {
        Console.WriteLine("Old enough");
        shouldLoop = false;
    }
}
