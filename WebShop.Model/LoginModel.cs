using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebShop.Model
{
    [Table("Login")]
    public class LoginModel
    {
        public LoginModel()
        {
            
        }
        [Required]
        [StringLength(320)]
        public string Email { get; set; }
        [Required]
        [StringLength(320)]
        public string Password { get; set; }
        //[Required(ErrorMessage = "Unesi email")]
        //[EmailAddress]
        //public string Email { get; set; }
        //[Required(ErrorMessage = "Unesi lozinku")]
        //[DataType(DataType.Password)]
        //[Display(Name = "Lozinka")]
        //public string Password { get; set; }
        //[Display(Name = "Zapamti me?")]
        //public bool RememberMe { get; set; }

        public LoginModel(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
            return this.Email + " " + this.Password;
        }
    }
}
