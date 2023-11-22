using OpenClosedPrincipe.Account;
using OpenClosedPrincipe.Calculator;

/// <summary>
/// Произвести рефакторинг кода в соответствии с принципом открытости/закрытости 
/// </summary>
namespace OpenClosedPrincipe
{
    public class RegularAccountCalculator : ICalculator<RegularAccount>
    {
        RegularAccount account;
        public RegularAccountCalculator(RegularAccount account)
        {
            this.account = account;
        }
        public void CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;
        }
    }


}
