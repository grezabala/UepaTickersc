using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UepaTicksWeb.Dominio.Dtos;
using UepaTicksWeb.Infraestructura.Interfaz.Services;

namespace UepaTicksWeb.Infraestructura.Interfaz.Repository
{
    public class TaquilasService : ITaquillasService
    {
        public Task<TaquillasDto> Add(TaquillasDto dto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<TaquillasDto> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TaquillasDto>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<TaquillasDto> Update(int Id, TaquillasDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
