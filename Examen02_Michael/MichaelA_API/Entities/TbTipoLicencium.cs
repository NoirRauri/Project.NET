using System;
using System.Collections.Generic;

namespace Entities;

public partial class TbTipoLicencium
{
    public string IdTipoLicencia { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Estado { get; set; }

    public virtual ICollection<TbLicenciaChofer> TbLicenciaChofers { get; set; } = new List<TbLicenciaChofer>();
}
