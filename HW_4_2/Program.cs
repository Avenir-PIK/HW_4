namespace HW_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n");
            int dig = 0;
            double drob = 1;
            // не даём ввести отрицательное не положительное (на целое не проверяем: лень)
            while (dig <= 0)
            {
                Console.WriteLine("\nВведите натуральное число!");
                dig = Convert.ToInt32(Console.ReadLine());
            }
            //находим что требуется
            for (int i = 2; i <= dig; i++)
            {
                drob += 1.0/i;
            }
            Console.WriteLine("\nСтранное действие с {0} равно {1}", dig, drob);
            Console.WriteLine("\nНажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}