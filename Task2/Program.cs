using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Потрібно:
    Створити масив розмірністю N елементів, заповнити його довільними цілими значеннями.
    Вивести найбільше значення масиву, найменше значення масиву, загальну суму елементів, 
    середнє арифметичне всіх елементів, вивести всі непарні значення.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть розмiр масиву: ");
            int N = Int32.Parse(Console.ReadLine());
            MyArray ar = new MyArray(N);

            ar.MinMax();
            ar.Average();
            Console.Write("Непарнi: ");
            ar.Odd();

            // Delay.
            Console.ReadKey();
        }
    }
}
