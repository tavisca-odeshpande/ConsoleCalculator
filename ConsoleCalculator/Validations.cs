using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class Validations
    {
        public string[] Validate(string inp)
        {
            bool digit = false, opertor = false, special = false;
            string[] output = new string[2];
            foreach(char ch in inp)
            {
                if (ch == '0' || ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9')
                {
                    digit = true;
                }
                else if (ch == '.' || ch == '-' || ch == '+' || ch == 'x' || ch == '/')
                {
                    opertor = true;
                }
                else if(ch == 's' || ch == 'c' || ch == '=')
                {
                    special = true;
                }
                else
                {
                    output[0] = "invalid input";
                    output[1] = "invalid charachters";

                    return output;
                }
            }

            if(inp.Length > 1 && digit==true && opertor==false && special == false)
            {
                output[0] = inp;
                output[1] = "digit";

                return output;
            }
            else if(inp.Length == 1 && digit == false && opertor == true && special == false)
            {
                output[0] = inp;
                output[1] = "operator";

                return output;
            }
            else if (inp.Length == 1 && digit == false && opertor == false && special == true)
            {
                output[0] = inp;
                output[1] = "special";

                return output;
            }
            else
            {
                output[0] = "invalid input";
                output[1] = "invalid syntax";

                return output;
            }
            
        }
    }
}
