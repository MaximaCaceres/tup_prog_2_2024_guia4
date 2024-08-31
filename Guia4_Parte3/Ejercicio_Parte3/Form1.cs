using Ejercicio_Parte3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Parte3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cooperativa cooperativa;
        Cliente client;
        private void btnIniciarCooperativa_Click(object sender, EventArgs e)
        {
            string nombre = tbxNombreCop.Text;
            cooperativa = new Cooperativa(nombre);
            
        }

        private void btnCargaCliente_Click(object sender, EventArgs e)
        {
            DatosDelCliente nachin = new DatosDelCliente();
            int NumServ, dni;
            string nombre, direccion;
            if(nachin.ShowDialog() == DialogResult.OK)
            {
                NumServ = Convert.ToInt32(nachin.tbxNumServ.Text);
                dni = Convert.ToInt32(nachin.tbxDNI.Text);
                nombre = nachin.tbxNombre.Text;
                direccion = nachin.tbxDireccion.Text;

                Medidor med = new Medidor(NumServ);
                cooperativa.AgregarCliente(dni, nombre, direccion, med);//la cooperativa agrega un cliente.
                MessageBox.Show("Nuevo cliente!!"+NumServ);//
            }
            nachin.Dispose();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int dato = Convert.ToInt32(tbxNumServicio.Text);
            int idx = cooperativa.BuscarCliente(dato);

            client = cooperativa.clientes[idx] as Cliente;
            lbResultado.Text = client.ToString();
            
        }

        private void btnCargarConsumo_Click(object sender, EventArgs e)
        {
            double consumo = Convert.ToDouble(tbxConsumo.Text);
            client.NumeroMedidor.RegistrarConsumo(consumo);
        }

        private void btnVerConsumo_Click(object sender, EventArgs e)
        {
            FromVer listar = new FromVer();
            foreach(Cliente numS in cooperativa.clientes)
            {
                double ret = numS.NumeroMedidor.ConsumoActual();
                listar.lbxLista.Items.Add(ret);
            }
            listar.ShowDialog();
            listar.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
