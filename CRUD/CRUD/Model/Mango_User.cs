using System.ComponentModel.DataAnnotations;

namespace CRUD.Model
{
    public class Mango_User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
