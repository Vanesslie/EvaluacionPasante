using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace API_pasantia.models;

public partial class Product
{
    [JsonIgnore] //ya que es auto incremental, si el usuario lo ingresa puede dar error
    public int ProductId { get; set; }

    public string CodigoProducto { get; set; } = null!;

    public string NombreProducto { get; set; } = null!;

    public decimal Precio { get; set; }

    public bool? Estado { get; set; }

    public int Stock { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int CategoryId { get; set; }

    //si se vuelve a hacer scaffold, este cambio (el de ignirar estos campos) se pierden
    [JsonIgnore]
    [ValidateNever] //provisional. una vez se agregue logica, la categoria debera agregarse autom. a partir del categoryID
    public virtual Category Category { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<MovInv> MovInvs { get; set; } = new List<MovInv>();
}
