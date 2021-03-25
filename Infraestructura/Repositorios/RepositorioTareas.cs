using Dominio;
using Dominio.Interfaces;
using Dominio.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Infraestructura.Repositorios
{
    public class RepositorioTareas : IRepositorioTareas
    {

        private readonly LoggerConsola logger;
        public RepositorioTareas(LoggerConsola logger)
        {
            this.logger = logger;
        }

        public async Task<List<Tarea>> ObtenerTareas()
        {

            var client = new HttpClient();
            var urlTareas = "https://jsonplaceholder.typicode.com/todos";
            var respuestareas = await client.GetAsync(urlTareas);
            respuestareas.EnsureSuccessStatusCode();
            var cuerpoRespuestaTareas = await respuestareas.Content.ReadAsStringAsync();
            logger.Log(cuerpoRespuestaTareas);
            var tareas = JsonConvert.DeserializeObject<List<Tarea>>(cuerpoRespuestaTareas);

            return tareas;

        }

    }
}
