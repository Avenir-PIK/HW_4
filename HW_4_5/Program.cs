namespace HW_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводятся целые числа a>0, b<0. Найти a^b. Не использовать класс Math");
            double dig_a = 0;
            do
            {
                Console.WriteLine("\nВведите число из диапазона [20;60]");
                dig_a = Convert.ToInt32(Console.ReadLine());
            }
            while (dig_a < 20 || dig_a > 60);

            Console.WriteLine("Спасибо!");
            Console.WriteLine("\nНажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}