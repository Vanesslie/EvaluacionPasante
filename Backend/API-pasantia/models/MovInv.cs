using System;
using System.Collections.Generic;

namespace API_pasantia.models;

public partial class MovInv
{
    public int MovInvId { get; set; }

    public int Cantidad { get; set; }

    public DateTime? FechaMov { get; set; }

    public int ProductId { get; set; }

    public int UserId { get; set; }

    public int TipoMovInvId { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual TipoMovInv TipoMovInv { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
