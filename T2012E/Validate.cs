using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormAccount
{
    class Validate
    {
        public bool CheckText(string text)
        {
            return text != "";
        }

        public bool CheckNumber(string number)
        {
            Regex regex = new Regex("^[0-9]{8,10}$");
            return regex.IsMatch(number);
        }

        public bool CheckPassword(string password)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9]{3,}$");
            return regex.IsMatch(password);
        }

        public bool CheckEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(email);
        }
    }
}