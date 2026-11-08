using System;

namespace AutonomiaFlota
{
    public class Automovil : Vehiculo
    {
        public int NumeroPuertas { get; set; }

        public override double CalcularAutonomiaKm()
        {
            return LitrosCombustible * 15.0;
        }
    }
}