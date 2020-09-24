using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebShop.Model
{
    [Table("Recipes")]
    public class RecipesModel
    {
        [Key]
        public int RecipeId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key, Column(Order = 0)]
        //public int RecipesId { get; set; }
        //[Required(ErrorMessage = "Enter Name")]
        //[DataType(DataType.Text)]
        //[StringLength(30, ErrorMessage = "Maximum length should be 30")]
        //public string Name { get; set; }
        //[DataType(DataType.Text)]
        //[StringLength(200, ErrorMessage = "Maximum length should be 200")]
        //public string Description { get; set; }
        public RecipesModel()
        {

        }
        public RecipesModel(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Description;
        }
    }
}
