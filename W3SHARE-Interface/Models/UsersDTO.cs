using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W3SHARE_Interface.Models
{
    public class UsersDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname{ get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
