using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppListC
{
    public partial class FrmListC : Form
    {
        // Definimos variables
        int? valor1;
        int? valor2;
        int? valor3;
        int? valor4;
        LinkedList<int> listaNumeros = new LinkedList<int>();
        string valorImprimir = "";

        public FrmListC()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

       }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); //Ciera el formulario
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                valor1 = int.Parse(txtNumero1.Text);
            }
            catch
            {
                valor1 = null;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Agregamos el valor de cada TextBox a la lista de números
            if (valor1 != null)
            {
                listaNumeros.AddLast((int)valor1);
            }

            if (valor2 != null)
            {
                listaNumeros.AddLast((int)valor2);
            }

            if (valor3 != null)
            {
                listaNumeros.AddLast((int)valor3);
            }

            if (valor4 != null)
            {
                listaNumeros.AddLast((int)valor4);
            }

            // Obtenemos el número menor y mayor de la lista original, para definir el rango de números que tendra la lista final
            int menor = listaNumeros.Min();
            int mayor = listaNumeros.Max();

            // Limpiamos la lista
            listaNumeros.Clear();

            // Rellenar la lista con números comprendidos entre el menor y mayor
            while (menor <= mayor)
            {
                listaNumeros.AddLast(menor);
                menor++;
            }

            // Concatenar cada número en la variable del resultado
            foreach (int numero in listaNumeros)
            {
                valorImprimir = valorImprimir + " " + numero;
            }

            // Imprimir resultado
            txtResultado.Text = valorImprimir;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Limpiamos todos los TextBox, la lista ligada y el valor a imprimir
            txtNumero1.Text = null;
            txtNumero2.Text = null;
            txtNumero3.Text = null;
            txtNumero4.Text = null;
            txtResultado.Text = null;
            listaNumeros.Clear();
            valorImprimir = "";
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor2 = int.Parse(txtNumero2.Text);
            }
            catch
            {
                valor2 = null;
            }
        }

        private void txtNumero4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor4 = int.Parse(txtNumero4.Text);
            }
            catch
            {
                valor4 = null;
            }
        }

        private void txtNumero3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor3 = int.Parse(txtNumero3.Text);
            }
            catch
            {
                valor3 = null;
            }
        }
    }
}
