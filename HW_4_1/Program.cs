using System.Runtime.Serialization.Formatters;

namespace HW_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.");
            int dig = 0;
            int fact = 1;
            // не даём ввести не положительное (на целое не проверяем - лень)
            while (dig <= 0)
            {
                Console.WriteLine("\nВведите положительное число!");
                dig = Convert.ToInt32(Console.ReadLine());
            }
            //находим факториал перемножением всего от 1 до dig
            for (int i = 1; i <= dig; i++)
            {
                fact *= i;
            }
            Console.WriteLine("\nФакториал {0} равен {1}", dig, fact);
            Console.WriteLine("\nНажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
