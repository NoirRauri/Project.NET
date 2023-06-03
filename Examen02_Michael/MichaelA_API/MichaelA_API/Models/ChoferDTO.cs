using Entities;

namespace MichaelA_API.Models
{
    public class ChoferDTO
    {
        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public ICollection<LicenciaChoferDTO> TbLicenciaChofers { get; set; }
    }
}
