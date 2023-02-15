Console.WriteLine("Enter the string: ");
string name = Console.ReadLine();
Console.WriteLine("The string is: " + name);
Console.WriteLine("Reverse of the string: ");
for (int i = name.Length - 1; i >= 0; i--)
{
    Console.Write(name[i]);
}