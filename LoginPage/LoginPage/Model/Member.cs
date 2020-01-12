using System;
using System.Collections.Generic;
using System.Text;
namespace LoginPage.Model
{

    class Member
    {

        private string firstName { get; set; }
        private string lastName { get; set; }
        private string email { get; set; }
        private string password { get; set; }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public Member()
        {

        }

    }
}
