using System.ComponentModel.DataAnnotations;

namespace WebApiWithSwagger.Models
{
    public class Person
    {
        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string LastName { get; set; }
    }
}
