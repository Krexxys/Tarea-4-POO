using System;

namespace EcosistemaMultimedia
{
    public class SmartTv : Dispositivo
    {
        public string Resolucion { get; set; } = string.Empty;

        // Sobrescribimos el método con la lógica específica para la Smart TV
        public override void ReproducerMedia()
        {
            Console.WriteLine($"[Smart TV] Marca: {Marca} | Resolución: {Resolucion}");
            Console.WriteLine("-> Reproduciendo streaming de video en alta definición con procesamiento de pantalla avanzado.");
        }
    }
}