using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Tour_Pricing
{
    public abstract class ClsCost
    {
        //-------------------------------------DECLARING OBJECTS AND VARIABLES------------------------------------
        private string _Name;
        private string _Description;
        private decimal _TotalPrice;
        protected ClsTour _Tour;
        public static readonly string[] CostType = { "Staff", "Transport", "Other" };
   

        //-------------------------------------END OF DECLARING OBJECTS AND VARIABLES----------------------------
        //
        //
        //
        //
        //-------------------------------------PROPERTY METHODS-------------------------------------------------
        public string Name { get => _Name; set => _Name = value; }
        public string Description { get => _Description; set => _Description = value; }
        public decimal TotalPrice { get => _TotalPrice; set => _TotalPrice = value; }
        public ClsTour Tour { get => _Tour; set => _Tour = value; }

        //-------------------------------------END OF PROPERTY METHODS--------------------------------------------
        //
        //
        //
        //
        //-------------------------------------CLASS METHODS----------------------------------------------------
        public override string ToString()
        {
            return GettypeOfCost() +"\t" + _TotalPrice + "\t" + _Name;
        }

        public static ClsCost NewCost(int prChoice, ClsTour prTour)
        {
            switch (prChoice)
            {
                case 0:
                return new ClsStaff() { Tour = prTour };
                case 1:
                    return new ClsVehicle() { Tour = prTour };
                default:
                    return new ClsOther() { Tour = prTour };
            }
        }

        public abstract bool VeiwEdit();

        public abstract string GettypeOfCost();
        public abstract decimal CalculateCost(decimal prRate);
        public abstract decimal UpdateCostFromTour(decimal prDays, decimal prDistance);
        //-------------------------------------END OF CLASS METHODS-----------------------------------------------


    }
}
// Coded By Deja Ballard 2018

