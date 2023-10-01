using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using UepaTicksWeb.Dominio.Dtos;
using UepaTicksWeb.Infraestructura.Interfaz.Services;

namespace UepaTicksWeb.Infraestructura.Interfaz.Repository
{
    public class ClientesService : IClientesService
    {
        private readonly string conexion = "Data Source=(motor Db); Initial Catalog=(nombre Db); Integrated Security=True";

        public async Task<ClientesDto> Add(ClientesDto dto)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            }

            SqlParameter nombre = new()
            {
                ParameterName = "@Nombre",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = dto.Nombre

            };
            cmd.Parameters.Add(nombre);

            SqlParameter apellidos = new()
            {
                ParameterName = "@Apellidos",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Value = dto.Apellidos
            };
            cmd.Parameters.Add(apellidos);

            SqlParameter contactos = new()
            {
                ParameterName = "@Contactos",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Value = dto.Contactos
            };
            cmd.Parameters.Add(contactos);

            SqlParameter emial = new()
            {
                ParameterName = "@Email",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Value = dto.Email
            };
            cmd.Parameters.Add(emial);

            SqlParameter personJuridica = new()
            {
                ParameterName = "@PersonaJuridica",
                SqlDbType = SqlDbType.Char,
                Size = 2,
                Value = dto.PersonaJuridica
            };
            cmd.Parameters.Add(personJuridica);

            SqlParameter personFisica = new()
            {
                ParameterName = "@PersonaFisica",
                SqlDbType = SqlDbType.Char,
                Size = 2,
                Value = dto.PersonaFisica
            };
            cmd.Parameters.Add(personFisica);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
            return dto;
        }

        public async Task Delete(int Id)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();

            SqlParameter deleteId = new()
            {
                ParameterName = "@ClienteId",
                SqlDbType = SqlDbType.Int,
                Value = Id
            };
            cmd.Parameters.Add(deleteId);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
            return;

        }

        public async Task<ClientesDto> Get(int Id)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ClienteId", Id);

            await cn.OpenAsync();
            var reader = cmd.ExecuteReader();

            while (await reader.ReadAsync())
            {
                var cliente = new ClientesDto()
                {
                    ClienteId = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Apellidos = reader.GetString(2),
                    Contactos = reader.GetString(3),
                    Email = reader.GetString(4),
                    PersonaJuridica = reader.GetString(4),
                    PersonaFisica = reader.GetString(5)
                };

                return cliente;
            }

            return null;
        }

        public async Task<List<ClientesDto>> Get()
        {
            List<ClientesDto> listClienteDto = new();
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@ClienteId", Id);

            await cn.OpenAsync();
            var reader = cmd.ExecuteReader();

            while (await reader.ReadAsync())
            {
                var cliente = new ClientesDto()
                {
                    ClienteId = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Apellidos = reader.GetString(2),
                    Contactos = reader.GetString(3),
                    Email = reader.GetString(4),
                    PersonaJuridica = reader.GetString(4),
                    PersonaFisica = reader.GetString(5)
                };

              listClienteDto.Add(cliente);
            }

            return listClienteDto;

        }

        public async Task<ClientesDto> Update(int Id, ClientesDto dto)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();

            SqlParameter updateId = new()
            {
                ParameterName = "@ClienteId",
                SqlDbType = SqlDbType.Int,
                Value = Id
            };
            cmd.Parameters.Add(updateId);

            SqlParameter nombre = new()
            {
                ParameterName = "@Nombre",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = dto.Nombre

            };
            cmd.Parameters.Add(nombre);

            SqlParameter apellidos = new()
            {
                ParameterName = "@Apellidos",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Value = dto.Apellidos
            };
            cmd.Parameters.Add(apellidos);

            SqlParameter contactos = new()
            {
                ParameterName = "@Contactos",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Value = dto.Contactos
            };
            cmd.Parameters.Add(contactos);

            SqlParameter emial = new()
            {
                ParameterName = "@Email",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Value = dto.Email
            };
            cmd.Parameters.Add(emial);

            SqlParameter personJuridica = new()
            {
                ParameterName = "@PersonaJuridica",
                SqlDbType = SqlDbType.Char,
                Size = 2,
                Value = dto.PersonaJuridica
            };
            cmd.Parameters.Add(personJuridica);

            SqlParameter personFisica = new()
            {
                ParameterName = "@PersonaFisica",
                SqlDbType = SqlDbType.Char,
                Size = 2,
                Value = dto.PersonaFisica
            };
            cmd.Parameters.Add(personFisica);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
            return dto;
        }
    }
}
