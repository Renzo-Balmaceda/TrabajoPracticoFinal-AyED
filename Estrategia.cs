
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;
using tp1;

namespace tpfinal
{

	public class Estrategia
	{
	
		public String Consulta1(List<string> datos)
		{
			string result = "Implementar";
            return result;
		}


		public String Consulta2(List<string> datos)
		{
			string result = "Implementar";
            
            return result;
        }

		

		public String Consulta3(List<string> datos)
		{
			string result = "Implementar";

            return result;
		}


		public List<Dato> BuscarConOrden(List<string> datos, int cantidad, List<Dato> collected)
		{
			Dictionary<string, Dato> dict = new Dictionary<string, Dato>();
			foreach (var texto in datos)
			{
				if (dict.ContainsKey(texto))
				{
					dict[texto].ocurrencia++;
				}
				else
				{
					dict.Add(texto, new Dato(1, texto));
				}
			}
			Dato[] arreglo = dict.Values.ToArray();
			Ordenamiento<Dato> aux = new Ordenamiento<Dato>();
			aux.MaxMergeSort(ref arreglo, 0, arreglo.Length - 1);

            int limite = Math.Min(cantidad, arreglo.Length);

            for (int i = 0; i < limite; i++)
            {
                collected.Add(arreglo[i]);
            }
			return collected;
           
        }



        public List<Dato> BuscarConHeap(List<string> datos, int cantidad, List<Dato> collected)
		{

			Dictionary < string, Dato> dict= new Dictionary < string, Dato>();
			foreach (var texto in datos)
			{
				if (dict.ContainsKey(texto))
				{
					dict[texto].ocurrencia++;
				}
				else
				{
					dict.Add(texto,new Dato(1,texto));
				}
			}
			List<Dato> lista=dict.Values.ToList();
			lista.Insert(0,null);
			Dato[] arreglo = lista.ToArray();
			Heap<Dato> heapFrecuencias = new Heap<Dato>(arreglo, true, arreglo.Length-1);
			while (collected.Count < cantidad &&!heapFrecuencias.EsVacia())
			{
				collected.Add(heapFrecuencias.Eliminar());
			}
			return collected;
        }
    }
}
