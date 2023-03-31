using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UepaTicksWeb.Dominio.Dtos;

namespace UepaTicksWeb.Infraestructura.Interfaz.Services
{
    internal interface IEventosService
    {
        Task<EventosDto> Add(EventosDto dto);
        Task<EventosDto> Update(int Id, EventosDto dto);
        Task Delete(int Id);
        Task<EventosDto> Get(int Id);
        Task<List<EventosDto>> Get();
    }
}
