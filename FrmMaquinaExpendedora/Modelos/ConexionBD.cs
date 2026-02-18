using Microsoft.EntityFrameworkCore;
using System;

namespace FrmMaquinaExpendedora
{
	public class ConexionBD: DbContext
	{
			public DbSet<Producto> productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LILY\\SQLEXPRESS;Initial Catalog=BDMaquinaExpendedora;Integrated Security=True;Trust Server Certificate=True");
        }

    }

}
