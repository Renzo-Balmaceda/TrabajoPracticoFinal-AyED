
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
            int repeticiones = 5;
            double totalHeap = 0;
            double totalOrden = 0;
            Stopwatch sw = new Stopwatch();
			for (int r = 0; r < repeticiones; r++)
            {
                    List<Dato> c1 = new List<Dato>();
                    sw.Restart();
                    BuscarConHeap(datos, 5, c1);
                    sw.Stop();
                    totalHeap += sw.Elapsed.TotalMilliseconds;

                    List<Dato> c2 = new List<Dato>();
                    sw.Restart();
                    BuscarConOrden(datos, 5, c2);
                    sw.Stop();
                    totalOrden += sw.Elapsed.TotalMilliseconds;
             }

            double promedioHeap = totalHeap / repeticiones;
            double promedioOrden = totalOrden / repeticiones;

            string result = "Promedio de " + repeticiones + " ejecuciones:\n";
            result += "BuscarConHeap(): " + promedioHeap.ToString("F4") + " ms\n";
            result += "BuscarConOrden(): " + promedioOrden.ToString("F4") + " ms";

            return result;
        }


		public String Consulta2(List<string> datos)
		{
			string resultado = "";
            Dictionary<string, Dato> dict = new Dictionary<string, Dato>();
            foreach (string texto in datos)
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
            List<Dato> lista = dict.Values.ToList();
            lista.Insert(0, null);
            Dato[] arregloDatos = lista.ToArray();
            Heap<Dato> heap = new Heap<Dato>(arregloDatos, true, arregloDatos.Length-1);
			for (int i=1; i<heap.GetDatos().Length; i*=2)
			{
				resultado += "\n"+ heap.GetDatos()[i].texto;
			}
            return resultado;
        }

		

		public String Consulta3(List<string> datos)
		{
			string resultado = "";
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
            List<Dato> lista = dict.Values.ToList();
            lista.Insert(0, null);
            Dato[] arreglo = lista.ToArray();
            Heap<Dato> heapFrecuencias = new Heap<Dato>(arreglo, true, arreglo.Length - 1);
			int nivelActual = 1;
			int IndiceSiguienteNivel = 2;
			Dictionary <Dato, int> niveles= new Dictionary<Dato, int>();
			for (int i=1; i<arreglo.Length-1; i++) 
			{
				if (i < IndiceSiguienteNivel)
				{
                    resultado += "\n" + arreglo[i].texto +" Nivel " + nivelActual+ ", ";
                }
				else
				{
                    IndiceSiguienteNivel = i * 2;
                    nivelActual++;
                    resultado+= " \n" + arreglo[i].texto+" Nivel "+ nivelActual+", ";
                }		
			}
			return resultado;
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
