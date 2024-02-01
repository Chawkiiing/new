using System;

namespace Activity1;

public class Math
{
    public void add(int num1, int num2)
    {
        Console.WriteLine("The sum of the two numbers is : " + (num1 + num2));
    }
    public void sub(int num1, int num2)
    {
        Console.WriteLine("The sub of the two numbers is : " + (num1 - num2));
    }
    public void multiplication(int num1, int num2)
    {
        Console.WriteLine("The multiplication of the two numbers is : " + (num1 * num2));
    }
    public void division(int num1, int num2)
    {
        double result = Convert.ToDouble(num1) / Convert.ToDouble(num2);
        Console.WriteLine("The division of the two numbers is : " + result.ToString("N2"));
    }
}
class Program
{
    static void Main(String[] args)
    {
        Math m = new Math();
        int num1, num2;
        Console.Write("Enter num1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter num2: ");
        num2 = int.Parse(Console.ReadLine());
        m.add(num1, num2);
        m.sub(num1, num2);
        m.division(num1, num2);
        m.multiplication(num1, num2);
    }
}
