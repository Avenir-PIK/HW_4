using System.Runtime.Serialization.Formatters;

namespace HW_4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводится число. Вывести его в зеркальном виде. Количество цифр в числе заранее неизвестно. Не использовать строки");

            int dig_a = 0; // вводимое число
            double numdig = 1; // количество цифр
            int revdig = 0; // отзеркаленное число
            do
            {
                Console.WriteLine("\nВведите натуральное число n");
                dig_a = Convert.ToInt32(Console.ReadLine());
            }
            while (dig_a < 1);

            // чтобы потом сравнить - запишем исходное
            int startdig = dig_a;
            int stepen = 1;

            // цикл по определению количества цифр
            while (dig_a / 10 > 0)
            {
                dig_a /= 10;
                numdig++;
                stepen *= 10; // максимальный множитель десятков для начала отзеркаливания, потом делим его на 10 каждый шаг
            }
            dig_a = startdig; // возвращаем стартовое значение

            for (int i = 0; i < numdig; i++)
            {
                revdig += dig_a % 10 * stepen; // последнюю умножаем на текущий макс множитель десятков
                stepen /= 10; // уменьшаем на 1 порядок множитель десятков
                dig_a /= 10; // обрезаем исходное число 
            }

            Console.WriteLine("Введенное и отзеркаленное: \nВвод: {0} \nЗерк: {1} ", startdig, revdig);

            Console.WriteLine("Спасибо!");
            Console.WriteLine("\nНажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}