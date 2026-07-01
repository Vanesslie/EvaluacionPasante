using System;
using System.Collections.Generic;

namespace API_pasantia.models;

public partial class User
{
    public int UserId { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string? Nombre { get; set; }

    public string Contrasena { get; set; } = null!;

    public string? Correo { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<MovInv> MovInvs { get; set; } = new List<MovInv>();
}
