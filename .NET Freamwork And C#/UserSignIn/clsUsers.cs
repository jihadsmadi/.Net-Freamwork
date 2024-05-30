using System.IO;

namespace UserSignIn
{
    internal class clsUsers
    {
        private string FilePath = @"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\UserSignIn\Users.txt";


        private string _UserName;
        private string _Password;
        private string _Email;
        private string _PhoneNumber;
        private string _Gender;


        //Set & Get Members
        public void SetUserName(string username)
        {
            this._UserName = username;
        }
        public string UserName()
        {
            return this._UserName;
        }
        public void Password(string password)
        {
            this._Password = password;
        }
        public string Password()
        {
            return this._Password;
        }
        public void Email(string email)
        {
            this._Email = email;
        }
        public string Email()
        {
            return this._Email;
        }
        public void PhoneNumber(string phoneNumber)
        {
            this._PhoneNumber = phoneNumber;
        }
        public string PhoneNumber()
        {
            return this._PhoneNumber;
        }
        public void Gender(string gender)
        {
            this._Gender = gender;
        }
        public string Gender()
        {
            return this._Gender;
        }


        //Constractor


        public clsUsers()
        {

        }
        public clsUsers(string UserName, string Password, string gender, string Email = "", string PhoneNumber = "")
        {
            this._UserName = UserName;
            this._Password = Password;
            this._Email = Email;
            this._PhoneNumber = PhoneNumber;
            this._Gender = gender;
        }

        //

        public clsUsers _ConvertLineToUser(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
                return null;

            string[] lUser = line.Split('|');
            clsUsers user = new clsUsers(lUser[0], lUser[1], lUser[2], lUser[3], lUser[4]);
            return user;

        }

     
        public string _CovertUserToLine()
        {
            return (this.UserName() + "|" + this.Password() + "|" + this.Gender() + "|" + this.Email() + "|" + this.PhoneNumber());
            
        }
        public void _WriteLineOnFile(string Line, string path = @"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\UserSignIn\Users.txt")
        {

            File.AppendAllText(path, (Line+"\n"));
        }

        public void _WriteLinesOnNewFile(string []Lines, string path = @"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\UserSignIn\Users.txt")
        {

            File.WriteAllLines(path,Lines);
        }
        public string[] _ReadFileLines(string path = @"D:\Work Space\Programming\Programming Advice\.NET Freamwork And C#\UserSignIn\Users.txt")
        {

            if (File.Exists(FilePath))
            {
                string[] Lines = File.ReadAllLines(FilePath);
                return Lines;
            }
            else { return null; }
        }
        public clsUsers Find(string UserName, string password)
        {
            string[] Lines = _ReadFileLines();
            clsUsers User = new clsUsers();

            foreach (string Line in Lines)
            {
                User = _ConvertLineToUser(Line);

                if (User == null)
                    continue;

                if ( (User.UserName().ToLower() == UserName.ToLower() && User.Password().ToLower() == password.ToLower() ))
                {
                    return   User;
                }

            }

            return null;

        }
        public clsUsers FindWithoutPassword(string UserName)
        {
            string[] Lines = _ReadFileLines();
            clsUsers User = new clsUsers();

            foreach (string Line in Lines)
            {
                User = _ConvertLineToUser(Line);

                if (User == null)
                    continue;

                if (User.UserName().ToLower() == UserName.ToLower()) 
                {
                    return User;
                }

            }

            return null;

        }
        public void UpdatePassword(string UserName, string NewPassword)
        {
            string[] Lines = _ReadFileLines();
            string[] NewLines = new string[Lines.Length];
            clsUsers User = new clsUsers();

            for(int i=0;i<Lines.Length;i++)
            {
                User = _ConvertLineToUser(Lines[i]);

                if (User == null)
                    continue;

                if (User.UserName().ToLower() == UserName.ToLower() )
                {
                    User.Password(NewPassword);

                }
                NewLines[i] = User._CovertUserToLine() + "\n";

            }

            _WriteLinesOnNewFile(NewLines);

        }



    }
}
