using System;
using System.Collections.Generic;

namespace API_pasantia.models;

public partial class TipoMovInv
{
    public int TipoMovInvId { get; set; }

    public string NombreMov { get; set; } = null!;

    public bool? TipoMov { get; set; }

    public virtual ICollection<MovInv> MovInvs { get; set; } = new List<MovInv>();
}
