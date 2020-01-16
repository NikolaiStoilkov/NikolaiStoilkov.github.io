using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BankAccuntManager;

namespace AccountVerifier
{
    class GetAccountCoincidence
    {
        public Dictionary<string, string> accDate = new Dictionary<string, string>();
        public string path = @"D:\NikolaiStoilkov.github.io\BankAccountManager\BankAccuntManagerSolution\BankAccuntManager\data\accounts.txt";
        
        // Create file to keep date.
        // 
        //
        //
        // Make method that read data and return in string, then fill dictionary and check each KEY.
        // If input coicidence with any KEY grant access to user.
        // 
        // Create "Register User to DB" then convert string to JSON.
        // If user register successfully grant access to add Bank Account for managing. 


        public void ReadAccountsFile(object sender, EventArgs e)
        {
            string[] readedAccounts = File.ReadAllLines(path);

            var accountsText = readedAccounts[0].Split(new char[] { ',', '"', '=', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            // Fill dictionary with readed data.

            for (int i = 0; i < accountsText.Length; i += 2)
            {
                accDate.Add(accountsText[i], accountsText[i + 1]);
            }

        }

        public bool CheckIfExistThisId(string id)
        {
            Form1 form = new Form1();

            // Form1 firstForm = new Form1();
            string insideKey = string.Empty;
            foreach (var key in accDate)
            {
                insideKey = key.Key;
                string box =  form.BoxValueOfAccount();
                if (accDate.ContainsKey(box))
                {
                    return true;
                }
            }

            return false;
        }

        // Split Accounts in file with specific symbols --> ',' =', ' ', '",
    }

    
}
