using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Models.Data
{
    public class Admin : IdentityUser
    {
        [Required(ErrorMessage = "Name Required")]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public string Phone { get; set; }
      
        [Column(TypeName = "varchar(50)")]
        public string Location { get; set; }
     
        [Column(TypeName = "varchar(50)")]
        public string Postal_code { get; set; }
    }
}
