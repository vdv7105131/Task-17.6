using System;

// Напишите свой вариант рефакторинга кода из задания 4 в соответствии с Принципом открытости-закрытости.

namespace Task_17._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var getCalculate = new GetCalculate();

            // расчет процентной ставки обычного аккаунта по правилам банка
            getCalculate.PerfomCalculate(new CalculateNormal());

            // расчет процентной ставк зарплатного аккаунта по правилам банка
            getCalculate.PerfomCalculate(new CalculateSalary());
        }
    }
}
