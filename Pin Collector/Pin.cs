using System;
using System.Collections.Generic;
using System.Text;


namespace Pin_Collector
{
    public class Pin
    {
        public string Name;
        public string Collection;
        public string Character;

       public string GetPinForDisplay()
        {
            return $"Name: {Name}      Collection: {Collection}      Character: {Character}";
        }
    } 
}
