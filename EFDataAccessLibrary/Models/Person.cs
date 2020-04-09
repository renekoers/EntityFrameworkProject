﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    public class Person
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        public List<Email> EmailAddresses { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
