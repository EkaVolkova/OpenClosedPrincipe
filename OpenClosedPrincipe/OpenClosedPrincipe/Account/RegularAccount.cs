using OpenClosedPrincipe.Account;
/// <summary>
/// Произвести рефакторинг кода в соответствии с принципом открытости/закрытости 
/// </summary>
namespace OpenClosedPrincipe
{
    public class RegularAccount : IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
    }



}
