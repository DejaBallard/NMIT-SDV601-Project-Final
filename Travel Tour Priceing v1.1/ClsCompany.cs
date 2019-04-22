using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Tour_Pricing
{
    class ClsCompany
    {
        //-------------------------------------DECLARING OBJECTS AND VARIABLES-----------------------------------


        private static Dictionary<string, ClsTour> _TourList = new Dictionary<string, ClsTour>();



        //-------------------------------------END OF DECLARING OBJECTS AND VARIABLES-----------------------------
        //
        //
        //
        //
        //-------------------------------------PROPERTY METHODS-------------------------------------------------


        public static Dictionary<string, ClsTour> TourList { get => _TourList; set => _TourList = value; }


        //-------------------------------------END OF PROPERTY METHODS-------------------------------------------
        //
        //
        //
        //
        //-------------------------------------CLASS METHODS-----------------------------------------------------

        //-------------------------------------END OF CLASS METHODS----------------------------------------------
    }
}
// Coded By Deja Ballard 2018
