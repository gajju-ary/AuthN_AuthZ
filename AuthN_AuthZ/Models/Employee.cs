﻿using System.ComponentModel.DataAnnotations;

namespace AuthN_AuthZ.Models
{
    public class Employee
    {

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }
        public string Address { get; set; }


    }

}
