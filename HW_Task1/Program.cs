using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    class Program
    {
        static void Print(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
        static void FillRandom(ref int[][] matrix, int left, int right)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = rnd.Next(left, right + 1);
                }
            }
        }
        static void upRows(ref int[][] matrix, int pos)
        {
            if (pos == matrix.Length)
            {
                Console.WriteLine("Nothing to do");
                return;
            }
            int[][] tmp = new int[matrix.Length][]; // резервуєм тимчасовий масив
            matrix.CopyTo(tmp, 0);// копіюємо в тимчасовий масив
            for (int i = 0; i < pos; i++)
            {
                matrix[i] = tmp[matrix.Length - i - 1];
                matrix[matrix.Length - i - 1] = tmp[i];
            }

        }
        static void downRows(ref int[][] matrix, int pos)
        {
            if (pos == matrix.Length)
            {
                Console.WriteLine("Nothing to do");
                return;
            }
            int[][] tmp = new int[matrix.Length][]; // резервуєм тимчасовий масив
            matrix.CopyTo(tmp, 0);// копіюємо в тимчасовий масив
            for (int i = 0; i < pos; i++)
            {
                matrix[matrix.Length - i - 1] = tmp[i];
                matrix[i] = tmp[matrix.Length - i - 1];
            }

        }
        static void deleteRowWithIndex(ref int[][] matrix, int index)
        {
            if (index < 0 || matrix.Length <= index)
            {
                Console.WriteLine("Please, enter correct index");
                return;
            }
            int[][] tmp = new int[matrix.Length][]; // резервуєм тимчасовий масив
            matrix.CopyTo(tmp, 0);// копіюємо в тимчасовий масив
            matrix = new int[matrix.Length - 1][];

            for (int i = 0, j = i; i < matrix.Length; i++)
            {
                if (i == index)
                {
                    ++j;
                }
                matrix[i] = tmp[j];
                ++j;
            }
        }

        static void addElemInRows<T>(ref T[][] matrix, T elem)
        {
            //int[][] tmp = new int[matrix.Length][]; // резервуєм тимчасовий масив
            //matrix.CopyTo(tmp, 0);// копіюємо в тимчасовий масив
            for (int i = 0; i < matrix.Length; i++)
            {
                Array.Resize(ref matrix[i], matrix[i].Length + 1);
                matrix[i][matrix[i].Length - 1] = elem;
            }
        }
        static int[][] createJugged(params int[] cols)
        {
            int[][] m = new int[cols.Length][];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new int[cols[i]];
            }
            return m;
        }

        // Task 2

        static void DeleteSymbol(ref string str, params char[] symbol)
        {
            foreach (var item in symbol)
            {
                str = str.Replace(item.ToString(), String.Empty);
            }
        }
        static string Multiply(string source, int multiplier)
        {
            StringBuilder sb = new StringBuilder(multiplier * source.Length);
            for (int i = 0; i < multiplier; i++)
            {
                sb.Append(source);
            }

            return sb.ToString();
        }
        static void CountLettersInString(String str)
        {
            char[] symbols = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'j', 'k', 'l', 'h', 'm', 'n', 's', 'p', 'r', 't', 'q', 'z' };
            int counts = 0;
            foreach (var item in symbols)
            {
                counts = str.Count(e => (e).Equals(item));
                if (counts != 0)
                {
                    Console.WriteLine($"{item}: [{counts}] {Multiply("*", counts)}");

                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~FillRandom~~~~~~~~~~~~~~~");
            int[][] matrix = createJugged(1, 2, 3, 4, 3, 2, 1);
            FillRandom(ref matrix, 1, 100);
            Print(matrix);
            Console.WriteLine("~~~~~~~~~~~UpRows~~~~~~~~~~~~");
            upRows(ref matrix, 2);
            Print(matrix);
            Console.WriteLine("~~~~~~~~~~~DownRows~~~~~~~~~~~");
            downRows(ref matrix, 2);
            Print(matrix);
            deleteRowWithIndex(ref matrix, 3);
            Console.WriteLine("~~~~~~~~~~~Deleted element~~~~~~~~~~~");
            Print(matrix);
            Console.WriteLine("~~~~~~~~~~~Add element in rows~~~~~~~~~~~");
            addElemInRows(ref matrix, 228);
            Print(matrix);
            Console.WriteLine("~~~~~~~~~~~Task 2~~~~~~~~~~~");
            Console.WriteLine("Delete symbols");
            string str = "wdawdwad2233";
            DeleteSymbol(ref str, '2', '3');
            Console.WriteLine($"STR : {str}");
            Console.WriteLine("Count symbols");
            CountLettersInString("I don’t know whether to delete this or rewrite it");
        }
    }
}
