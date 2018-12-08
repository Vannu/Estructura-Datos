using System;
using System.Collections;

namespace Tp_Final_Soria
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Funciones
            // Crear Cola, "new Queue()"
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


            // Eliminar contenido de la cola, método utilizado Clear()
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

                //Manejo de exepciones : objeto nulo

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


            // Agrega elemento a la cola, método utilizado Enqueue()
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

                //Manejo de exepciones : objeto nulo y formato correcto

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


            // Borrar último pedido, método utilizado Dequeue()
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

                //Manejo de exepciones : objeto nulo

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


            // Mostrar contenido de la cola iterando con un Foreach 
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
                    foreach (int contenido in cola) // iteracion 
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

                //Manejo de exepciones : objeto nulo

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


            // Mostrar el último pedido de la Cola, para obtener la ultima posicion
            // copio la cola a una lista, y con el método .Count() accedo a la posicion
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

                //Manejo de exepciones : objeto nulo estado del objeto y valores permitidos

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


            //Mostrar el primer pedido de la cola, utilizacion del método Peek()
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

                //Manejo de exepciones : objeto nulo y estado actual del objeto

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


            // Mostrar cantidad de pedidos con el método Count()
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
                //Manejo de exepciones : objeto nulo

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


            //Buscar pedido en cola, copio la cola a una lista y comparao el valor ingresado utilizando el método Contains()
            void BuscarPedido(ref Queue cola)
            {
                Console.Write("\nIngresar Número del Pedido: ");
                try
                {
                    int valor = Convert.ToInt32(Console.ReadLine()); // Ingreso del pedido
                    ArrayList lista = new ArrayList(); // creo una lista
                    foreach (int dato in cola) // copio los datos de la cola a una lista
                    {
                        lista.Add(dato);
                    }

                    cola.Clear();

                    // Buscar pedido.

                    if (lista.Contains(valor)) //comparo el valor ingresado 
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
                    foreach (var dato in lista) // los datos de la lista lo copio a la cola
                    {
                        cola.Enqueue(dato);
                    }

                    Console.ReadKey();
                    Console.Clear();

                }

                //Manejo de exepciones : objeto nulo

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


            //Ordenar pedidos, copio los datos a una lista y con el método Sort() lo ordeno 
            void OrdenarPedidos(ref Queue cola)
            {
                try
                {
                    ArrayList lista = new ArrayList();
                    foreach (int dato in cola) // copio datos a lista
                    {
                        lista.Add(dato);
                    }

                    lista.Sort(); // ordenar lista de manera Descendente

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Los Pedidos se han ordenado: ");
                    Console.ResetColor();


                    int i = 1;
                    foreach (var elemento in lista) // iteracion
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0} - Pedido  {1} ", i, elemento);
                        Console.ResetColor();
                        i++;
                    }

                    Console.WriteLine("Para continuar presione una tecla...");

                    foreach (var dato in lista) // pasar los datos de la lista a la cola
                    {
                        cola.Enqueue(dato);
                    }

                    Console.ReadKey();
                    Console.Clear();

                }

                //Manejo de exepciones : objeto nulo

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
                //Visualizacion del menu en pantalla

                Console.Clear();
                Console.WriteLine("Ifts18 \n" +
                    "Estructura de datos - TP FInal \n" +
                    "Alumna - Vanesa Soria",
                      Console.Title);
                Console.WriteLine("\t \t \t \t \t \t ==================");
                Console.WriteLine("\t \t \t \t \t \t ==================");
                Console.WriteLine("\t \t \t \t \t \t Sistema de Pedidos");
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

                //Manejo de exepciones
                try
                {
                    int valor = Convert.ToInt32(Console.ReadLine());
                    return valor;
                }

                //Manejo de exepciones : objeto nulo y formato correcto

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

            //Mostrar en pantalla mensaje
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
            while (opcion != 0); //termina el programa si la opcion es 0
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            mensaje("Ha salido del programa");
            Console.ResetColor();
            #endregion
        }
    }
}
