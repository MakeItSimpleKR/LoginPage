using System;
using System.Collections.Generic;
using System.Text;
namespace LoginPage.Model
{

    class Member
    {

        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string _email { get; set; }
        private string _password { get; set; }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public Member()
        {

        }

    }
}
