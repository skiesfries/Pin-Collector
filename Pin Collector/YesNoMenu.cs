using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Pin_Collector
{
    public class YesNoMenu : Menu
    {
        public YesNoMenu(string prompt) : base(prompt, new string[] { "Yes", "No" })
        {
        }

        public bool isYes()
        {
            Run();

            return selectedIndex == 0;
        }
    }
}
