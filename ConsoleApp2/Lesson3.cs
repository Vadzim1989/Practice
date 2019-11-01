/*Начальный вклад в банке равен 1000 руб. Через каждый месяц размер вклада увеличивается 
 на P процентов от имеющейся суммы. По данному P определить, 
 через сколько месяцев размер вклада превысит 1100 руб., 
 и вывести найденное количество месяцев K и итоговый размер вклада S*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Lesson3
    {
        static void Main(string[] args)
        {
            decimal S = 1000;
            int k = 0;

            Console.WriteLine("Добро пожаловать в БАНК. Вы планируете открыть депозит на сумму 1000 руб.");
            Console.WriteLine("Давайте отпределимся с процентной ставкой Вашего депозита.");
            Console.WriteLine("Наш банк может предложить Вам от 1% до 15%. Какой процент вы выибраете?");

            int percent = int.Parse(Console.ReadLine());

            while(percent<1||percent>15) //зашита от "дурня"
            {
                Console.WriteLine("Внимательно изучите наше предложение по процентным ставкам и сделайте свой выбор!");
                percent = int.Parse(Console.ReadLine());
            }

            while(S<1100) //расчет итоговой суммы и количестов месяцев
            {
                S = S + S * Convert.ToDecimal(percent) / 100;
                k++;
            }

            Console.WriteLine("Мы рассчитали для вас итоговую сумму вклада и количество месяцев");
            Console.WriteLine($"Итоговая сумма вклада: {S:f2}, прошло {k} месяцев"); // f:2 - количество символов после запятой.
            Console.ReadKey();
        }
    }
}
