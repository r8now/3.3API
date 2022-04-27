using Microsoft.EntityFrameworkCore;
using Moment33API.Models;

namespace Moment33API.Data
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }
        
        public DbSet<Music> Music { get; set; }
        
    }
}
