using System;

namespace aporte
{
    public class Cliente
    {
        public string NOMBRE { get; set; }
        public string DISPOSITIVO { get; set; }

        public Cliente(string NOMBRE, string DISPOSITIVO)
        {
            this.NOMBRE = NOMBRE;
            this.DISPOSITIVO = DISPOSITIVO;
            
        }

        public void OrdenReparacion()
        {
            Console.WriteLine("Nombre del Cliente: " + NOMBRE);
            Console.WriteLine("Dispositivo a reparar: " + DISPOSITIVO);
        }
    }
}