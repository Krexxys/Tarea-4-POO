using System;

namespace AutonomiaFlota
{
    public class Vehiculo
    {
        public double LitrosCombustible { get; set; }

        // Método virtual para permitir el polimorfismo en las clases hijas
        public virtual double CalcularAutonomiaKm()
        {
            // Fórmula base genérica (ej: 10 km por litro)
            return LitrosCombustible * 10.0;
        }
    }
}