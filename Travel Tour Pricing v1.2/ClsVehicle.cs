using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Tour_Pricing
{
    class ClsVehicle : ClsCost
    {
        //-------------------------------------DECLARING OBJECTS AND VARIABLES-----------------------------------
        private decimal _KmCharge;
        public static FrmVehicle _Form = new FrmVehicle();


        //-------------------------------------END OF DECLARING OBJECTS AND VARIABLES----------------------------
        //
        //
        //
        //
        //-------------------------------------PROPERTY METHODS-------------------------------------------------
        public decimal KmCharge { get => _KmCharge; set => _KmCharge = value; }
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

        public override string GettypeOfCost()
        {
            return "Vehicle";
        }


        public override decimal CalculateCost(decimal prRate)
        {
            decimal lcTotal = prRate * _Tour.Distance;
            lcTotal *= _Tour.TotalDays;
            return lcTotal;
        }
        public override decimal UpdateCostFromTour(decimal prDays,decimal prDistance)
        {
            base.TotalPrice = _KmCharge * prDistance;
            base.TotalPrice *= prDays;
            return base.TotalPrice;
        }
        //-------------------------------------END OF CLASS METHODS-----------------------------------------------
    }
}
