using BankyStuffLibrary;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_101
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string aFriend = "Hendra";
            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");  // выводим через интерполяцию строк

            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");


            C#: The Basics of Strings [3 of 19]
            В этом примере демонстрируются важные принципы работы со строками. Методы управления строками возвращают новые строковые объекты, 
            а не вносят изменения в существующие. Как видите, каждый вызов любого из методов Trim возвращает новую строку, а не изменяет 
            исходное сообщение.

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello);
            Console.WriteLine(sayHello.ToLower());
            Console.WriteLine(sayHello);
            */


            // C#: Searching Strings [4 of 19]
            /*
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.StartsWith("goodbye"));    // false
            Console.WriteLine(songLyrics.StartsWith("You"));        // true
            Console.WriteLine(songLyrics.Contains("goodbye"));      // true
            Console.WriteLine(songLyrics.Contains("greetings"));    // false
            */

            // C#: Numbers and Integer Math [5 of 19]
            /*
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);

            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            int a1 = 5;
            int b1 = 4;
            int c1 = 2;
            int d1 = (a1 + b1) * c1;
            Console.WriteLine(d1);

            int d2 = (a + b) - 6 * c + (12 * 4) / 3 + 12;  // 9 - 12 + 36 / 15  =  33 / 15  =  2.2  -  я посчитал неправильно
            Console.WriteLine(d2);
            */


            // C#: Numbers and Integer Precision [6 of 19]
            /*
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            double a = 19;
            double b = 23;
            double c = 8;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
            */


            // C#: Numbers and Decimals [7 of 19]
            /*
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
            */

            // C#: Branches (if) [8 of 19]
            /*
            int a = 5;
            int b = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is not greater than 10");
            */


            // C#: "Hello World" Explained [9 of 19]
            // using подключает библиотеки классов
            // namespace группирует классы по назначению к примеру


            // C#: What are Loops? [10 of 19]
            /*
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

            int counter2 = 10;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
                counter2++;
            } while (counter2 < 10);


            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"Hello World! The index is {i}");
            }
            */


            //C#: Combining Branches and Loops [11 of 19]
            /*
            int sum = 0;
            for (int i = 0; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"The sum is: {sum}");
            */



            // C#: Arrays, List, and Collections [12 of 19]
            /*
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (string item in names)
            {
                Console.WriteLine($"Hello {item.ToUpper()}!");
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }
            names.Add("Maria");
            names.Remove("Ana");
            foreach (string item in names)
            {
                Console.WriteLine($"Hello {item.ToUpper()}!");
            }

            Console.WriteLine(names[0]);
            */


            // C#: Sort, Search, and Index Lists [13 of 19]
            /*
            var names = new List<string> { "Weird", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            */


            // C#: Lists of Other Types [14 of 19]
            /*
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

            Console.WriteLine(fibonacciNumbers.Count);
            */


            // C#: Debugging [15 of 19]


            // My Super Bank
            // C#: Object Oriented Programming - Objects and Classes [16 of 19] (описали и создали объект)
            // C#: Object Oriented Programming - Methods and Members [17 of 19]
            // C#: Object Oriented Programming - Methods and Exceptions [18 of 19]
            // C#: Object Oriented Programming - Catching Exceptions [19 of 19]





            // What is .NET? [1 of 8]
            // Installing .NET [2 of 8]
            // What is a .NET Hello World App? [3 of 8]
            // .NET: Basic Debugging [4 of 8]
            // .NET - Adding a Class Library [5 of 8]
            // .NET - Using a NuGet Package [6 of 8]
            // .NET - Unit Testing[7 of 8]
            // .NET - Publishing an App [8 of 8]

            var account = new BankAccount("Khedra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}$");
            
            account.MakeWithdrawal(50, DateTime.Now, "Xbox game");
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");

            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine($"Account balance {account.Balance}$");






     





        }
    }
}
