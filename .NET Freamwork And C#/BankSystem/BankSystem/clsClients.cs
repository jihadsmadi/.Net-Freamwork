using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BankSystem
{
    internal class clsClients : clsPerson
    {
        private string ClientsFilePath = @"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\BankSystem\BankSystem\Clients.txt";
        private string TransactionFilePath = @"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\BankSystem\BankSystem\TransactionLog.txt";

        private string _AccountNumber;
        private string _PinCode;
        private float _AccountBalance;
        private bool _MarkForDelete = false;

        public string AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }
        }

        public string PinCode
        {
            get { return _PinCode; }
            set { _PinCode = value; }
        }

        public float AccountBalance
        {
            get { return _AccountBalance; }
            set { _AccountBalance = value; }
        }

        public bool MarkForDelete
        {
            get { return _MarkForDelete; }
            set
            {
                _MarkForDelete = value;
            }
        }

        public clsClients()
        {

        }

        public clsClients(string accountNumber, string pinCode, float accountBalance, bool markForDelete, string ID, string firstName, string lastName,
            string address, string phone, string email, string MohterName,
            string FatherName, DateTime DataOfBirth)
        {
            AccountNumber = accountNumber;
            PinCode = pinCode;
            AccountBalance = accountBalance;
            MarkForDelete = markForDelete;
            Id = ID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
            Email = email;
            MotherName = MohterName;
            FatheName = FatherName;
            DateOfBirth = DataOfBirth;

        }

        private string _ConvertClientToLine(clsClients client, char Seperator = '|')
        {
            string Line = "";
            Line = client.AccountNumber + Seperator + client.PinCode + Seperator;
            Line += client.FirstName + Seperator + client.LastName + Seperator;
            Line += client.Id + Seperator + client.AccountBalance + Seperator;
            Line += client.FatheName + Seperator + client.MotherName + Seperator;
            Line += client.Address + Seperator + client.Phone + Seperator;
            Line += client.Email + Seperator + client.DateOfBirth.ToShortDateString() + Seperator;
            Line += client.MarkForDelete.ToString();

            return Line;
        }

        private clsClients _ConvertLineToClient(string Line, char Seperator = '|')
        {
            string[] Lines = Line.Split(Seperator);
            clsClients client = new clsClients(accountNumber: Lines[0], pinCode: Lines[1], firstName: Lines[2],
                                               lastName: Lines[3], ID: Lines[4], accountBalance: Convert.ToSingle(Lines[5]), FatherName: Lines[6], MohterName: Lines[7],
                                               address: Lines[8], phone: Lines[9], email: Lines[10], DataOfBirth: Convert.ToDateTime(Lines[11]), markForDelete: Convert.ToBoolean(Lines[12]));

            return client;
        }

        private void _AddLineToFile(string Line)
        {
            File.AppendAllText(ClientsFilePath, (Line + "\n"));
        }

        public List<clsClients> ReadClientsFromFile()
        {
            string [] Lines = File.ReadAllLines(ClientsFilePath);
            List <clsClients> clients = new List<clsClients>();

            foreach (string Line in Lines)
            {
                clients.Add(_ConvertLineToClient(Line));
            }

            return clients;

        }
        public bool IsClientExist(string AccountNumber)
        {
            List <clsClients> clients = ReadClientsFromFile();

            foreach(clsClients client in clients)
            {
                if (client.AccountNumber.ToLower() == AccountNumber.ToLower())
                    return true;
            }

            return false;
        }

        public clsClients Find(string AccountNumber,string PinCode)
        {
            List<clsClients> clients = ReadClientsFromFile();

            foreach (clsClients client in clients)
            {
                if (client.AccountNumber.ToLower() == AccountNumber.ToLower() && client.PinCode.ToLower() == PinCode.ToLower())
                    return client;
            }
            return null;
        }

        public clsClients FindWithoutPinCode(string AccountNumber)
        {
            List<clsClients> clients = ReadClientsFromFile();

            foreach (clsClients C in clients)
            {
                if (C.AccountNumber.ToLower() == AccountNumber.ToLower())
                    return C;
            }
            return null;
        }

        public bool Add()
        {
            if(!IsClientExist(this.AccountNumber))
            {
                _AddLineToFile(_ConvertClientToLine(this));
                return true;
            }
            return false;
        }

        private void AddTextToFile(List<clsClients> clients)
        {
            File.Delete(ClientsFilePath);
            foreach (clsClients C in clients)
            {
                if (C != null)
                {
                    File.AppendAllText(ClientsFilePath, (_ConvertClientToLine(C)+ "\n"));
                }
            }
        }
        public void Update(clsClients NewClient)
        {
            List<clsClients> Clients = ReadClientsFromFile();

         for(int i=0;i<Clients.Count;i++)
            {
                if (Clients[i].AccountNumber.ToLower() == NewClient.AccountNumber.ToLower())
                {
                    Clients[i] = NewClient;
                    break;
                }
            }
            
         AddTextToFile(Clients);
         

        }

        public void Delete()
        {
            

            List<clsClients> clients = ReadClientsFromFile();
            File.Delete(ClientsFilePath);
            for(int i=0;i<clients.Count;i++)
            {
                if(this.AccountNumber.ToLower() == clients[i].AccountNumber.ToLower())
                {
                    continue;
                }
                else
                {
                    _AddLineToFile(_ConvertClientToLine(clients[i]));
                }
            }

        }

        public bool Deposit(float amount)
        {
            

           
            this.AccountBalance += amount;

            List <clsClients> Clients = ReadClientsFromFile();
            File.Delete(ClientsFilePath);

            for (int i=0;i<Clients.Count;i++)
            {
                if (Clients[i].AccountNumber.ToLower() == this.AccountNumber.ToLower())
                {
                    Clients[i].AccountBalance += amount;
                  
                }
                _AddLineToFile(_ConvertClientToLine(Clients[i]));
            }

           
            return true;
        }

        public bool Withdraw(float amount)
        {
            if(amount > this.AccountBalance)
                return false;

            this.Deposit((-1) * amount);
            return true;
        }

       public void SaveTransactionInfo(string ClientFrom,string ClientTo,float Amount)
       {
            string line = ClientFrom + '|' + ClientTo + '|' + Amount.ToString() + '|' + DateTime.Now.ToLocalTime().ToString();

            File.AppendAllText(TransactionFilePath, (line + "\n"));
        }


    }
}
