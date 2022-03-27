using Microsoft.EntityFrameworkCore;
using RestfulApiWithEFCore.Models.Data;

namespace RestfulApiWithEFCore.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
