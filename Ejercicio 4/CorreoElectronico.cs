using System;

namespace CentroAlertas
{
    public class CorreoElectronico : Notificacion
    {
        public string DireccionCorreo { get; set; } = string.Empty;

        // Sobrescribimos el método para enviar por correo
        public override void Enviar()
        {
            Console.WriteLine($"[Correo Electrónico] Destino: {DireccionCorreo}");
            Console.WriteLine($"-> Contenido de la alerta: \"{Mensaje}\"");
            Console.WriteLine("-> Estado: Correo enviado mediante protocolo SMTP de forma exitosa.\n");
        }
    }
}