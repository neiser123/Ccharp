using Dominio.Interfaces;
using System;


namespace Infraestructura.Loggers
{
    public class LoggerConsola : ILog
    {

        public void Log(String mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public void SeteaColor(ConsoleColor color) {
            Console.ForegroundColor = color;
        }
        public void LogException(Exception ex)
        {
            SeteaColor(ConsoleColor.Red);
            
            String error = $"{ex.Message}:{ex.StackTrace}";
            Log(error);
            SeteaColor(ConsoleColor.White);
        }
    }
}
