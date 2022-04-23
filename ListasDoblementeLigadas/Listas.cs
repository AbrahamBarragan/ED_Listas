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
            nodoActual = nodoActual.nodoSiguiente;
            while (nodoActual.nodoSiguiente != null)
            {
                nodoActual = nodoActual.nodoAnterior;
            }
            Nodo nodoNuevo = new Nodo(dato);
            nodoActual.nodoSiguiente = nodoNuevo;
        }
        public Nodo Buscar(string dato)
        {
            if (ValidarVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.nodoSiguiente != null)
                {
                    nodoBusqueda = nodoBusqueda.nodoSiguiente;
                    if(nodoBusqueda.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
        public Nodo BuscarPorIndice(int indice)
        {
            int Indice = -1;
            if (ValidarVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while(nodoBusqueda.nodoSiguiente != null)
                {
                    nodoBusqueda = nodoBusqueda.nodoSiguiente;
                    Indice++;
                        if(Indice == indice)
                    {
                        return nodoBusqueda;
                    }   
                }
            }
            return null;
        }
    }
}
