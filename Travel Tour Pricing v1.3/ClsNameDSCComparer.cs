using System.Collections.Generic;

namespace Travel_Tour_Pricing
{
    class ClsNameDSCComparer : IComparer<ClsTour>
    {
        public int Compare(ClsTour prTourX, ClsTour prTourY)
        {
            return prTourY.TravelID.CompareTo(prTourX.TravelID);
        }
    }
}
