using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UepaTicksWeb.Dominio.Dtos;
using UepaTicksWeb.Infraestructura.Interfaz.Services;

namespace UepaTicksWeb.Infraestructura.Interfaz.Repository
{
    public class EventosService : IEventosService
    {
        public Task<EventosDto> Add(EventosDto dto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<EventosDto> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<EventosDto>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<EventosDto> Update(int Id, EventosDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
