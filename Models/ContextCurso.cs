using Microsoft.EntityFrameworkCore;
using ReadData.Data;

namespace MVCPrototype.Models
{
    public class ContextCurso : DbContext
    {
        //este constructor sirve para poner la configuración en el fichero appsettings.json
        //en vez de en esta clase.
        public ContextCurso(DbContextOptions<ContextCurso> options) : base(options){}

        public DbSet<Instructor> Instructor{get; set;}

    }
}