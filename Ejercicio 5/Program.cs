using System;
using System.Collections.Generic;

namespace RendimientoFinanciero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CÁLCULO DE RENDIMIENTO FINANCIERO EN CUENTAS BANCARIAS ===\n");

            // Lista unificada de cuentas (Polimorfismo)
            List<CuentaBancaria> listaCuentas = new List<CuentaBancaria>
            {
                new CuentaAhorros 
                { 
                    Saldo = 15000.00m, 
                    TasaPromocional = 2.5m 
                },
                new CuentaInversion 
                { 
                    Saldo = 50000.00m, 
                    FactorRiesgo = 4.0 
                },
                new CuentaBancaria
                {
                    Saldo = 5000.00m
                }
            };

            // Recorremos la lista y calculamos los intereses de forma dinámica
            foreach (var cuenta in listaCuentas)
            {
                string tipo = cuenta.GetType().Name;
                Console.WriteLine($"Tipo de Cuenta: {tipo}");
                Console.WriteLine($"Saldo Actual: Q{cuenta.Saldo:N2}");
                Console.WriteLine($"Interés Mensual Calculado: Q{cuenta.CalcularInteresMensual():N2}");
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}