using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Parte3.Models
{
    public class Cooperativa
    {
       public ArrayList clientes = new ArrayList();
       
        public string Nombre { get; set; }
        public Cooperativa(string nombre)
        {
            Nombre = nombre;
        }
        public int BuscarCliente(int numServ)
        {
            int indice = 0;
            clientes.Sort();//ordenamos
            for(int n = 0; n < clientes.Count; n++)
            {
                Cliente obj = clientes[n] as Cliente;
                if(obj.NumeroMedidor.NumeroServicio == numServ)//para entrar al numero de servicio hay que entrar al numero del medidor.
                {
                    indice = n;
                }            
            }
            return indice;
        }
        public Cliente AgregarCliente(int dni,string nombre,string direccion, Medidor medi)
        {
            Cliente client = new Cliente(dni,nombre,direccion,medi);
            clientes.Add(client);
            return client;
        }

    }
}
