using FluentValidation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MNY.Model
{
    public class Customer
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
       
        [Required]
        public string Email { get; set; }

    }
}
