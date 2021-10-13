using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Pin_Collector
{
    public class PinList
    {
        static public List<Pin> OwnedPins = new List<Pin>();

        public void ListAllPins()
        {
            Clear();
            string allPinsTitle = @"
 

 __     __                 ____                          _   _____ _           
 \ \   / /                / __ \                        | | |  __ (_)          
  \ \_/ /__  _   _ _ __  | |  | |_      ___ __   ___  __| | | |__) | _ __  ___ 
   \   / _ \| | | | '__| | |  | \ \ /\ / / '_ \ / _ \/ _` | |  ___/ | '_ \/ __|
    | | (_) | |_| | |    | |__| |\ V  V /| | | |  __/ (_| | | |   | | | | \__ \
    |_|\___/ \__,_|_|     \____/  \_/\_/ |_| |_|\___|\__,_| |_|   |_|_| |_|___/
                                                                               
                                                                               

            
                                                                 ";

            Console.WriteLine(allPinsTitle);

            
            foreach (var ownedPin in PinList.OwnedPins)
                WriteLine(ownedPin.GetPinForDisplay());
            ReadKey();

        }

    }


    
}
