using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COLAS
{
    class Program
    {
        const int N = 5;
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
        static void Iniciar(ref Cola co)
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

        static bool Full(Cola co)
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


        static void Imp(ref Cola co)
        {
            Cola ct = new Cola();
            ct.ci();
            Iniciar(ref ct);

            char dato = ' ';

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

        //Sobre Carga de m�todo

        static void Pedir(string m, ref int op)
        {
            Console.Write("\n{0}", m);
            op = int.Parse(Console.ReadLine());

        }
        static void Pedir(string m, ref char dato)
        {
            Console.Write("\n{0}", m);
            dato = char.Parse(Console.ReadLine());

        }

        static void Menu()
        {
            Console.WriteLine("\n<<<<< MENU >>>>>");
            Console.WriteLine("1. PUSH");
            Console.WriteLine("2. POP");
            Console.WriteLine("3. IMPRIMIR");
            Console.WriteLine("4. SALIR");


        }
        static void Ejecutar(ref Cola co)
        {

            int op = 0;
            char dato = ' ';
            do
            {
                Menu();
                Pedir("Dar la opcion: ", ref op);
                switch (op)
                {
                    case 1:
                        if (Full(co))
                            Console.WriteLine("\nCola LLena...");
                        else
                        {
                            Pedir("De el dato: ", ref dato);
                            Push(ref co, dato);
                        }
                        break;

                    case 2:
                        if (Empty(co))
                            Console.WriteLine("\nCola Vacia...");
                        else
                        {
                            Console.WriteLine("\nSacando dato de la cola.....");
                            Pop(ref co, ref dato);
                        }
                        break;
                    case 3:

                        if (Empty(co))
                            Console.WriteLine("\nNo se puede imprimir la cola Vacia...");
                        else
                            Imp(ref co);
                        break;



                    case 4: Console.WriteLine("\nSALIR"); break;
                    default: Console.WriteLine("\ningrese una opcion dentro del rango"); break;
                }
            }
            while (op != 4);
        }
        static void Main(string[] args)
        {
            Cola co = new Cola();
            co.ci();
            Iniciar(ref co);
            Ejecutar(ref co);
            Console.ReadLine();


        }
    }
}

