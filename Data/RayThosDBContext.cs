using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RaythosAerospace.Data
{
    public class RayThosDBContext : IdentityDbContext
    {

        public RayThosDBContext(DbContextOptions<RayThosDBContext> opts) : base(opts)
        {

        }
    }
}
