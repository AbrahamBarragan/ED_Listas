using ListasDoblementeLigadas;

Listas lista = new Listas();
lista.AgregarNodo("Dos");
lista.AgregarNodo("Tres");
lista.AgregarNodo("Cuatro");
lista.AgregarNodo("Cinco");
Console.WriteLine(lista.RecorrerLista());
Console.WriteLine("Buscando nodo Cuatro");
Nodo nodoTres = lista.Buscar("Cuatro");
Console.WriteLine(nodoTres.Valor);
Console.WriteLine("Borrando Cuatro");
lista.BorrarNodo("Tres");
Console.WriteLine(lista.RecorrerLista());
