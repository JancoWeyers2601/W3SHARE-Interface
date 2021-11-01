using W3SHARE_Interface.Models;
using W3SHARE_Interface.Repo;


namespace W3SHARE_Interface.Pages.Authentication
{
    public partial class Register
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        private void RegisterBTN()
        {
            //INSERT password valadation

            UsersDTO usersDTO = new UsersDTO();
            usersDTO.Name = this.Name;
            usersDTO.Surname = this.Surname;
            usersDTO.Email = this.Email;
            usersDTO.Password = this.Password;

            UsersRepo usersRepo = new UsersRepo();
            

            if (usersRepo.AddUser(usersDTO) == true)
            {
                // go to login
               
            }
            else
            {
                // user already exist
            }

            NavManager.NavigateTo("/Content");
        }  
    }

    
}
