using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Создать коллекцию List < int > .Вывести на экран позицию и значение элемента,
            //    являющегося вторым максимальным значением в коллекции.
            //    Вывести на экран сумму элементов на четных позичиях.
            List<int> list = new List<int>();
            Random rnd = new Random();
            const int size = 20;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                list.Add(rnd.Next(0, 100));
                Console.WriteLine("  " + list[i]);
            }
            int maxElement = list.Max();
            int secondElement = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > secondElement && list[i] < maxElement)
                {
                    secondElement = list[i];
                }
            }

            Console.WriteLine("Второе число после максимального элемента : {0} , Позиция элемента : {1}" , secondElement , list.IndexOf(secondElement) );

            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0)
                    sum += list[i];
            }
            Console.WriteLine("Сумма Элементво на четных позициях : {0}",sum);
            Console.ReadLine();
        }
    }
}
