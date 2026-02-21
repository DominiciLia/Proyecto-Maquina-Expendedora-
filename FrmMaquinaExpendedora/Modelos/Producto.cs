using System;
using System.ComponentModel.DataAnnotations;

public class Producto
{
	    [Key]
		public int  codigoProducto { get; set; }
	    public string producto { get; set; }

	    public decimal precio { get; set; }

	    public int cantidad { get; set; }
	
}


