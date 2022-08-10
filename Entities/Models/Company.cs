﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Company
    {
        [Column("Company id")]
        public Guid Id { get; set; }

        [Required(ErrorMessage="Company name is required field.")]
        [MaxLength(60, ErrorMessage="Maximum length of the name is 60 characters.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Company address is required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length of the address is 60 characters.")]
        public string Address { get; set; }

        public string Country { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
