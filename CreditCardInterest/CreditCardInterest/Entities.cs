using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreditCardInterest
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class CreditCard
    {
        //public string DisplayName { get; set; }
        //public DateTime ExpiryDate { get; set; }
        //public int CVV { get; set; }
        //public string CreditCardNumber { get; set; }

        public float BalanceAmount { get; set; }

        public abstract float CalculateInterestPerMonth();
    }

    /// <summary>
    /// 
    /// </summary>
    public class VisaCard : CreditCard
    {
        private readonly float interest = 0.1F;

        public override float CalculateInterestPerMonth()
        {
            return BalanceAmount * interest;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MasterCard : CreditCard
    {
        private readonly float interest = 0.05F;

        public override float CalculateInterestPerMonth()
        {
            return BalanceAmount * interest;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class DiscoverCard : CreditCard
    {
        private readonly float interest = 0.01F;

        public override float CalculateInterestPerMonth()
        {
            return BalanceAmount * interest;
        }
    }

    public interface IPerson
    {
        List<IWallet> Wallets { get; set; }
        float CalculatePersonInterest();
    }

    /// <summary>
    /// 
    /// </summary>
    public class Person : IPerson
    {
        public List<IWallet> Wallets { get; set; }

        public float CalculatePersonInterest()
        {
            float interest = 0.0F;

            if (Wallets != null && Wallets.Any())
            {
                foreach (var wallet in Wallets)
                {
                    interest += wallet.CalculateWalletInterest();
                }
            }
            return interest;
        }
    }

   
    public interface IWallet
    {
        List<CreditCard> CreditCards { get; set; }
        float CalculateWalletInterest();
    }

    /// <summary>
    /// 
    /// </summary>
    public class Wallet : IWallet
    {
        public List<CreditCard> CreditCards { get; set; }

        public float CalculateWalletInterest()
        {
            float interest = 0.0F;

            if (CreditCards != null && CreditCards.Any())
            {
                foreach (var card in CreditCards)
                {
                    interest += card.CalculateInterestPerMonth();
                }
            }
            return interest;
        }      
    }
}
