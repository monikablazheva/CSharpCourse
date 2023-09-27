using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class User
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string Password { get; set; }
        private User()
        {

        }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
