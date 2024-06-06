/*
 * Created by SharpDevelop.
 * User: Denu
 * Date: 1/4/2024
 * Time: 20:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace trabajo_practico_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//prueba arbol binario del ejemplo
			ArbolBinario<int> arbolBinario1 = new ArbolBinario<int>(8);
            ArbolBinario<int> hijoIzquierdo = new ArbolBinario<int>(5);
            ArbolBinario<int> hijoDerecho = new ArbolBinario<int>(22);
            ArbolBinario<int> hijoIzq_Derecho = new ArbolBinario<int>(6);
            hijoDerecho.agregarHijoIzquierdo(hijoIzq_Derecho );
            hijoIzq_Derecho .agregarHijoIzquierdo(new ArbolBinario<int>(7));
            hijoDerecho.agregarHijoDerecho(new ArbolBinario<int>(18));

            arbolBinario1.agregarHijoIzquierdo(hijoIzquierdo);
            arbolBinario1.agregarHijoDerecho(hijoDerecho);

            Console.WriteLine("Longitud 1: " + string.Join("-", arbolBinario1.resolver(arbolBinario1, 1)));
            Console.WriteLine("Longitud 2: " + string.Join("-", arbolBinario1.resolver(arbolBinario1, 2)));
            Console.WriteLine("Longitud 5: " + string.Join("-", arbolBinario1.resolver(arbolBinario1, 5)));

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
		}
	}
}