using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;

namespace BankSystem
{
   
    internal class clsUser : clsPerson
    {
         public string UserFilePath = @"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\BankSystem\BankSystem\Users.txt";
        private string LoginLogFilePath = @"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\BankSystem\BankSystem\LoginLog.txt";


        private string _UserName;
        private string _Password;

        private int _Permissions;

        private bool _MarkForDelete ;
        public string UserName { get { return _UserName;} set { _UserName = value; } }
        public string Password { get { return _Password;}
            set
            {
                _Password = value;
            }
        }
        public int Permissions
        { get { return _Permissions; }
            set
            {
                _Permissions = value;
            }
        }
        public bool MarkForDelete
        {
            get { return _MarkForDelete; }
            set { _MarkForDelete = value; }
        }

        public enum enPermission { All=-1 ,Dashboard=1,Users=2,Clients=4,Transaction=8,LoginLog=16}
        
        public clsUser()
        {

        }

        public clsUser(string id, string firstName, string lastName,
            string address, string phone, string email, string MohterName,
            string FatherName, DateTime DataOfBirth,string userName,string Passowrd,
            int permissions,bool MarkforDelete)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.FatheName= FatherName;
            this.MotherName = MohterName;
            this.DateOfBirth= DataOfBirth;
            this.UserName = userName;
            this.Password = Passowrd;
            this.Permissions = permissions;
            this.MarkForDelete= MarkforDelete;

        }

      
        public List<clsUser> GetUsersList()
        {
            var list = new List<clsUser>();

            string[] UserLines = File.ReadAllLines(UserFilePath);

            foreach(string Line in UserLines)
            {
                list.Add(_StaticConvertFromLineToUser(Line));
            }

            return list;
        }
        public clsUser Find(string userName,string password)
        {
            string[] UsersLine = File.ReadAllLines(UserFilePath);

            clsUser User;
            foreach(string UserLine in UsersLine)
            {
                User = _ConvertFromLineToUser(UserLine);

                if ( User.UserName.ToLower() == userName.ToLower() && User.Password.ToLower() == password.ToLower())
                {
                   
                    return User;
                }
            }

            return null;


        }      
        public clsUser FindWithoutPassword(string userName)
        {
            string[] UsersLine = File.ReadAllLines(UserFilePath);

            clsUser User;
            foreach (string UserLine in UsersLine)
            {
                User = _ConvertFromLineToUser(UserLine);

                if (User.UserName.ToLower() == userName.ToLower())
                {
                    return User;
                }
            }

            return null;


        }
        private string _ConverFromUserToLine(clsUser User,char Seperator='|')
        {
            string Line = "";

            Line = this.Id + Seperator + this.FirstName + Seperator + this.LastName + Seperator;
            Line +=  this.Address + Seperator + this.Phone + Seperator + this.Email + Seperator;
            Line += this.MotherName + Seperator + this.FatheName + Seperator + this.DateOfBirth.ToString() + Seperator;
            Line += this.UserName + Seperator + this.Password + Seperator + this.Permissions.ToString() + Seperator;
            Line += this.MarkForDelete;

            return Line;
        }
        private clsUser _ConvertFromLineToUser(string Line,char Seperator = '|')
        {
            string [] User = Line.Split(Seperator);

            return new clsUser(id: User[0], firstName: User[1], lastName: User[2], address: User[3], phone: User[4],
                email: User[5], MohterName: User[6],FatherName: User[7],DataOfBirth:Convert.ToDateTime(User[8]),userName: User[9],Passowrd: User[10],permissions:Convert.ToInt32(User[11]), MarkforDelete:Convert.ToBoolean(User[12])) ;


        }

        static private clsUser _StaticConvertFromLineToUser(string Line, char Seperator = '|')
        {
            string[] User = Line.Split(Seperator);

            return new clsUser(id: User[0], firstName: User[1], lastName: User[2], address: User[3], phone: User[4],
                email: User[5], MohterName: User[6], FatherName: User[7], DataOfBirth: Convert.ToDateTime(User[8]), userName: User[9], Passowrd: User[10], permissions: Convert.ToInt32(User[11]), MarkforDelete: Convert.ToBoolean(User[12]));


        }
        private bool isUserExist(string UserName)
        {
            string[] UsersLine = File.ReadAllLines(UserFilePath);

            foreach(string line in UsersLine)
            {
                if(_ConvertFromLineToUser(line).UserName == UserName)
                { return true; }
            }


            return false;

        }
        private void AddLineOnFile(string Line)
        {
            File.AppendAllText(UserFilePath, (Line+"\n"));
            
        }
        private void _AddNewFile(string [] UserLines)
        {
            File.Delete(UserFilePath);
            foreach(string line in UserLines)
            {
                if(line != null)
                {
                    File.AppendAllText(UserFilePath, (line + "\n"));
                }
            }
           
        }
        public bool AddNewUser()
        {
            
            if(isUserExist(this.UserName))
            {
                return false;
            }

            string Line = _ConverFromUserToLine(this);

            AddLineOnFile(Line);

            return true;
        }
        public bool Update(clsUser NewUser)
        {
            string[] UsersLine = File.ReadAllLines(UserFilePath);
            string[] NewUsers= new string[UsersLine.Length];

            clsUser User;

            for(int i=0;i<UsersLine.Length;i++)
            {
                User = _ConvertFromLineToUser(UsersLine[i]);                  

                if (User.UserName.ToLower() == NewUser.UserName.ToLower())
                {
                    NewUsers[i] = _ConverFromUserToLine(NewUser);
                    continue;
                }
                NewUsers[i] = UsersLine[i];
            }

            _AddNewFile(NewUsers);
            return true;
        }   
        public void Delete()
        {
            this.MarkForDelete = true;
           
            this.Update(this);

            string[] UsersLine = File.ReadAllLines(UserFilePath);
            string[] NewUserline = new string[UsersLine.Length];

            for(int i=0;i<UsersLine.Length;i++)
            {
                if (_ConvertFromLineToUser(UsersLine[i]).MarkForDelete == true)
                {
                    continue;
                }

                NewUserline[i] = UsersLine[i];
            }
            _AddNewFile(NewUserline);


            this.Id =       null;
            this.FirstName =null;
            this.LastName = null;
            this.Address =  null;
            this.Phone =    null;
            this.Email =    null;
            this.FatheName =null;
            this.MotherName =null;
            this.DateOfBirth = DateTime.Now;
            this.UserName = null   ;
            this.Password = null   ;
            this.Permissions= 0 ;
            this.MarkForDelete =false ;

            
        }
        public void RegisterLogin()
        {
            string Line =this.UserName+"|" + DateTime.Now.ToLocalTime().ToString();

            File.AppendAllText(LoginLogFilePath, (Line + "\n"));
        }

        public bool isPermissionToAccess(int permissionYouWant)
        {
            if (this.Permissions == -1)
                return true;

            if((permissionYouWant & this.Permissions) == permissionYouWant)
            {
                return true;
            }else
            { return false; }

        }

    }
}
