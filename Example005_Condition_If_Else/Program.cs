Console.WriteLine("Insert your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{
Console.WriteLine("So great! It's Maria!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}