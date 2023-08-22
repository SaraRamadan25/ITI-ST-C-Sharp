using System.ComponentModel.DataAnnotations;

namespace Demo1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(3)]
        public string Age { get; set; }


    }
}
