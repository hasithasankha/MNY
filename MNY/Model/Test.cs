using System.ComponentModel.DataAnnotations;

namespace MNY.Model
{
    public class Test
    {
        public int Id { get; set; }

        [Required]
        public string Test_Name { get; set; }

        [Required]
        public string Test_Description { get; set;}
    }
}
