using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class SignUpModel
    {

        //overload 1
        public SignUpModel()
        {
            // Initialize default values for properties if necessary
        }


        //overload 2
        public SignUpModel(int id, string? fullname, string? email, string? password, DateTime regDate)
        {
            Id = id;
            Fullname = fullname;
            Email = email;
            Password = password;
            RegDate = regDate;
        }

        [Required]
        public int Id { get; set; }

        [Required]
        public string? Fullname { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }


        public DateTime RegDate { get; set; }


    }
}
