using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_WebAPI.Entity_Framework
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        public string Username { get; set; }

        public DateTime CreatedTimestamp { get; set; } = DateTime.Now;

        public string Email { get; set; }
    }
}
