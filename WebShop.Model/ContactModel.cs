using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebShop.Model
{
    [Table("Contact")]
    public class ContactModel
    {
        [Key]
        public int ContactId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(320)]
        public string Email { get; set; }
        [Required]
        [StringLength(200)]
        public string Message { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key, Column(Order = 0)]
        //public int ContactId { get; set; }
        //[Required(ErrorMessage = "Enter Name")]
        //[DataType(DataType.Text)]
        //[StringLength(30, ErrorMessage = "Maximum length should be 30")]
        //public string Name { get; set; }
        //[Required(ErrorMessage = "Enter Email")]
        //[DataType(DataType.EmailAddress)]
        //[StringLength(320, ErrorMessage = "Maximum length should be 320")]
        //public string Email { get; set; }
        //[Required(ErrorMessage = "Enter Message")]
        //[DataType(DataType.Text)]
        //[StringLength(200, ErrorMessage = "Maximum length should be 200")]
        //public string Message { get; set; }
    }
}
