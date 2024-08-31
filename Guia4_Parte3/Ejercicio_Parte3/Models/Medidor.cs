using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_Parte3.Models
{
    public class Medidor
    {
        public int NumeroServicio { get; private set; }
        public double LecturaAnterior { get; private set; }
        public double LecturaActual { get; private set; }
        public ArrayList consumos = new ArrayList();
        public int CantidadConsumos
        {
            get
            {
                return consumos.Count;
            }
        }
        public int PeriodoActual
        {
            get
            {
                int cont = 0;
                if(cont < 7)
                {
                    cont++;
                }
                else
                {
                    cont = 0;
                }
                return cont;
            }
            private set
            {

            }
        }

        

        #region Metodos
        public Medidor(int numServis)
        {
            NumeroServicio = numServis;
            
        }
        public double ConsumoActual()
        {
            double ConsumoActual = LecturaActual - LecturaAnterior;
            return ConsumoActual;
        }
        public void Medicion(double lecActual)//intercambio de datos
        {
            double aux = 0;
            aux = LecturaActual;
            LecturaActual = lecActual;
            LecturaAnterior = aux;

        }

        public void RegistrarConsumo(double medicion)
        {
            LecturaActual = medicion;
            consumos.Add(ConsumoActual());
            PeriodoActual++;

        }
        public double LeerConsumo(int pos)
        {
            double ret = 0;
            foreach (Medidor m in consumos)
            {
                if (m == consumos[pos])
                {
                    ret = m.ConsumoActual();
                }
            }
            return ret;
        }

        #endregion
    }
}
