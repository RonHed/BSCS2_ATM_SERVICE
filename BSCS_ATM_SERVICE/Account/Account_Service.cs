using System;
using System.Globalization;

namespace BSCS_ATM_SERVICE.Account
{
    // Methods in ATM_Machine
    public class Account_Service : ATM
    {
        
        public void Transaction_Menu() {
            Console.WriteLine("|=======================================|");
            Console.WriteLine("|      WELCOME TO BSCS ATM SERVICE!     |");
            Console.WriteLine("|=======================================|");
            Console.WriteLine("|           Transaction Menu            |");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("          [1] Current Balance            ");
            Console.WriteLine("          [2] Withdraw                   ");
            Console.WriteLine("          [3] Deposit                    ");
            Console.WriteLine("          [4] Cancel                     ");
        }

        public void Another_Transaction(){
            Console.WriteLine("=========================================");
            Console.WriteLine("Would you like to do another transaction?");
            Console.WriteLine("     [1] Yes \n     [2] No");
        }
        public double Current_Balance(double _balance){
            Console.WriteLine("*****************************************");
            Console.WriteLine("-------------Account-Balance-------------");
            Console.WriteLine("| Time: " + DateTime.Now);
            Console.WriteLine("| Balance: P" + _balance);
            Console.WriteLine("*****************************************");

            Console.WriteLine("--Thank you for using BSCS ATM Service!--");
            return _balance;
        }

        public double Withdraw(double _balance){
            double withdrawMoney; 
            
            Console.WriteLine("-----------------------------------------");
            Console.Write("Enter your withdrawal amount: ");
            withdrawMoney = Convert.ToDouble(Console.ReadLine());
            
            if(withdrawMoney >= 0 && withdrawMoney <= _balance) {
            _balance -= withdrawMoney;
            Console.WriteLine("*****************************************");
            Console.WriteLine("-------------Account-Balance-------------");
            Console.WriteLine("| Time: " + DateTime.Now);
            Console.WriteLine("| Balance: P" + _balance);
            Console.WriteLine("*****************************************");
            
            Console.WriteLine("------------Have a nice day!------------\n-Thank you for banking with BSCS ATM Service!-");
	        }
	        else{
		        Console.WriteLine("\nSorry, this transaction may exceed/fail the minimum balance of your account.\n--Thank you for banking with us! Have a nice day!--");
	        }
            return _balance;
      }
        public double Deposit(double _balance){
            double depositMoney;

            Console.WriteLine("-----------------------------------------");
            Console.Write("Enter amount to deposit: ");
            depositMoney = Convert.ToDouble(Console.ReadLine());

                if(depositMoney > 0){
                _balance += depositMoney;

                Console.WriteLine("*****************************************");
                Console.WriteLine("-------------Account-Balance-------------");
                Console.WriteLine("| Time: " + DateTime.Now);
                Console.WriteLine("| Balance: P" + _balance);
                Console.WriteLine("*****************************************");
                Console.WriteLine("------------Have a nice day!------------\n-Thank you for banking with BSCS ATM Service!-");
                }
                else
                {
                    Console.WriteLine("---!Sorry, cannot deposit with that amount.!---\nThank you for banking with us! Have a nice day!");    
                }
            return _balance;
        }

        public void Cancel_Transaction(){
            Environment.Exit(-1);
        }

        public void Message() {
            System.Console.WriteLine("--Thank you for using BSCS ATM Service!--");
        }

        public void Error_Message(){
            Console.WriteLine("-------!Invalid Transaction Number!------"); 
        }
    }
}
// ***********************
// Work by Ron Hedwig Zape
// BSCS 2
// ACLCC-Iriga
// ***********************