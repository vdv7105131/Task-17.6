using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17._6
{
    public class GetCalculate
    {
        public void PerfomCalculate(ICalculateInterest calculateInterest)
        {
            calculateInterest.Calculate();
        }
    }
}
