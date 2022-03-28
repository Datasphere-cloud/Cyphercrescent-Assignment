// See https://aka.ms/new-console-template for more information
Console.Write("Enter the values of a: ");

int a = int.Parse(Console.ReadLine());

Console.Write("Enter the values of b: ");

int b = int.Parse(Console.ReadLine());

Console.Write("Enter the values of c: ");

int c = int.Parse(Console.ReadLine());

int D = b*b - (4 * a * c);

Console.Write("Determinat: " + D);

Console.WriteLine();

if (D>0)
{
    Console.WriteLine("Hurray! Roots of equation are real");
    if (D<0)
    {
        Console.WriteLine("Wow! Roots of equation are complex");
        if (D==0)
        {
            Console.WriteLine("Roots are equal");
        }
    }
}

Console.Beep();


