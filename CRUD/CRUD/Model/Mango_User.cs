using System.ComponentModel.DataAnnotations;

namespace CRUD.Model
{
    public class Mango_User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
}
