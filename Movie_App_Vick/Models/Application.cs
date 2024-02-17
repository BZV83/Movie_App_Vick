﻿using System.ComponentModel.DataAnnotations;

namespace Movie_App_Vick.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director {  get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; } //not required
        public string LentTo { get; set; } //not required
        public string Notes { get; set; } //not required
    }
}
