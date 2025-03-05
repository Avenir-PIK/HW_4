namespace HW_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона [20; 60]");
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