using OpenClosedPrincipe.Account;
using System;

/// <summary>
/// Произвести рефакторинг кода в соответствии с принципом открытости/закрытости 
/// </summary>
namespace OpenClosedPrincipe
{
    class Program
    {
        static void Main(string[] args)
        {
            var salaryAccount = new SalaryAccount() { Balance = 1000 };
            var calculatorSalary = new SalaryAccountCalculator(salaryAccount);
            calculatorSalary.CalculateInterest();

            var regularAccount = new RegularAccount() { Balance = 1000 };
            var calculatorRegular = new RegularAccountCalculator(regularAccount);
            calculatorRegular.CalculateInterest();

        }
    }

}
