using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Pin_Collector
{
    class Collector
    {
        public void Start()
        {
            Console.Title = "Pin Collector 1.0";
            string title = @"
 
  _____ _          _____      _ _           _               __   ___  
 |  __ (_)        / ____|    | | |         | |             /_ | / _ \ 
 | |__) | _ __   | |     ___ | | | ___  ___| |_ ___  _ __   | || | | |
 |  ___/ | '_ \  | |    / _ \| | |/ _ \/ __| __/ _ \| '__|  | || | | |
 | |   | | | | | | |___| (_) | | |  __/ (__| || (_) | |     | || |_| |
 |_|   |_|_| |_|  \_____\___/|_|_|\___|\___|\__\___/|_|     |_(_)___/ 
                                                                      
                                                                      
            
                                                                 ";

            Console.WriteLine(title);

            
            WriteLine("Press Enter to begin managing your collection!");
            ReadKey(true);

            RunMainMenu();
        }   

        private void RunMainMenu()
        {
            string prompt = "Hello! What would you like to do today?\n";
            string[] menuOptions = { "Add New Pin to Collection", "View All Pins in Collection", "Edit Owned Pins", "Exit the Pin Collector" };
            Menu mainMenu = new Menu(prompt, menuOptions);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex) 
            {
                case 0:
                    AddNewPin();
                    break;
                case 1:
                    ViewAllPins();
                    break;
                case 2:
                    EditPins();
                    break;
                case 3:
                    Exit();
                    break;
            }
        }

        private void Exit()
        {
            string prompt = "Are you sure you would like to exit?";
            string[] menuOptions = { "Yes", "No" };
            Menu yesOrNoMenu = new Menu(prompt, menuOptions);
            int selectedIndex = yesOrNoMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    RunMainMenu();
                    break;
            }
        }

        private void AddNewPin()
        {

        }

        private void ViewAllPins()
        {

        }

        private void EditPins()
        {

        }
    }
}
