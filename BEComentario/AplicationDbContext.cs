using BEComentario.Models;
using Microsoft.EntityFrameworkCore;

namespace BEComentario
{
    public class AplicationDbContext:DbContext
    {
        public DbSet<Comentario> Comentarios { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {
            
        }
    }
}
