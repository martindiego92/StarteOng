using System.ComponentModel.DataAnnotations;

namespace starteAlkemy.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
    }
}