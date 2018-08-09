using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COLAS
{
    class Program
    {
        const int N = 3;
        public struct Cola
        {
            public int inic;
            public int fin;
            public char[] c;

            public void ci()
            {
                c = new char[N];
            }
        }

        public struct ColaS
        {
            public int inic;
            public int fin;
            public string[] c;
            public void ci()
            {
                c = new string[N+N];
            }
        }

        static void Iniciar(ref Cola co)
        {
            co.inic = -1;
            co.fin = -1;
        }

        static void Iniciar(ref ColaS co)
        {
            co.inic = -1;
            co.fin = -1;
        }

        static bool Empty(Cola co)
        {

            if (co.inic == -1 && co.fin == -1 || co.inic > co.fin)
                return true;
            else
                return false;
        }

        static bool Empty(ColaS co)
        {
            if (co.inic == -1 && co.fin == -1 || co.inic > co.fin)
                return true;
            else
                return false;
        }

        static bool Full(Cola co)
        {
            if (co.fin == N - 1)
                return true;

            else
                return false;
        }

        static bool Full(ColaS co)
        {
            if (co.fin == N - 1)
                return true;
            else
                return false;
        }

        static void Push(ref Cola co, char dato)
        {
            if (Full(co))
            {
                Console.WriteLine("LA COLA ESTA LLENA");

            }

            else
            {
                if (co.inic == -1 && co.fin == -1)
                    co.inic++;
                co.fin++;
                co.c[co.fin] = dato;

            }


        }

        static void Push(ref ColaS co, string dato)
        {
            if(Full(co))
            {
                Console.WriteLine("La cola esta llena");
            }

            else
            {
                if (co.inic == -1 && co.fin == -1)
                    co.inic++;
                co.fin++;
                co.c[co.fin] = dato;
            }
        }


        static void Pop(ref Cola co, ref char dato)
        {
            if (Empty(co))
                Console.WriteLine("LA COLA ESTA VACIA.....");
            else
            {
                dato = co.c[co.inic];
                co.inic++;
            }
        }

        static void Pop(ref ColaS co, ref string dato)
        {
            if (Empty(co))
                Console.WriteLine("La cola esta vacia");

            else
            {
                dato = co.c[co.inic];
                co.inic++;
            }
        }


        static void Imp(ref ColaS co)
        {
            ColaS ct = new ColaS();
            ct.ci();
            Iniciar(ref ct);

            string dato = " ";

            Console.WriteLine("\nLos datos de la COLA.....");
            while (!Empty(co))
            {
                Pop(ref co, ref dato);
                Console.WriteLine("{0}", dato);
                Push(ref ct, dato);
            }
            Iniciar(ref co);
            while (!Empty(ct))
            {
                Pop(ref ct, ref dato);
                Push(ref co, dato);
            }

        }

        static void Imp(ref Cola co3)
        {
            Cola ct = new Cola();
            ct.ci();
            Iniciar(ref co3);
            char dato = ' ';
            Console.WriteLine("Imprimiendo datos...");

            while(!Empty(co3))
            {
                Pop(ref co3, ref dato);
                Console.WriteLine(dato);
                Push(ref co3, dato);
            }

            Iniciar(ref co3);
            while(!Empty(ct))
            {
                Pop(ref ct, ref dato);
                Push(ref co3, dato);
            }

        }

        static void Tarea(ref ColaS co1, ref ColaS co2, ref Cola co3)
        {
            ColaS ct = new ColaS();
            ct.ci();
            Iniciar(ref ct);
            string dato = " ";
            Console.WriteLine("Realizando tarea...");

            while(!Empty(co1))
            {
                Pop(ref co1, ref dato);
            }
        }

        //Sobre Carga de m�todo

        static void Pedir(string m, ref int op)
        {
            Console.Write("\n{0}", m);
            op = int.Parse(Console.ReadLine());

        }
        static void Pedir(string m, ref string dato)
        {
            Console.Write("\n{0}", m);
            dato = Console.ReadLine();

        }

        static void Menu()
        {
            Console.WriteLine("\n<<<<< MENU >>>>>");
            Console.WriteLine("1. PUSH COLA 1");
            Console.WriteLine("2. POP COLA 1");
            Console.WriteLine("3. PUSH COLA 2");
            Console.WriteLine("4. POP COLA 2");
            Console.WriteLine("5. IMPRIMIR COLA 1");
            Console.WriteLine("6. IMPRIMIR COLA 2");
            Console.WriteLine("7. IMPRIMIR COLA 3");
            Console.WriteLine("8. SALIR");


        }
        static void Ejecutar(ref ColaS co1, ref ColaS co2)
        {
            Cola co3 = new Cola();
            co3.ci();
            Iniciar(ref co3);

            int op = 0;
            string dato = " ";
            do
            {
                Menu();
                Pedir("Dar la opcion: ", ref op);
                switch (op)
                {
                    case 1:
                        if (Full(co1))
                            Console.WriteLine("\nCola LLena...");
                        else
                        {
                            Pedir("De el dato: ", ref dato);
                            Push(ref co1, dato);
                        }
                        break;

                    case 2:
                        if (Empty(co1))
                            Console.WriteLine("\nCola Vacia...");
                        else
                        {
                            Console.WriteLine("\nSacando dato de la cola.....");
                            Pop(ref co1, ref dato);
                        }
                        break;
                    case 3:

                        if (Empty(co1))
                            Console.WriteLine("\nNo se puede imprimir la cola Vacia...");
                        else
                            Imp(ref co1);
                        break;



                    case 4:
                        
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        Console.WriteLine("\nSALIR");
                        break;

                    default: Console.WriteLine("\ningrese una opcion dentro del rango"); break;
                }
            }
            while (op != 8);
        }
        static void Main(string[] args)
        {
            ColaS co1 = new ColaS();
            co1.ci();
            Iniciar(ref co1);
            ColaS co2 = new ColaS();
            co2.ci();
            Iniciar(ref co2);
            Ejecutar(ref co1, ref co2);
            Console.ReadLine();


        }
    }
}

