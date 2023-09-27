using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Serie
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
        public int Seasons { get; private set; }

        [Required]
        public int Episodes { get; private set; }

        [Required]
        [MaxLength(30)]
        public string AgeRestriction { get; set; }

    }
}
