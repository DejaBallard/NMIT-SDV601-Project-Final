using System.Collections.Generic;

namespace Travel_Tour_Pricing
{
    class ClsDateDSCComparer : IComparer<ClsTour>
    {
        public int Compare(ClsTour prTourX, ClsTour prTourY)
        {
            return prTourY.StartDate.Date.CompareTo(prTourX.StartDate.Date);
        }
    }
}
