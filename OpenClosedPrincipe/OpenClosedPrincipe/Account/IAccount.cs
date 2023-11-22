/// <summary>
/// Произвести рефакторинг кода в соответствии с принципом открытости/закрытости 
/// </summary>
namespace OpenClosedPrincipe.Account
{
    public interface IAccount
    {

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
    }



}
