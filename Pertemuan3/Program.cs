// Delegates Function
// sebagai pointer / placeholder dari function

using System;

namespace DelegateExample
{
    public delegate string MyDelegates(int a, int b);
    public delegate void MyDelegate(int arg1, int arg2);
    class MyClass
    {
        public string MyMethod(int a, int b)
        {
            return (a - b).ToString();
        }
    }

    class Program
    {
        static string Square(int a, int b) {
            return (a * b).ToString();
        }

        static string Sum(int a, int b)
        {
            return (a + b).ToString();
        }

        // chaining function
        static string MyFunc(int a, Func<int,int, string> func)
        {
            return func(a, a).ToString();
        }

        static void Main() {
            // Memanggil Delegates
            MyDelegates fun1 = Square;
            Console.WriteLine(fun1(2, 3));

            MyDelegates fun2 = Sum;
            Console.WriteLine(fun2(2, 3));

            // delegate dari instance class method
            MyClass mc = new();
            MyDelegates fun3;
            fun3 = mc.MyMethod;
            Console.WriteLine("Hasil mymethod " + fun3(30, 20));

            // Func Delegates
            Func<int,int, string> add = Sum;
            Func<int, int, string> doublevalue = Square;

            var result = MyFunc(3, doublevalue);
            Console.WriteLine(result);

            var result2 = MyFunc(2, add);
            Console.WriteLine(result2);

            // composable delegate
            static void func1(int arg1, int arg2)
            {
                string result = (arg1 + arg2).ToString();
                Console.WriteLine("Hasil Func1: " + result);
            }
            static void func2(int arg1, int arg2)
            {
                string result = (arg1 * arg2).ToString();
                Console.WriteLine("Hasil Func2: " + result);
            }

            MyDelegate f1 = func1;
            MyDelegate f2 = func2;
            // Create a composed delegate from f1 and f2
            MyDelegate f1f2 = f1 + f2;

            int a = 10;
            int b = 20;

            // call each delegate and then the chain
            Console.WriteLine("Calling the first delegate");
            f1(a, b);
            Console.WriteLine("Calling the second delegate");
            f2(a, b);
            // Call the composed delegate
            Console.WriteLine("\nCalling the chained delegates");
            f1f2(a, b);
        }
    }
}

/*
// Lamdba Expression
// Function yang anonim, satu baris 
var x  = () => "Test";
// var y = x => x * x;

Func<int, int> square = x => x * x;
Console.WriteLine(square(5));

int[] angka = {1,2,3,4,5};
var genap = angka.Where(x => x % 2 == 0);
foreach (var item in genap)
{
    Console.WriteLine(item);
}

// lambda pada Func delegate dan Linq method
Func<List<string>, List<int>> getLengths = s => s.Select(str => str.Length).ToList();
List<string> strings = new() { "hello", "world", "foo", "bar" };
List<int> lengths = getLengths(strings);

foreach (var item in lengths)
{
    Console.WriteLine(item);
}

*/