using System;
using System.Collections.Generic;

namespace AutonomiaFlota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== AUTONOMÍA DE FLOTA VEHICULAR Y EFICIENCIA ENERGÉTICA ===\n");

            // Lista unificada de vehículos (Polimorfismo)
            List<Vehiculo> listaVehiculos = new List<Vehiculo>
            {
                new Automovil 
                { 
                    LitrosCombustible = 40.0, 
                    NumeroPuertas = 4 
                },
                new Camion 
                { 
                    LitrosCombustible = 200.0, 
                    CapacidadCargaTon = 12.5 
                },
                new Vehiculo
                {
                    LitrosCombustible = 50.0
                }
            };

            // Recorremos la lista y ejecutamos el cálculo de autonomía de forma dinámica
            foreach (var vehiculo in listaVehiculos)
            {
                string tipo = vehiculo.GetType().Name;
                Console.WriteLine($"Tipo de Vehículo: {tipo}");
                Console.WriteLine($"Combustible disponible: {vehiculo.LitrosCombustible} litros");
                Console.WriteLine($"Autonomía estimada: {vehiculo.CalcularAutonomiaKm():F2} km");
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}