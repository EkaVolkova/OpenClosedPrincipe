using OpenClosedPrincipe.Account;
/// <summary>
/// Произвести рефакторинг кода в соответствии с принципом открытости/закрытости 
/// </summary>
namespace OpenClosedPrincipe.Calculator
{
    public interface ICalculator<TAccount> where TAccount: IAccount
    {
        public void CalculateInterest();
    }

}
