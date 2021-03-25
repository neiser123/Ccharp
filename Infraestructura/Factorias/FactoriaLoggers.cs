using Dominio;
using Dominio.Interfaces;
using Infraestructura.Loggers;
using System;

namespace Infraestructura.Factorias
{
    public class FactoriaLoggers
    {
        public ILog ObtenerLogger(String discriminante)
        {
            switch (discriminante)
            {
                case "consola":
                    return new Loggers.LoggerConsola();
                case "archivo":
                    return new LoggerArchivoDeTexto();

                default:
                    throw new NotImplementedException("LOGER NO FOUND");
                    break;
            }


        }
    }
}
