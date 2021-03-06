﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola
{
    class Program
    {
        const int N = 3; //Constante tamaño de la cola
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

        static void iniciar(ref Cola co)
        {
            co.inic = -1;
            co.fin = -1;
        }

        static bool empty(Cola co)
        {

            if (co.inic == -1 && co.fin == -1 || co.inic > co.fin)
                return true;
            else
                return false;
        }

        static bool full(Cola co)
        {
            if (co.fin == N - 1)
                return true;

            else
                return false;
        }

        static void push(ref Cola co, char dato)
        {
            if (full(co))
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


        static void pop(ref Cola co, ref char dato)
        {
            if (empty(co))
                Console.WriteLine("LA COLA ESTA VACIA.....");
            else
            {
                dato = co.c[co.inic];
                co.inic++;
            }
        }


        static void imp(ref Cola co)
        {
            Cola ct = new Cola();
            ct.ci();
            iniciar(ref ct);
            char dato = ' ';

            Console.WriteLine("\nLos datos de la COLA.....");
            while (!empty(co))
            {
                pop(ref co, ref dato);
                Console.WriteLine("{0}", dato);
                push(ref ct, dato);
            }
            iniciar(ref co);

            while (!empty(ct))
            {
                pop(ref ct, ref dato);
                push(ref co, dato);
            }

        }
     
        static void tarea(ref Cola co)
        {
            Cola ct = new Cola();
            ct.ci();
            iniciar(ref ct);
            char dato = ' ';
            int cont = 0;
            Console.WriteLine("Contando datos de la cola");

            while(!empty(co))
            {
                pop(ref co, ref dato);
                cont++;
                push(ref ct, dato);
            }

            iniciar(ref co);
            while(!empty(ct))
            {
                pop(ref ct, ref dato);
                push(ref co, dato);
            }

            Console.WriteLine("La cantidad de elementos en la cola es: {0}", cont);
        }

        //Sobre Carga de m?todo

        static void pedir(string m, ref int op)
        {
            Console.Write("\n{0}", m);
            op = int.Parse(Console.ReadLine());

        }
        static void pedir(string m, ref char dato)
        {
            Console.Write("\n{0}", m);
            dato = char.Parse(Console.ReadLine());

        }

        static void menu()
        {
            Console.WriteLine("\n<<<<< MENU >>>>>");
            Console.WriteLine("1. PUSH");
            Console.WriteLine("2. POP");
            Console.WriteLine("3. IMPRIMIR");
            Console.WriteLine("4. CONTAR ELEMENTOS");
            Console.WriteLine("5. SALIR");


        }
        static void ejecutar(ref Cola co)
        {

            int op = 0;
            char dato = ' ';
            do
            {
                menu();
                do
                {
                    pedir("Dar la opcion: ", ref op);
                }
                while (op < 1 || op > 5);

                switch (op)
                {
                    case 1:
                        if (full(co))
                            Console.WriteLine("\nCola LLena...");
                        else
                        {
                            pedir("De el dato: ", ref dato);
                            push(ref co, dato);
                        }
                        break;

                    case 2:
                        if (empty(co))
                            Console.WriteLine("\nCola Vacia...");
                        else
                        {
                            Console.WriteLine("\nSacando dato de la cola.....");
                            pop(ref co, ref dato);
                        }
                        break;
                    case 3:

                        if (empty(co))
                            Console.WriteLine("\nNo se puede imprimir la cola Vacia...");
                        else
                            imp(ref co);
                        break;

                    case 4:
                        tarea(ref co);
                        break;

                    case 5:
                        Console.WriteLine("\nSALIR");
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("\ningrese una opcion dentro del rango"); break;
                }
            }
            while (op != 5);
        }
        static void Main(string[] args)
        {
            Cola co = new Cola();
            co.ci();
            iniciar(ref co);
            ejecutar(ref co);
            Console.ReadLine();


        }
    }
}
