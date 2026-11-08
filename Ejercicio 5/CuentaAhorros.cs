using System;

namespace RendimientoFinanciero
{
    public class CuentaAhorros : CuentaBancaria
    {
        public decimal TasaPromocional { get; set; }

        // Sobrescribimos el método utilizando la tasa promocional
        public override decimal CalcularInteresMensual()
        {
            return Saldo * (TasaPromocional / 100m);
        }
    }
}