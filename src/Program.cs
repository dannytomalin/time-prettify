using System;
using System.Collections.Generic;
using TimePrettify;

namespace src
{
    class Program
    {

        public static string UserInput { get; private set; }
        public static string PrettfiedTime { get; private set; }
        public static string ConvertedMinutes { get; set; }
        public static string ConvertedHours { get; set; }

        public static TimeDictionary TimeDictionary = new TimeDictionary();
        public static void Main()
        {

            Console.WriteLine("Please enter a time hh:mm");
            UserInput = Console.ReadLine();
            
            var IsValidDate = DateTime.TryParse(UserInput, out DateTime result);

            if(IsValidDate == true)
            {                      
                var hours = result.Hour;
                var minutes = result.Minute;

                foreach (var item in TimeDictionary.MinutesDictionary)
                {
                    if (minutes == item.Key)
                    {
                        ConvertedMinutes = minutes.ToString();
                        ConvertedMinutes = item.Value;
                    }
                };

                foreach (var item in TimeDictionary.HoursDictionary)
                {
                    if (hours == item.Key)
                    {
                        ConvertedHours = hours.ToString();
                        ConvertedHours = item.Value;
                    }
                };

                if (minutes <= 30)
                {
                    if (minutes == 0)
                    {
                        PrettfiedTime = $"{ConvertedHours} {ConvertedMinutes}";
                    } 
                    else if(minutes == 15 || minutes == 30)
                    {
                        PrettfiedTime = $"{ConvertedMinutes} past {ConvertedHours}";
                    }
                    else
                    {
                        if(minutes > 1)
                        {
                            PrettfiedTime = $"{ConvertedMinutes} minutes past {ConvertedHours}";

                        } 
                        else
                        {
                            PrettfiedTime = $"{ConvertedMinutes} minute past {ConvertedHours}";

                        }
                    }
                } 
                else
                {
                    var totalMinutes = 60;
                    minutes = totalMinutes - minutes;
                    hours = hours + 1;

                    foreach (var item in TimeDictionary.MinutesDictionary)
                    {

                        if (minutes == item.Key)
                        {
                            ConvertedMinutes = minutes.ToString();
                            ConvertedMinutes = item.Value;
                        }
                    }
                    foreach (var item in TimeDictionary.HoursDictionary)
                    {
                        if (hours == item.Key)
                        {
                            ConvertedHours = hours.ToString();
                            ConvertedHours = item.Value;
                        }
                    };

                    if(minutes == 45)
                    {
                        PrettfiedTime = $"{ConvertedMinutes} to {ConvertedHours}";
                    }
                    else
                    {
                        if(minutes > 1)
                        {
                            PrettfiedTime = $"{ConvertedMinutes} minutes to {ConvertedHours}";

                        }
                        else
                        {
                            PrettfiedTime = $"{ConvertedMinutes} minute to {ConvertedHours}";

                        }
                    }
                }
                PrettfiedTime = PrettfiedTime.ToLower();
                var Capital = PrettfiedTime.Substring(0,1).ToUpper();
                PrettfiedTime = Capital + PrettfiedTime.Substring(1);
                Console.WriteLine(PrettfiedTime);
            }
            else
            {
                Console.WriteLine("That doesn't look like a valid time");
            }
        }
    }
}
