﻿using System.ComponentModel.DataAnnotations;

namespace ProjectLibrary.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}