using Microsoft.EntityFrameworkCore;
using PARTNER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Context
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }
        public  DbSet<Student> Students { get; set; }
        public  DbSet<Branch> Branches { get; set; }
        public  DbSet<Check> Checks { get; set; }
        public  DbSet<District> Districts { get; set; }
        public  DbSet<Faculty> Faculties { get; set; }
        public  DbSet<Group> Groups { get; set; }
        public  DbSet<Interist> Interists { get; set; }
        public  DbSet<LiveReady> LiveReadies { get; set; }
        public  DbSet<Nogiron> Nogirons { get; set; }
        public  DbSet<Parents> Parents { get; set; }
        public  DbSet<Region> Regions { get; set; }
        public  DbSet<Tyutor> Tyutors { get; set; }
        public  DbSet<Unversty> Unversties { get; set; }
    }
}
