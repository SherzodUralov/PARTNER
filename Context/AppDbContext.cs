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
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Check> Checks { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Interist> Interists { get; set; }
        public virtual DbSet<LiveReady> LiveReadies { get; set; }
        public virtual DbSet<Nogiron> Nogirons { get; set; }
        public virtual DbSet<Parents> Parents { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<Tyutor> Tyutors { get; set; }
        public virtual DbSet<Unversty> Unversties { get; set; }
    }
}
