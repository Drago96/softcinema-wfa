﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Models
{
    public class Movie
    {
        public Movie()
        {
            this.Cast = new HashSet<Actor>();
            this.Categories = new HashSet<Category>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Length { get; set; }

        [Range(0,10)]
        public float? Rating { get; set; }

        public string Synopsis { get; set; }

        public virtual ICollection<Actor> Cast { get; set; }

        [Required]
        public string DirectorName { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        public string ReleaseCountry { get; set; }

        [Required]
        public AgeRestriction AgeRestriction { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}