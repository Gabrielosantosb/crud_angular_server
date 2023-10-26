using Crud.ORM.Entity;
using Microsoft.EntityFrameworkCore;

namespace Crud.ORM.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }

    }
}
