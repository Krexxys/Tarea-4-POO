using System;
using System.Collections.Generic;

namespace GestionCompensaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE GESTIÓN DE COMPENSACIONES ===\n");

            // Lista unificada de colaboradores (Polimorfismo)
            List<Empleado> listaEmpleados = new List<Empleado>
            {
                new Desarrollador 
                { 
                    Nombre = "Carlos Pérez", 
                    SalarioBase = 8000m, 
                    LineasCodigoPorDia = 250 
                },
                new Gerente 
                { 
                    Nombre = "Ana Gómez", 
                    SalarioBase = 15000m, 
                    BonoAnualFijo = 36000m 
                },
                new Empleado 
                { 
                    Nombre = "Luis Morales (Base)", 
                    SalarioBase = 5000m 
                }
            };

            // Recorremos la lista y desplegamos los salarios de forma dinámica
            foreach (var emp in listaEmpleados)
            {
                Console.WriteLine($"Empleado: {emp.Nombre}");
                Console.WriteLine($"Salario Base: Q{emp.SalarioBase:N2}");
                Console.WriteLine($"Salario Total Calculado: Q{emp.CalcularSalarioTotal():N2}");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}