using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpfinal
{
    public class Ordenamiento<T> where T : IComparable<T>
    {
        public void MaxMergeSort<T>(ref T[] arreglo, int izq, int der)where T : IComparable<T>
        {
            if(izq < der)
            {
                int m = (izq + der) / 2;
                MaxMergeSort(ref arreglo, izq, m);
                MaxMergeSort(ref arreglo, m+1, der);
                Merge(ref arreglo,izq,m,der);
            }
        }
        public void Merge<T>(ref T[]arreglo, int izq, int m, int der)where T : IComparable<T>
        {
            T[] aux= new T[der-izq+1];
            int k = 0;
            int j = m + 1;
            int i = izq;
            while (i<=m && j<=der)
            {
                if (arreglo[i].CompareTo(arreglo[j])<0)
                {
                    aux[k] = arreglo[j];k++;j++;
                }else if (arreglo[i].CompareTo(arreglo[j])>0)
                {
                    aux[k] = arreglo[i];k++;i++;
                }
                else
                {
                    aux[k] = arreglo[i];
                    k++;
                    aux[k] = arreglo[j];
                    k++; j++;i++;
                }
            }
            while (i<=m)
            {
                aux[k] = arreglo[i];
                i++;k++;
            }
            while (j<=der)
            {
                aux[k]=arreglo[j];
                k++;j++;
            }
            for(int index=0; index <aux.Length; index++)
            {
                arreglo[izq + index] = aux[index];
            }
        }

    }
    public class Heap<T> where T : IComparable<T>
    {
        private T[] datos;
        private bool Max;
        private int Tam;

        public Heap(T[] inicial, bool m, int dim)
        {
            this.Max = m;
            this.Tam = dim;
            this.datos = inicial;
            BuildHeap();
        }

        public T[] GetDatos()
        {
            return datos; 
        }
        public T Eliminar()
        {
            if (EsVacia())
            {
                return default(T);
            }
            T dato = datos[1];
            datos[1] = datos[Tam];
            Tam--;
            if (Tam > 0)
            {
                FiltrarAbajo(1);
            }
            return dato;

        }

        public T Tope()
        {
            return datos[Tam];
        }
        public bool AgregarElem(T elem)
        {
            if (Tam >= datos.Length-1) { return false; }
            Tam++;
            datos[Tam] = elem;
            FiltrarArriba(Tam);
            return true;
        }
        public bool EsVacia()
        {
            return Tam==0;
        }
        private void FiltrarAbajo(int i)
        {
            while (2 * i <= Tam)
            {
                int j = 2 * i;
                if ((j < Tam) && Comparar(j + 1, j))
                {
                    j++;
                }
                if (Comparar(j, i))
                {
                    Intercambiar(i, j);
                }
                i = j;
            }
        }
        private void FiltrarArriba(int i)
        {
            while ((i > 1) && (Comparar(i, i / 2)))
            {
                Intercambiar(i, i / 2);
                i = i / 2;
            }
        }
        private void Intercambiar(int i, int j)
        {
            T aux = datos[j];
            datos[j] = datos[i];
            datos[i] = aux;
        }
        public bool Comparar(int i, int j)
        {
            int comp = datos[i].CompareTo(datos[j]);
            if (Max)
            {
                return (comp > 0);
            }
            else
            {
                return (comp < 0);
            }
        }
        private void BuildHeap()
        {
            for (int i = Tam / 2; i >= 1; i--)
            {
                FiltrarAbajo(i);
            }
        }
    }
}
