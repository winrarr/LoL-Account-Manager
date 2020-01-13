using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoL_Account_Manager
{
    public class AccountListHandler
    {
        public static void addAccountToServer(Account account, MainForm mainForm)
        {
            switch (account.Server)
            {
                case "EUW1":
                    mainForm.accounts[0].Add(account);
                    break;
                case "NA1":
                    mainForm.accounts[1].Add(account);
                    break;
                case "EUN1":
                    mainForm.accounts[2].Add(account);
                    break;
                case "TR1":
                    mainForm.accounts[3].Add(account);
                    break;
                case "LA1":
                    mainForm.accounts[4].Add(account);
                    break;
                case "OC1":
                    mainForm.accounts[5].Add(account);
                    break;
                default:
                    break;
            }
        }
    }
}
