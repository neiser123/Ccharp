
using Dominio.Interfaces;
using System;
using System.IO;

namespace Infraestructura.Loggers
{
    public class LoggerArchivoDeTexto : ILog
    {
        public void Log(string mensaje)
        {

            using (StreamWriter writertext = new StreamWriter(@"C:\log.txt", append: true))
            {
                writertext.WriteLine(mensaje);
            }


        }

        public void LogException(Exception ex)
        {
            String error = $"{ex.Message} : {ex.StackTrace}";
            Log(error);
        }

    }
}
