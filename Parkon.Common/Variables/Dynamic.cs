using Prkn.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prkn.Common.Variables
{
    public class Dynamic
    {
        public static List<Users> AllUsers                          = new List<Users>();
        public static Users OnlineUser                              = new Users();
        public static User_Authorization OnlineUser_Authorization   = new User_Authorization();

        public static Image UserImage;
        public static Image UserImageBarItem;

    }
}
