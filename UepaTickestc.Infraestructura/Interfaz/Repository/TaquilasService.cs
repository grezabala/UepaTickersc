using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using UepaTicksWeb.Dominio.Dtos;
using UepaTicksWeb.Infraestructura.Interfaz.Services;

namespace UepaTicksWeb.Infraestructura.Interfaz.Repository
{
    public class TaquilasService : ITaquillasService
    {
        private readonly string conexion = "Data Source=(motor Db); Initial Catalog=(nombre Db); Integrated Security=True";
        public async Task<TaquillasDto> Add(TaquillasDto dto)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            }

            SqlParameter seccin = new()
            {
                ParameterName = "@Seccion",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = dto.Seccion
            };
            cmd.Parameters.Add(seccin);

            SqlParameter precioTicker = new()
            {
                ParameterName = "@PrecioPorTicker",
                SqlDbType = SqlDbType.Decimal,
                Value = dto.PrecioPorTicker
            };
            cmd.Parameters.Add(precioTicker);

            SqlParameter cantidadPorSeccion = new()
            {
                ParameterName = "@CantidadPorSeccion",
                SqlDbType = SqlDbType.Int,
                Value = dto.CantidadPorSeccion
            };
            cmd.Parameters.Add(cantidadPorSeccion);

            SqlParameter condicion = new()
            {
                ParameterName = "@Seccion",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = dto.Seccion
            };
            cmd.Parameters.Add(seccin);


            await cn.OpenAsync();
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

            SqlParameter taquillaId = new()
            {
                ParameterName = "@TaquillaId",
                SqlDbType = SqlDbType.Int,
                Value = Id
            };
            cmd.Parameters.Add(taquillaId);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();

            return; 
        }

        public async Task<TaquillasDto> Get(int Id)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TaquillaId",Id);
            }

            await cn.OpenAsync();
            var reader = cmd.ExecuteReader();

            while (await reader.ReadAsync()) 
            {
                var taquilla = new TaquillasDto()
                {
                    TaquillaId = reader.GetInt32(0),
                    CantidadPorSeccion = reader.GetInt32(1),
                    Condición = reader.GetString(2),
                    Seccion = reader.GetString(3),
                    PrecioPorTicker = reader.GetDecimal(4),
                };

                return taquilla; 
 
            }

            return null;

        }

        public async Task<List<TaquillasDto>> Get()
        {
            List<TaquillasDto> listTaquillas = new List<TaquillasDto>();

            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            }

            await cn.CloseAsync();
            var reader = cmd.ExecuteReader();

            while (await reader.ReadAsync()) 
            {
                var taquillasDto = new TaquillasDto()
                {
                    TaquillaId = reader.GetInt32(0),
                    CantidadPorSeccion = reader.GetInt32(1),
                    Condición = reader.GetString(2),
                    Seccion = reader.GetString(3),
                    PrecioPorTicker = reader.GetDecimal(4),

                };

                listTaquillas.Add(taquillasDto);
            }

            return listTaquillas;
        }

        public async Task<TaquillasDto> Update(int Id, TaquillasDto dto)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            }

            SqlParameter taquillaId = new()
            {
                ParameterName = "@TaquillaId",
                SqlDbType = SqlDbType.Int,
                Value = Id
            };
            cmd.Parameters.Add(taquillaId);

            SqlParameter seccin = new()
            {
                ParameterName = "@Seccion",
                SqlDbType = SqlDbType.VarChar,
                Size = 150,
                Value = dto.Seccion
            };
            cmd.Parameters.Add(seccin);

            SqlParameter precioTicker = new()
            {
                ParameterName = "@PrecioPorTicker",
                SqlDbType = SqlDbType.Decimal,
                Value = dto.PrecioPorTicker
            };
            cmd.Parameters.Add(precioTicker);

            SqlParameter cantidadPorSeccion = new()
            {
                ParameterName = "@CantidadPorSeccion",
                SqlDbType = SqlDbType.Int,
                Value = dto.CantidadPorSeccion
            };
            cmd.Parameters.Add(cantidadPorSeccion);

            SqlParameter condicion = new()
            {
                ParameterName = "@Seccion",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = dto.Seccion
            };
            cmd.Parameters.Add(seccin);


            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();

            return dto;
        }
    }
}
