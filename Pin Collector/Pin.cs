using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace Pin_Collector
{
    public class Pin
    {
        public string Name;
        public string Collection;
        public string Character;

       public string GetPinForDisplay(string color)
        {
            if (color == "cyan")
            {
                ForegroundColor = ConsoleColor.Cyan;
            }

            return $"Name: {Name}      Collection: {Collection}      Character: {Character}";
          
        }

        public string IsInfoCorrectResetColor()
        {
            return "If this information is correct, select \"SAVE\" to add this pin to your collection. Otherwise, select the information that is incorrect to modify it.";
        }

    } 

}
