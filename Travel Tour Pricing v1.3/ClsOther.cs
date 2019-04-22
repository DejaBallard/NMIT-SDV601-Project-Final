using System;

namespace Travel_Tour_Pricing
{
    [Serializable]
    class ClsOther : ClsCost
    {
        //-------------------------------------DECLARING OBJECTS AND VARIABLES-----------------------------------


        public static FrmOther _Form = new FrmOther();


        //-------------------------------------END OF DECLARING OBJECTS AND VARIABLES----------------------------
        //
        //
        //
        //
        //-------------------------------------PROPERTY METHODS-------------------------------------------------
        //-------------------------------------END OFPROPERTY METHODS--------------------------------------------
        //
        //
        //
        //
        //-------------------------------------CLASS METHODS----------------------------------------------------


        public override bool VeiwEdit()
        {
            return _Form.ShowDialog(this);
        }

        protected override string GettypeOfCost()
        {
            return "Other";
        }

        public override decimal CalculateCost(decimal prRate)
        {
            return prRate;
        }

        public override decimal UpdateCostFromTour(int prDays, decimal prDistance)
        {
            return base.TotalPrice;
        }


        //-------------------------------------END OF CLASS METHODS-----------------------------------------------
    }
}
