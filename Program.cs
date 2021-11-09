using System;

namespace hopooe.useracc
{


    class Program
    {

        static void Main(string[] args)
        {
            #region User class


            User Users = new User(); 


            Console.WriteLine("First Name");
            Users.FirstName = Console.ReadLine();

            Console.WriteLine("Last Name:");
            Users.lastName = Console.ReadLine();
            Console.WriteLine("User Name:");
            Users.UserName = Console.ReadLine();
            Console.WriteLine("Email");
            Users.Email = Console.ReadLine();

            Console.WriteLine("birthday");
            Users.BirthDay = Convert.ToDateTime(Console.ReadLine());

           
            Console.WriteLine("mobile");
            Users.mobile = Console.ReadLine();

            Console.WriteLine("monthly Salary");
            Users.monthlysalary = Convert.ToDouble(Console.ReadLine());
            


            Console.WriteLine(Users.FullName());
            Console.WriteLine("User's age is: " + Users.CalAge());
           
           
            Console.WriteLine("User's Mobile Number:" + Users.Mobile());
            Console.ReadLine();
            #endregion


            respon respon = new respon();
            #region Check password
            Console.WriteLine("write your password");
            string userPassword = Console.ReadLine();



            bool IsPasswordCorrect = respon.CheckPassword(userPassword);

            if (IsPasswordCorrect)
            {

                Console.WriteLine("logged in");
            }
            else
            {
                Console.WriteLine("password is wrong");
            }
            #endregion

            #region Confirm password
            
            Console.WriteLine("enter you password");
             
            string UserPassword = respon.ConvertoCapital(Console.ReadLine());
            
            Console.WriteLine("confirm your password again");
            
            string UserConfirmPassword = respon.ConvertoCapital(Console.ReadLine());

            bool IsPasswordConfirmed = respon.ConfirmPassword(UserPassword, UserConfirmPassword);
            if (IsPasswordConfirmed)
            {
                Console.WriteLine("password confirmed");
            }
            else
            {
                Console.WriteLine("password is wrong");
            }

            #endregion
           
        }


    }
    class respon
    {
        
        public bool CheckPassword(string password)
        {
            string MainPassword = "";

            if (password == MainPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ConfirmPassword(string password, string confirmPassword)
        {
            if (password == confirmPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string ConvertoCapital(string text)
        {
            
            string Capital = text.ToUpper();
            return Capital;
        }
    }
}