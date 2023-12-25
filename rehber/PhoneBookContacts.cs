using System;

namespace PhoneBookApp
{

class PhoneBookContacts
    {
        private string userName;
        private string userLastName;
        private string userPhone;
        private int userId;

        
        
        public PhoneBookContacts(string username, string userlastname, string userphone, int userid)
        {
            this.userName = username;
            this.userLastName = userlastname;
            this.userPhone = userphone;
            this.userId = userid;
        }

        public string username
        {
            get {return this.userName;}
            set {this.userName = value;}
        }

        public string userlastname
        {
            get {return this.userLastName;}
            set {this.userLastName = value;}
        }

        public string userphone
        {
            get {return this.userPhone;}
            set {this.userPhone = value;}

        }

        public int userid
        {
            get {return this.userId;}
            set {this.userId = value;}
        }

        

        
    }
}
