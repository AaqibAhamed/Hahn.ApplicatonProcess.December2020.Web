using Hahn.ApplicatonProcess.December2020.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hahn.ApplicatonProcess.December2020.Data.DataAccessLayer
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

        public DbSet<Applicant> Applicants { get; set; }


    }

   
}
