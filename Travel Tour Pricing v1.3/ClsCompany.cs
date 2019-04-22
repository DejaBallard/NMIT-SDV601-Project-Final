using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Travel_Tour_Pricing
{
    [Serializable]
    class ClsCompany
    {
        //-------------------------------------DECLARING OBJECTS AND VARIABLES-----------------------------------

        private static Dictionary<string, ClsTour> _TourList = new Dictionary<string, ClsTour>();
        private static string _FileName = "..\\Storage.dat";

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

        public static void Save()
        {
            using (FileStream lcFileStream = new FileStream(_FileName, FileMode.Create))
            { BinaryFormatter lcFormatter = new BinaryFormatter();
                lcFormatter.Serialize(lcFileStream, _TourList);
            }
        }
        public static void Retrive()
        {
            using (FileStream lcFileStream = new FileStream(_FileName, FileMode.Open))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                _TourList = (Dictionary<string, ClsTour>)
                    lcFormatter.Deserialize(lcFileStream);
            }
        }
        //-------------------------------------END OF CLASS METHODS----------------------------------------------
    }
}
// Coded By Deja Ballard 2018
