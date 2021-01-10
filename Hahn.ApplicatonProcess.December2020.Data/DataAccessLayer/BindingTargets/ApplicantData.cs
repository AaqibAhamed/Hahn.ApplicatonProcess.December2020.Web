using Hahn.ApplicatonProcess.December2020.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hahn.ApplicatonProcess.December2020.Data.DataAccessLayer.BindingTargets
{
    public class ApplicantData
    {
        public Applicant Applicant { get; set; } = new Applicant();
       
        [Required]
        [MinLength(5)]
        public string Name
        {
            get => Applicant.Name; set => Applicant.Name = value;
        }

        [Required]
        [MinLength(5)]
        public string FamilyName
        {
            get => Applicant.FamilyName; set => Applicant.FamilyName = value;
        }

        [Required]
        [MinLength(10)]
        public string Address
        {
            get => Applicant.Address; set => Applicant.Address = value;
        }

        public string CountryOfOrigin
        {
            get => Applicant.CountryOfOrigin; set => Applicant.CountryOfOrigin = value;
        }

        [EmailAddress]
        [Required(ErrorMessage = "Email Adress is required")]
        public string EmailAdress
        {
            get => Applicant.EmailAdress; set => Applicant.EmailAdress = value;
        }

        [Range(20, 60, ErrorMessage = "Age must be between 20 and 60")]
        public int Age
        {
            get => Applicant.Age; set => Applicant.Age = value;
        }
        
        [Required]
        public bool Hired
        {
            get => (bool)Applicant.Hired; set => Applicant.Hired = value;
        }
    }
}
