using System;

public class ConexionBD
{
	public ConexionBD : dbcontext 

	{
		public DbSet<Producto> productosas { get; set; }

}
}
