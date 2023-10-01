using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using UepaTicksWeb.Dominio.Context;
using UepaTicksWeb.Dominio.Dtos;
using UepaTicksWeb.Infraestructura.Interfaz.Services;

namespace UepaTicksWeb.Infraestructura.Interfaz.Repository
{
    public class EventosService : IEventosService
    {
        //Conexion SQL 
        private readonly string conexion = "Data Source=(motor Db); Initial Catalog=(nombre Db); Integrated Security=True";


        public async Task<EventosDto> Add(EventosDto dto)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            };

            SqlParameter nameEvento = new()
            {
                ParameterName = "@NameEvento",
                SqlDbType = SqlDbType.NVarChar,
                Size = 250,
                Value = dto.NameEvento
            };
            cmd.Parameters.Add(nameEvento);

            SqlParameter tipoEvento = new()
            {
                ParameterName = "@TipoDeEvento",
                SqlDbType = SqlDbType.NVarChar,
                Size = 250,
                Value = dto.TipoDeEvento
            };
            cmd.Parameters.Add(tipoEvento);

            SqlParameter capacidaEvento = new()
            {
                ParameterName = "@CapacidadTotalDelEvento",
                SqlDbType = SqlDbType.Int,
                Value = dto.CapacidadTotalDelEvento
            };
            cmd.Parameters.Add(capacidaEvento);

            SqlParameter lugarEvento = new()
            {
                ParameterName = "@LugarDelEvento",
                SqlDbType = SqlDbType.NVarChar,
                Size = 250,
                Value = dto.LugarDelEvento
            };
            cmd.Parameters.Add(lugarEvento);

            SqlParameter fechaEvento = new()
            {
                ParameterName = "@FechaDelEvento",
                SqlDbType = SqlDbType.DateTime,
                Value = dto.FechaDelEvento
            };
            cmd.Parameters.Add(fechaEvento);

            SqlParameter horaEvento = new()
            {
                ParameterName = "@HoraDelEvento",
                SqlDbType = SqlDbType.DateTime,
                Value = dto.HoraDelEvento
            };
            cmd.Parameters.Add(horaEvento);

            await cn.CloseAsync();
            await cmd.ExecuteNonQueryAsync();
            return dto;
        }

        public async Task Delete(int Id)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            }

            SqlParameter delete = new()
            {
                ParameterName = "@EventoId",
                SqlDbType = SqlDbType.Int,
                Value = Id
            };
            cmd.Parameters.Add(delete);

            await cn.CloseAsync();
            await cmd.ExecuteNonQueryAsync();
            return;
        }

        public async Task<EventosDto> Get(int Id)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@EventoId", Id);

            }

            await cn.CloseAsync();
            var reader = cmd.ExecuteReader();

            while (await reader.ReadAsync())
            {
                var evento = new EventosDto()
                {
                    EventoId = reader.GetInt32(0),
                    CapacidadTotalDelEvento = reader.GetInt32(1),
                    FechaDelEvento = reader.GetDateTime(2),
                    HoraDelEvento = reader.GetDateTime(3),
                    LugarDelEvento = reader.GetString(4),
                    NameEvento = reader.GetString(5),
                    TipoDeEvento = reader.GetString(6)

                };

                return evento;

            }

            return null;
        }

        public async Task<List<EventosDto>> Get()
        {
            List<EventosDto> listEventos = new List<EventosDto>();

            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn); 
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
           
            await cn.OpenAsync();
            var reader = cmd.ExecuteReader();

            while (await reader.ReadAsync()) 
            {
                var eventos = new EventosDto()
                {

                    EventoId = reader.GetInt32(0),
                    CapacidadTotalDelEvento = reader.GetInt32(1),
                    FechaDelEvento = reader.GetDateTime(2),
                    HoraDelEvento = reader.GetDateTime(3),
                    LugarDelEvento = reader.GetString(4),
                    NameEvento = reader.GetString(5),
                    TipoDeEvento = reader.GetString(6)

                };

                listEventos.Add(eventos);
            }

            return listEventos;
        }

        public async Task<EventosDto> Update(int Id, EventosDto dto)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            };

            SqlParameter eventoId = new()
            {
                ParameterName = "@EventoId",
                SqlDbType = SqlDbType.Int,
                Value = Id
            };
            cmd.Parameters.Add(eventoId);

            SqlParameter nameEvento = new()
            {
                ParameterName = "@NameEvento",
                SqlDbType = SqlDbType.NVarChar,
                Size = 250,
                Value = dto.NameEvento
            };
            cmd.Parameters.Add(nameEvento);

            SqlParameter tipoEvento = new()
            {
                ParameterName = "@TipoDeEvento",
                SqlDbType = SqlDbType.NVarChar,
                Size = 250,
                Value = dto.TipoDeEvento
            };
            cmd.Parameters.Add(tipoEvento);

            SqlParameter capacidaEvento = new()
            {
                ParameterName = "@CapacidadTotalDelEvento",
                SqlDbType = SqlDbType.Int,
                Value = dto.CapacidadTotalDelEvento
            };
            cmd.Parameters.Add(capacidaEvento);

            SqlParameter lugarEvento = new()
            {
                ParameterName = "@LugarDelEvento",
                SqlDbType = SqlDbType.NVarChar,
                Size = 250,
                Value = dto.LugarDelEvento
            };
            cmd.Parameters.Add(lugarEvento);

            SqlParameter fechaEvento = new()
            {
                ParameterName = "@FechaDelEvento",
                SqlDbType = SqlDbType.DateTime,
                Value = dto.FechaDelEvento
            };
            cmd.Parameters.Add(fechaEvento);

            SqlParameter horaEvento = new()
            {
                ParameterName = "@HoraDelEvento",
                SqlDbType = SqlDbType.DateTime,
                Value = dto.HoraDelEvento
            };
            cmd.Parameters.Add(horaEvento);

            await cn.CloseAsync();
            await cmd.ExecuteNonQueryAsync();
            return dto;
        }
    }
}
