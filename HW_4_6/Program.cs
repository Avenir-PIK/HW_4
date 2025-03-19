namespace HW_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводится n. Определить, является ли оно степенью 2-ки?");

            int dig_a = 0;
            do
            {
                Console.WriteLine("\nВведите натуральное число n");
                dig_a = Convert.ToInt32(Console.ReadLine());
            }
            while (dig_a < 1);

            while (dig_a % 2 == 0)
            {
                dig_a /= 2;
            }

            if (dig_a == 1) { Console.WriteLine("Введенное число является степенью двойки!"); }
            else { Console.WriteLine("Введенное число НЕ является степенью двойки!"); }

            Console.WriteLine("Спасибо!");
            Console.WriteLine("\nНажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}