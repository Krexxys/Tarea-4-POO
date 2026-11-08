
using System;

namespace RendimientoFinanciero
{
    public class CuentaInversion : CuentaBancaria
    {
        public double FactorRiesgo { get; set; }

        // Sobrescribimos el método aplicando el factor de riesgo sobre el saldo
        public override decimal CalcularInteresMensual()
        {
            decimal rendimiento = SalcedoSimulado(Saldo, FactorRiesgo);
            return rendimiento;
        }

        private decimal SalcedoSimulado(decimal saldoActual, double riesgo)
        {
            // Lógica de cálculo basada en el factor de riesgo y saldo
            decimal tasaVariable = 0.02m + (decimal)(riesgo * 0.005);
            return saldoActual * tasaVariable;
        }
    }
}