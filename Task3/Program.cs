using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
     Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Потрібно:
    Створити клас MyMatrix, який забезпечує надання матриці довільного розміру з можливістю зміни числа рядків і стовпців.
    Написати програму, яка виводить на екран матрицю і похідні від неї матриці різних порядків.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введiть число рядкiв матрицi: ");
            //int N = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Введiть число стовбцiв матрицi: ");
            //int M = Int32.Parse(Console.ReadLine());
            MyMatrix mymatrix = new MyMatrix(4,5);
            mymatrix.Show();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("[1][2] = {0}", mymatrix[1, 2]);
            Console.WriteLine("[6][2] = {0}", mymatrix[6, 2]);
            mymatrix[0, 0] = 11;

            Console.WriteLine(new string('-', 30));
            mymatrix.ChengeSize(7, 6);
            mymatrix.Show();

            Console.WriteLine(new string('-', 30));
            mymatrix.ShowPartly(1, 0, 4, 4);

            //Delay
            Console.ReadKey();

        }
    }
}
