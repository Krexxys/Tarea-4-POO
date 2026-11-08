using System;

namespace RendimientoFinanciero
{
    public class CuentaBancaria
    {
        public decimal Saldo { get; set; }

        // Método virtual para permitir el polimorfismo en las clases hijas
        public virtual decimal CalcularInteresMensual()
        {
            // Interés base genérico (ej: 1% mensual)
            return Saldo * 0.01m;
        }
    }
}