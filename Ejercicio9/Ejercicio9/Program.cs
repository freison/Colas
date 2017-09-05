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
                c = new string[N];
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

        static void Tarea(ref ColaS co1, ref ColaS co2, ref Cola co3)
        {

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
            Console.WriteLine("1. PUSH");
            Console.WriteLine("2. POP");
            Console.WriteLine("3. IMPRIMIR");
            Console.WriteLine("4. SALIR");


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



                    case 4: Console.WriteLine("\nSALIR"); break;
                    default: Console.WriteLine("\ningrese una opcion dentro del rango"); break;
                }
            }
            while (op != 4);
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

