using Microsoft.EntityFrameworkCore;

namespace bulkyweb.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) {

        }
    }
}
