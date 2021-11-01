using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W3SHARE_Interface.Models;
using W3SHARE_Interface.Repo;

namespace W3SHARE_Interface.Pages.Authentication
{
    public partial class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }


        private void LoginBTN()
        {
            UsersRepo usersRepo = new UsersRepo();
            UsersDTO usersDTO = usersRepo.ReturnUser(Email, Password);


            if (usersDTO == null)
            {
                //email and password incorect
            }
            else
            {
                //Ingelog 
                //Store usersDTO as logged in user
                //redirect 1. stuur param na nuwe page 2. Cookies
            }
        }
        
    }
}
