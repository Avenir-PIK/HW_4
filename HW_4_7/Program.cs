namespace HW_4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводится n. Определить количество цифр в числе");

            int dig_a = 0;
            int numdig = 1;
            do
            {
                Console.WriteLine("\nВведите натуральное число n");
                dig_a = Convert.ToInt32(Console.ReadLine());
            }
            while (dig_a < 1);

            while (dig_a / 10  > 0)
            {
                dig_a /= 10;
                numdig++;
            }
            Console.WriteLine("Введенное число содержит цифр: {0} ", numdig);

            Console.WriteLine("Спасибо!");
            Console.WriteLine("\nНажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}