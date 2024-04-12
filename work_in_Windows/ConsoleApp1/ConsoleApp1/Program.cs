
using RectangleApplication;
using System;


// hello world
Console.WriteLine("Hello, World! 2024-0412-0126");

string divider = "=========== ";

// Rectangle demo
Console.WriteLine(divider + "Rectangle demo");

RectangleApplication.Rectangle rec = new();
rec.Acceptdetails();
rec.Display();

RectangleApplication.ExecuteRectangle excute = new();
excute.main();

// Value demo
Console.WriteLine(divider + "Value demo");
ValueType.ValueArguments val = new();
val.Printer();

// Loop demo
Console.WriteLine(divider + "Loop demo");
LoopDemo.Looper.Execute();

// Recursion demo
Console.WriteLine(divider + "Recursion demo");

Console.WriteLine("Factorial - Enumerable.Range(1, 10)");
foreach (int index in Enumerable.Range(1, 10))
{
    Console.WriteLine("Factorial({0}) = {1}", index, RecursionDemo.RecursionClass.Factorial(index));
}

Console.WriteLine("Fibonacci - Enumerable.Range(1, 10)");
foreach (int index in Enumerable.Range(1, 10))
{
    Console.WriteLine("Fibonacci({0}) = {1}", index, RecursionDemo.RecursionClass.Fibonacci(index));
}

// Nullable demo
Console.WriteLine(divider + "Nullable demo");
NullableDemo.Nullables.Main();


namespace RectangleApplication
{
    public class Rectangle
    {
        // 成员变量
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    public class ExecuteRectangle
    {
        public void main()
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
        }
    }
}

namespace ValueType
{
    public class ValueArguments
    {
        bool valBool = false;
        byte valByte = 0;
        char valChar = 'a';
        decimal valDecimal = 0;
        double valDouble = 0;
        float valFloat = 0;
        int valInt = 0;
        long valLong = 0;
        sbyte valSByte = 0;
        short valShort = 0;
        uint valUint = 0;
        ulong valULong = 0;
        ushort valUShort = 0;

        object obj = 100;
        dynamic dyn = 1000;
        string strNoAt = "C:\\Windows";
        string strAt = @"C:\Windows";
        string strScript = @"<script type=""text/javascript"">
        <!--
        -->
        </script>";

        string strExampleA = "hello, world";                  // hello, world
        string strExampleB = @"hello, world";               // hello, world
        string strExampleC = "hello \t world";               // hello     world
        string strExampleD = @"hello \t world";               // hello \t world
        string strExampleE = "Joe said \"Hello\" to me";      // Joe said "Hello" to me
        string strExampleF = @"Joe said ""Hello"" to me";   // Joe said "Hello" to me
        string strExampleG = "\\\\server\\share\\file.txt";   // \\server\share\file.txt
        string strExampleH = @"\\server\share\file.txt";      // \\server\share\file.txt
        string strExampleI = "one\r\ntwo\r\nthree";
        string strExampleJ = @"one
        two
        three";

        public void Printer()
        {
            Console.WriteLine("valBool: {0}", valBool);
            Console.WriteLine("valByte: {0}", valByte);
            Console.WriteLine("valChar: {0}", valChar);
            Console.WriteLine("valDecimal: {0}", valDecimal);
            Console.WriteLine("valDouble: {0}", valDouble);
            Console.WriteLine("valFloat: {0}", valFloat);
            Console.WriteLine("valInt: {0}", valInt);
            Console.WriteLine("valLong: {0}", valLong);
            Console.WriteLine("valSByte: {0}", valSByte);
            Console.WriteLine("valShort: {0}", valShort);
            Console.WriteLine("valUint: {0}", valUint);
            Console.WriteLine("valULong: {0}", valULong);
            Console.WriteLine("valUShort: {0}", valUShort);

            Console.WriteLine("obj: {0}", obj);
            Console.WriteLine("dyn: {0}", dyn);
            Console.WriteLine("strNoAt: {0}", strNoAt);
            Console.WriteLine("strAt: {0}", strAt);
            Console.WriteLine("strScript: {0}", strScript);

            Console.WriteLine("strExampleA: {0}", strExampleA);
            Console.WriteLine("strExampleB: {0}", strExampleB);
            Console.WriteLine("strExampleC: {0}", strExampleC);
            Console.WriteLine("strExampleD: {0}", strExampleD);
            Console.WriteLine("strExampleE: {0}", strExampleE);
            Console.WriteLine("strExampleF: {0}", strExampleF);
            Console.WriteLine("strExampleG: {0}", strExampleG);
            Console.WriteLine("strExampleH: {0}", strExampleH);
            Console.WriteLine("strExampleI: {0}", strExampleI);
            Console.WriteLine("strExampleJ: {0}", strExampleJ);

            Console.WriteLine("p0 = {0}, p1 = {1}, p2 = {2}", 0.3, "demo", 20);
            Console.WriteLine("p0 = {0}, p1 = {1}, p2 = {2}", 0.3, "demo", 20);

            Console.WriteLine("sizeof(int) = {0}, sizeof(double) = {1}", sizeof(int), sizeof(double));
        }
    }
}

namespace LoopDemo
{
    public class Looper
    {
        public static void Execute()
        {
            int sum = 0;
            Console.WriteLine("for 0 <= i < 20");
            for (int index = 0; index < 20; index++)
            {
                sum += index;
                Console.WriteLine("index = {0}, sum = {1}", index, sum);
            }

            sum = 0;
            int start = 5;
            int end = 15;
            Console.WriteLine("foreach Range({0}, {1})", start, end);
            foreach (int index in Enumerable.Range(start, end))
            {
                sum += index;
                Console.WriteLine("index = {0}, sum = {1}", index, sum);
            }

            sum = 0;
            Console.WriteLine("while example");
            int x = 11;
            int N = 5;
            while (x >= N - 1)
            {
                sum += x;
                Console.WriteLine(" x = {0}, N = {1}, sum = {2}", x, N, sum);
                x--;
            }
        }
    }
}

namespace RecursionDemo
{
    class RecursionClass
    {
        public static int Factorial(int num)
        {
            int result;

            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = Factorial(num - 1) * num;
                return result;
            }
        }
        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}

namespace NullableDemo
{
    public class Nullables
    {
        public static void Main()
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolval = new bool?();
            Console.WriteLine("display nullable value： {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("display nullable bool： {0}", boolval);

            double? num5 = null;
            double? num6 = 3.14157;
            double num7;
            num7 = num5 ?? 5.34;    // if num1 is null, set to 5.34
            Console.WriteLine("num7 =  {0}", num7);
            num7 = num6 ?? 9.018;    // if num1 is null, set to 9.018
            Console.WriteLine("num7 = {0}", num7);

        }
    }
}

