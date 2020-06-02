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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }

        //public List<OrdersModel> ordersModels { get; set; } = new List<OrdersModel>();

        public UserModel()
        {

        }
        public UserModel(string name, string lastName, string address, string contact, string email)
        {
            Name = name;
            LastName = lastName;
            Address = address;
            Contact = contact;
            Email = email;

        }
        public override string ToString()
        {
            return this.Name + " " + this.LastName + " " + this.Address + " " + this.Contact + " " + this.Email;
        }
    }
}
