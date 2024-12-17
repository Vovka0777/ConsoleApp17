using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void OutPutint(List<int> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        static void OutPutMin(int a)
        {
            Console.WriteLine(a);
        }

        static void OutPut(List<string> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        static void OutPutUp(List<string> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i.ToUpper());
            }
            Console.WriteLine();
        }

        static void OutPutLow(List<string> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i.ToLower());
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ////Создайте коллекцию(6 вариант) из шести элементов
            ////1)добавьте в список элементы строчными буквами;

            //List<string> list = new List<string>() {"Круг", "Квадрат","Треугольник","Паралилепипед","Ромб","Трапеция"};

            ////2)выведите содержимое коллекции на экран;

            //OutPut(list);

            ////3)преобразуйте все буквы элементов в прописные;

            //OutPutUp(list);

            ////4)выведите содержимое коллекции на экран;

            //OutPut(list);

            ////5)определите текущее количество элементов коллекции;

            //OutPutMin(list.Count());

            ////6)добавьте в коллекцию новый элемент в конец списка соответствующего варианта;

            //list.Add("Многоугольник");

            ////7)выведите содержимое коллекции на экран;

            //OutPut(list);

            ////8)добавьте в коллекцию новый элемент в начале списка соответствующего варианта;

            //list.Insert(0, "Паралелограмм");

            ////9)выведите содержимое коллекции на экран;

            //OutPut(list);

            ////10)удалите третий элемент коллекции;

            //list.RemoveAt(3);

            ////11)выведите содержимое коллекции на экран;

            //OutPut(list);

            ////12)расположите элементы в обратном порядке

            //list.Reverse();
            //OutPut(list);


            //Задача 2

            //Задача 3. Создать список из целых чисел. Определить сумму значений элементов списка, кратных 5.

            //List<int> list = new List<int> { 1, 15, 84, 35, 10, 63 };
            //foreach (var i in list)
            //{
            //    if (i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Задание 4.Создать список из целых чисел. Вставить в список число 10 после каждого элемента с отрицательным значением.

            List<int> list = new List<int> { 1, 15, -84, 35, -10, 63, };
            for (int i = 0;i<list.Count;i++)
            {
                if (list[i] < 0)
                {
                    list.Insert(i + 1, 10);
                    i++;
                }
            }


            //foreach (var el in list)
            //{
            //    if (el<0)
            //    {
            //        list.Insert(a + 1, 10);
            //    }
            //}
            OutPutint(list);
            Console.Read();
        }
    }
}
