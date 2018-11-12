using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForLoginsDto
    {
        public string username { get; set; }

        public string password { get; set; }
    }
}