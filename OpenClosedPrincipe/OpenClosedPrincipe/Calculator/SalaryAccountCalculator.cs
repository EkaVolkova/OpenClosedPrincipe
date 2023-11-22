using OpenClosedPrincipe.Account;
using OpenClosedPrincipe.Calculator;


/// <summary>
/// Произвести рефакторинг кода в соответствии с принципом открытости/закрытости 
/// </summary>
namespace OpenClosedPrincipe
{
    public class SalaryAccountCalculator : ICalculator<SalaryAccount>
    {
        SalaryAccount account;
        public SalaryAccountCalculator(SalaryAccount account)
        {
            this.account = account;
        }

        /// <summary>
        /// // расчет процентной ставк зарплатного аккаунта по правилам банка
        /// </summary>
        /// <param name="account"></param>
        public void CalculateInterest()
        {
            account.Interest = account.Balance * 0.5;
        }
    }



}
