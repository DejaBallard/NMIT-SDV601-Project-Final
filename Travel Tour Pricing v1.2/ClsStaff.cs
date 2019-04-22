using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Tour_Pricing
{
    class ClsStaff : ClsCost
    {
        //-------------------------------------DECLARING OBJECTS AND VARIABLES-----------------------------------
        private decimal _Rate;
        public static FrmStaff _Form = new FrmStaff();

        //-------------------------------------END OF DECLARING OBJECTS AND VARIABLES----------------------------
        //
        //
        //
        //
        //-------------------------------------PROPERTY METHODS-------------------------------------------------
        public decimal Rate { get => _Rate; set => _Rate = value; }
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
            return "Staff";
        }

        public override decimal CalculateCost(decimal prRate)
        {
            decimal lcTotal = _Tour.TotalDays* prRate;
            return lcTotal;
        }
        public override decimal UpdateCostFromTour(decimal prDays, decimal prDistance)
        {
            base.TotalPrice = _Rate * prDays;
            return base.TotalPrice;
        }
        //-------------------------------------END OF CLASS METHODS-----------------------------------------------
    }
}
