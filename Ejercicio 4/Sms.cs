using System;

namespace CentroAlertas
{
    public class Sms : Notificacion
    {
        public string NumeroTelefono { get; set; } = string.Empty;

        // Sobrescribimos el método para enviar por SMS
        public override void Enviar()
        {
            Console.WriteLine($"[Mensaje SMS] Destino: {NumeroTelefono}");
            Console.WriteLine($"-> Contenido de la alerta: \"{Mensaje}\"");
            Console.WriteLine("-> Estado: SMS despachado a través de la pasarela de telecomunicaciones.\n");
        }
    }
}