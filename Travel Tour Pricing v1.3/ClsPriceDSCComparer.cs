using System.Collections.Generic;


namespace Travel_Tour_Pricing
{
    class ClsPriceDSCComparer : IComparer<ClsTour>
    {
        public int Compare(ClsTour prTourX, ClsTour prTourY)
        {
            return prTourY.PricePerPerson.CompareTo(prTourX.PricePerPerson);
        }
    }
}
