// See https://aka.ms/new-console-template for more information
Console.WriteLine("write your name:");
string username = Console.ReadLine();
GreetUser(username);
void GreetUser(string name)
{
    Console.WriteLine("hello " + name);

}
Console.WriteLine("enter the measurment of the box:");
Console.Write("Length:");
double length = Convert.ToDouble(Console.ReadLine());
Console.Write("width:");
double width = Convert.ToDouble(Console.ReadLine());
Console.Write("hight");
double height = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("volume is " + height*width*length);
