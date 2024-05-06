using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GameReviewApp.Components.Game;

namespace GameReviewApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<GameReviewApp.Components.Game.Game> Game { get; set; } = default!;
    }
}
