using CreditCardInterest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CalculateInterestUnitTest
{
    public class CalculateInterestTestCases
    {
        public CalculateInterestTestCases()
        {
            //initialise objects
        }

        #region Positive Scenarios
        [Fact]
        public async Task Scenario1()
        {
            IPerson person = TestData.PrepareTestData_Scenario_1();

            float totalInterest = person.CalculatePersonInterest();

            Assert.Equal(16.0F, totalInterest);
        }

        [Fact]
        public async Task Scenario2()
        {
            IPerson person = TestData.PrepareTestData_Scenario_2();

            float totalInterest = person.CalculatePersonInterest();

            Assert.Equal(16.0F, totalInterest); //total interest

            Assert.Equal(11.0F, person.Wallets[0].CalculateWalletInterest());
            Assert.Equal(5.0F, person.Wallets[1].CalculateWalletInterest());

            ////foreach (var wallet in person.Wallets)
            ////{
            //    float walletInterest = wallet.CalculateWalletInterest();

            //}
        }

        [Fact]
        public async Task Scenario3()
        {
            IList<IPerson> persons = TestData.PrepareTestData_Scenario_3();

            BusinessLogic businessLogic = new BusinessLogic();

            float totalInterest = businessLogic.CalculateTotalInterest(persons);

            Assert.Equal(35.0F, totalInterest);

            Assert.Equal(20.0F, persons[0].CalculatePersonInterest()); //each person interest

            Assert.Equal(15.0F, persons[1].CalculatePersonInterest());

        }
        #endregion

        #region Nagetive Scenarios
        #endregion
    }
}
