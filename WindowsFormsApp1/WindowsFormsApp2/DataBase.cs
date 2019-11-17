using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    static class DataBase
    {
      
            public static ArrayList list;

            static DataBase()
            {
                list = new ArrayList();
            }
            static public void addUser(User user)
            {
                list.Add(user);
            }

            static public bool checkUser(string login , string password)
        {
            foreach (User item in list)
            {
                if(item.login == login && item.password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
