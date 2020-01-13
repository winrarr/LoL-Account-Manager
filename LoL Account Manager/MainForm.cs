using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Account_Manager
{
    public partial class MainForm : Form
    {
        public List<List<Account>> accounts = new List<List<Account>>();
        public List<string> accountPuuids = new List<string>();
        private int currentServer;

        public MainForm()
        {
            InitializeComponent();
            setup();
            loadAccounts();
            updateAccounts();
            serverCombobox.SelectedIndex = 0;
            currentServer = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAccountForm addAccountsForm = new AddAccountForm(this, currentServer);
            addAccountsForm.Show();
        }

        private void setup()
        {
            for (int i = 0; i < 6; i++)
            {
                accounts.Add(new List<Account>());
            }
        }

        public void updateAccounts()
        {
            accountListbox.Items.Clear();
            try
            {
                List<Account> rawAccountList = new List<Account>();
                foreach (List<Account> server in accounts)
                {
                    foreach (Account account in server)
                    {
                        try
                        {
                            account.addAPIAccount(RiotAPI.GetAccountFromUrl<APIAccount>(account.Server, account.Name));
                        }
                        catch (Exception) { account.addAPIAccount(new APIAccount()); }
                        try
                        {
                            account.addAPIRank(RiotAPI.GetRankFromUrl<APIRank>(account.Server, account.Id));
                        }
                        catch (Exception) { account.addAPIRank(new APIRank()); }

                        rawAccountList.Add(account);
                        accountListbox.Items.Add(account.Name);
                    }
                }
                AccountSerializer.serializeAllAccounts(rawAccountList);
            }
            catch (Exception) { }
        }

        private void loadAccounts()
        {
            try
            {
                foreach (Account account in AccountSerializer.getAllAccounts())
                {
                    AccountListHandler.addAccountToServer(account, this);
                }
            }
            catch (Exception) { }
        }

        private void accountListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account account = accounts[currentServer][accountListbox.SelectedIndex];

            string rankString = account.Tier + " ";
            rankString += account.Rank + " (";
            rankString += account.LeaguePoints + " LP)";
            rankDisplayLabel.Text = rankString;

            int wins = account.Wins;
            int losses = account.Losses;
            string winrateString = wins + "/" + losses + " = " + ((float)wins / ((float)wins + (float)losses) * 100).ToString("0.000") + "%";
            winrateDisplayLabel.Text = winrateString;

            usernameTextbox.Text = account.Username;
            passwordTextbox.Text = account.Password;
        }

        private void updateAccountsButton_Click(object sender, EventArgs e)
        {
            updateAccounts();
        }

        private void serverCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeServer(serverCombobox.SelectedIndex);
        }

        public void changeServer(int index)
        {
            currentServer = index;
            accountListbox.Items.Clear();
            try
            {
                foreach (Account account in accounts[index])
                {
                    accountListbox.Items.Add(account.Name);
                }
            }
            catch (Exception) { }
        }

        private void usernameCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(usernameTextbox.Text);
        }

        private void passwordCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordTextbox.Text);
        }

        private void showPassWordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassWordCheckbox.Checked)
            {
                passwordTextbox.PasswordChar = (char)0;
            }
            else
            {
                passwordTextbox.PasswordChar = '•';
            }
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            Account account = accounts[currentServer][accountListbox.SelectedIndex];
            accountPuuids.Remove(account.Puuid);
            accounts[currentServer].Remove(account);
            updateAccounts();
        }
    }
}
