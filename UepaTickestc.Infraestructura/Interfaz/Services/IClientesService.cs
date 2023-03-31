using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UepaTicksWeb.Dominio.Dtos;

namespace UepaTicksWeb.Infraestructura.Interfaz.Services
{
    internal interface IClientesService
    {
        Task<ClientesDto> Add(ClientesDto dto);
        Task<ClientesDto> Update(int Id, ClientesDto dto);
        Task Delete(int Id);
        Task<ClientesDto> Get(int Id);
        Task<List<ClientesDto>> Get();

    }
}
