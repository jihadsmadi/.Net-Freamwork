using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem
{
    internal class clsPerson
    {
        static string UserFilePath = @"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\BankSystem\BankSystem\Users.txt";

        private string _Id;
        private string _FirstName,_LastName,_Address,_Phone,_Email,_FatheName,_MotherName;
        private DateTime _DateOfBirth;

        public string Id
        { 
            get { return _Id; } 
            set { _Id = value; }
        }

        public string FirstName
        { 
            get { return _FirstName; } 
            set { _FirstName = value; } 
        }

        public string LastName
        { 
            get { return _LastName; }
            set
            {
                _LastName = value;
            } 
        }

        public string Address
        { get { return _Address; }
            set
            {
                _Address = value;
            } }

        public string Phone
        { get { return _Phone; }
            set
            {
                _Phone = value;
            }
        }

        public string Email
        { get { return _Email; }
            set
            {
                _Email = value;
            }
        }

        public string FatheName
        {
            get { return _FatheName; }
            set { _FatheName = value; }
        }

        public string MotherName
        {
            get { return _MotherName; }
            set { _MotherName= value; }
        }

        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }
        public clsPerson()
        {

        }
        public clsPerson(string id, string firstName, string lastName, string address, string phone, string email,string MohterName,string FatherName,DateTime DataOfBirth)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
            Email = email;
            MotherName= MohterName;
            FatheName= FatherName;
            DateOfBirth = DataOfBirth;
        }

        static private clsUser _ConvertFromLineToUser(string Line, char Seperator = '|')
        {
            string[] User = Line.Split(Seperator);

            return new clsUser(id: User[0], firstName: User[1], lastName: User[2], address: User[3], phone: User[4],
                email: User[5], MohterName: User[6], FatherName: User[7], DataOfBirth: Convert.ToDateTime(User[8]), userName: User[9], Passowrd: User[10], permissions: Convert.ToInt32(User[11]), MarkforDelete: Convert.ToBoolean(User[12]));


        }
        static public bool IsIdExist(string id)
        {
            string[] UsersLine = File.ReadAllLines(UserFilePath);

            clsUser User;
            foreach (string UserLine in UsersLine)
            {
                User = _ConvertFromLineToUser(UserLine);

                if (User.Id == id)
                {

                    return true;
                }
            }

            return false;
        }
    }
}
