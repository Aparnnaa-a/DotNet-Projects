using System.Threading.Channels;
//Using For Loop

int i, n;
Console.Write("Enter a limit : ");
n=Int32.Parse(Console.ReadLine());

Console.WriteLine("Even Numbers Using For Loop");
for (i = 0; i <=n; i += 2)
{
    Console.WriteLine(i);
}

//Using while loop

Console.WriteLine("Even Numbers Using While Loop");
int j = 0, m;
Console.Write("Enter a limit : ");
m = Int32.Parse(Console.ReadLine());


while (j <= m)
{
    Console.WriteLine(j);
    j = j + 2;
}
