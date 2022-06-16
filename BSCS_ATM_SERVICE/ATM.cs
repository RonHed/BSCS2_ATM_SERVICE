using System;
using System.Globalization;
using BSCS_ATM_SERVICE.Account;

namespace BSCS_ATM_SERVICE
{
    public class ATM
    {
        // Declare properties
        public double _balance { get; set; }
        public int transactNum { get; set; }
        public int transactNum2 { get; set; }

        // Initialize values in constructor
        public ATM()
        {
            _balance = 10000.00;
            transactNum = 0;
            transactNum2 = 0;
        }    

        // ATM 
        public void ATM_Machine() 
        {
            do
            {
                // Display Transaction Menu from Account Services
                Account_Service accountS = new Account_Service();
                accountS.Transaction_Menu();
                
                Console.WriteLine("-----------------------------------------");
                Console.Write("Enter the transaction number: ");
                transactNum = Convert.ToInt32(Console.ReadLine());

                // Options from Transaction Menu 
                    switch (transactNum)
                    {
                        case 1:
                            // Current Balance
                            accountS.Current_Balance(_balance);
                        break;
                        case 2:
                            // Withdraw
                            accountS.Withdraw(_balance);
                        break;
                        case 3:
                            // Deposit 
                            accountS.Deposit(_balance);
                        break;
                        case 4:
                            // Cancel
                            accountS.Cancel_Transaction();
                        break;
                        default: 
                            // Invalid Transaction Number
                            accountS.Error_Message();
                        break;
                    } 
                // Another Transaction 
                accountS.Another_Transaction();

                // Try-Catch-Finally for Unhandled Exceptions 
                try
                {
                    transactNum2 = Convert.ToInt32(Console.ReadLine());    
                }
                catch (Exception e) 
                {
                    accountS.Message();
                }
                finally 
                {
                    if (transactNum2 == 2) {
                        accountS.Message();
                    }
                    else if(transactNum2 < 1) {
                        accountS.Error_Message();
                        accountS.Message();
                    }
                    else
                    {
                        accountS.Message();
                    }
                }
            } while (transactNum != 4 && transactNum2 != 2);                      
        }
    }
}
// ***********************
// Work by Ron Hedwig Zape
// BSCS 2
// ACLCC-Iriga
// ***********************