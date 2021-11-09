using System;

namespace hopooe.useracc
{
    class User
    {
        
        public string FirstName;
        public string lastName;
        public string UserName;
        public string Email;
        public DateTime BirthDay;
        public double monthlysalary;
        public string mobile;
        private string number;
        public string Mobile()
        {
           
         return mobile;
        }


        private string Name;
        public string FullName()
        {


            Name = string.Concat(FirstName + lastName);
            return Name;
        }


        private DateTime today = DateTime.Now; 
        private int Age;

        public int CalAge()
        {
            Age = today.Year - BirthDay.Year;
            return Age;
        }
    }
}