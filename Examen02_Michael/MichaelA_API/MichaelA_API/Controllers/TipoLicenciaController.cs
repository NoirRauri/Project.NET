using AutoMapper;
using Entities;
using MichaelA_API.Models;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace MichaelA_API.Controllers
{
    [ApiController]
    [Route("api/tipolicencia")]
    public class TipoLicenciaController: ControllerBase
    {
        public readonly IService<TbTipoLicencium> _ITipoLicenciaService;
        private readonly IMapper _mapper;

        public TipoLicenciaController(IService<TbTipoLicencium> iTipoLicenciaService, IMapper mapper)
        {
            _ITipoLicenciaService = iTipoLicenciaService;
            _mapper = mapper;
        }

        // GET all
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<TipoLicenciaDTO>>> get()
        {
            try
            {
                List<TbTipoLicencium> lista = await _ITipoLicenciaService.obtenerTodos();
                //Destino     Origen
                var listaDTO = _mapper.Map<List<TipoLicenciaDTO>>(lista);
                if (listaDTO == null)
                {
                    return NotFound("No existe datos en la  BD");
                }
                return Ok(listaDTO);
            }
            catch (Exception)
            {
                return BadRequest("No existen tipos de licencias en la Base de datos");
            }
        }
    }
}
