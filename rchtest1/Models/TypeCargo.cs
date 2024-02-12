using System;
using System.Collections.Generic;

namespace rchtest1.Models;

public partial class TypeCargo
{
    public int TypeCargoId { get; set; }

    public string TypeCargoName { get; set; } = null!;

    public virtual ICollection<Transport> Transports { get; set; } = new List<Transport>();
}
