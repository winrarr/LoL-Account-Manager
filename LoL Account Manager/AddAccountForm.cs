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
    public partial class AddAccountForm : Form
    {
        private MainForm mainForm;

        public AddAccountForm(MainForm form, int serverIndex)
        {
            InitializeComponent();
            serverCombobox.SelectedIndex = serverIndex;
            mainForm = form;
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                APIAccount account = RiotAPI.GetAccountFromUrl<APIAccount>(serverCombobox.Text, nameTextbox.Text);

                if (mainForm.accountPuuids.Contains(account.Puuid))
                {
                    MessageBox.Show("Account already added");
                    return;
                }

                AccountListHandler.addAccountToServer(new Account(account, null, usernameTextbox.Text, passwordTextbox.Text, serverCombobox.Text), mainForm);
                mainForm.accountPuuids.Add(account.Puuid);

                mainForm.updateAccounts();
                mainForm.changeServer(serverCombobox.SelectedIndex);

                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured");
            }
        }
    }
}
