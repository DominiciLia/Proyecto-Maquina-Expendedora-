using System;
using Microsoft.EntityFrameworkCore;

public class ConexionBD : DbContext
{
    public DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=LILY\\SQLEXPRESS;Initial Catalog=MaquinaExpendedora;Integrated Security=True;Trust Server Certificate=True");
    }
}
}


