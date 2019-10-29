using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class TUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<TRole> TRoles { get; set; }

    }
}
