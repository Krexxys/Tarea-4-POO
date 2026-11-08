using System;

namespace EcosistemaMultimedia
{
    public class Dispositivo
    {
        public string Marca { get; set; } = string.Empty;

        // Método virtual para permitir el polimorfismo en las clases hijas
        public virtual void ReproducerMedia()
        {
            Console.WriteLine($"El dispositivo de marca {Marca} está reproduciendo contenido multimedia genérico.");
        }
    }
}