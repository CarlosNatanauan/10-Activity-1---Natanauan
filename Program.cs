using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Carlos";
            Administrator admin = new Administrator(name, "14369", "pass123");
            string user, pass, newpass, newname;
            int pick;
            Console.WriteLine("To check if credentials are correct");
            Console.WriteLine("Name: Carlos  UserID:14369   Pass:pass123\n");
            Console.WriteLine("\t1 -- Login\n\t2 -- Update Name\n\t3 -- Update Password");
            Console.Write("\nEnter number: ");
            pick = Convert.ToInt32(Console.ReadLine());
            switch (pick) {
                case 1:
                    Console.WriteLine("\n       LOG IN   ");
                    Console.WriteLine("\n   Admin Name:" + name);
                    Console.Write("Enter User ID: ");
                    user = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    pass = Console.ReadLine();

                    if (admin.verifyLogin(user, pass) == true)
                    {
                        Console.WriteLine("\n+------------------+");
                        Console.WriteLine("+  Greetings " + name);
                        Console.WriteLine("+  Log in Success");
                        Console.WriteLine("+------------------+");
                    }
                    else
                    {
                        Console.WriteLine("\n---User or Password Incorrect---");
                        Console.WriteLine("\n----Exit and Try again----\n");
                    }
                    break;
                case 2:
                    Console.WriteLine("\n    Update Admin Name");
                    
                    Console.Write("\nEnter New Name: ");
                    newname = Console.ReadLine();
                    admin.updateName(newname);

                    Console.WriteLine("\n       LOG IN   ");
                    Console.WriteLine("\n   Admin Name:" + newname);
                    Console.Write("Enter User ID: ");
                    user = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    pass = Console.ReadLine();

                    if (admin.verifyLogin(user, pass) == true)
                    {
                        Console.WriteLine("\n+------------------+");
                        Console.WriteLine("+  Greetings " + newname);
                        Console.WriteLine("+  Log in Success");
                        Console.WriteLine("+------------------+");
                    }
                    else
                    {
                        Console.WriteLine("\n---User or Password Incorrect---");
                        Console.WriteLine("\n----Exit and Try again----\n");
                    }
                    break;
                case 3:
                    Console.WriteLine("\n    Update Password");

                    Console.Write("\nEnter New Password: ");
                    newpass = Console.ReadLine();
                    admin.updatePassword(newpass);

                    Console.WriteLine("\n       LOG IN   ");
                    Console.WriteLine("\n   Admin Name:" + name);
                    Console.Write("Enter User ID: ");
                    user = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    pass = Console.ReadLine();

                    if (admin.verifyLogin(user, pass) == true)
                    {
                        Console.WriteLine("\n+------------------+");
                        Console.WriteLine("+  Greetings " + name);
                        Console.WriteLine("+  Log in Success");
                        Console.WriteLine("+------------------+");
                    }
                    else
                    {
                        Console.WriteLine("\n---User or Password Incorrect---");
                        Console.WriteLine("\n----Exit and Try again----\n");
                    }
                    break;
                default: Console.WriteLine("Input Error");
                    break;

            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            
        }
        public abstract class User
        {
            private string user_id;

            protected string user_password;

            public User(string id, string pass)
            {
                this.user_id = id;
                this.user_password = pass;
            }
            public bool verifyLogin(string id, string pass)
            {
                return user_id.Equals(id) && user_password.Equals(pass);
            }
            public abstract void updatePassword(string newPassword);
            
        }

        public class Administrator : User
        {
            private string admin_name;

            public Administrator(string name, string id, string pass) : base(id, pass)
            {
                this.admin_name = name;
            }
            public override void updatePassword(string newPassword)
            {
                this.user_password = newPassword;
            }

            public void updateName(string name)
            {
                this.admin_name = name;
            }
            
        }

    }
}
