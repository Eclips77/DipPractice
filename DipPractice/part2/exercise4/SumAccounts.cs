using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPractice.part2.exercise4
{
    public static class SumAccounts
    {
        public static void SumBalances(List<IAccount> accounts)
        {
            decimal total = 0;
            foreach (var account in accounts)
            {
                total += account.GetBalance();
            }
            Console.WriteLine($"Total net: {total}");
        }
     
    }
}
