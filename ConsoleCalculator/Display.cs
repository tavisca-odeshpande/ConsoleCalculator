using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class Display
    {

        string displayString = "";
        public void ShowOnDisplay()
        {
            Console.Clear();
            Console.WriteLine(displayString);
        }

        public string AcceptInputOnDisplay(string added)
        {
            displayString += added;
            return displayString;
        }
    }
}
