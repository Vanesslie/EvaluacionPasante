using System;
using System.Collections.Generic;

namespace API_pasantia.models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string NombreCategoria { get; set; } = null!;

    public bool? EstadoCategoria { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
