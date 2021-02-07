using Microsoft.EntityFrameworkCore;
using MVCBookManager.Models;

namespace MVCBookManager.Data
{
    public class MvcBookContext: DbContext
    {
        public MvcBookContext (DbContextOptions<MvcBookContext> options)
            :base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
    }
}
