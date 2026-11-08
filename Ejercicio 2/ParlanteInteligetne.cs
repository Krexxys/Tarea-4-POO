using System;

namespace EcosistemaMultimedia
{
    public class ParlanteInteligente : Dispositivo
    {
        public int PotenciaWatts { get; set; }

        // Sobrescribimos el método con la lógica específica para el parlante
        public override void ReproducerMedia()
        {
            Console.WriteLine($"[Parlante Inteligente] Marca: {Marca} | Potencia: {PotenciaWatts}W");
            Console.WriteLine("-> Reproduciendo audio en streaming emitiendo perfiles acústicos personalizados.");
        }
    }
}