using Hahn.ApplicatonProcess.December2020.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hahn.ApplicatonProcess.December2020.Data.DataAccessLayer
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if(context.Applicants.Count() == 0)
            {
                var a1 = new Applicant
                {
                    Name = "Aaqib",
                    FamilyName ="Wiki",
                    Address ="Colombo",
                    Age = 24,
                    EmailAdress ="example@aqb.com",
                    CountryOfOrigin ="LK",
                    Hired =true

                };

                context.SaveChanges();
            }
        }
    }
}
