using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutSystem
{   class CreateOrder
    {
        public double starterCost = 4;
        public double mainDishCost = 7;
        public double drinksCost = 2.5;

        public int Total(int  starterNumber = 0 , int mainDishNumber = 0, int drinksNumber = 0)
        {
            double TotalCost = starterCost * starterNumber + mainDishCost * mainDishNumber + drinksCost * drinksNumber;
            double ServiceCharge = (TotalCost / 100) * 10;
            TotalCost += ServiceCharge;
            Console.WriteLine("Total Bill " + " " + TotalCost);
            return (int)TotalCost;
        }

    }
}
                                                                 
