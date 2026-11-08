using System;

namespace GestionCompensaciones
{
    public class Gerente : Empleado
    {
        public decimal BonoAnualFijo { get; set; }

        // Sobrescribimos el método: Sumamos la parte mensual del bono fijo
        public override decimal CalcularSalarioTotal()
        {
            decimal bonoMensual = BonoAnualFijo / 12m;
            return SalarioBase + bonoMensual;
        }
    }
}