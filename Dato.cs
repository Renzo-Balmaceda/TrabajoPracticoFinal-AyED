using System;
using System.Collections.Generic;

namespace tpfinal
{

	[Serializable]
	public class Dato : IComparable<Dato>
	{
		public int ocurrencia { get; set; }
		public string texto { get; set; } // String of symbols

		public string descripcion { get; set; } // String of symbols


        public Dato(int ocurrencia, string texto)
        {
            this.ocurrencia = ocurrencia;
            this.texto = texto;
        }

        public Dato(int ocurrencia, string texto, string descripcion)
		{
			this.ocurrencia = ocurrencia;
			this.texto = texto;
			this.descripcion = descripcion;
		}



		public int CompareTo(Dato dato2)
		{
			int resultado= this.ocurrencia.CompareTo(dato2.ocurrencia);
			return resultado;
		}
		public override string ToString()
		{
			if (texto != null)
			{

				return "(" + ocurrencia + ") " + texto;

			}
			else
			{

				return "";
			}
		}

	}
}