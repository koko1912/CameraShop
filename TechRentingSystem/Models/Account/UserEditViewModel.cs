﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TechRentingSystem.Models.Account
{
    public class UserEditViewModel
    {
        public string Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}