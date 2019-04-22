using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Tour_Pricing
{
    public class ClsTour
    {
        //Declaring
        private string _TravelID;
        private string _Name;
        private DateTime _StartDate = DateTime.Today;
        private DateTime _EndDate = DateTime.Today;
        // add combo box for type
        private int _Distance;
        private int _MaxPeople;
        private int _MarkUp;

        //Properties
        public string TravelID { get => _TravelID; set => _TravelID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public DateTime StartDate { get => _StartDate; set => _StartDate = value; }
        public DateTime EndDate { get => _EndDate; set => _EndDate = value; }
        public int Distance { get => _Distance; set => _Distance = value; }
        public int MaxPeople { get => _MaxPeople; set => _MaxPeople = value; }
        public int MarkUp { get => _MarkUp; set => _MarkUp = value; }
    }
}
