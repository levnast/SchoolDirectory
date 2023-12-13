using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class AuthorizationClass : User
    {
       public void Registration(Dictionary <string,string> DataBase, string login,  string password)
        {
            if (!DataBase.ContainsKey(login))
            {
                DataBase.Add(login, password);
            }
        }
        public bool Confirmation(Dictionary<string, string> DataBase, string login, string password) 
        {
            if (DataBase[login] == password)
            {
                return true;
            }
            else 
                return false;
        }
    }
}
