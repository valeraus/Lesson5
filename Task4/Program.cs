using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Потрібно:
    Створити клас Article, що містить наступні закриті поля:
    • Назва товару;
    • назва магазину, в якому продається товар;
    • вартість товару в гривнях.
    Створити клас Store, який містить закритий масив елементів типу Article.
    Забезпечити такі можливості:
    • висновок інформації про товар за номером за допомогою індексу;
    • висновок на екран інформації про товар, назва якого введено з клавіатури, якщо таких товарів немає, 
    видати відповідне повідомлення;
    Написати програму, виведення на екран інформацію про товар.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Store st = new Store(3);

            st.AddArticle(new Article("Book", "MackMilan", 20.50), 0);
            st.AddArticle(new Article("Apple", "Delight", 5.90), 1);
            st.AddArticle(new Article("Coca-Cola", "Fozzy", 7.25), 2);


            Console.WriteLine(st["Apple"]);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(st["Dog"]);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(st[2]);
            Console.WriteLine(new string('-', 30));

            st.Show();
            Console.WriteLine(new string('-', 30));

            st.Sort();
            st.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
