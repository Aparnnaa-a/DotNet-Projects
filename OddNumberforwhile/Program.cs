using System.Threading.Channels;
//Using For Loop

int i, n;
Console.Write("Enter a limit : ");
n = Int32.Parse(Console.ReadLine());

Console.WriteLine("Odd Numbers Using For Loop");
for (i = 1; i<=n; i += 2)
{
    Console.WriteLine(i);
}

//Using while loop

Console.WriteLine("Odd Numbers Using While Loop");
int j = 1, m;
Console.Write("Enter a limit : ");
m = Int32.Parse(Console.ReadLine());


while (j <= m)
{
    Console.WriteLine(j);
    j = j + 2;
}

