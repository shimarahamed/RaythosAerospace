using Microsoft.AspNetCore.Identity;

namespace RaythosAerospace.Models
{
    public class AppUser : IdentityUser
    {

   
        public string Name { get; set; }

        public AppUser() {
        
        }


    }
}
