﻿using System.ComponentModel.DataAnnotations;

namespace Belatrix.Client.ViewModels
{
    public class LoginViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public bool HasError { get; set; }
    }
}
