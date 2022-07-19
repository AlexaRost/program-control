using System;
using System.IO;
using System.Collections.Generic;
namespace RostovykhAD_Lab9
{
    class Program
    {
        /*static void BubbleSort1<T>(T[] mas) where T : IComparable
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length - 1; j++)
                {
                    if (mas[i].CompareTo(mas[j]) > 0)
                    {
                        (mas[i], mas[j]) = (mas[j], mas[i]);
                    }
                }
            }
        }*/



        static void Quicksort<T>(T[] mas, int a, int b) where T : IComparable
        {
            if (a>= b)
                return;
            int mid = Partition(mas, a, b);
            Quicksort<T>(mas, a, mid);
            Quicksort<T>(mas, mid + 1, b);
        }

        static int Partition<T>(T[] mas, int a, int b) where T : IComparable
        {
            T mid = mas[(a + b) / 2];
            int i = a;
            int j = b;
            while (i <= j)
            {
                while (mas[i].CompareTo(mid) < 0) i++;
                while (mas[j].CompareTo(mid) > 0) j--;
                if (i >= j) break;
                (mas[i], mas[j]) = (mas[j], mas[i]);
                i++; j--;
            }
            return j;
        }


        static void BubbleSort2<T>(T[] mas) where T : IComparable
        {
            int k = 0;
            bool flag = false;
            while (!flag)
            {
                flag = true;
                for (int i = 0; i < mas.Length - 1 - k; i++)
                {
                    if (mas[i].CompareTo(mas[i + 1]) > 0)
                    {
                        flag = false;
                        (mas[i], mas[i + 1]) = (mas[i + 1], mas[i]);
                    }
                }
                k++;
            }
        }

        /*
        static int Partition<T>(T[] m, int a, int b) where T : IComparable
        {
            int i = a;
            for (int j = a; j <= b; j++)         // просматриваем с a по b
            {
                if (m[j].CompareTo(m[b]) <= 0)  // если элемент m[j] не превосходит m[b],
                {
                    (m[i], m[j]) = (m[j], m[i]); // меняем местами m[j] и m[a], m[a+1], m[a+2] и так далее..
                    i++;                         // таким образом последний обмен: m[b] и m[i], после чего i++
                }
            }
            return i - 1;                        // в индексе i хранится <новая позиция элемента m[b]> + 1
        }

        static void Quicksort<T>(T[] m, int a, int b) where T : IComparable// a - начало подмножества, b - конец
        {                                        // для первого вызова: a = 0, b = <элементов в массиве> - 1
            if (a >= b) return;
            int c = Partition(m, a, b);
            Quicksort(m, a, c - 1);
            Quicksort(m, c + 1, b);
        }*/
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\7 семестр\МКП\Лаба9\RostovykhAD_Lab9\3000.txt", System.Text.Encoding.Default);
            
                var list = new List<int>();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    list.Add(Convert.ToInt32(line));
                    //list.Add(line);
                }            
                var arrTheoria = list.ToArray();
                var arrTheoria2 = list.ToArray();

            // for (int i = 0; i < arrTheoria.Length; i++)
            //{

            // Console.WriteLine(arrTheoria[i] + " ");
            // }
            Quicksort(arrTheoria2, 0, arrTheoria2.Length - 1);
            //StreamWriter sw = new StreamWriter(@"C:\7 семестр\МКП\Лаба9\RostovykhAD_Lab9\res.txt");
            BubbleSort2(arrTheoria);
                
                //Console.WriteLine("End");
                //for (int i = 0; i < arrTheoria.Length; i++)
                // {

                // sw.WriteLine(arrTheoria[i]);
                // }
                //StreamWriter sw2 = new StreamWriter(@"C:\7 семестр\МКП\Лаба9\RostovykhAD_Lab9\res2.txt");

                //Console.WriteLine("End");
                //Console.WriteLine(arrTheoria2.Length);
                //Console.WriteLine(arrTheoria.Length);
                //for (int i = 0; i < arrTheoria2.Length; i++)
                // {

                //sw2.WriteLine(arrTheoria2[i] + " ");
                // }
            
            //Console.WriteLine("End of Program");
            //Console.ReadLine();
        }
    }
}
