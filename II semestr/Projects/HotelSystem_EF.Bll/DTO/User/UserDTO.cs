using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HotelSystem_EF.Bll.DTO.User
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName {get; set; } = null!;
        public string Email {get; set; } = null!;
        public string Username {get; set; } = null!;
        public string Password {get; set; } = null!;
    }
}
