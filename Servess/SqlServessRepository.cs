using PARTNER.Context;
using PARTNER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Servess
{
    public class SqlServessRepository : IStudentRepository,ITyutorRepository,IRegionRepository
    {
        private readonly AppDbContext dbContext;

        public SqlServessRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Region> getall()
        {
            return dbContext.Regions;
        }

        public IEnumerable<Tyutor> GetAlll()
        {
            return dbContext.Tyutors;
        }
    }
}
