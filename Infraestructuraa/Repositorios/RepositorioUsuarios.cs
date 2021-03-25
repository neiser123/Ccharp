
using Dominio.Interfaces;
using Dominio.Models;
using Infraestructura.Loggers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace Infraestructura.Repositorios
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {

        private readonly LoggerConsola logger;
        public RepositorioUsuarios(LoggerConsola logger)
        {
            this.logger = logger;
        }

        public async Task<List<Usuarios>> ObtenerUsuarios()
        {

            var client = new HttpClient();
            var urlUsuarios = "https://jsonplaceholder.typicode.com/users";
            var respuestaUsuarios = await client.GetAsync(urlUsuarios);
            respuestaUsuarios.EnsureSuccessStatusCode();
            var cuerpoRespuestaUsuarios = await respuestaUsuarios.Content.ReadAsStringAsync();
            logger.Log(cuerpoRespuestaUsuarios);
            var usuarios = JsonConvert.DeserializeObject<List<Usuarios>>(cuerpoRespuestaUsuarios);

            return usuarios;

        }

    }
}
