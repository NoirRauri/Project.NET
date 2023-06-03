using Entities;

namespace MichaelA_API.Models
{
    public class LicenciaChoferDTO
    {
        public string IdLicencia { get; set; }

        public string IdTipoLicencia { get; set; }

        public DateTime FechaEmicion { get; set; }

        public DateTime FechaVenc { get; set; }
    }
}
