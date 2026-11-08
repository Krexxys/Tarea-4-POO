using System;
using System.Collections.Generic;

namespace EcosistemaMultimedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ECOSYSTEMA DE DISPOSITIVOS MULTIMEDIA ===\n");

            // Lista unificada de dispositivos (Polimorfismo)
            List<Dispositivo> listaDispositivos = new List<Dispositivo>
            {
                new SmartTv 
                { 
                    Marca = "Samsung", 
                    Resolucion = "4K Ultra HD" 
                },
                new ParlanteInteligente 
                { 
                    Marca = "Bose", 
                    PotenciaWatts = 50 
                },
                new Dispositivo
                {
                    Marca = "Genérico"
                }
            };

            // Recorremos la lista y ejecutamos el método de forma dinámica
            foreach (var dispositivo in listaDispositivos)
            {
                dispositivo.ReproducerMedia();
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}