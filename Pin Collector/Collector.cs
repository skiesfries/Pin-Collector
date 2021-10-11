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
            while(true)
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

            if (new YesNoMenu("Are you sure you would like to exit?").isYes())
            {
                Environment.Exit(0);
            }
         
        }

        private void AddNewPin()
        {
            Clear();
            string newPinTitle = @"
 .-----------------. .----------------.  .----------------.   .----------------.  .----------------.  .-----------------.
| .--------------. || .--------------. || .--------------. | | .--------------. || .--------------. || .--------------. |
| | ____  _____  | || |  _________   | || | _____  _____ | | | |   ______     | || |     _____    | || | ____  _____  | |
| ||_   \|_   _| | || | |_   ___  |  | || ||_   _||_   _|| | | |  |_   __ \   | || |    |_   _|   | || ||_   \|_   _| | |
| |  |   \ | |   | || |   | |_  \_|  | || |  | | /\ | |  | | | |    | |__) |  | || |      | |     | || |  |   \ | |   | |
| |  | |\ \| |   | || |   |  _|  _   | || |  | |/  \| |  | | | |    |  ___/   | || |      | |     | || |  | |\ \| |   | |
| | _| |_\   |_  | || |  _| |___/ |  | || |  |   /\   |  | | | |   _| |_      | || |     _| |_    | || | _| |_\   |_  | |
| ||_____|\____| | || | |_________|  | || |  |__/  \__|  | | | |  |_____|     | || |    |_____|   | || ||_____|\____| | |
| |              | || |              | || |              | | | |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' | | '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'   '----------------'  '----------------'  '----------------' ";

            Write(newPinTitle);

            WriteLine("\n\nWhat is the name of your new pin?");
            string newPinName = ReadLine();
            //WriteLine("Is the name " + newPinName + " correct?");

            var iscorrect = new YesNoMenu("Is the name " + newPinName + " correct?").isYes();
            //int selectedIndex = yesOrNoMenu.Run("Is the name " + newPinName + " correct?");
        }

        private void ViewAllPins()
        {

        }

        private void EditPins()
        {

        }
    }
}
