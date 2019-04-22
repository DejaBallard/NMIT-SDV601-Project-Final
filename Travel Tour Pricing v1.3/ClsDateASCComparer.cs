using System.Collections.Generic;

namespace Travel_Tour_Pricing
{
    class ClsDateASCComparer : IComparer<ClsTour>
    {
        public int Compare (ClsTour prTourX, ClsTour prTourY)
        {
            return prTourX.StartDate.Date.CompareTo(prTourY.StartDate.Date);
        }
    }
}
