using System;
using System.Collections.Generic;

namespace TimePrettify
{
    public class TimeDictionary
    {

        public Dictionary<int, string> MinutesDictionary { get; private set; }
        public Dictionary<int, string> HoursDictionary { get; private set; }

        public TimeDictionary()
        {
            MinutesDictionary = new Dictionary<int, string>()
            {
                {0, "O'Clock"},
                {1, "One"},
                {2, "Two"},
                {3, "Three"},
                {4, "Four"},
                {5, "Five"},
                {6, "Six"},
                {7, "Seven"},
                {8, "Eight" },
                {9, "Nine" },
                {10, "Ten"},
                {11, "Eleven"},
                {12, "Twelve"},
                {13, "Thirteen"},
                {14, "Fourteen"},
                {15, "Quarter"},
                {16, "Sixteen"},
                {17, "Seventeen"},
                {18, "Eighteen"},
                {19, "Nineteen"},
                {20, "Twenty"},
                {21, "Twenty One"},
                {22, "Twenty Two"},
                {23, "Twenty Three"},
                {24, "Twenty Four"},
                {25, "Twenty Five"},
                {26, "Twenty Six"},
                {27, "Twenty Seven"},
                {28, "Twenty Eight"},
                {29, "Twenty Nine"},
                {30, "Half"},
                {31, "Thirty One"},
                {32, "Thirty Two"},
                {33, "Thirty Three"},
                {34, "Thirty Four"},
                {35, "Thirty Five"},
                {36, "Thirty Six"},
                {37, "Thirty Seven"},
                {38, "Thirty Eight"},
                {39, "Thirty Nine"},
                {40, "Fourty"},
                {41, "Fourty One"},
                {42, "Fourty Two"},
                {43, "Fourty Three"},
                {44, "Fourty Four"},
                {45, "Quarter"},
                {46, "Fourty Six"},
                {47, "Fourty Seven"},
                {48, "Fourty Eight"},
                {49, "Fourty Nine"},
                {50, "Fifty"},
                {51, "Fifty One"},
                {52, "Fifty Two"},
                {53, "Fifty Three"},
                {54, "Fifty Four"},
                {55, "Fifty Five"},
                {56, "Fifty Six"},
                {57, "Fifty Seven"},
                {58, "Fifty Seven"},
                {59, "Fifty Seven"},
            };

            HoursDictionary = new Dictionary<int, string>() 
            {
                {1, "One"},
                {2, "Two"},
                {3, "Three"},
                {4, "Four"},
                {5, "Five"},
                {6, "Six"},
                {7, "Seven"},
                {8, "Eight"},
                {9, "Nine"},
                {10, "Ten"},
                {11, "Eleven"},
                {12, "Twelve"},
                {13, "One"},
                {14, "Two"},
                {15, "Three"},
                {16, "Four"},
                {17, "Five"},
                {18, "Six"},
                {19, "Seven"},
                {20, "Eight"},
                {21, "Nine"},
                {22, "Ten"},
                {23, "Eleven"},
                {24, "Twelve"}
            };
        }
      
    }
}
