using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebShop.Model
{
    [Table("Users")]
    public class UserModel
    {
        public UserModel()
        {
            Orders = new HashSet<OrdersModel>();
        }

        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        [StringLength(40)]
        public string Address { get; set; }
        [Required]
        [StringLength(20)]
        public string Contact { get; set; }
        [Required]
        [StringLength(320)]
        public string Email { get; set; }

        [Required]
        [StringLength(320)]
        public string Password { get; set; }

        [Required]
        [StringLength(320)]
        public string ConfirmPassword { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<OrdersModel> Orders { get; set; }
        public bool IsAdmin { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key, Column(Order = 0)]
        //public int UserId { get; set; }
        //[Required(ErrorMessage = "Enter Name")]
        //[DataType(DataType.Text)]
        //[StringLength(20, ErrorMessage = "Maximum length should be 20")]
        //public string Name { get; set; }
        //[Required(ErrorMessage = "Enter LastName")]
        //[DataType(DataType.Text)]
        //[StringLength(30, ErrorMessage = "Maximum length should be 30")]
        //public string LastName { get; set; }
        //[Required(ErrorMessage = "Enter Address")]
        //[DataType(DataType.Text)]
        //[StringLength(40, ErrorMessage = "Maximum length should be 40")]
        //public string Address { get; set; }
        //[Required(ErrorMessage = "Enter Contact")]
        //[DataType(DataType.PhoneNumber)]
        //[StringLength(20, ErrorMessage = "Maximum length should be 20")]
        //public string Contact { get; set; }
        //[Required(ErrorMessage = "Enter Email")]
        //[DataType(DataType.EmailAddress)]
        //[StringLength(320, ErrorMessage = "Maximum length should be 320")]
        //public string Email { get; set; }

        //public List<OrdersModel> ordersModels { get; set; } = new List<OrdersModel>();

        public UserModel(string name, string lastName, string address, string contact, string email, string password, string confirmPassword)
        {
            Name = name;
            LastName = lastName;
            Address = address;
            Contact = contact;
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
        }
        public override string ToString()
        {
            return this.Name + " " + this.LastName + " " + this.Address + " " + this.Contact + " " + this.Email + " " + this.Password + " " + this.ConfirmPassword;
        }
    }
}
