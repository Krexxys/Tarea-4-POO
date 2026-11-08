using System;

namespace AutonomiaFlota
{
    public class Camion : Vehiculo
    {
        public double CapacidadCargaTon { get; set; }

        // Sobrescribimos el método: El camión gasta más combustible debido a la carga (ej: 5 km por litro reducido por tonelada)
        public override double CalcularAutonomiaKm()
        {
            double rendimientoReal = Math.Max(2.0, 8.0 - (CapacidadCargaTon * 0.5));
            return LitrosCombustible * rendimientoReal;
        }
    }
}