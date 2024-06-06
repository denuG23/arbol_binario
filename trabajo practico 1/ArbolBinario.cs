/*
 * Created by SharpDevelop.
 * User: Denu
 * Date: 1/4/2024
 * Time: 20:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace trabajo_practico_1
{
	/// <summary>
	/// Description of ArbolBinario

	public class ArbolBinario<T>
	{
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;

		public ArbolBinario(T dato)
		{
			this.dato = dato;
			this.hijoIzquierdo = null;
			this.hijoDerecho = null;
		}

		public T getDatoRaiz()
		{
			return this.dato;
		}
		
		public void setDatoRaiz(T dato)
		{
			this.dato = dato;
		}

		public ArbolBinario<T> getHijoIzquierdo()
		{
			return this.hijoIzquierdo;
		}
		
		public void setHijoIzquierdo(ArbolBinario<T> hijoIzquierdo)
		{
			this.hijoIzquierdo = hijoIzquierdo;
		}

		public ArbolBinario<T> getHijoDerecho()
		{
			return this.hijoDerecho;
		}
		
		public void setHijoDerecho(ArbolBinario<T> hijoDerecho)
		{
			this.hijoDerecho = hijoDerecho;
		}


		public void agregarHijoIzquierdo(ArbolBinario<T> hijo)
		{
			this.hijoIzquierdo = hijo;
		}

		public void agregarHijoDerecho(ArbolBinario<T> hijo)
		{
			this.hijoDerecho = hijo;
		}

		public void eliminarHijoIzquierdo()
		{
			this.hijoIzquierdo = null;
		}

		public void eliminarHijoDerecho()
		{
			this.hijoDerecho = null;
		}

		public bool esHoja()
		{
			return this.hijoIzquierdo == null && this.hijoDerecho == null;
		}

		public bool buscarCamino(ArbolBinario<T> arbol, int longitud, List<T> camino)
		{
			if (arbol == null)
				return false;

			if (longitud == 0 && arbol.esHoja())
			{
				camino.Add(arbol.getDatoRaiz());
				return true;
			}

			if (longitud > 0)
			{
				if (arbol.getHijoIzquierdo() != null && buscarCamino(arbol.getHijoIzquierdo(), longitud - 1, camino))
				{
					camino.Insert(0, arbol.getDatoRaiz());
					return true;
				}

				if (arbol.getHijoDerecho() != null && buscarCamino(arbol.getHijoDerecho(), longitud - 1, camino))
				{
					camino.Insert(0, arbol.getDatoRaiz());
					return true;
				}
			}

			return false;
		}
		public List<T> resolver(ArbolBinario<T> arbol, int longitud)
		{
			List<T> camino = new List<T>();
			bool encontrado = buscarCamino(arbol, longitud, camino);
			return camino;
		}
	}
}