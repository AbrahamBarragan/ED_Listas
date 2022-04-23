using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Listas
    {
        Nodo nodoInicial;
        Nodo nodoActual;

        public Listas()
        {
            nodoInicial = new Nodo();
        }
        public bool ValidarVacio()
        {
            return (nodoInicial.nodoSiguiente == null);
        }
        public void Vaciar()
        {
            nodoInicial.nodoSiguiente = null;
        }
        public String RecorrerLista()
        {
            string datosLista = "";
            nodoActual = nodoInicial;
            while (nodoActual.nodoSiguiente != null)
            {
                nodoActual = nodoActual.nodoSiguiente;
                datosLista += $"{nodoActual.Valor}\n";
            }
            return datosLista;
        }
        public void AgregarNodo(string dato)
        {

        }
    }
}
