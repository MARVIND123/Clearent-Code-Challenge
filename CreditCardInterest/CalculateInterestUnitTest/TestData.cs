using CreditCardInterest;
using GenFu;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateInterestUnitTest
{
    public class TestData
    {
        public static IPerson PrepareTestData_Scenario_1()
        {
            IPerson Person = new Person();

            IWallet wallet = new Wallet
            {
                CreditCards = new List<CreditCard>
                {
                    new VisaCard() { BalanceAmount = 100.0F },
                    new MasterCard() { BalanceAmount = 100.0F },
                    new DiscoverCard() { BalanceAmount = 100.0F }
                }
            };
            Person.Wallets = new List<IWallet>();
            Person.Wallets.Add(wallet);

            return Person;
        }

        public static IPerson PrepareTestData_Scenario_2()
        {
            IPerson Person = new Person();
            
            IWallet wallet1 = new Wallet
            {
                CreditCards = new List<CreditCard>
                {
                    new VisaCard() { BalanceAmount = 100.0F },
                    new DiscoverCard() { BalanceAmount = 100.0F }
                }
            };

            IWallet wallet2 = new Wallet
            {
                CreditCards = new List<CreditCard>
                {
                    new MasterCard() { BalanceAmount = 100.0F },
                }
            };

            Person.Wallets = new List<IWallet>() { wallet1, wallet2 };

            return Person;
        }

        public static List<IPerson> PrepareTestData_Scenario_3()
        {
            IPerson Person1 = new Person();

            IWallet wallet1 = new Wallet
            {
                CreditCards = new List<CreditCard>
                {
                    new MasterCard() { BalanceAmount = 100.0F },
                    new MasterCard() { BalanceAmount = 100.0F },
                    new VisaCard() { BalanceAmount = 100.0F }
                }
            };

            Person1.Wallets = new List<IWallet>() { wallet1 };

            IPerson Person2 = new Person();

            IWallet wallet2 = new Wallet
            {
                CreditCards = new List<CreditCard>
                {
                    new MasterCard() { BalanceAmount = 100.0F },
                    new VisaCard() { BalanceAmount = 100.0F }
                }
            };

            Person2.Wallets = new List<IWallet>() { wallet2 };

            return new List<IPerson>() { Person1, Person2 };
        }
    }
}
