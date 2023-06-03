using Data;
using Entities;
using Services;

namespace MichaelA_API
{
    public static class ServicesExtensions
    {
        public static IServiceCollection addServices(this IServiceCollection services)
        {
            //capa negocios
            services.AddTransient<IService<TbChofer>,ChoferService>();
            services.AddTransient<IService<TbLicenciaChofer>,LicenciaChoferServices>();
            services.AddTransient<IService<TbTipoLicencium>,TipoLicenciaService>();


            //capa de datos
            services.AddTransient<IData<TbChofer>, ChoferData>();
            services.AddTransient<IData<TbLicenciaChofer>, LicenciaChoferData>();
            services.AddTransient<IData<TbTipoLicencium>, TipoLicenciaData>();

            //antes del return agregamos las inyecciones de dependencias
            return services;
        }
    }
}
