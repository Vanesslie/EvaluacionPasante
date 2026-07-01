using System;
using System.Collections.Generic;

namespace API_pasantia.models;

public partial class Product
{
    public int ProductId { get; set; }

    public string CodigoProducto { get; set; } = null!;

    public string NombreProducto { get; set; } = null!;

    public decimal Precio { get; set; }

    public bool? Estado { get; set; }

    public int Stock { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<MovInv> MovInvs { get; set; } = new List<MovInv>();
}
