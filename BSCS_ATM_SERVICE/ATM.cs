using System;
using System.Globalization;
using BSCS_ATM_SERVICE.Account;

namespace BSCS_ATM_SERVICE
{
    public class ATM
    {
        // public double balance { get; set; }
        // public ATM()
        // {
            
        // }
        public void ATM_Machine() 
        {
            double balance = 10000.00D;
            int transactNum; 
            int transactNum2 = 0;

            do
            {
                Account_Service accountS = new Account_Service();
                accountS.Transaction_Menu();
                
                Console.WriteLine("-----------------------------------------");
                Console.Write("Enter the transaction number: ");
                transactNum = Convert.ToInt32(Console.ReadLine());

                    switch (transactNum)
                    {
                        case 1:
                            accountS.Current_Balance(balance);
                        break;
                        case 2:
                            accountS.Withdraw(balance);
                        break;
                        case 3:
                            accountS.Deposit(balance);
                        break;
                        case 4:
                            accountS.Cancel_Transaction();
                        break;
                        default: 
                            accountS.Error_Message();
                        break;
                    } 
                accountS.Another_Transaction();
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