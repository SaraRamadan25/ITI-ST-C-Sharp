using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [Range(10,25)]
        public int Age { get; set; }

        public int? DeptNo { get; set; }

        [ForeignKey("DeptNo")]
        public Department Department { get; set; }

        [RegularExpression(@"[a-zA-Z0-9_]+@[A-Za-z]+.[a-zA-Z]{2,4}")]
        public string Email { get; set; }

        [Required]
        [MinLength(3)]
        public string Password { get; set; }

        [Compare("Password")]
        [NotMapped]
        public string cpassword { get; set; }
    }
}