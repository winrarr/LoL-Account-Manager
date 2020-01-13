using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoL_Account_Manager
{
    class AccountSerializer
    {
        public static List<Account> getAllAccounts(string path = @"Accounts.json")
        {
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Account>>(json);
        }

        public static void serializeAllAccounts(List<Account> accounts, string path = @"Accounts.json")
        {
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, accounts);
            }
        }
    }
}
