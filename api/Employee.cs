using System;

namespace api
{
    public class Employee
    {
        public int employeeID {get; set;}

        public string empFName {get; set;}

        public string empLName {get; set;}

        public string empEmail {get; set;}

        public string empPassword {get; set;}

        public override string ToString()
        {
            return employeeID + " " + empFName + " " + empLName + " " + empEmail + " " + empPassword;
        }
    }
}