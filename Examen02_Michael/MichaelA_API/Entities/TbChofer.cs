using System;
using System.Collections.Generic;

namespace Entities;

public partial class TbChofer
{
    public string Cedula { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido1 { get; set; } = null!;

    public string Apellido2 { get; set; } = null!;

    public virtual ICollection<TbLicenciaChofer> TbLicenciaChofers { get; set; } = new List<TbLicenciaChofer>();
}
