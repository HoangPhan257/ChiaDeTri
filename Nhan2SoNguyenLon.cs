using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        string X = "2357";
        string Y = "4891";

        string result = KaratsubaMultiply(X, Y);
        Console.WriteLine($"Kết quả của phép nhân: {result}");
        Console.ReadLine();
    }

    static string KaratsubaMultiply(string X, string Y)
    {

        int maxLength = Math.Max(X.Length, Y.Length);
        if (maxLength % 2 != 0)
        {
            maxLength++;
            X = X.PadLeft(maxLength, '0');
            Y = Y.PadLeft(maxLength, '0');
        }

        return Karatsuba(X, Y);
    }

    static string Karatsuba(string X, string Y)
    {
        int n = X.Length;


        if (n == 1)
        {
            return (int.Parse(X) * int.Parse(Y)).ToString();
        }

        int m = n / 2;

        string X1 = X.Substring(0, m);
        string X0 = X.Substring(m);
        string Y1 = Y.Substring(0, m);
        string Y0 = Y.Substring(m);

        string A = Karatsuba(X1, Y1);
        string B = Karatsuba(X0, Y0);
        string C = Karatsuba(Add(X1, X0), Add(Y1, Y0));

        C = Subtract(Subtract(C, A), B);

        return Add(Add(MultiplyByPowerOf10(A, 2 * m), MultiplyByPowerOf10(C, m)), B);
    }

    static string Add(string a, string b)
    {
        return (int.Parse(a) + int.Parse(b)).ToString();
    }

    static string Subtract(string a, string b)
    {
        return (int.Parse(a) - int.Parse(b)).ToString();
    }

    static string MultiplyByPowerOf10(string number, int power)
    {
        return number + new string('0', power);
    }
}