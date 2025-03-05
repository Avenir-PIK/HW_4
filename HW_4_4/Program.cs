namespace HW_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводятся целые числа a>0, b<0. Найти a^b. Не использовать класс Math");
            int dig_a = 0;
            int dig_b = 0;
            // не даём ввести не по условию
            while (dig_a <= 0)
            {
                Console.WriteLine("\nВведите целое число a > 0");
                dig_a = Convert.ToInt32(Console.ReadLine());
            }
            while (dig_b >= 0)
            {
                Console.WriteLine("\nВведите целое число b < 0");
                dig_b = Convert.ToInt32(Console.ReadLine());
            }
            //находим что требуется

            dig_b *= -1;
            double result = dig_a;

            for (int i = 1; i < dig_b; i++)
            {
                result = result * dig_a;
            }

            double result2 = 1 / result;
            Console.WriteLine("\n{0} в степени -{1} равно {2}", dig_a, dig_b, result2);
            Console.WriteLine("\nНажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}