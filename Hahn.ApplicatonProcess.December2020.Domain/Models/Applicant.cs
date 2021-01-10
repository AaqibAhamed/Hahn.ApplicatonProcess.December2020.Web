using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Hahn.ApplicatonProcess.December2020.Domain.Models
{
    public class Applicant
    {
        public int ID { get; set; }

        [MinLength(5)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [MinLength(5)]
        public string FamilyName { get; set; }

        [MinLength(10)]
        public string Address { get; set; }

        public string CountryOfOrigin { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Required(ErrorMessage = "Email Adress is required")]
        public string EmailAdress { get; set; }

        [Range(20, 60, ErrorMessage = "Age must be between 20 and 60")]
        public int Age { get; set; }

        public bool? Hired { get; set; }

    }
}
