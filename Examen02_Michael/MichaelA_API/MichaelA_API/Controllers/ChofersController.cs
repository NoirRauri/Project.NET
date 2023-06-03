using AutoMapper;
using Entities;
using MichaelA_API.Models;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace MichaelA_API.Controllers
{
    [ApiController]
    [Route("api/chofers")]
    public class ChofersController:ControllerBase
    {
        public readonly IService<TbChofer> _IChoferService;
        public readonly IService<TbTipoLicencium> _ITipoLicenciaService;
        private readonly IMapper _mapper;

        public ChofersController(IService<TbChofer> iChoferService, IService<TbTipoLicencium> iTipoLicenciaService, IMapper mapper)
        {
            _IChoferService = iChoferService;
            _ITipoLicenciaService = iTipoLicenciaService;
            _mapper = mapper;
        }

        // GET all
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<ChoferDTO>>> get()
        {
            try
            {
                List<TbChofer> lista = await _IChoferService.obtenerTodos();
                //Destino     Origen
                var listaDTO = _mapper.Map<List<ChoferDTO>>(lista);
                if (listaDTO == null)
                {
                    return NotFound("No existe los Choferes en la BD");
                }
                return Ok(listaDTO);
            }
            catch (Exception)
            {
                return BadRequest("No existen Clientes en la Base de datos");
            }
        }

        // GET for ID
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ChoferDTO>> getById(string id)
        {
            try
            {
                TbChofer chofer = new TbChofer();

                chofer.Cedula = id;
                chofer = await _IChoferService.obtenerPorId(chofer);
                if (chofer == null)
                {
                    return NotFound("No existe el chofer con ese ID");
                }
                ChoferDTO choferDTO = _mapper.Map<ChoferDTO>(chofer);
                return Ok(choferDTO);
            }
            catch (Exception)
            {
                return BadRequest("No existe el chofer con ese ID");
            }
        }

        // POST
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ChoferDTO>> post([FromBody] ChoferDTO ChoferDTO)
        {
            try
            {
                if (!validarDatos(ChoferDTO))
                {
                    return NotFound("Los datos estan incorrectos");
                }

                TbChofer chofer = new TbChofer();
                chofer.Cedula = ChoferDTO.Cedula;
                chofer = await _IChoferService.obtenerPorId(chofer);
                if (chofer != null)
                {
                    return NotFound("Chofer existe");
                }

                chofer = _mapper.Map<TbChofer>(ChoferDTO);

                foreach (var list in chofer.TbLicenciaChofers)
                {
                    TbTipoLicencium tipoLicencia = new TbTipoLicencium();
                    tipoLicencia.IdTipoLicencia = list.IdTipoLicencia;
                    tipoLicencia = await _ITipoLicenciaService.obtenerPorId(tipoLicencia);
                    if (tipoLicencia == null)
                    {
                        return NotFound("La licencia no existe");
                    }
                }
                await _IChoferService.guardar(chofer);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("No se pudo crear el cliente");
            }
        }

        public bool validarDatos(ChoferDTO ChoferDTO)
        {
            if (ChoferDTO.Cedula==null)
            {
                return false;
            }
            else if (ChoferDTO.Nombre == null)
            {
                return false;
            }
            else if (ChoferDTO.Apellido1 == null)
            {
                return false;
            }
            else if (ChoferDTO.Apellido2 == null)
            {
                return false;
            }
            else if (ChoferDTO.TbLicenciaChofers == null)
            {
                return false;
            }
            return true;
        }

    }
}
