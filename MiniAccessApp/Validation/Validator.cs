using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //to use with RegEx

namespace MiniAccessApp.Validation
{
    class Validator
    {

        public static bool isValidName(string input)
        {
            if (input == "")
            {
                MessageBox.Show("Invalid Text Format Input! \nEmpty string is not allowed!", "Error Message!");
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLetter(input[i]) && (!Char.IsWhiteSpace(input[i])) && (!Char.IsDigit(input[i])))
                {
                    MessageBox.Show("Invalid Text Format Input! \nNot compatible characters!", "Error Message!");
                    return false;
                }
            }
            return true;
        }


        public static bool isValidId(string input, int size)
        {
            //this could be used to check any size of input string
            //checking the input against numbers only
            if (Regex.IsMatch(input, @"^\d{" + size + "}$"))
            {
                return true;
            }
            return false;
        }
    }
}
