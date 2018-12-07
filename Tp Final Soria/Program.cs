using System;
using System.Collections;

namespace Tp_Final_Soria
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Funciones
            // Crear Cola
            void crear(ref Queue micola)
            {

                Queue miColaPedido = new Queue();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n Se ha creado una cola ");
                Console.ResetColor();
                //MostrarPedidos(micola);
                Console.WriteLine("Para continuar presione una tecla...");
                Console.ReadKey();
                Console.Clear();
            }

            //Eliminar contenido de la cola
            void BorrarContenido(ref Queue cola)
            {
                try
                {
                    cola.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    mensaje(" El contenido de la cola se ha eliminado ");
                    Console.ResetColor();
                }
                catch (NullReferenceException)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("La Cola no fue creada todavía.");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadKey();
                    Console.Clear();
                }

            }

            //Agrega elemento a la cola 
            void AgregarPedido(ref Queue cola)
            {
                try
                {
                    int i;
                    Console.Write("\nIngresar Número del Pedido: ");
                    int valor = Convert.ToInt32(Console.ReadLine()); // Ingreso del pedido
                    bool verificar = int.TryParse(Convert.ToString(valor), out i);
                    if (verificar == true && valor < 999 && valor > 0) //Validar Ingreso de pedido
                    {
                        cola.Enqueue(valor);
                        //  MostrarPedidos(cola);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(" El pedido {0} fue agregado exitosamente ", valor);
                        Console.ResetColor();
                        Console.ReadKey();
                        
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        mensaje("Debe ingresar números del 1 al 999.");
                        Console.ResetColor();
                       
                    }
                }
                catch (NullReferenceException)
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" La Cola no fue creada todavía. ");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (FormatException)                             //Excepcion ante presencia de error (al ingresar una letra o simbolo).
                {
 
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" Ingreso un caracter no valido.\n ");
                    Console.ResetColor();
                    Console.WriteLine("Presione una tecla para continuar...\n");
                    Console.ReadKey();
                    Console.Clear();

                }
            }

            //Borrar último pedido
            void BorrarPedido(ref Queue cola)
            {
                try
                {
                    int valor = (int)cola.Dequeue();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Pedido " + valor + " eliminado.");
                    Console.ResetColor();
                    MostrarPedidos(cola);
                }
                catch (NullReferenceException)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" La Cola no fue creada todavía. ");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            //Mostrar contenido de la cola
            void MostrarPedidos(Queue cola)
            {
                try
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nLista de pedidos");
                    Console.WriteLine("----------------");
                    Console.ResetColor();
                    int i = 1;
                    foreach (int contenido in cola)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0} - Pedido  {1} ", i, contenido);
                        Console.ResetColor();
                        i++;
                    }
                    Console.WriteLine("\nPresione cualquier tecla para continuar ...");
                    Console.ReadKey();

                }
                catch (NullReferenceException)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" La Cola no fue creada todavía. ");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadKey();
                    Console.Clear();

                }


            }

            //Mostrar el último pedido de la Cola
            void ultimoPedido(ref Queue cola)
            {
                try
                {
                    ArrayList aux = new ArrayList();
                    int ultimo = cola.Count - 1;                //posicion del ultimo Pedido.

                    foreach (int dato in cola)                     //Copio la cola en una lista.
                    {
                        aux.Add(dato);
                    }
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El último pedido ingresado es \n\n1 - Pedido {0}", aux[ultimo]);
                    Console.ResetColor();
                    MostrarPedidos(cola);
                }
                catch (NullReferenceException)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" La Cola no fue creada todavía. ");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadKey();
                    Console.Clear();
                }

                catch (InvalidOperationException)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("La Cola esta vacía");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadLine();
                    Console.Clear();


                }
                catch (ArgumentOutOfRangeException)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("La Cola esta vacía");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadLine();
                    Console.Clear();

                }
            }

            //Mostrar el primer pedido de la cola
            void PrimerPedido(ref Queue cola)
            {
                try
                {
                    int valor = (int)cola.Peek();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El primer pedido ingresado es es \n\n1 - Pedido " + valor);
                    Console.ResetColor();
                    MostrarPedidos(cola);
                }

                catch (NullReferenceException)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" La Cola no fue creada todavía. ");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (InvalidOperationException)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("La Cola esta vacía");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadLine();
                    Console.Clear();

                }

            }

            // Mostrar cantidad de pedidos
            void CantidadPedidos(ref Queue cola)
            {
                try
                {
                    int valor = (int)cola.Count;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("La cola tiene " + valor + " pedidos.");
                    Console.ResetColor();
                    MostrarPedidos(cola);
                }
                catch (NullReferenceException)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" La Cola no fue creada todavía. ");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            //Buscar pedido en cola 
            void BuscarPedido(ref Queue cola)
            {
                Console.Write("\nIngresar Número del Pedido: ");
                try
                {
                    int valor = Convert.ToInt32(Console.ReadLine()); // Ingreso del pedido
                    ArrayList lista = new ArrayList();
                    foreach (int dato in cola)
                    {
                        lista.Add(dato);
                    }

                    cola.Clear();

                    // Buscar pedido.

                    if (lista.Contains(valor))
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nPedido {0} Existente", valor);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nPedido {0} Inexistente", valor);
                        Console.ResetColor();
                    }
                    foreach (var dato in lista)
                    {
                        cola.Enqueue(dato);
                    }

                    Console.ReadKey();
                    Console.Clear();

                }
                catch (NullReferenceException)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" La Cola no fue creada todavía. ");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            //Ordenar pedidos
            void OrdenarPedidos(ref Queue cola)
            {
                try
                {
                    ArrayList lista = new ArrayList();
                    foreach (int dato in cola)
                    {
                        lista.Add(dato);
                    }

                    lista.Sort();

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Los Pedidos se han ordenado: ");
                    Console.ResetColor();


                    int i = 1;
                    foreach (var elemento in lista)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0} - Pedido  {1} ", i, elemento);
                        Console.ResetColor();
                        i++;
                    }

                    Console.WriteLine("Para continuar presione una tecla...");

                    foreach (var dato in lista)
                    {
                        cola.Enqueue(dato);
                    }

                    Console.ReadKey();
                    Console.Clear();

                }
                catch (NullReferenceException)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" La Cola no fue creada todavía. ");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }


            #endregion
            #region Menu
            int menu()
            {
                Console.Clear();
                Console.WriteLine("Ifts18 \n" +
                    "Estructura de datos - TP FInal \n" +
                    "Alumna - Vanesa Soria",
                      Console.Title);
                Console.WriteLine("\t \t \t \t \t \t ==================");
                Console.WriteLine("\t \t \t \t \t \t ==================");
                Console.WriteLine("\t \t \t \t \t \t Sistema| de Pedidos");
                Console.WriteLine("\t \t \t \t \t \t ==================");
                Console.WriteLine("\t \t \t \t \t \t ==================");
                Console.WriteLine(" (1) Crear Cola");
                Console.WriteLine(" (2) Borrar Cola");
                Console.WriteLine(" (3) Agregar Pedido");
                Console.WriteLine(" (4) Borrar Último Pedido");
                Console.WriteLine(" (5) Listar Todos los Pedidos");
                Console.WriteLine(" (6) Listar Último Pedido");
                Console.WriteLine(" (7) Listar Primer Pedido");
                Console.WriteLine(" (8) Ver Cantidad de Pedidos");
                Console.WriteLine(" (9) Buscar pedido Existente");
                Console.WriteLine(" (10) Ordenar pedidos");
                Console.WriteLine(" (0) Salir del Programa\n");
                Console.Write(" Ingresa tu opción: ");

                try
                {
                    int valor = Convert.ToInt32(Console.ReadLine());
                    return valor;
                }

                catch (NullReferenceException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("La Cola no fue creada todavía.");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadKey();
                    Console.Clear();
                    return menu();
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Ingresó un caracter inválido");
                    Console.ResetColor();
                    Console.WriteLine("Para continuar presione una tecla...");
                    Console.ReadKey();
                    Console.Clear();
                    return menu();

                }
            }

            //Mostrar en pantalla
            void mensaje(String texto)
            {
                if (texto.Length != 0)
                {
                    Console.WriteLine(" {0}", texto);
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }

            Queue miCola = new Queue(); // Crear cola
            int opcion; // variable Opcion para el Menu 

            do
            {
                Console.Clear(); // Limpia Pantalla
                opcion = menu(); // Mostrar Menu 
                switch (opcion)
                {
                    case 1: //Crear Cola
                        crear(ref miCola);
                        break;
                    case 2: //Borrar contenido de la Cola
                        BorrarContenido(ref miCola);
                        break;
                    case 3: //agregar elemento
                        AgregarPedido(ref miCola);
                        break;
                    case 4: //borrar elemento
                        BorrarPedido(ref miCola);
                        break;
                    case 5: //Mostrar todos los elementos de la cola
                        MostrarPedidos(miCola);
                        break;
                    case 6: //Mostrar último elemento de la cola
                        ultimoPedido(ref miCola);
                        break;
                    case 7:  //Mostrar primer elemento de la cola
                        PrimerPedido(ref miCola);
                        break;

                    case 8: //Mostrar cantidad de elementos en la cola
                        CantidadPedidos(ref miCola);
                        break;
                    case 9: //Verifica si el pedido es existente
                        BuscarPedido(ref miCola);
                        break;
                    case 10: //Ordena números de pedidos
                        OrdenarPedidos(ref miCola);
                        break;
                    case 0: break; // Salir del programa 

                    default:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Ingresó una opción inválida");
                        Console.ResetColor();
                        
                        Console.WriteLine("Para continuar presione una tecla...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            while (opcion != 0);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            mensaje("Ha salido del programa");
            Console.ResetColor();
            #endregion
        }
    }
}
