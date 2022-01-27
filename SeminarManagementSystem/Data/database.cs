using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeminarManagementSystem.Models;

    public class database : DbContext
    {
        public database (DbContextOptions<database> options)
            : base(options)
        {
        Database.EnsureCreated();
        }

        public DbSet<SeminarManagementSystem.Models.Attendee> Attendee { get; set; }

        public DbSet<SeminarManagementSystem.Models.Organiser> Organiser { get; set; }

        public DbSet<SeminarManagementSystem.Models.TypeSeminar> TypeSeminar { get; set; }
    }
