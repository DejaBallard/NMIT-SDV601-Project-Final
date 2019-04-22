using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Tour_Pricing
{
    public class ClsTour
    {
        //-------------------------------------DECLARING OBJECTS AND VARIABLES------------------------------------


        private string _TravelID;
        private string _Name;
        private DateTime _StartDate = DateTime.Today;
        private DateTime _EndDate = DateTime.Today;
        private int _TotalDays;
        private int _TypeIndex;
        private decimal _Distance;
        private int _MaxPeople;
        private decimal _MarkUp;
        private decimal _TotalPrice;
        private decimal _TotalPriceWithMarkUp;
        private decimal _PricePerPerson;
        private static FrmTour _Tour = new FrmTour();
        private List<ClsCost> _CostList = new List<ClsCost>();


        //-------------------------------------END OF DECLARING OBJECTS AND VARIABLES----------------------------
        //
        //
        //
        //
        //-------------------------------------PROPERTY METHODS-------------------------------------------------


        public string TravelID { get => _TravelID; set => _TravelID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public DateTime StartDate { get => _StartDate; set => _StartDate = value; }
        public DateTime EndDate { get => _EndDate; set => _EndDate = value; }
        public decimal Distance { get => _Distance; set => _Distance = value; }
        public int MaxPeople { get => _MaxPeople; set => _MaxPeople = value; }
        public decimal MarkUp { get => _MarkUp; set => _MarkUp = value; }
        public decimal TotalPrice { get => _TotalPrice; set => _TotalPrice = value; }
        public decimal PricePerPerson { get => _PricePerPerson; set => _PricePerPerson = value; }
        public decimal TotalPriceWithMarkUp { get => _TotalPriceWithMarkUp; set => _TotalPriceWithMarkUp = value; }
        public int TypeIndex { get => _TypeIndex; set => _TypeIndex = value; }
        public int TotalDays { get => _TotalDays; set => _TotalDays = value; }
        public List<ClsCost> CostList { get => _CostList; set => _CostList = value; }


        //-------------------------------------END OFPROPERTY METHODS--------------------------------------------
        //
        //
        //
        //
        //-------------------------------------CLASS METHODS----------------------------------------------------


        public override string ToString()
        {
            return _TravelID + "\t" + _StartDate.ToShortDateString() + "\t\t" + _PricePerPerson;
        }

        public bool VeiwEdit()
        {
            return _Tour.ShowDialog(this);
        }


        //-------------------------------------END OF CLASS METHODS--------------------------------------------------
    }
}
// Coded By Deja Ballard 2018
