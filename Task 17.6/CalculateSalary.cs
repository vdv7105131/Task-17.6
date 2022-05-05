using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17._6
{
    public class CalculateSalary : ICalculateInterest
    {
        public void Calculate()
        {
            var account = new Account();
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}
