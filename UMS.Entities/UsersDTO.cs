using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.Entities
{
    public class UsersDTO
    {
        public int UserID { get; set; }
        public String Login { get; set; }

        public String Name { get; set; }

        public String Password { get; set; }

        public String Email { get; set; }

        public String Gender { get; set; }

        public String Address { get; set; }

        public int Age { get; set; }

        public String Nic { get; set; }

        public DateTime Dob { get; set; }

        public Boolean IsCricket { get; set; }

        public Boolean Hockey { get; set; }

        public Boolean Chess { get; set; }

        public String ImageName { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}
