using System;
using System.Collections.Generic;

namespace tp1
{
	public class ArbolGeneral<T>
	{
		
		private T dato;
		private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();

		public ArbolGeneral(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			return hijos;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Add(hijo);
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Remove(hijo);
		}
	
		public bool esHoja() {
			return this.getHijos().Count == 0;
		}
	
		public int altura(Nodo nodo) {
			int mayor = 0;
			int temporal;
			if (nodo == null)
			{
				return 0;

			}
			else {
				for (int i = 0; i < nodo.noHijos; i++) {
					temporal = altura(nodo.hijos[i]);
					if (temporal > mayor) {
						mayor = temporal;
							}
				}	return mayor + 1;
			}
			
		}
	
		
		public int nivel(T dato) {
			return 0;
		}
	
	}
}
