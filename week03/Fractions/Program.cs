using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        int top1 = 2;
        int bottom1 = 4;

        int top2 = 4;
        int bottom2 = 6;

        int top3 = 6;
        int bottom3 = 8;

        f1.SetTop(top1);
        f1.SetBottom(bottom1);

        f2.SetTop(top2);
        f2.SetBottom(bottom2);

        f3.SetTop(top3);
        f3.SetBottom(bottom3);


        f1.GetFractionString();
        f2.GetFractionString();
        f3.GetFractionString();

        double f1Des = f1.GetDecimalValue();
        double f2Des = f2.GetDecimalValue();
        double f3Des = f3.GetDecimalValue();

        Console.WriteLine(f1Des);
        Console.WriteLine(f2Des);
        Console.WriteLine(f3Des);
    }
}