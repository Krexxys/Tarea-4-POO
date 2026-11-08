using System;
using System.Collections.Generic;

namespace CentroAlertas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CENTRO DE ENVÍOS DE ALERTAS Y NOTIFICACIONES MULTICANAL ===\n");

            // Lista unificada de notificaciones (Polimorfismo)
            List<Notificacion> listaNotificaciones = new List<Notificacion>
            {
                new CorreoElectronico 
                { 
                    Mensaje = "¡Alerta crítica! Intento de acceso no autorizado en el servidor principal.", 
                    DireccionCorreo = "admin@seguridad.com" 
                },
                new Sms 
                { 
                    Mensaje = "Caída detectada en el servicio de base de datos.", 
                    NumeroTelefono = "+502 5555-1234" 
                },
                new Notificacion
                {
                    Mensaje = "Mantenimiento programado del sistema."
                }
            };

            // Recorremos la lista y despachamos los mensajes de forma polimórfica
            foreach (var notificacion in listaNotificaciones)
            {
                notificacion.Enviar();
            }
        }
    }
}