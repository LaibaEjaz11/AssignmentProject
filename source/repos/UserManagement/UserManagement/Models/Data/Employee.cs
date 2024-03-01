using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Models.Data
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string EmpName { get; set; }
        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string EmpEmail { get; set; }
        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string EmpContact { get; set; }
        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string EmpAddress { get; set; }
        public int Department { get; set; }
       
    }
}
