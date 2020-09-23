using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.SOLID.S
{
    class User
    {
        private string _mail;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get => _mail;
            set {
                if (EmailValidator.Validate(value))
                    _mail = value;
                else
                    throw new Exception();
            } }


    }

    class EmailValidator
    {
        public static bool Validate(string mail)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(mail);
                return addr.Address == mail;
            }
            catch
            {
                return false;
            }
        }
    }
}
