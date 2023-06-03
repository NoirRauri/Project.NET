using System;
using System.Collections.Generic;

namespace Entities;

public partial class TbLicenciaChofer
{
    public string IdLicencia { get; set; } = null!;

    public string IdTipoLicencia { get; set; } = null!;

    public DateTime FechaEmicion { get; set; }

    public DateTime FechaVenc { get; set; }

    public virtual TbChofer IdLicenciaNavigation { get; set; } = null!;

    public virtual TbTipoLicencium IdTipoLicenciaNavigation { get; set; } = null!;
}
