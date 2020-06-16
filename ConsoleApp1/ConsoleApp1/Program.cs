using System;
class Program
{
    public static void Main()
    {
        bool a = true;
        bool b = false;

        a = a || b;
        b = a && b;

        a = !a;
        a = a != b;
        b = a == b;

        bool c = 2 > 2;
        bool d = 2 <= 2;

        string ans = a ? "a" : "X";
        ans += b ? "b" : "X";
        ans += c ? "c" : "X";
        ans += d ? "d" : "X";

        a = b;
        b = b || c;
        c = d;
        d = a && d;

        Console.WriteLine("Hello");
    }
}