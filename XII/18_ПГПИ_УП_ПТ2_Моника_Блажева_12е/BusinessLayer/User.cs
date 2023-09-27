using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer
{
    //клас потрбител
    public class User
    {
        [Key]
        public int Id { get; private set; }
        [MaxLength(20)]  [Required]
        public string Name { get; set; }
        [Range(18, 81, ErrorMessage = "Must be number between 18 and 81")]
        public int Age { get; set; }
        [MaxLength(20)] [Required]
        public string Username { get; set; }
        private User()
        {

        }

        public User(string name,  int age, string username)
        {
            Name = name;
            Age = age;
            Username = username;
        }
    }
}
