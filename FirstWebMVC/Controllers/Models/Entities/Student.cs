using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models.Entities
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public string StudentCode { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;
    }
}