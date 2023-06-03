using AutoMapper;
using Entities;
using MichaelA_API.Models;

namespace MichaelA_API
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<TbChofer, ChoferDTO>().ReverseMap();
            CreateMap<TbLicenciaChofer, LicenciaChoferDTO>().ReverseMap();
            CreateMap<TbTipoLicencium, TipoLicenciaDTO>().ReverseMap();

        }
    }
}
