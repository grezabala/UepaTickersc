using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UepaTicksWeb.Dominio.Dtos;

namespace UepaTicksWeb.Infraestructura.Interfaz.Services
{
    interface ITaquillasService
    {
        Task<TaquillasDto> Add(TaquillasDto dto);
        Task<TaquillasDto> Update(int Id, TaquillasDto dto);
        Task Delete(int Id);
        Task<TaquillasDto> Get(int Id);
        Task<List<TaquillasDto>> Get();
    }
}
