using Microsoft.AspNetCore.Mvc;
using Dapper;
using Microsoft.Data.SqlClient;
using Personas.Api.Models;

namespace Personas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonasController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public PersonasController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> CrearPersona(Persona persona)
        {
            string connectionString =
                _configuration.GetConnectionString("DefaultConnection");

            using var connection = new SqlConnection(connectionString);

            string sql = @"
                INSERT INTO Personas (Nombre, Apellido, Edad)
                VALUES (@Nombre, @Apellido, @Edad)";

            await connection.ExecuteAsync(sql, persona);

            return Ok("Persona guardada correctamente");
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerPersonas()
        {
            string connectionString =
                _configuration.GetConnectionString("DefaultConnection");

            using var connection = new SqlConnection(connectionString);

            string sql = "SELECT Nombre, Apellido, Edad FROM Personas";

            var personas = await connection.QueryAsync<Persona>(sql);

            return Ok(personas);
        }
    }
}