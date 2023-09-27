using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Model.Classes
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Range(10, 150, ErrorMessage = "Age must be between 10 and 150!")]
        public int Age { get; set; }

        // Prevent loops if you are using Net Core Json Serializer!
        //[JsonIgnore]
        public IList<Message> Messages { get; set; }

        public IList<Hobby> Hobbies { get; set; }

        public User()
        {
            this.Messages = new List<Message>();
            this.Hobbies = new List<Hobby>();
        }

        public User(string username, string email, int age, string name)
        {
            this.UserName = username;
            this.NormalizedUserName = username.ToUpper();
            this.Email = email;
            this.NormalizedEmail = email.ToUpper();
            this.Age = age;
            this.Name = name;
            this.Messages = new List<Message>();
            this.Hobbies = new List<Hobby>();
        }

        public User(string id, string username, string email, int age, string name)
            : this(username, email, age, name)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            return string.Format($"{Id} {Name} {Age}");
        }

        public static explicit operator User(ValueTask<IdentityUser> v)
        {
            throw new NotImplementedException();
        }
    }
}
