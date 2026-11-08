using System;

namespace GestionCompensaciones
{
    public class Desarrollador : Empleado
    {
        public int LineasCodigoPorDia { get; set; }

        // Sobrescribimos el método: Bono por líneas de código (ejemplo: Q0.50 por línea al mes)
        public override decimal CalcularSalarioTotal()
        {
            decimal bonoDesempenio = LineasCodigoPorDia * 0.50m * 20; // 20 días laborales
            return SalarioBase + bonoDesempenio;
        }
    }
}