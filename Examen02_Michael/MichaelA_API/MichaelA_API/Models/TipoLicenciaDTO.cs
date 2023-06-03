using Entities;

namespace MichaelA_API.Models
{
    public class TipoLicenciaDTO
    {
        public string IdTipoLicencia { get; set; }

        public string? Descripcion { get; set; }

        public bool Estado { get; set; }

        public ICollection<LicenciaChoferDTO> TbLicenciaChofers { get; set; }
    }
}
