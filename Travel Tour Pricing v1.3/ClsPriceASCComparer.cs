using System.Collections.Generic;

namespace Travel_Tour_Pricing
{
    class ClsPriceASCComparer : IComparer<ClsTour>
    {
        public int Compare(ClsTour prTourX, ClsTour prTourY)
        {
            return prTourX.PricePerPerson.CompareTo(prTourY.PricePerPerson);
        }
    }
}
