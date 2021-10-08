﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Pin_Collector
{
    class Menu
    {
        public int selectedIndex;
        public string[] menuOptions;
        public string Prompt;

        public Menu(string prompt, string[] menuOptions)
        {
            Prompt = prompt;
            this.menuOptions = menuOptions;
            selectedIndex = 0;
        }

        private void DisplayOptions()
        {
            WriteLine(Prompt);
            for (int i = 0; i < menuOptions.Length; i++)
            {
                string currentOption = menuOptions[i];
                string indicator;

                if (i == selectedIndex)
                {
                    indicator = "*";
                    ForegroundColor = ConsoleColor.DarkRed;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    indicator = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }

                WriteLine($"{indicator} << {currentOption} >>");
            }
            ResetColor();
        }
        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                }
            } while (keyPressed != ConsoleKey.Enter);

            return selectedIndex;
        }
    }
}
