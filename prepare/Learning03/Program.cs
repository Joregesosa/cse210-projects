using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.getFraction());
        Console.WriteLine(f1.getDecimal());

        Fraction f2 = new Fraction(8);
        Console.WriteLine(f2.getFraction());
        Console.WriteLine(f2.getDecimal());

        Fraction f3 = new Fraction(8, 3);
        Console.WriteLine(f3.getFraction());
        Console.WriteLine(f3.getDecimal());	

        Fraction f4 = new Fraction();
        f4.setTop(5);
        f4.setBottom(2);
        Console.WriteLine(f4.getFraction());
        Console.WriteLine(f4.getDecimal());

        
    }
}