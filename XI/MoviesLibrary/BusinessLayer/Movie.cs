using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Movie
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Genre { get; set; }

        [Required]
        [MaxLength(30)]
        public string Date { get; set; }

        [Required]
        [MaxLength(150)]
        public string Director { get; set; }

        [Required]
        [MaxLength(30)]
        public string AgeRestriction { get; set; }
        private Movie()
        {

        }

        public Movie(string name, string genre, string date, string director, string ageRestriction)
        {
            Name = name;
            Genre = genre;
            Date = date;
            Director = director;
            AgeRestriction = ageRestriction;
        }
    }
}
