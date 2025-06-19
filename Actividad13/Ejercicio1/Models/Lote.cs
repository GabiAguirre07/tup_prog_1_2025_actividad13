using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Lote
    {
        
        public int numero;
        public double[] medidas = new double[100];
        public int cantidad;


        public double VerMedida(int idx,out int valor)
        {
            valor = 0;
            return 0 ;
        }
         public void RegistrarMedida(double valor)
        {
            medidas[cantidad]=valor;
            cantidad++;
        }
        public int VerCantidad()
        {
            return cantidad;
        }
        public int VerNumeroLote()
        {
            return numero;
        }
        public void AsignarNumeroLote(int valor)
        {
            numero = valor;
        }

    }
}
