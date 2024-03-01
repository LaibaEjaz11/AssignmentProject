using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace AssignmentProject.Models.Data
{
    public class Customer:IdentityUser
    {
        [Required(ErrorMessage = "Name Required")]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Phone Required")]
        [Column(TypeName = "varchar(50)")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Location Required")]
        [Column(TypeName = "varchar(50)")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Email Required")]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Postal Code Required")]
        [Column(TypeName = "varchar(50)")]
        public string Postal_code { get; set; }
        [NotMapped]
        public IFormFile ImageIForm { set; get; }
        [Required(ErrorMessage = "Profile Image Required")]
        [Column(TypeName = "varchar(max)")]
        public string Image { get; set; }
    }
}
