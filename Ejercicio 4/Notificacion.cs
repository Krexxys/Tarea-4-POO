using System;

namespace CentroAlertas
{
    public class Notificacion
    {
        public string Mensaje { get; set; } = string.Empty;

        // Método virtual para permitir el polimorfismo en las clases hijas
        public virtual void Enviar()
        {
            Console.WriteLine($"Enviando notificación genérica: {Mensaje}");
        }
    }
}