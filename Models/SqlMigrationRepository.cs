using PARTNER.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class SqlMigrationRepository : IStudentRepository
    {
        private readonly AppDbContext _dbContext;

        public SqlMigrationRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Student GET(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GETALL()
        {
            return _dbContext.Students;
        }
    }
}
