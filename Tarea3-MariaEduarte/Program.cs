using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    class Program
    {
  
        static int option = 0;
        static int i = 0;
        static int size = 2;
       
        [Flags]
        enum Genero
        {
            Femenino = 1,
            Masculino = 2,

        };
        struct Book
        {
            public int estudianteid;
            public string estudiantename;
            public int Edad;
            public int Genero;
      
        };

        static Book[] Estudiente;

        static void AddEstudiantes()
        {
            int r = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < Estudiente.Length)
                {
                    Console.WriteLine("-* Universidad Hispanoamericana  *-*");
                    Console.WriteLine("Ingreso de Estudiantes.             ");
                    Console.Write("Digite el ID:                  ");
                    Estudiente[i].estudianteid = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del Estudiante:    ");
                    Estudiente[i].estudiantename = Console.ReadLine();
                    Console.Write("Digite la Edad del Estudiante:     ");
                    Estudiente[i].Edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Seleccione el Genero:");
                    Console.Write(Genero.Femenino + ":" + (int)Genero.Femenino + "\n" );
                    Console.Write(Genero.Masculino + ":" + (int)Genero.Masculino + "\n");
                    Estudiente[i].Genero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Desea agregar otro Estudiante 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de Estudiante lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }

        static void ShowBooks()
        {
            int reg = 0;
            Console.Clear();
            Console.WriteLine("-* Universidad Hispanoamericana  *-*");
            Console.WriteLine("Ingreso de Estudiantes.             ");
            for (i = 0; i < Estudiente.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine("Registro: " + reg);
                Console.WriteLine("ID:       " + Estudiente[i].estudianteid);
                Console.WriteLine("Nombre:   " + Estudiente[i].estudiantename);
                Console.WriteLine("Edad:     " + Estudiente[i].Edad);
                Console.WriteLine("Genero:   " + Estudiente[i].Genero);
            }
            Console.ReadKey();
        }

        static void SeekBooks()
        {
            //Buscar por registro
            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Universidad Hispanoamericana  *-*");
                Console.WriteLine("Búsquedad de Esudiantes.           ");
                Console.WriteLine("Digite el ID del Estudiante a buscar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < Estudiente.Length; i++)
                {
                    if (ID == Estudiente[i].estudianteid)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("ID:       " + Estudiente[i].estudianteid);
                        Console.WriteLine("Nombre:   " + Estudiente[i].estudiantename);
                        Console.WriteLine("Edad:     " + Estudiente[i].Edad);
                        Console.WriteLine("Genero:   " + Estudiente[i].Genero);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro Estudiante 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void ModificarEstudante()
        {
            //Modificar registro
           
            {
                int idnuevo;
                int idnuevoaux;
                int r=0;
                while (r != 1)
                    Console.Clear();
                 Console.WriteLine("-* Universidad Hispanoamericana  *-*");
                Console.WriteLine("Modificar registro de Estudiantes.           ");
                Console.WriteLine("Digite el ID del Estudiante a modificar");
                idnuevo = int.Parse(Console.ReadLine());
                    if (i >=0 && i < Estudiente[i].estudianteid)
                    {
                        Console.WriteLine("Registro: " );
                        Console.WriteLine("Ingrese el nuevo ID" + Estudiente[i].estudianteid);
                        idnuevoaux = int.Parse(Console.ReadLine());
                        Estudiente[i].estudianteid = idnuevoaux;
                        i++;
                    }
                  
                
                else
                {
                    Console.WriteLine("No se encontro ese ID");
               
                }
                Console.WriteLine("Desea modificar otro Estudiante 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void EliminarEstudante()
        {
            Console.WriteLine("Borrar Estudiante");
            int posicionBorrar = 1;
            for (i = posicionBorrar; i < i - 1; i++)
                Estudiente[i] = Estudiente[i + 1];
            i--;

        }
        static void Main()
        {
            Estudiente = new Book[size];
            do
            {
                Console.Clear();
                Console.WriteLine("-* Universidad Hispanoamericana  *-*");
                Console.WriteLine("1. Ingreso de Estudiante.");
                Console.WriteLine("2. Modificación de datos Estudiante.");
                Console.WriteLine("3. Eliminación de registro Estudiante.");
                Console.WriteLine("4. Búsquedad de Estudiante.");
                Console.WriteLine("5. Listado de Estudiante.");
                Console.WriteLine("6. Clasificacion de Estudiantes.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            AddEstudiantes();
                            break;
                        }
                    case 2:
                        {
                            //Console.WriteLine("Modificar Estudiante");
                            //int posicionBorrar = 1;
                            //for (i = posicionBorrar; i < i - 1; i++)
                            //    Estudiente[i] = Estudiente[i + 1];
                            //i--;

                            //Modificar la infor
                            ModificarEstudante();
                            break;
                        }
                    case 3:
                        {
                            //Console.WriteLine("Borrar Estudiante");
                            //int posicionBorrar = 1;
                            //for (i = posicionBorrar; i < i - 1; i++)
                            //    Estudiente[i] = Estudiente[i + 1];
                            //i--;
                            //Dejar campos en 0 y vacío
                            EliminarEstudante();
                            break;
                        }
                    case 4:
                        {
                            SeekBooks();
                            break;
                        }
                    case 5:
                        {
                            ShowBooks();
                            break;
                        }
                    case 6:
                        {
                            //
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}