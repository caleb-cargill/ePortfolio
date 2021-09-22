using Microsoft.EntityFrameworkCore;

namespace ePortfolio.Web.API.Models
{
    public class PortfolioContext : DbContext
    {

        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        { }

        public DbSet<Section> Sections { get; set; }

    }
}
