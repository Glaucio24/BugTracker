﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class BTUser: IdentityUser
    {

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at leat {2} and a max {1} characters long", MinimumLength = 2)]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at leat {2} and a max {1} characters long", MinimumLength = 2)]
        public string? LastName { get; set; }

        [NotMapped]
        public string? FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }
}
