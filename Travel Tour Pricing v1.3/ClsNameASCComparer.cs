using System.Collections.Generic;


namespace Travel_Tour_Pricing
{
    class ClsNameASCComparer : IComparer<ClsTour>
    {
        public int Compare(ClsTour prTourX, ClsTour prTourY)
        {
            return prTourX.TravelID.CompareTo(prTourY.TravelID);
        }
    }
}
