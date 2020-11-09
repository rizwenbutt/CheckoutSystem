using System;
using TechTalk.SpecFlow;

namespace CheckoutSystem
{
    [Binding]
    public class NewOrderSteps
    {
        [Given(@"there are (.*) customers")]
        public void GivenThereAreCustomers(int p0)
        {
            CreateOrder order = new CreateOrder();
            order.Total(1, 1, 1);
        }
        
        [Given(@"they order (.*) starters")]
        public void GivenTheyOrderStarters(int p0)
        {
            int starterNumber = p0;
        }
        
        [Given(@"they order (.*) mains")]
        public void GivenTheyOrderMains(int p0)
        {
            int MainNumber = p0;
        }
        
        [Given(@"they order (.*) drinks")]
        public void GivenTheyOrderDrinks(int p0)
        {
            int DrinksNumber = p0; 
        }
        
        [When(@"the total bill is calculated")]
        public void WhenTheTotalBillIsCalculated()
        {
            order.Total(1, 1, 1); ;
        }
    }
}
