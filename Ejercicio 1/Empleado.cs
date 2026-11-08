using System;

namespace GestionCompensaciones
{
    public class Empleado
    {
        public string Nombre { get; set; } = string.Empty;
        public decimal SalarioBase { get; set; }

        // El método virtual permite que las clases hijas lo sobrescriban (Polimorfismo)
        public virtual decimal CalcularSalarioTotal()
        {
            return SalarioBase;
        }
    }
}