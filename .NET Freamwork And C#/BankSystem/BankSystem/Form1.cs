using BankSystem.Properties;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem
{
    public partial class frmBankSystem : Form
    {
        clsClients NowClient = new clsClients();
        clsUser NowUser = new clsUser();
        clsUser User = new clsUser();
        clsClients Client = new clsClients();

        public enum enUserOrClient  {user = 1,client = 2};
        enUserOrClient _UserOrClient;

        public frmBankSystem(enUserOrClient UserOrClient, string AccountNumberOrUserName)
        {
            InitializeComponent();

            ReturnButtonsToNormal();
            ChangeColorOnClick(btnDashboard);
            HideAllScreens();
            _UserOrClient = UserOrClient;

            plDashBoard.Visible = true;
            plUsers.Visible = true;
            plClients.Visible = true;
            plClientsScreen.Visible = true;
            plTransaction.Visible = true;
            plTransactionScreen.Visible = true;
            plLoginLog.Visible = true;
            plLoginLogScreen.Visible = true;
            plAccessDenied.Visible = true;
            plNewDashboard.Visible = true;



            if (UserOrClient == enUserOrClient.user)
            {
                NowUser = NowUser.FindWithoutPassword(AccountNumberOrUserName);
                pbNowUser.Visible = true;

               
                    ShowAccessDeniedScreen("                   This Page Is Only For Clients  ..!");
                    return;
                

            }
            else
            {
                NowClient = NowClient.FindWithoutPinCode(AccountNumberOrUserName);
                GenerateDashboard();
            }

           

        }

        //UI Design

        private void GenerateDashboard()
        {
           
            pbNowUser.Visible = false;


            lbCardAccountNumber.Text = NowClient.AccountNumber;
            lbCardName.Text = NowClient.FirstName + " " + NowClient.LastName;

            lbAccountNumberDashboardForUpdate.Text = NowClient.AccountNumber;
            tbPinCodeDashboard.Text = NowClient.PinCode;

            lbClientBalanceDashboard.Text = "$"+NowClient.AccountBalance.ToString() ;


            List<clsClients> clsClients = NowClient.ReadClientsFromFile();

            cbAccountNumberDashboard.Items.Clear();
            foreach (clsClients c in clsClients)
            {
                if (c.AccountNumber == NowClient.AccountNumber)
                    continue;

                cbAccountNumberDashboard.Items.Add(c.AccountNumber);
            }



            // lvLastTransaction

            string[] Lines = File.ReadAllLines(@"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\BankSystem\BankSystem\TransactionLog.txt");
            List <string> ClientLines = new List<string> { };

            string[] OneLine;

            foreach (string Line in Lines)
            {
                OneLine = Line.Split('|');
                if (OneLine[0] == NowClient.AccountNumber || OneLine[1] == NowClient.AccountNumber)
                {
                    ClientLines.Add(Line);
                }
            }


           lvLastTransaction.Items.Clear();
            
            for (int i =0 ; i < ClientLines.Count;i++)
            {
                OneLine = ClientLines[i].Split('|');
                lvLastTransaction.Items.Add(OneLine[0]);
                lvLastTransaction.Items[i].SubItems.Add(OneLine[1]);
                lvLastTransaction.Items[i].SubItems.Add(OneLine[2]+"$");
                lvLastTransaction.Items[i].SubItems.Add(OneLine[3]);
            }

           



        }
        private void HideAllScreens()
        {
            plDashBoard.Visible = false;
            plClients.Visible = false;
            plClientsScreen.Visible = false;
            plUsers.Visible = false;
            plTransaction.Visible = false;
            plLoginLog.Visible = false;
            plAccessDenied.Visible = false;
        }
        private void ClearAddUserForm()
        {
            tbID.Clear();
           tbFirstName.Clear();
           tbLastName.Clear();
           tbAddress.Clear();
           tbPhone.Clear();
           tbEamil.Clear();
           tbFatherName.Clear();
           tbMotherName.Clear();
          
        }
        private void ClearAddClientForm()
        {
            
            tbIdClient.Clear();
            tbFNameClient.Clear();
            tbLNameClient.Clear();
            tbAddressClient.Clear();
            tbAddressClient.Clear();
            tbEmailClient.Clear();
            tbFatherClient.Clear();
            tbMotherClient.Clear();
            tbPhoneClient.Clear();

            tbAccountNumber.Clear();
            tbPinCode.Clear();
            
            tbAccountNumberUpdateClient.Clear();
            tbPinCodeUpdateClient.Clear();
            
            tbAccountNumberDeleteClient.Clear();

            tbAccountNumberSearchClient.Clear();

            

        }
        private void OpenClientScreen()
        {
            
            ReturnButtonsToNormal();
            HideAllScreens();
            ClearAddClientForm();
            ChangeColorOnClick(btnClients);
           
            plDashBoard.Visible = true;
            plUsers.Visible = true;
            plClients.Visible = true;
            plClientsScreen.Visible = true;
            plAddClient2.Visible = false;
            plUpdateClient1.Visible = false;
            plUpdateClient2.Visible = false;
            plDeleteClient.Visible = true;
            plSearchClient.Visible = false;
        }
        private void OpenUserScreen()
        {
           
            ReturnButtonsToNormal();
            HideAllScreens();
            ChangeColorOnClick(btnUsers);
            ClearUpdateScreen();

            plDashBoard.Visible = true;
            plClients.Visible = true;
            plUsers.Visible = true;
            plAddUserFirstInfo.Visible = true;
            plAddUserSecondInfo.Visible = false;
            plTransactionScreen.Visible = false;
            
        }
        private bool ValidateTextBox(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                return true;

            return false;
        }
        private void ReturnButtonsToNormal()
        {
            btnDashboard.BackColor = Color.FromArgb(246, 246, 246);
            btnDashboard.FillColor = Color.FromArgb(246, 246, 246);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Image = Resources.icons8_home_48px_2;

            btnUsers.BackColor = Color.FromArgb(246, 246, 246);
            btnUsers.FillColor = Color.FromArgb(246, 246, 246);
            btnUsers.ForeColor = Color.Black;
            btnUsers.Image = Resources.Users;

            btnClients.BackColor = Color.FromArgb(246, 246, 246);
            btnClients.FillColor = Color.FromArgb(246, 246, 246);
            btnClients.ForeColor = Color.Black;
            btnClients.Image = Resources.Clients;

            btnTransaction.BackColor = Color.FromArgb(246, 246, 246);
            btnTransaction.FillColor = Color.FromArgb(246, 246, 246);
            btnTransaction.ForeColor = Color.Black;
            btnTransaction.Image = Resources.icons8_transaction_48px_2;

            btnLoginLog.BackColor = Color.FromArgb(246, 246, 246);
            btnLoginLog.FillColor = Color.FromArgb(246, 246, 246);
            btnLoginLog.ForeColor = Color.Black;
            btnLoginLog.Image = Resources.Log;



        }
        private void ChangeColorOnClick(Guna2Button button)
        {

            button.BorderColor = Color.FromArgb(229, 241, 255);
            button.FillColor = Color.FromArgb(229, 241, 255);
            button.ForeColor = Color.FromArgb(5, 115, 253);
            button.Image = Image.FromFile(@"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\BankSystem\BankSystem\images\" + button.Tag.ToString() + ".png");
        }
        private void ShowAccessDeniedScreen(string Message = "Please talk to your maneger for give you permission")
        {
            lbAccessDenaidMessage.Text = Message;
            plDashBoard.Visible = true;
            plUsers.Visible = true;
            plClients.Visible = true;
            plClientsScreen.Visible = true;
            plTransaction.Visible = true;
            plTransactionScreen.Visible = true;
            plLoginLog.Visible = true;
            plLoginLogScreen.Visible = true;
            plAccessDenied.Visible = true;
            plNewDashboard.Visible = false;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {

            ReturnButtonsToNormal();
            ChangeColorOnClick(btnDashboard);

            if(_UserOrClient == enUserOrClient.client)
            {



                HideAllScreens();
                plDashBoard.Visible = true;
                plUsers.Visible = true;
                plClients.Visible = true;
                plClientsScreen.Visible = true;
                plTransaction.Visible = true;
                plTransactionScreen.Visible = true;
                plLoginLog.Visible = true;
                plLoginLogScreen.Visible = true;
                plAccessDenied.Visible = true;
                plNewDashboard.Visible = true;

                GenerateDashboard();



            }
            else
            {
                ShowAccessDeniedScreen("                   This Page Is Only For Clients  ..!");
                return;
                
            }

            

           





        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            // Error
            OpenUserScreen();
            ChangeColorOnClick((Guna2Button)sender);
           
            ClearChangesOnUserBar();
            ChangeButtonStyleUserBar(btnAddNewUser);

            if(_UserOrClient == enUserOrClient.client)
            {
                ShowAccessDeniedScreen();
                return;
            }
            


            if (!NowUser.isPermissionToAccess(Convert.ToInt32(clsUser.enPermission.Users)))
            {
                ShowAccessDeniedScreen();
                return;
            }

           
            
          
         
        }
        private void btnClients_Click(object sender, EventArgs e)
        {
           
            OpenClientScreen();
            ChangeColorOnClick((Guna2Button)sender);


            if (_UserOrClient == enUserOrClient.client)
            {
                ShowAccessDeniedScreen();
                return;
            }

            if (!NowUser.isPermissionToAccess(Convert.ToInt32(clsUser.enPermission.Clients)))
            {
                ShowAccessDeniedScreen();
                return;
            }

            ClearChangesOnClientBar();
            ChangeButtonStyleUserBar(btnAddClient);
          
           
            plTransactionScreen.Visible = false;
        }
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            ReturnButtonsToNormal();
            ChangeColorOnClick((Guna2Button)sender);


            if (_UserOrClient == enUserOrClient.client)
            {
                ShowAccessDeniedScreen();
                return;
            }

            if (!NowUser.isPermissionToAccess(Convert.ToInt32(clsUser.enPermission.Transaction)))
            {
                ShowAccessDeniedScreen();
                return;
            }

            
          
            HideAllScreens();
            plDashBoard.Visible = true;
            plUsers.Visible = true;
            plClients.Visible = true;
            plTransaction.Visible = true;
            plClientsScreen.Visible = true;
            plTransactionScreen.Visible = true;
            plLoginLogScreen.Visible = false;
            plAccessDenied.Visible = false;
            
           
            ClearTransactionScreen();
        }
        private void DownloadLoginLog()
        {
            string[] list = File.ReadAllLines(@"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\BankSystem\BankSystem\LoginLog.txt");
            string[] Line;

            lvLoginLog.Items.Clear();

            for (int i = 0; i < list.Length; i++)
            {
                Line = list[i].Split('|');

                lvLoginLog.Items.Add(Line[0]);
                lvLoginLog.Items[i].SubItems.Add(Line[1]);

            }
        }
        private void btnLoginLog_Click(object sender, EventArgs e)
        {
            ReturnButtonsToNormal();
            ChangeColorOnClick((Guna2Button)sender);


            if (_UserOrClient == enUserOrClient.client)
            {
                ShowAccessDeniedScreen();
                return;
            }


            if (!NowUser.isPermissionToAccess(Convert.ToInt32(clsUser.enPermission.LoginLog)))
            {
                ShowAccessDeniedScreen();
                return;
            }

          
            HideAllScreens();
            plDashBoard.Visible = true;
            plUsers.Visible = true;
            plClients.Visible = true;
            plClientsScreen.Visible = true;
            plTransaction.Visible = true;
            plTransactionScreen.Visible=true;
            plLoginLog.Visible = true;
            plLoginLogScreen.Visible = true;
            
          
            DownloadLoginLog();



        }
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (ValidateTextBox(tbID) || ValidateTextBox(tbFirstName) || ValidateTextBox(tbLastName) || ValidateTextBox(tbAddress) || ValidateTextBox(tbFatherName) || ValidateTextBox(tbMotherName))
            {
                MessageBox.Show("Fill The Form ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                

            User.Id = tbID.Text;
            User.FirstName = tbFirstName.Text;
            User.LastName = tbLastName.Text;
            User.Address = tbAddress.Text;
            User.Phone = tbPhone.Text;
            User.Email = tbEamil.Text;
            User.FatheName = tbFatherName.Text;
            User.MotherName = tbMotherName.Text;
            User.DateOfBirth = TimePickerDateOfBirth.Value;

            plAddUserSecondInfo.Visible = true;
            plUpdateUser.Visible = false;
            plUpdateUserSecond.Visible = false;
        }
        private void pbEye_Click(object sender, EventArgs e)
        {
            if (pbEye.Tag.ToString() == "see")
            {
                pbEye.Image = Resources.icons8_invisible_96px;
                pbEye.Tag = "vis";
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                pbEye.Image = Resources.icons8_eye_96px;
                pbEye.Tag = "see";
                tbPassword.PasswordChar = '*';
            }
        }
        private void rbAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllPermissions.Checked)
            {
                cbCliets.Checked = true;
                cbDashboard.Checked = true;
                cbUsers.Checked = true;
                cbTransaction.Checked = true;
                cbLoginLog.Checked = true;
            }

        }
        private void cbDashboard_Click(object sender, EventArgs e)
        {
            if (cbDashboard.Checked && cbCliets.Checked && cbUsers.Checked && cbTransaction.Checked && cbLoginLog.Checked)
            {
                rbAllPermissions.Checked = true;
            }
            else
            {
                rbAllPermissions.Checked = false;
            }
        }     
        private int GetPermission()
        {
            if(rbAllPermissions.Checked)
            {
                return -1;
            }

            int Permession = 0;
            if(cbDashboard.Checked)
            {
                Permession += 1;
            }

            if (cbUsers.Checked)
            {
                Permession += 2;
            }

            if (cbCliets.Checked)
            {
                Permession += 4;
            }

            if (cbTransaction.Checked)
            {
                Permession += 8;
            }

            if (cbLoginLog.Checked)
            {
                Permession += 16;
            }

            return Permession;
        }
        private int GetUpdatePermission()
        {
            if (rbAllPermissinoUpdate.Checked)
            {
                return -1;
            }

            int Permession = 0;
            if (cbDashboardUpdate.Checked)
            {
                Permession += 1;
            }

            if (cbUsersUpdate.Checked)
            {
                Permession += 2;
            }

            if (cbClientsUpdate.Checked)
            {
                Permession += 4;
            }

            if (cbTransactionUpdate.Checked)
            {
                Permession += 8;
            }

            if (cbLoginLogUpdate.Checked)
            {
                Permession += 16;
            }

            return Permession;
        }    
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbUserName.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {

                MessageBox.Show("You Should Enter Username & password ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User.UserName = tbUserName.Text;
            User.Password = tbPassword.Text;

            User.Permissions = GetPermission();

            if(User.Permissions == 0)
            {
                MessageBox.Show("You Should Give The User Permission ...!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(User.AddNewUser())
            {
                MessageBox.Show("User Added Succesfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenUserScreen();
                ClearAddUserForm();
                return;
            }
        }    
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            plAddUserSecondInfo.Visible = true;
            plUpdateUser.Visible = true;
            plUpdateUserSecond.Visible = false;

            ClearUpdateScreen();
            ClearChangesOnUserBar();
            ChangeButtonStyleUserBar((Guna2Button)sender);
        }
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            OpenUserScreen();
            ClearChangesOnUserBar();
            ChangeButtonStyleUserBar((Guna2Button)sender);
        }
        private void btnNextUpdate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbUserNameForUpdate.Text) || User.FindWithoutPassword(tbUserNameForUpdate.Text) == null)
            {
                MessageBox.Show("Enter a valied Username ..!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            User = new clsUser();
           
            User = User.FindWithoutPassword(tbUserNameForUpdate.Text);
            tbUserNameForUpdate.Enabled = false;
            plUpdateUserSecond.Visible = true;
            plDeleteUser.Visible = false;
            tbIdUpdateUser.Text = User.Id;
            tbIdUpdateUser.Enabled = false;



            tbFirstNameUpdate.Text = User.FirstName;
            tbLastNameUpdate.Text = User.LastName;
            tbAddressUpdate.Text = User.Address;
            tbPhoneUpdate.Text = User.Phone;
            tbEmailUpdate.Text = User.Email;
            tbFatherNameUpdate.Text = User.FatheName;
            tbMotherNameUpdate.Text = User.MotherName;
            timePikerUpdate.Value = User.DateOfBirth;
            
        }
        private void rbAllPermissinoUpdate_CheckedChanged(object sender, EventArgs e)
        {

            if (rbAllPermissinoUpdate.Checked)
            {
                cbClientsUpdate.Checked = true;
                cbDashboardUpdate.Checked = true;
                cbLoginLogUpdate.Checked = true;
                cbTransactionUpdate.Checked = true;
                cbUsersUpdate.Checked = true;
            }
        }
        private void cbDashboardUpdate_Click(object sender, EventArgs e)
        {

            if (cbDashboardUpdate.Checked && cbClientsUpdate.Checked && cbUsersUpdate.Checked && cbTransactionUpdate.Checked && cbLoginLogUpdate.Checked)
            {
                rbAllPermissinoUpdate.Checked = true;
            }
            else
            {
                rbAllPermissinoUpdate.Checked = false;
            }
        }
        private void ClearUpdateScreen()
        {
            tbUserNameForUpdate.Enabled = true;
            tbUserNameForUpdate.Clear();
            tbFirstNameUpdate.Clear();
            tbLastNameUpdate.Clear();
             tbAddressUpdate.Clear();
            tbPhoneUpdate.Clear();
            tbEmailUpdate.Clear();
            tbFatherNameUpdate.Clear();
            tbMotherNameUpdate.Clear();

            cbClientsUpdate.Checked = false;
            cbUsersUpdate.Checked = false;
            cbDashboardUpdate.Checked = false;
            cbTransactionUpdate.Checked = false;
            cbLoginLogUpdate.Checked = false;
            
        }
        private void btnSaveChangesUpdate_Click(object sender, EventArgs e)
        {
            

            if (ValidateTextBox(tbFirstNameUpdate) || ValidateTextBox(tbLastNameUpdate) || ValidateTextBox(tbAddressUpdate) || ValidateTextBox(tbEmailUpdate) || ValidateTextBox(tbFatherNameUpdate) || ValidateTextBox(tbMotherNameUpdate))
            {
                MessageBox.Show("You Should Fill The Form ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User.FirstName = tbFirstNameUpdate.Text;
            User.LastName = tbLastNameUpdate.Text;
            User.Address = tbAddressUpdate.Text;
            User.Phone = tbPhoneUpdate.Text;
            User.Email = tbEmailUpdate.Text;
            User.FatheName = tbFatherNameUpdate.Text;
            User.MotherName = tbMotherNameUpdate.Text;
            User.DateOfBirth = timePikerUpdate.Value;
            User.Permissions = GetUpdatePermission();

            if (User.Permissions == 0)
            {
                MessageBox.Show("You Should Give The User Permission ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ( User.Update(User))
            {
                MessageBox.Show("User Updated Successfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenUserScreen();
                ClearUpdateScreen();
                Refresh();
            }
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace( tbUserNameDelete.Text) || User.FindWithoutPassword(tbUserNameDelete.Text) == null)
            {
                MessageBox.Show("You Should Enter A Valied User Name ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are You Sure You Want To Delete " + User.FindWithoutPassword(tbUserNameDelete.Text).FirstName + "....? ", "Qustion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                User = User.FindWithoutPassword(tbUserNameDelete.Text);
                User.MarkForDelete = true;
                User.Delete();
                MessageBox.Show("User Deleted Successfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenUserScreen();
                tbUserNameDelete.Clear();
                return;
            }
            else
                return;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            plAddUserSecondInfo.Visible = true;
            plUpdateUser.Visible = true;
            plUpdateUserSecond.Visible = true;
            plDeleteUser.Visible = true;
            plUsersList.Visible = false;
            ClearChangesOnUserBar();
            ChangeButtonStyleUserBar((Guna2Button)sender);
        }       
        private void NormalUserBarButton(Guna2Button btn)
        {
            btn.BorderThickness = 0;
        }
        private void ChangeButtonStyleUserBar(Guna2Button btn)
        {
            btn.BorderThickness = 3;
            
        }
        private void ClearChangesOnUserBar()
        {
            NormalUserBarButton(btnAddNewUser);
            NormalUserBarButton(btnUpdate);
            NormalUserBarButton(btnDelete);
            
            NormalUserBarButton(btnUsersList);
        }
        private void ClearChangesOnClientBar()
        {
            NormalUserBarButton(btnAddClient);
            NormalUserBarButton(btnUpdateClient);
            NormalUserBarButton(btnDeleteClient);
            NormalUserBarButton(btnSearch);
            NormalUserBarButton(btnClientsList);
        }
        private void btnUsersList_Click(object sender, EventArgs e)
        {
            AddUsersToUsersList();
            plAddUserSecondInfo.Visible = true;
            plUpdateUser.Visible = true;
            plUpdateUserSecond.Visible = true;
            plDeleteUser.Visible = true;
            plUsersList.Visible = true;
            ClearChangesOnUserBar();
            ChangeButtonStyleUserBar((Guna2Button)sender);
        }
        public void AddUsersToUsersList()
        {
           lvUsers.Items.Clear();
            List<clsUser> users = User.GetUsersList();
            
            
            for (int i=0;i<users.Count;i++)
            {
                
                ListViewItem item = new ListViewItem(users[i].Id);
                lvUsers.Items.Add(item);
                lvUsers.Items[i].SubItems.Add(users[i].UserName);
                lvUsers.Items[i].SubItems.Add(users[i].FirstName + " " + users[i].LastName);
                lvUsers.Items[i].SubItems.Add(users[i].FatheName);
                lvUsers.Items[i].SubItems.Add(users[i].MotherName);
                lvUsers.Items[i].SubItems.Add(users[i].Address);
                lvUsers.Items[i].SubItems.Add(users[i].Phone);
                lvUsers.Items[i].SubItems.Add(users[i].Email);
                lvUsers.Items[i].SubItems.Add(users[i].DateOfBirth.ToShortDateString());
                lvUsers.Items[i].SubItems.Add(users[i].Permissions.ToString());
                
            }
            
           
        }     
        private void btnNextAddClient_Click(object sender, EventArgs e)
        {
            if(clsPerson.IsIdExist(tbIdClient.Text))
            {
                MessageBox.Show("Id is alredy exist try another one ....!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(ValidateTextBox(tbIdClient) || ValidateTextBox(tbFNameClient)|| ValidateTextBox(tbLNameClient)||ValidateTextBox(tbFatherClient)|| ValidateTextBox(tbMotherClient))
            {
                MessageBox.Show("You Should Fill The Form ....!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Client.Id= tbIdClient.Text;
            Client.FirstName = tbFNameClient.Text ;
            Client.LastName = tbLNameClient.Text;
            Client.Email = tbEmailClient.Text ;
            Client.Phone = tbPhoneClient.Text;
            Client.Address = tbAddressClient.Text;
            Client.FatheName = tbFatherClient.Text;
            Client.MotherName = tbMotherClient.Text;
            Client.DateOfBirth = DTdateOfBirthClient.Value;



            plAddClient2.Visible = true;

        }      
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClearChangesOnClientBar();
            ChangeButtonStyleUserBar((Guna2Button)sender);
            plAddClient1.Visible = true;
            plAddClient2.Visible = false;
            plUpdateClient1.Visible = false;
            plUpdateClient2.Visible = false;
        }
        private void btnAddClientFinal_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbAccountNumber.Text) || string.IsNullOrWhiteSpace(tbPinCode.Text))
            {
                MessageBox.Show("You Should Enter Acc.Number & Password ...!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            Client.PinCode = tbPinCode.Text;
            Client.AccountNumber = tbAccountNumber.Text;

            if (Client.IsClientExist(Client.AccountNumber))
            {
                MessageBox.Show("Account Number Is Alrady Exist Try Another One ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            Client.AccountBalance = Convert.ToSingle(tbBalance.Value);


            if(Client.Add())
            {
                MessageBox.Show("Client Added Successfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }else
            {
                MessageBox.Show("Something Wronf ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            OpenClientScreen();
            
        }
        private void btnNextUpdateClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAccountNumberUpdateClient.Text) || string.IsNullOrWhiteSpace(tbPinCodeUpdateClient.Text))
            {
                MessageBox.Show("You Should Enter Acc.Number & Password ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client.PinCode = tbPinCodeUpdateClient.Text;
            Client.AccountNumber = tbAccountNumberUpdateClient.Text;

            if (!Client.IsClientExist(Client.AccountNumber))
            {
                MessageBox.Show("Account Number Is Not Exist Try Another One ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Client.Find(Client.AccountNumber, Client.PinCode) == null)
            {
                MessageBox.Show("Account Number Or Password Uncorrect ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client = Client.Find(Client.AccountNumber, Client.PinCode);

            tbIDUpdateClient.Text = Client.Id;
            tbIDUpdateClient.Enabled = false;

            tbFnameUpdateClient.Text = Client.FirstName;
            tbLNameUpdateClient.Text = Client.LastName;
            tbAddresseUpdateClient.Text = Client.Address;
            tbEmailUpdateClient.Text = Client.Email;
            tbFatherNameUpdateClient.Text = Client.FatheName;
            tbMotherNameUpdateClient.Text = Client.MotherName;

            tbBalanceUpdateClient.Value = Convert.ToDecimal(Client.AccountBalance);



            plUpdateClient2.Visible = true;
            plDeleteClient.Visible = false;

        }
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            ClearChangesOnClientBar();
            ChangeButtonStyleUserBar((Guna2Button)sender);
            OpenClientScreen();
        
            plAddClient2.Visible = true;
            plUpdateClient1.Visible = true;
            plUpdateClient2.Visible = false;


            


        }
        private void btnFinalyUpdateClient_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("Are You Sure You Want To Update Client Information ...? ", "Qustion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                OpenClientScreen();
            }
            clsClients newClient = new clsClients();
            newClient.AccountNumber = Client.AccountNumber;
            newClient.PinCode = Client.PinCode;
            newClient.FirstName = tbFnameUpdateClient.Text;
            newClient.LastName = tbLNameUpdateClient.Text;
            newClient.Address = tbAddresseUpdateClient.Text;
            newClient.Email = tbEmailUpdateClient.Text;
            newClient.Phone = tbPhoneUpdateClient.Text;
            newClient.FatheName = tbFatherNameUpdateClient.Text;
            newClient.MotherName = tbMotherNameUpdateClient.Text;
            newClient.DateOfBirth = DOBUpdateClient.Value;
            newClient.AccountBalance = Convert.ToSingle(tbBalanceUpdateClient.Value);


            Client.Update(newClient);


            MessageBox.Show("Client Updated Successfully ...! ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenClientScreen();
          

        }
        private void btnDeleteClientFinaly_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAccountNumberDeleteClient.Text))
            {

                MessageBox.Show("You Should Enter Account Number ...! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Client.FindWithoutPinCode(tbAccountNumberDeleteClient.Text) == null)
            {
                MessageBox.Show("Client is Not Exist Try Another One ...! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client = Client.FindWithoutPinCode(tbAccountNumberDeleteClient.Text);

            if (MessageBox.Show("Are You Sure You Want To Delete " + Client.AccountNumber + " ...! ", "Qustino", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                OpenClientScreen();
                return;
            }

            Client.Delete();

            MessageBox.Show("Client Deleted Succussfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenClientScreen();

        }
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            ClearChangesOnClientBar();
            ChangeButtonStyleUserBar((Guna2Button)sender);
            OpenClientScreen();
            plAddClient2.Visible = true;
            plUpdateClient1.Visible = true;
            plUpdateClient2.Visible = true;
            plDeleteClient.Visible = true;
        }
        private void btnSearchAccountNumber_Click(object sender, EventArgs e)
        {


            if(string.IsNullOrWhiteSpace(tbAccountNumberSearchClient.Text))
            {
                MessageBox.Show("You should enter a value for search ...!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(Client.IsClientExist(tbAccountNumberSearchClient.Text) == false)
            {

                MessageBox.Show("Account Number is not exists try another one ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lvSearchClient.Items.Clear();
           

            Client = Client.FindWithoutPinCode(tbAccountNumberSearchClient.Text);

            lvSearchClient.Items.Add(Client.AccountNumber);
            lvSearchClient.Items[0].SubItems.Add(Client.AccountBalance.ToString());
            lvSearchClient.Items[0].SubItems.Add(Client.FirstName + " " + Client.LastName);
            lvSearchClient.Items[0].SubItems.Add(Client.Id);
            lvSearchClient.Items[0].SubItems.Add(Client.Address);
            lvSearchClient.Items[0].SubItems.Add(Client.Phone);
            lvSearchClient.Items[0].SubItems.Add(Client.Email);
            lvSearchClient.Items[0].SubItems.Add(Client.FatheName);
            lvSearchClient.Items[0].SubItems.Add(Client.MotherName);
            lvSearchClient.Items[0].SubItems.Add(Client.DateOfBirth.ToShortDateString());
            



        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearChangesOnClientBar();
            ChangeButtonStyleUserBar((Guna2Button)sender);
            OpenClientScreen();
            plAddClient2.Visible = true;
            plUpdateClient1.Visible = true;
            plUpdateClient2.Visible = true;
            plDeleteClient.Visible = true;
            plSearchClient.Visible = true;
            plClientsList.Visible = false;
        }
        private void btnClientsList_Click(object sender, EventArgs e)
        {
            ClearChangesOnClientBar();
            ChangeButtonStyleUserBar((Guna2Button)sender);
            OpenClientScreen();
            plAddClient2.Visible = true;
            plUpdateClient1.Visible = true;
            plUpdateClient2.Visible = true;
            plDeleteClient.Visible = true;
            plSearchClient.Visible = true;
            plClientsList.Visible = true;


            List<clsClients> listClients = Client.ReadClientsFromFile();

            lbClientsCount.Text = listClients.Count.ToString();

            lvClientsList.Items.Clear();

            for(int i=0; i<listClients.Count; i++)
            {
                lvClientsList.Items.Add(listClients[i].AccountNumber);
                lvClientsList.Items[i].SubItems.Add(listClients[i].AccountBalance.ToString());
                lvClientsList.Items[i].SubItems.Add(listClients[i].FirstName + " " + listClients[i].LastName);
                lvClientsList.Items[i].SubItems.Add(listClients[i].Id);
                lvClientsList.Items[i].SubItems.Add(listClients[i].Address);
                lvClientsList.Items[i].SubItems.Add(listClients[i].Phone);
                lvClientsList.Items[i].SubItems.Add(listClients[i].Email);
                lvClientsList.Items[i].SubItems.Add(listClients[i].FatheName);
                lvClientsList.Items[i].SubItems.Add(listClients[i].MotherName);
                lvClientsList.Items[i].SubItems.Add(listClients[i].DateOfBirth.ToShortDateString());
            }



        }
        private void btnFinalyDeposit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbAccountNumberDeposit.Text))
            {
                MessageBox.Show("You Should Enter Account Number ...!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (!Client.IsClientExist(tbAccountNumberDeposit.Text))
            {
                MessageBox.Show("Client Is Not Exists Try Another One ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            Client = Client.FindWithoutPinCode(tbAccountNumberDeposit.Text);

            Client.Deposit(Convert.ToSingle(tbAmountTransaction.Text));

            MessageBox.Show("Deposit Done Saccussfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTransactionScreen();

        }
        private void ClearTransactionScreen()
        {
            plDeposit.Visible = true;
            plWithDraw.Visible = false;
            plTotalBalances.Visible = false;
            tbAccountNumberDeposit.Clear();
            tbAmountTransaction.Value = 0;
            tbAccountNumberWithdraw.Clear();
            tbAmountWithdraw.Value = 0;
            btnTotalBalances.BorderThickness = 0;
            btnWithdraw.BorderThickness = 0;
            btnDeposit.BorderThickness = 2;
        }
        private void pbDeposit_Click(object sender, EventArgs e)
        {
            ClearTransactionScreen();
           
            plWithDraw.Visible = false;
            plDeposit.Visible = true;
        }
        private void pbWithdraw_Click(object sender, EventArgs e)
        {
            ClearTransactionScreen();
            btnTotalBalances.BorderThickness = 0;
            btnDeposit.BorderThickness = 0;
            btnWithdraw.BorderThickness = 2;
            plDeposit.Visible = true;
            plWithDraw.Visible = true;
           
        }
        private void btnFinalyWithdraw_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbAccountNumberWithdraw.Text))
            {
                MessageBox.Show("You Should Enter Account Number ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Client.IsClientExist(tbAccountNumberWithdraw.Text))
            {
                MessageBox.Show("Client Is Not Exists Try Another One ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Client = Client.FindWithoutPinCode(tbAccountNumberWithdraw.Text);

            if(Client.Withdraw(Convert.ToSingle(tbAmountWithdraw.Text)) == false)
            {
                MessageBox.Show("Amount Is More Than " + Client.AccountNumber+" Balance His Balance Is "+Client.AccountBalance.ToString()+"  ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Withdraw Done Saccussfully ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTransactionScreen();

        }
        private void btnTotalBalances_Click(object sender, EventArgs e)
        {

            ClearTransactionScreen();
            btnTotalBalances.BorderThickness = 2;
            btnDeposit.BorderThickness = 0;
            btnWithdraw.BorderThickness = 0;
            plDeposit.Visible = true;
            plWithDraw.Visible = true;
            plTotalBalances.Visible = true;



            float TotalBalances = 0;

            List<clsClients> Clients = Client.ReadClientsFromFile();

            foreach(clsClients client in Clients)
            {
                TotalBalances += client.AccountBalance;
            }

            lbTotalBalancesAmount.Text = TotalBalances.ToString() + " $";

            if (Clients.Count > 1)
                lbClientsCountTotalBalances.Text = Clients.Count.ToString() + " Clients";
            else
                lbClientsCountTotalBalances.Text = Clients.Count.ToString() + " Client";


            lvTotalBalancesTransaction.Items.Clear();

            for(int i=0;i<Clients.Count;i++)
            {
                lvTotalBalancesTransaction.Items.Add(Clients[i].AccountNumber.ToString());
                lvTotalBalancesTransaction.Items[i].SubItems.Add(Clients[i].AccountBalance.ToString());
            }

        }
        private void pbNowUser_Click(object sender, EventArgs e)
        {
            Form frm= new frmNowUser(NowUser.UserName);
            frm.Show();
        }
        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = new frmLogin();
            frm.Show();

        }
        private void btnUpdatePinCodeDashboard_Click(object sender, EventArgs e)
        {
            tbPinCodeDashboard.Enabled = true;
            tbPinCodeDashboard.Focus();
            btnSaveChangePinCodeDashboard.Visible = true;
        }
        private void btnSaveChangePinCodeDashboard_Click(object sender, EventArgs e)
        {
            tbPinCodeDashboard.Enabled = false;
           
            btnSaveChangePinCodeDashboard.Visible = false;

            clsClients NewClient = NowClient;
            NewClient.PinCode = tbPinCodeDashboard.Text;
            NowClient.Update(NewClient);

            NowClient = NowClient.FindWithoutPinCode(NewClient.AccountNumber);

            GenerateDashboard();


        }
        private void btnSendMoney_Click(object sender, EventArgs e)
        {
            if (cbAccountNumberDashboard.SelectedItem == null)
            {
                MessageBox.Show("You Can't Send Money For No One, Select Account Number For Send To Him ...!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
           

            
            if(NowClient.AccountBalance > Convert.ToSingle( tbAmountDashboard.Value) )
            {


                Client = Client.FindWithoutPinCode(cbAccountNumberDashboard.SelectedItem.ToString());
                Client.Deposit(Convert.ToSingle(tbAmountDashboard.Value));
                NowClient.Withdraw(Convert.ToSingle(tbAmountDashboard.Value));
               
                lbClientBalanceDashboard.Text = NowClient.AccountBalance.ToString();

                NowClient.SaveTransactionInfo(NowClient.AccountNumber, Client.AccountNumber, Convert.ToSingle(tbAmountDashboard.Value));

                MessageBox.Show("Send Money Done ...!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenerateDashboard();


            }
            else
            {
                MessageBox.Show("You Can't Send Money More Than You Have, Enter Less Amount ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAmountDashboard.Value = 0;
                return;
            }
        }


    }
}
