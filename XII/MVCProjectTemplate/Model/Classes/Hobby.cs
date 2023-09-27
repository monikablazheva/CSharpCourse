using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Classes
{
    public class Hobby
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter name!")]
        [MaxLength(30)]
        public string Name { get; set; }

        public IList<User> Users { get; set; }

        // For Controller's Binding
        public Hobby()
        {
            this.Users = new List<User>();
        }

        public Hobby(string name)
        {
            this.Name = name;
            this.Users = new List<User>();
        }

    }
}
