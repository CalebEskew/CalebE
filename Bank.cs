using System;

public class Bank
{

   


    public Account[] accountsArray = new Account[10];

   
        //add account method
   
    public bool AddAccount(Account newAcc)
    {
        bool accAdded = false;

        for (int i = 0; i < accountsArray.Length; i++)
        {
            if (accountsArray[i] == null)
            {
               
                accountsArray[i] = newAcc;
                accAdded = true;
                break;
            }


        }

        return accAdded;


    }

    public void ApplyDeposits()
    {
        for (int i = 0; i < accountsArray.Length; i++)
        {
            if (accountsArray[i] != null)
            {
                accountsArray[i].UpdateAcctBalance();
            }
        }


    }

    public override string ToString()
    {
        string str = "";
        for (int i = 0; i < accountsArray.Length; i++)
        {
            if (accountsArray[i] != null)
            {
                str += accountsArray[i] + "\n\n";
            }
            else
            {
                str += "No Account found \n\n";
            }
        }

        return str;
    }

}