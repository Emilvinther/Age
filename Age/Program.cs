Console.WriteLine("Write your name");
string name = Console.ReadLine();

Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());

if (age < 3)
{
    Console.WriteLine("{0} du må gå med ble", name);
}
else if (age > 3 && age <= 15)
{
    Console.WriteLine("{0}, du må ingenting", name);
}
else if (age > 15 && age < 18)
{
    Console.WriteLine("{0}, du må drikke", name);
}
else Console.WriteLine("{0}, du må stemme og køre bil", name);

Console.ReadKey();

