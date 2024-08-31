using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Parte3.Models
{
    public class Cliente: IComparable
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }
        public string Direccion { get; private set; }
        public Medidor NumeroMedidor { get; private set; }
        

        public Cliente(int dni, string nombre, string direccion, Medidor medidor)
        {
            DNI = dni;
            Nombre = nombre;
            Direccion = direccion;
            NumeroMedidor=medidor;
        }
        public int CompareTo(object obj)//hacemos la comparacion por numero de servicio del medidor.
        {
            Cliente cli = obj as Cliente; //casteamos a que sea un cliente.
            if (cli != null)
                return NumeroMedidor.NumeroServicio.CompareTo(NumeroMedidor.NumeroServicio);
            return 1;

        }
        public override string ToString()
        {
            string detalle = $"{Nombre}||{DNI}||";
            return detalle;
        }
        
    }
}
