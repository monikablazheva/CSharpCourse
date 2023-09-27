using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Telephone { get; set; }

        public List<Product> Products { get; set; }

        public Brand()
        {
            Products = new List<Product>();
        }

        public Brand(string name, string email) : this()
        {
            Name = name;
            Email = email;
        }

        public Brand(string name, string email, string telephone) 
         : this(name, email)
        {
            Telephone = telephone; 
        }

        public Brand(int id, string name, string email, string telephone)
         : this(name, email, telephone)
        {
            Id = id;
        }

    }
}
