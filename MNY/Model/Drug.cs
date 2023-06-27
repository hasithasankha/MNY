using System.ComponentModel.DataAnnotations;

namespace MNY.Model
{
    public class Drug
    {
       
        public int ID { get; set; }

        [Required]
        public string Trde_Name { get; set; }

        [Required]
        public string Generic_Name { get; set; }

        [Required]
        public string Note { get; set; }
    } 
}
