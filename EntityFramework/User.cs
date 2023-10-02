using System.ComponentModel.DataAnnotations;

namespace EntityFramework
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        public string? Username { get; set; }

        public DateTime CreatedTimestamp { get; set; } = DateTime.Now;

        public string? Email { get; set; }
    }
}
