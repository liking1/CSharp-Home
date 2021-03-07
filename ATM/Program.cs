using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class ATM
    {
        // реалізуєм перемінні
        private decimal Money = 0;
        private Int32 Id = 0;
        private String Login, Password;

        public ATM() { }
        public ATM(decimal Money_, Int32 Id_, String Login_, String Password_)
        {
            this.Money = Money_;
            this.Id = Id_;
            this.Login = Login_;
            this.Password = Password_;
        }
        // додавання грошей
        public decimal AddMoney()
        {
            decimal Money_;
            Console.WriteLine("Enter value : ");
            Money_ = decimal.Parse(Console.ReadLine());
            if (Money_ != 0)
            {
                this.Money = Money_;
            }
            else
                Console.WriteLine("Error!!!");
            return Money_;
        }
        
        // зняття грошей
        public decimal Withdraw()
        {
            decimal Money_;
            Console.WriteLine("Enter count : ");
            Money_ = decimal.Parse(Console.ReadLine());
            if (Money_ != 0)
            {
                this.Money -= Money_;
            }
            else
            {
                Console.WriteLine("Error of deleting!");
            }
            return Money_;
        }
        // показ балансу
        public void ShowBalance()
        {
            Console.WriteLine($"Show balance : {Money}");
        }

        public int GetId()
        {
            return Id;
        }
        //public String GetOwner()
        //{
        //    return Owner;
        //}
        public void Menu()
        {
            
            int action = 0;
            Console.WriteLine("Enter login : ");
            Login = Console.ReadLine();
            if (Login == "hello")
            {
                Console.WriteLine("Enter password : ");
                Password = Console.ReadLine();
                do
                {
                    if (Password == "world")
                    {
                        Console.Clear();
                        Console.WriteLine("1. Add Money ");
                        Console.WriteLine("2. Withdraw ");
                        Console.WriteLine("3. Show Balance ");
                        Console.WriteLine("0. Exit ");

                        Console.WriteLine("Enter action : ");
                        action = int.Parse(Console.ReadLine());
                        if (action == 1)
                        {
                            AddMoney();
                            
                        }
                        else if (action == 2)
                        {
                            Withdraw();
                        }
                        else if (action == 3)
                        {
                            ShowBalance();
                            Console.WriteLine($"Press any key {Console.ReadKey()}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad password");
                    }
                } while (action != 0);
                
            }
            else
            {
                Console.WriteLine("Bad login");
            }
        }
    }

    class Card : ATM
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            atm.Menu();
        }
    }
}
