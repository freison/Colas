using System;
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

            public void ci(int n)
            {
                c = new char[n];
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


        static void imp(ref Cola co, int n)
        {
            Cola ct = new Cola();
            ct.ci(n);
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

        static void impco2(ref Cola co2, int n)
        {
            Cola ct = new Cola();
            ct.ci(n);
            iniciar(ref ct);
            char dato = ' ';

            Console.WriteLine("Imprimiendo datos de la Cola 2");

            while(!empty(co2))
            {
                pop(ref co2, ref dato);
                Console.WriteLine(dato);
                push(ref ct, dato);
            }

            while(!empty(ct))
            {
                pop(ref ct, ref dato);
                push(ref co2, dato);
            }

        }

        static void impco3(ref Cola co3, int n)
        {
            Cola ct = new Cola();
            ct.ci(n);
            iniciar(ref ct);
            char dato = ' ';

            Console.WriteLine("Imprimiendo datos de la Cola 2");

            while (!empty(co3))
            {
                pop(ref co3, ref dato);
                Console.WriteLine(dato);
                push(ref ct, dato);
            }

            while (!empty(ct))
            {
                pop(ref ct, ref dato);
                push(ref co3, dato);
            }

        }

        //OPERACIONES DE LA PILA
        public struct pila
        {
            public int tope;
            public char[] p;

            public void pi()
            {
                p = new char[N];
            }
        }
        static void Inic(ref pila po)
        {
            po.tope = -1;
        }

        static bool Empty(pila po)
        {

            if (po.tope == -1)
                return true;
            else
                return false;
        }

        static bool Full(pila po)
        {
            if (po.tope == N - 1)
                return true;

            else
                return false;
        }

        static void Push(ref pila po, char dato)
        {
            if (Full(po))
                Console.WriteLine("PILA LLENA");
            else
            {
                po.tope++;
                po.p[po.tope] = dato;
            }
        }

        static void Pop(ref pila po, ref char dato)
        {
            if (Empty(po))
                Console.WriteLine("PILA VACIA");

            else
                dato = po.p[po.tope];
            po.tope--;

        }
        static void tarea(ref Cola co, ref Cola co2, ref Cola co3, int n)
        {
            Cola ct = new Cola();
            ct.ci(n);
            iniciar(ref ct);
            char dato = ' ';

            Console.WriteLine("\nUniendo Colas");
            while (!empty(co))
            {
                pop(ref co, ref dato);
                push(ref co3, dato);
            }
            iniciar(ref co);
            while (!empty(ct))
            {
                pop(ref co2, ref dato);
                push(ref co3, dato);
            }
        }

        //Sobre Carga de metodo

        static void pedir(string m, ref int op)
        {
            Console.WriteLine("\n{0}", m);
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
            Console.WriteLine("3. UNIR COLAS");
            Console.WriteLine("4. IMPRIMIR COLA 1");
            Console.WriteLine("5. IMPRIMIR COLA 2");
            Console.WriteLine("6. IMPRIMIR COLA 3");
            Console.WriteLine("7. SALIR");


        }
        static void ejecutar(ref Cola co, ref Cola co2, ref Cola co3, int n)
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
                while (op < 1 || op > 4);

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
                            tarea(ref co, ref co2, ref co3, n);
                        break;

                    case 4:                        
                        if (empty(co))
                            Console.WriteLine("\nNo se puede imprimir la cola Vacia...");
                        else
                            imp(ref co, n);
                        break;

                    case 5:
                        if (empty(co2))
                            Console.WriteLine("\nNo se puede imprimir la cola Vacia...");
                        else
                            impco2(ref co2, n);

                        break;

                    case 6:
                        if (empty(co3))
                            Console.WriteLine("\nNo se puede imprimir la cola Vacia...");
                        else
                            impco3(ref co3, n);

                        break;

                    case 7:
                        Console.WriteLine("\nSALIR");
                        Environment.Exit(0);
                        break;

                    default: Console.WriteLine("\ningrese una opcion dentro del rango"); break;
                }
            }
            while (op != 7);
        }
        static void Main(string[] args)
        {
            int n = 0;
            pedir("Ingrese la longitud de las colas", ref n);
            Cola co1 = new Cola();
            co1.ci(n);
            iniciar(ref co1);
            Cola co2 = new Cola();
            co2.ci(n);
            iniciar(ref co2);
            Cola co3 = new Cola();
            co3.ci(n+n);
            iniciar(ref co3);
            ejecutar(ref co1, ref co2, ref co3, n);
            Console.ReadLine();


        }
    }
}

